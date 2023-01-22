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
    public partial class PlaylistElement : UserControl
    {
        public Track ThisTrack { get; set; } // объект трека, привязанного к плейлист-элементу

        private bool LBPressed { get; set; } // нажата ЛКМ или нет

        private bool selected_; // выбран ли плейлист-элемент как играющий
        public bool Selected
        {
            get => selected_;
            set
            {
                if (value) // форматируем элементы как выделенные, запрет на перетаскивание
                {
                    BackColor = Color.FromKnownColor(KnownColor.Azure);
                    timePanel.BackColor = Color.FromKnownColor(KnownColor.Azure);
                    movePanel.BackColor = Color.FromKnownColor(KnownColor.Azure);
                    contextCMS.Items[0].Enabled = false;
                    label2.ForeColor = Color.LightGray;
                }
                else // форматируем элемент как НЕвыделенные, разрешение на перетаскивание
                {
                    BackColor = Color.FromKnownColor(KnownColor.Info);
                    timePanel.BackColor = Color.FromKnownColor(KnownColor.Info);
                    movePanel.BackColor = Color.FromKnownColor(KnownColor.Info);
                    contextCMS.Items[0].Enabled = true;
                    label2.ForeColor = Color.Black;
                }

                selected_ = value;
            }
        }

        public PlaylistElement(Track track, bool sel = false)
        {
            InitializeComponent();

            ThisTrack = track;
            trackLbl.Text = ThisTrack.Name;
            label1.Text = ThisTrack.Duration;
            Dock = DockStyle.Top;
            
            // настраиваем Контекстное меню для функционала удаления
            ToolStripMenuItem del = new ToolStripMenuItem("Удалить");
            contextCMS.Items.Add(del);

            ContextMenuStrip = contextCMS;

            del.Click += Delete_Click;

            Selected = sel;
        }

        // Удаление
        private void Delete_Click(object sender, EventArgs e)
        {
            // запускаем процедуру удаления элемента (в списке воспроизведения, списке плейлиста и контрол-списке)
            (Parent as PlayList).EraseElement(this);
        }

        // Ховёр
        private void TrackLink_MouseEnter(object sender, EventArgs e)
        {
            // реакция на ховёр на элемент в случае, если элемент не выделен
            if (!Selected)
            {
                BackColor = Color.FromKnownColor(KnownColor.Azure);
                timePanel.BackColor = Color.FromKnownColor(KnownColor.Azure);
                movePanel.BackColor = Color.FromKnownColor(KnownColor.Azure);
            }
        }

        // Контрховёр
        private void TrackLink_MouseLeave(object sender, EventArgs e)
        {
            // реакция на увод мыши
            if (!Selected)
            {
                BackColor = Color.FromKnownColor(KnownColor.Info);
                timePanel.BackColor = Color.FromKnownColor(KnownColor.Info);
                movePanel.BackColor = Color.FromKnownColor(KnownColor.Info);
            }    
        }

        // Лейблховёр
        private void TrackLbl_MouseEnter(object sender, EventArgs e)
        {
            // дублируем для лейбла
            if (!Selected)
                TrackLink_MouseEnter(sender, e);
        }

        // Лейблконтрховёр
        private void TrackLbl_MouseLeave(object sender, EventArgs e)
        {
            // дублируем для лейбла
            if (!Selected)
                TrackLink_MouseLeave(sender, e);
        }

        // Выбор элемента через даблклик
        private void PlaylistElement_DoubleClick(object sender, EventArgs e)
        {
            // запускаем процесс выделения элемента и запуска трека по двойному нажатию
            (Parent as PlayList).PlaylistElement_DoubleClick(ThisTrack);         
        }

        // Лейблдаблклик
        private void TrackLbl_DoubleClick(object sender, EventArgs e)
        {
            // дублируем для лейбла
            PlaylistElement_DoubleClick(sender, e);
        }

        // Начало перетаскивание, нажатие на панель перетаскивания
        private void MovePanel_MouseDown(object sender, MouseEventArgs e)
        {
            // по нажатии ЛКМ на панель перетаскивания
            if (e.Button == MouseButtons.Left && !Selected)
            {
                LBPressed = true; 
                Dock = DockStyle.None;
                // начинаем задавать позицюи элемент от мыши
                Location = new Point(0, (int)(Parent as PlayList).PointToClient(Control.MousePosition).Y - 15); 
                // запускаем процесс реакции на перемещение
                (Parent as PlayList).ElementMoveInit(this);
            }
        }

        // Конец перетаскивания
        private void MovePanel_MouseUp(object sender, MouseEventArgs e)
        {
            // отпустили ЛКМ
            if (LBPressed)
            {
                LBPressed = false;
                Dock = DockStyle.Top;
                // запускаем процесс обработки результата перемещения
                (Parent as PlayList).ElementMoveEnd(this);
            }

        }

        // Само перемещение
        private void MovePanel_MouseMove(object sender, MouseEventArgs e)
        {
            // в случае нажатой ЛКМ позиция элемента изменяется по мыши
            if (LBPressed)
                Location = new Point(0, (int)(Parent as PlayList).PointToClient(Control.MousePosition).Y - 15);
        }

        private void Label2_MouseDown(object sender, MouseEventArgs e)
        {
            // дублируем для лейба внутри панели перемещения
            MovePanel_MouseDown(sender, e);
        }

        private void Label2_MouseUp(object sender, MouseEventArgs e)
        {
            // дублируем для лейба внутри панели перемещения
            MovePanel_MouseUp(sender, e);
        }

        private void Label2_MouseMove(object sender, MouseEventArgs e)
        {
            // дублируем для лейба внутри панели перемещения
            MovePanel_MouseMove(sender, e);
        }

    }
}
