using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace GMMusic
{
    public class TrackLinkList : Panel
    {
        public List<Track> TrackList { get; set; }
        public List<Track> ShowList { get; set; }

        public TrackLinkList() : base()
        {
            BackColor = Color.FromKnownColor(KnownColor.Azure);
            TrackList = new List<Track>();
        }

        public void RefreshList()
        {
            ShowList = new List<Track>(TrackList);
            FillTheList();
        }

        public void FillTheList()
        {
            if (ShowList.Count > 0)
            {
                Controls.Clear();
                ShowList = ShowList.OrderByDescending(t => t.Name).ToList();
                foreach (Track track in ShowList)
                {
                    TrackLink link = new TrackLink(track);
                    link.Dock = DockStyle.Top;
                    Controls.Add(link);
                }
                ShowList.Reverse();
            }
            else
                Controls.Clear();
        }


    }
}
