using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GMMusic
{
    [Serializable]
    public class Track
    {
        public int Id { get; set; }
        public string File { get; set; }
        public string Name { get; set; }
        public string Duration { get; set; }
        public bool Ambience { get; set; }
        public List<string> Tags { get; set; }

        public Track() { }

        public Track(string file, string name, bool ambience, List<string> tags, string dur = null)
        {
            Id = ++Singleton.TLastId;
            File = file;
            Name = name;
            Duration = dur;
            Ambience = ambience;
            Tags = tags;
        }

        public override string ToString()
        {
            return Name;
        }

    }
}
