using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMMusic
{
    public class Save
    {
        public string Name { get; set; }
        public List<Track> MTPL1;
        public List<Track> MTPL2;
        public List<Track> MTPL3;

        public Save() { }

        public Save(string s, List<Track> m1, List<Track> m2, List<Track> m3)
        {
            Name = s;
            MTPL1 = new List<Track>(m1);
            MTPL2 = new List<Track>(m2);
            MTPL3 = new List<Track>(m3);
        }

        public void Update(List<Track> m1, List<Track> m2, List<Track> m3)
        {
            MTPL1 = new List<Track>(m1);
            MTPL2 = new List<Track>(m2);
            MTPL3 = new List<Track>(m3);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
