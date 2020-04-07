using System;
using System.Collections.Generic;
using System.Text;

namespace _2020LearCsharp
{
    public class _113FormatString
    {
        static void sample1FormatString()
        {
            int i = 99;
            double pi = 3.141592654;
            Console.WriteLine($"{i,-10:D} {i,-10:X} {pi,5:N2}");
            Console.ReadKey();
        }

        class MusickTrack : IFormattable
        {
            string Artist { get; set; }
            string Title { get; set; }

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
                return $"{Artist} {Title}";
            }

            public MusickTrack(string artist, string title)
            {
                Artist = artist;
                Title = title;
            }
        }

        private static void sample2MusicktrackFormatter()
        {
            MusickTrack m = new MusickTrack(artist:"Anibal Aguas", title:"Me pecho sobre tu espalda.");
            Console.WriteLine($"Artists: {m:A}");
            Console.WriteLine($"Title: {m:T}");
            Console.WriteLine($"Default {m:G}");
            Console.WriteLine($"Default {m:F}");
            Console.ReadKey();

        }

        public static void executeTest()
        {
            sample1FormatString();
            sample2MusicktrackFormatter();
        }


    }
}
