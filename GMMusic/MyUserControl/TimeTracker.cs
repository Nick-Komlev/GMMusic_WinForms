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
    public partial class TimeTracker : UserControl
    {
        private double timespent;
        public double TimeSpent
        {
            get=> timespent;
            set
            {
                TimeSpentChanged(value);
                timespent = value;
            }
        }
        public double TimeWhole { get; set; }
        public WMPLib.WindowsMediaPlayer WMP { get; set; }

        public TimeTracker()
        {
            InitializeComponent();
            TimeSpent = 0.0f;
            TimeWhole = 1.0f;
        }

        private void PanelSpent_Click(object sender, EventArgs e)
        {
            double piece = (float)PointToClient(Control.MousePosition).X / (float)Size.Width;
            TimeSpent = TimeWhole * piece;
            WMP.controls.currentPosition = TimeSpent;
        }

        private void PanelLeft_Click(object sender, EventArgs e)
        {
            float piece = (float)PointToClient(Control.MousePosition).X / (float)Size.Width;
            TimeSpent = TimeWhole * piece;
            WMP.controls.currentPosition = TimeSpent;
        }

        private void TimeSpentChanged(double timeSpent)
        {
            double piece = timeSpent / TimeWhole;
            panelSpent.Width = (int)(Size.Width * piece);
        }

    }
}
