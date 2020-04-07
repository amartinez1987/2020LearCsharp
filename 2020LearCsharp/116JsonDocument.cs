using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2020LearCsharp
{
    public class _116JsonDocument
    {
        [Serializable]
        class MusickTrack : IFormattable
        {
            [JsonProperty]
            string Artist { get; set; }
            [JsonProperty]
            string Title { get; set; }
            [JsonProperty]
            int Lenght { get; set; }

            public string ToString(string format, IFormatProvider formatProvider)
            {
                if (string.IsNullOrEmpty(format))
                    format = "G";
                switch (format)
                {
                    case "A":
                        return Artist;
                    case "T":
                        return Title;
                    case "G":
                    case "F":
                        return $"{Artist} {Title}";
                    default:
                        throw new FormatException("Format specifier was invalid");

                }
            }

            public override string ToString()
            {
                return $"{Artist} {Title} {Lenght} Seconds Long";
            }

            public MusickTrack(string artist, string title, int lenght)
            {
                Artist = artist;
                Title = title;
                Lenght = lenght;
            }
        }

        static void sample1MusicTrack()
        {
            MusickTrack m = new MusickTrack(artist:"Anibal Martinez",title:"Me pecho sobre tu espalda.",lenght:100);
            string json = JsonConvert.SerializeObject(m);
            Console.WriteLine("JSON");
            Console.WriteLine(json);

            MusickTrack mD = JsonConvert.DeserializeObject<MusickTrack>(json);
            Console.WriteLine("Deserialize");
            Console.WriteLine(m.ToString());

            Console.ReadKey();

        }

        static void sample2ListAlbumMusic()
        {
            List<MusickTrack> album = new List<MusickTrack>();
            string[] trackNames = new string[] { "My Way","Your Way","Their Way","The Wrong Way"};
            foreach (string trackName in trackNames)
            {
                MusickTrack m = new MusickTrack(artist:"Rob Miles",trackName,lenght:150);
                album.Add(m);
            }

            Console.WriteLine("JSON");
            string jsonAlbum = JsonConvert.SerializeObject(album);
            Console.WriteLine(jsonAlbum);
            List<MusickTrack> lsD = JsonConvert.DeserializeObject<List<MusickTrack>>(jsonAlbum);
            foreach (MusickTrack m in lsD)
            {
                Console.WriteLine(m.ToString());
            }

            Console.ReadKey();

        }

        public static void executeTest()
        {
            sample1MusicTrack();
            sample2ListAlbumMusic();
        }
    }
}
