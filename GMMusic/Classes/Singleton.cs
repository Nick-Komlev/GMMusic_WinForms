using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Windows.Forms;


namespace GMMusic
{
    public static class Singleton
    {
        public static string MPath { get; set; }
        public static string TPath { get; set; }
        public static string SPath { get; set; }
        public static int TLastId { get; set; }
        public static List<Track> Tracks { get; set; }
        public static MediaTrackList MTL { get; set; }
        public static List<Save> Saves { get; set; }

        static Singleton()
        {
            MPath = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory))) + "\\" + "Music";
            TPath = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory))) + "\\" + "track_xml.xml";
            SPath = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory))) + "\\" + "save_xml.xml";

            if (!File.Exists(TPath) && !File.Exists(SPath))
            {
                Tracks = new List<Track> { new Track(MPath+"\\"+"Adrian von Ziegler - A Celtic Lore.mp3", "Adrian von Ziegler - A Celtic Lore", false, new List<string>(), "0:00") };
                Saves = new List<Save> { new Save("default", Tracks, Tracks, Tracks) };

                Serialize();
            }



            Deserialize();
            GetTLastId();

        }

        public static void Deserialize()
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<Track>));
            using (FileStream fs = new FileStream(TPath, FileMode.OpenOrCreate))
                Tracks = (List<Track>)formatter.Deserialize(fs);

            formatter = new XmlSerializer(typeof(List<Save>));
            using (FileStream fs = new FileStream(SPath, FileMode.OpenOrCreate))
                Saves = (List<Save>)formatter.Deserialize(fs);

        }

        public static void Serialize()
        {
            File.Delete(TPath);
            XmlSerializer formatter = new XmlSerializer(typeof(List<Track>));
            using (FileStream fs = new FileStream(TPath, FileMode.OpenOrCreate, FileAccess.Write))
                formatter.Serialize(fs, Tracks);

            File.Delete(SPath);
            formatter = new XmlSerializer(typeof(List<Save>));
            using (FileStream fs = new FileStream(SPath, FileMode.OpenOrCreate, FileAccess.Write))
                formatter.Serialize(fs, Saves);
        }

        public static void GetTLastId()
        {
            if (Tracks.Count > 0)
                TLastId = Tracks[Tracks.Count - 1].Id;
            else
                TLastId = 0;
        }
    }
}
