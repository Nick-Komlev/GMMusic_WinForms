using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GMMusic
{
    public partial class Form1 : Form
    {
        public MediaTrackList MTL;
        public TrackLinkList SdtckList;
        public TrackLinkList AmbList;

        private bool SearchOpened { get; set; }

        private bool SdtckOpen { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PlayList[] PL = new PlayList[3];

            for (int i = PL.Length; i > 0; i--)
            {
                PL[i - 1] = new PlayList(i - 1);
                PL[i - 1].Name = "playList" + i.ToString();
                PL[i - 1].Dock = DockStyle.Top;
                PL[i - 1].Visible = false;
                threadPanel.Controls.Add(PL[i - 1]);
            }

            MTL = new MediaTrackList(PL);
            MTL.Dock = DockStyle.Fill;
            Singleton.MTL = MTL;
            playerPanel.Controls.Add(MTL);

            SearchOpened = true;
            searchPanel.Size = new Size(450, 0);

            SdtckOpen = true;


            SdtckList = new TrackLinkList();
            SdtckList.Name = "sdtckPanel";
            SdtckList.Dock = DockStyle.Fill;
            SdtckList.AutoScroll = true;
            SdtckList.TrackList = Singleton.Tracks.FindAll(t => !t.Ambience).ToList();
            SdtckList.ShowList = new List<Track>(SdtckList.TrackList);
            SdtckList.FillTheList();
            sdtckPanel.Dock = DockStyle.Fill;
            sdtckPanel.Controls.Add(SdtckList);


            AmbList = new TrackLinkList();
            AmbList.Name = "ambPanel";
            AmbList.Dock = DockStyle.Fill;
            AmbList.AutoScroll = true;
            AmbList.TrackList = Singleton.Tracks.FindAll(t => t.Ambience).ToList();
            AmbList.ShowList = new List<Track> (AmbList.TrackList);
            AmbList.FillTheList();
            ambPanel.Dock = DockStyle.Fill;
            ambPanel.Controls.Add(AmbList);


            SountrackSearchOpen();

        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MTL.MTDispose();
        }

        private void NewTrackBtn_Click(object sender, EventArgs e)
        {
            Form createScene = new TrackInfo();
            if (createScene.ShowDialog() != DialogResult.Cancel) return;
        }

        private void OpenSearchBtn_Click(object sender, EventArgs e)
        {
            if (SearchOpened)
            {
                SearchOpened = false;
                searchPanel.Size = new Size(30, 0);
            }
            else
            {
                SearchOpened = true;
                searchPanel.Size = new Size(300, 0);
            }
              
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                this.Size = new Size(1300, this.Size.Height);
                SearchOpened = true;
                searchPanel.Size = new Size(450, 0);
            }
                
            else if (e.KeyCode == Keys.F2)
            {
                this.Size = new Size(880, this.Size.Height);
                SearchOpened = false;
                searchPanel.Size = new Size(30, 0);
            }

            else if (e.KeyCode == Keys.F3)
            {
                this.Size = new Size(493, this.Size.Height);
                SearchOpened = false;
                searchPanel.Size = new Size(30, 0);
            }

        }

        private void SountrackSearchOpen()
        {
            if (SdtckOpen)
            {
                ambPanel.Visible = false;
                ambHeaderPanel.Dock = DockStyle.Bottom;
                sdtckPanel.Visible = true;
            }
            else
            {
                sdtckPanel.Visible = false;
                ambHeaderPanel.Dock = DockStyle.Top;
                ambPanel.Visible = true;
            }

        }

        private void Label1_Click(object sender, EventArgs e)
        {
            SdtckHeaderPanel_Click(sender, e);
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            AmbHeaderPanel_Click(sender, e);
        }

        private void SdtckHeaderPanel_Click(object sender, EventArgs e)
        {
            SdtckOpen = true;
            SountrackSearchOpen();
        }

        private void AmbHeaderPanel_Click(object sender, EventArgs e)
        {
            SdtckOpen = false;
            SountrackSearchOpen();
        }

        private void SdtckSearchTB_Enter(object sender, EventArgs e)
        {
            SdtckHeaderPanel_Click(sender, e);
        }

        private void AmpSearchTB_Enter(object sender, EventArgs e)
        {
            AmbHeaderPanel_Click(sender, e);
        }

        private void SdtckReBtn_Click(object sender, EventArgs e)
        {
            SdtckHeaderPanel_Click(sender, e);
            sdtckSearchTB.Text = "";
            SdtckList.TrackList = Singleton.Tracks.FindAll(t => !t.Ambience).ToList();
            SdtckList.RefreshList();
        }

        private void AmbReBtn_Click(object sender, EventArgs e)
        {
            AmbHeaderPanel_Click(sender, e);
            ambSearchTB.Text = "";
            AmbList.TrackList = Singleton.Tracks.FindAll(t => t.Ambience).ToList();
            AmbList.RefreshList();
        }

        private void SdtckSearchTB_TextChanged(object sender, EventArgs e)
        {
            string s = sdtckSearchTB.Text;
            if (s != "")
                SdtckList.ShowList = SdtckList.TrackList.FindAll(t => t.Name.ToLower().Contains(s.ToLower()) || t.Tags.Any(tg => tg.Contains(s.ToLower())));
            else
                SdtckList.ShowList = SdtckList.TrackList.FindAll(t => true);
            SdtckList.FillTheList();
        }

        private void AmbSearchTB_TextChanged(object sender, EventArgs e)
        {
            string s = ambSearchTB.Text;
            if (s != "")
                AmbList.ShowList = AmbList.TrackList.FindAll(t => t.Name.ToLower().Contains(s.ToLower()) || t.Tags.Any(tg => tg.Contains(s.ToLower())));
            else
                AmbList.ShowList = AmbList.TrackList.FindAll(t => true);
            AmbList.FillTheList();
        }

        private void ChooseSaveBtn_Click(object sender, EventArgs e)
        {
            Form createScene = new SaveInfo();
            if (createScene.ShowDialog() != DialogResult.Cancel)
            {

            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            Form createScene = new SaveSave();
            if (createScene.ShowDialog() != DialogResult.Cancel)
            {
                Singleton.Serialize();
            }
        }
    }
}
