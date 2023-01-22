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
    public partial class TrackLink : UserControl
    {
        private Track ThisTrack { get; set; }

        public TrackLink(Track track_)
        {
            InitializeComponent();
            ThisTrack = track_;

            trackLbl.Text = ThisTrack.Name;
            label1.Text = ThisTrack.Duration;
            ToolStripMenuItem edit = new ToolStripMenuItem("Изменить");
            contextCMS.Items.Add(edit);

            ContextMenuStrip = contextCMS;

            edit.Click += Edit_Click;
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            Form createScene = new TrackInfo(ThisTrack);
            if (createScene.ShowDialog() != DialogResult.Cancel)
                (Parent as TrackLinkList).FillTheList();
            else
                return;
        }

        private void TrackLink_MouseEnter(object sender, EventArgs e)
        {
            trackLbl.ForeColor = Color.FromKnownColor(KnownColor.DarkGoldenrod);
        }

        private void TrackLink_MouseLeave(object sender, EventArgs e)
        {
            trackLbl.ForeColor = Color.FromKnownColor(KnownColor.DarkBlue);
        }

        private void TrackLbl_MouseEnter(object sender, EventArgs e)
        {
            TrackLink_MouseEnter(sender, e);
        }

        private void TrackLbl_MouseLeave(object sender, EventArgs e)
        {
            TrackLink_MouseLeave(sender, e);
        }

        private void TrackLink_DoubleClick(object sender, EventArgs e)
        {
            Singleton.MTL.MT[Singleton.MTL.Selected].PlaylistAdd(ThisTrack);
        }

        private void TrackLbl_DoubleClick(object sender, EventArgs e)
        {
            TrackLink_DoubleClick(sender, e);
        }

    }
}
