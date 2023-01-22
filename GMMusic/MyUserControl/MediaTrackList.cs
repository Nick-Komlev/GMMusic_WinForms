using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AxWMPLib;
using System.Drawing;
namespace GMMusic
{
    public class MediaTrackList : Panel
    {

        public MediaTrack[] MT { get; set; } // МедиаТреки 3 штуки
        private PlayList[] PL { get; set; } // Плейлисты, соответствующие МедиаТрекам 3 штуки

        private int selected_; // номер выбранного МедиаТрека=отображенного плейлиста
        public int Selected {
            get => selected_;
            set
            {
                SelectMediaTrack(value);
                selected_ = value;
            }
        }

        public MediaTrackList(PlayList[] pl) : base()
        {
            MT = new MediaTrack[3];
            PL = pl; // инициируется Form1, пробрасываются заполненные плейлисты

            for (int i = MT.Length; i > 0; i--) // создаются и заполняются МедиаТреки
            {
                MT[i - 1] = new MediaTrack(i - 1);
                Controls.Add(MT[i - 1]);
                MT[i - 1].Name = "MT" + i.ToString();
                MT[i - 1].Dock = DockStyle.Top;
            }

            Selected = 0;
        }

        // Добавление в плейлист в плейлист[id_]
        public void PlaylistAdd(int id_, Track track)
        {
            // Передача добавления трека в плейлист, используется при загрузке МТ,
            // добавлении из Поиска, добавлении в конец при перемещении
            PL[id_].AddTrack(track);
        }

        // Следующий (track_n) трек в плейлист[id_]
        public void Next(int id_, int track_n)
        {
            // при старте следующего трека форсировать смену текущего трека
            PL[id_].Selected = track_n;
        }

        // Смена выбора МТ и плейлиста
        private void SelectMediaTrack(int id_)
        {
            // действия по скрытию/отображению бывшего/текущего выбранного плейлиста, перекраска выбранного МТ
            // вызывается при изменении selected_
            MT[selected_].panel.BackColor = Color.FromKnownColor(KnownColor.Azure);
            MT[id_].panel.BackColor = Color.FromKnownColor(KnownColor.Info);

            PL[selected_].Visible = false;
            PL[selected_].Dock = DockStyle.Top;
            PL[id_].Visible = true;
            PL[id_].Dock = DockStyle.Fill;
        }

        // Чистка таймеров
        public void MTDispose()
        {
            // чистим таймеры при завершении, разрдражают вроде
            foreach (MediaTrack mt in MT)
                mt.timer.Dispose();
        }

        public void ConnectToList(int id_, List<Track> list)
        {
            PL[id_].ConnectToList(list);
        }
    }
}
