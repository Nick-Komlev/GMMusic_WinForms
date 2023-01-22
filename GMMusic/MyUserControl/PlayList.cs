using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GMMusic
{
    public partial class PlayList : Panel
    {
        public List<Track> TrackList { get; set; }
        private int Id { get; set; } // порядковый номер плейлиста на панели дорожек

        private int selected_; // порядковый номер выбранного трека в СПИСКЕ (не в контролах)
        public int Selected
        {
            get=>selected_;
            set
            {
                if (Controls.Count > 0)
                {
                    // форсируем снятие выделения первого элемента
                    (Controls[0] as PlaylistElement).Selected = false;

                    try // на случай, если номер бывшего выделения не выходит за границы после удаления
                    {
                        // снимаем выделение с прошлого элемента
                        (Controls[Controls.Count - selected_ - 1] as PlaylistElement).Selected = false;
                    }
                    catch { }
                        
                    // выделяем текущий элемент
                    (Controls[Controls.Count - value - 1] as PlaylistElement).Selected = true;
                }
                selected_ = value;
            }
        }

        public PlayList(int id_) : base()
        {
            Selected = 0;
            Id = id_;
            TrackList = new List<Track>();
        }

        // Добавить трек в плейлист
        public void AddTrack(Track track)
        {
            // окончание процесса добавления элемента в плейлист
            TrackList.Add(track);
            FillControls();
        }

        // Перезаполнить контролы
        private void FillControls()
        {
            Controls.Clear();
            PlaylistElement link;
            // заполняем контролы реверснутым списком треков
            for (int i = TrackList.Count - 1; i >= 0 ; i--)
            {
                link = new PlaylistElement(TrackList[i], (Controls.Count == 0));
                                                          // автоматическое выделение
                                                          // первого элемента
                link.Dock = DockStyle.Top;
                Controls.Add(link);
            }
            Selected = Selected; // для офрсирования выделения
        }

        // Выбор элемент
        public void PlaylistElement_DoubleClick(Track elem)
        {
            // передаем процесс назначения текущего трека в МедиаТрек, 
            // назначая переменный порядковый номер выбранного трека в СПИСКЕ
            Singleton.MTL.MT[Id].CurrentTrack = TrackList.FindIndex(t => t.Id == elem.Id);
        }

        // Удаление элемента
        public void EraseElement(PlaylistElement ple)
        {
            // удаление элемента из плейлиста
            int ind = TrackList.FindIndex(t => t.Id == ple.ThisTrack.Id);
            Controls.Remove(ple);
            if (ind < Selected) // проверка на смещение номера выбранного трека
            {
                // если ниже, то смещаем номер
                Selected--;
                Singleton.MTL.MT[Id].EraseElement(ple.ThisTrack, true); // передаем процесс МедиаТреку
                                                                        // с указанием на смещение true
            }
            else
                Singleton.MTL.MT[Id].EraseElement(ple.ThisTrack, false); // передаем процесс МедиаТреку
                                                                         // без указания на смещение false
            TrackList.Remove(ple.ThisTrack);
            
        }

        // Начало процесса перемещения элемента
        public void ElementMoveInit(PlaylistElement ple)
        {
            // начало перемещения
            int ind = TrackList.FindIndex(t => t.Id == ple.ThisTrack.Id); // номер перемещаемого в списке

            // удаляем трек из очереди воспроизведения, чтобы перетаскиваемый элемент не участвовал в этом
            if (ind < Selected)
            {
                // если ниже выбранного, смещение номера выбранного
                Singleton.MTL.MT[Id].EraseElement(ple.ThisTrack, true); // передаем процесс МедиаТреку
                                                                        // с указанием на смещение true
                Selected--;
            }
            else
                Singleton.MTL.MT[Id].EraseElement(ple.ThisTrack, false); // передаем процесс МедиаТреку
                                                                         // без указания на смещение false

            for (int i = 0; i < Controls.Count; i++) // удаляем все контролы, кроме перетаскиваемого
                if ((Controls[i] as PlaylistElement) != ple)
                {
                    Controls.Remove((Controls[i] as PlaylistElement));
                    i--;
                }

            TrackList.Remove(ple.ThisTrack); // но удаляем перетаскиваемый элемент из списка плейлиста 

            PlaylistElement link;
            for (int i = TrackList.Count - 1; i >= 0; i--) // обратно заполняем контролы (без перетаскиваемого), 
                                                           // чтобы перетаскиваемый оказался над всеми
            {
                link = new PlaylistElement(TrackList[i], (Controls.Count == 0));
                link.Dock = DockStyle.Top;
                Controls.Add(link);
            }
            Selected = Selected; // форсируем выделение
        }

        // Конец процесса перемещения элемента
        public void ElementMoveEnd(PlaylistElement ple)
        {
            // обрабатываем результат перетаскивания
            int pos = (int)PointToClient(Control.MousePosition).Y / 30; // определяем над какой позицией была отпущена ЛКМ

            if (pos >= TrackList.Count)
                Singleton.MTL.MT[Id].PlaylistAdd(ple.ThisTrack); // если позиция последняя или ниже, просто запускаем
                                                                 // процесс добавления трека в конец

            else if (pos <= Selected) // если позиция ниже или на позицию номера выбранного трека
            {
                TrackList.Insert(pos, ple.ThisTrack); 
                selected_++; // смещение
                Singleton.MTL.MT[Id].PlaylistIns(pos, ple.ThisTrack, true); // инсерт трека в очередь со смещением номера выбранного
            }

            else
            {
                TrackList.Insert(pos, ple.ThisTrack);
                Singleton.MTL.MT[Id].PlaylistIns(pos, ple.ThisTrack, false); // инсерт трека в очередь без смещения номера выбранного
            }

            FillControls(); // перезаполняем контролы
        }

        // Назначить плейлист
        public void ConnectToList(List<Track> list)
        {
            TrackList = new List<Track>(list);
            Selected = 0;
            FillControls();
        }
    }
}
