using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GMMusic
{
    public partial class TrackInfo : Form
    {
        private bool Add { get; set; }
        private Track Track_ {get; set; }

        public TrackInfo()
        {
            InitializeComponent();
            Add = true;
            tagLB.InitAdd();
        }

        public TrackInfo(Track track)
        {
            InitializeComponent();
            fileTB.Text = track.File;
            nameTB.Text = track.Name;
            durTB.Text = track.Duration;
            ambienceChB.Checked = track.Ambience;
            tagLB.FillTheLines(track.Tags);
            Track_ = track;
            Add = false;
        }

        private void TrackInfo_Load(object sender, EventArgs e)
        {
        }


        private void AcceptBtn_Click(object sender, EventArgs e)
        {
            if (fileTB.Text.Length > 0 && nameTB.Text.Length > 0 && durTB.Text.Length > 0)
            {
                List<string> ls = new List<string>();
                foreach (TextBox tb in tagLB.Controls)
                    if (tb.Text.Length > 0) ls.Add(tb.Text);

                if (Add)
                {
                    Singleton.Tracks.Add(new Track(fileTB.Text, nameTB.Text, ambienceChB.Checked, ls, durTB.Text));
                    Singleton.Serialize();
                }

                else
                {
                    Track_.File = fileTB.Text;
                    Track_.Name = nameTB.Text;
                    Track_.Duration = durTB.Text;
                    Track_.Ambience = ambienceChB.Checked;
                    Track_.Tags = ls;
                    Singleton.Serialize();
                }

                this.DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("Не заполнены ключевые поля");
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void FileBtn_Click(object sender, EventArgs e)
        {
            if (openFile.ShowDialog() == DialogResult.Cancel)
                return;
            fileTB.Text = openFile.FileName;
            nameTB.Text = fileTB.Text.Split('\\').Last().Split('.')[0];
            var file = TagLib.File.Create(openFile.FileName);
            durTB.Text = file.Properties.Duration.Minutes.ToString() + ":" + file.Properties.Duration.Seconds.ToString("D2");
        }
    }
}
