using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AxWMPLib;
using WMPLib;


namespace GMMusic
{
    public partial class MediaTrack : UserControl
    {
        public List<Track> Playlist_ { get; set; } // очередь воспроизведения

        public WindowsMediaPlayer WMP { get; set; } // привязанный к МедиаТреку плеер
        public int Id { get; set; } // порядковый номер МедиаТрека в листа
        public bool AutoStarting { get; set; } // блокировка самопроизвольного старта
        public bool Restart { get; set; } // повтор

        private int curTrack_; // текущий трек
        public int CurrentTrack
        {
            get => curTrack_;
            set
            {

                if (value >= Playlist_.Count) // в начало при завершении последнего трека в очереди
                    curTrack_ = 0;
                else if (value < 0) // в конец при попытке возврата из начала
                    curTrack_ = Playlist_.Count - 1;
                else
                    curTrack_ = value;
                // AutoStarting = false; // включаем запрет на автостарт
                Next(curTrack_); // запускаем процесс смены трека
            }
        }

        public MediaTrack(int id_)
        {
            InitializeComponent();
            AutoStarting = false;
            Restart = false;

            WMP = new WindowsMediaPlayer();
            WMP.PlayStateChange += WMP_PlayStateChange;
            //WMP.MediaChange += WMP_MediaChange;
            WMP.settings.autoStart = true;


            timeTracker.WMP = WMP;

            Id = id_;

            Playlist_ = new List<Track>();
        }

        private void MediaTrack_Load(object sender, EventArgs e)
        {
            // при загрузке необходимо положить хоть что-то в плейлист
            PlaylistAdd(Singleton.Tracks[0]);
            CurrentTrack = 0;

            volumeBar.Value = 16;
        }

        // Добавление трека в конец
        public void PlaylistAdd(Track track)
        {
            // добавление в конец трека из поиска или при перемещении
            if (Playlist_.Find(t => t.Id == track.Id) == null)
            {
                Playlist_.Add(track);
                (Parent as MediaTrackList).PlaylistAdd(Id, track); // передаем эстафету листу для передачи в плейлист
            }
        }

        // Инсерт в очередь воспроизведения
        public void PlaylistIns(int idd, Track track, bool slide)
        {
            // инсерт в очередь воспроизведения
            Playlist_.Insert(idd, track);
            if (slide) // если необходимо смещение
                curTrack_++;
        }

        // Удаление трека из очереди воспроизведения
        public void EraseElement(Track track, bool slide)
        {
            Playlist_.Remove(track);
            if (slide) // если есть смещение
                curTrack_--;
        }

        // Следующий указанный трек
        public void Next(int id_)
        {
            // начало процесса перехода на указанный трек
            WMP.URL = Playlist_[id_].File;
            Singleton.MTL.Next(Id, id_); // проверить потом, можно ли обратить к МТЛ через пэрент,
                                   // или наоборот выше обратиться через Синглтон
            WMP.controls.play();
        }

        // Изменения состояний воспроизведения
        private void WMP_PlayStateChange(int NewState)
        {
            if (WMP.playState == WMPPlayState.wmppsPlaying && !AutoStarting)
            { 
                // если трек запустился, но у нас стоит блокировка произвольного старта
                WMP.controls.pause();
                LoadTrack(); // подгружаем данные о треке
            }

            else if (WMP.playState == WMPPlayState.wmppsPlaying && AutoStarting)
            {
                // если трек запустился без блокировки произвольного старта
                LoadTrack(); // подгружаем данные о треке
                timer.Enabled = true;
            }

            // смена трека при его окончании
            else if (WMP.openState == WMPOpenState.wmposPlaylistOpenNoMedia && WMP.playState == WMPPlayState.wmppsReady && WMP.controls.currentItem != null)
            {
                PlayBtn_Click(new object(), new EventArgs());
            }

            else if (WMP.playState == WMPPlayState.wmppsMediaEnded)
            {
                // если трек закончился
                timer.Dispose();
                if (Restart)
                    Next(CurrentTrack);
                else
                    CurrentTrack++;
            }
        }

        // Конверт секунд в формат строки
        public string GetConvertedTime(double s)
        {
            int mins = (int)(s / 60.0d);
            int secs = (int)(s % 60.0d);
            string time = mins.ToString() + ':' + secs.ToString("D2");
            return time;
        }

        // Подгрузка данных трека на МТ
        public void LoadTrack()
        {
            timer.Dispose(); // уничтожаем таймер для перезапуска

            var TrackTime = WMP.currentMedia.duration;
            var TrackName = Playlist_[CurrentTrack].Name;

            nameLbl.Text = TrackName;
            timeWhole.Text = GetConvertedTime(TrackTime);

            timeTracker.TimeWhole = TrackTime;
            timeTracker.TimeSpent = WMP.controls.currentPosition;

        }

        // Кнопка Воспроизвести
        private void PlayBtn_Click(object sender, EventArgs e)
        {
            AutoStarting = true;
            WMP.controls.play();
            timer.Enabled = true;
        }

        // Кнопка Пауза
        private void PauseBtn_Click(object sender, EventArgs e)
        {
            WMP.controls.pause();
            timer.Enabled = false;
        }

        // Кнопка Стоп
        private void StopBtn_Click(object sender, EventArgs e)
        {
            WMP.controls.stop();
            timer.Enabled = false;
        }

        // Таймтрекер тикает
        private void Timer_Tick(object sender, EventArgs e)
        {
            timeSpent.Text = GetConvertedTime(WMP.controls.currentPosition);
            timeTracker.TimeSpent = WMP.controls.currentPosition;
        }

        // Изменение громкости
        private void VolumeBar_ValueChanged(object sender, EventArgs e)
        {
            WMP.settings.volume = volumeBar.Value * 5;
        }

        // Выбор МТ
        private void Panel_Click(object sender, EventArgs e)
        {
            (Parent as MediaTrackList).Selected = Id;
        }

        // Лейблвыбор
        private void NameLbl_Click(object sender, EventArgs e)
        {
            Panel_Click(sender, e);
        }

        // Следующий трек
        private void NextBtn_Click(object sender, EventArgs e)
        { 
            CurrentTrack++;
        }

        // Предыдущий трек
        private void PrevBtn_Click(object sender, EventArgs e)
        {
            CurrentTrack--;
        }

        private void RestartBtn_Click(object sender, EventArgs e)
        {
            Restart = !Restart;
            if (Restart)
                restartBtn.BackColor = Color.Gold;
            else
                restartBtn.BackColor = Color.FromKnownColor(KnownColor.Control);
        }

        public void ConnectToList(List<Track> list)
        {
            Playlist_ = new List<Track>(list);
            CurrentTrack = 0;
            Singleton.MTL.ConnectToList(Id, list);
        }
    }
}
