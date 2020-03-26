using System;
using System.Collections.Generic;
using System.Text;

namespace _2020LearCsharp
{
    public class _086TypeConversion
    {
        class Miles
        {
            public double Distance { get; }

            public static implicit operator kilometers(Miles r)
            {
                Console.WriteLine("Implicit conversion Miles to Kilometers");
                return new kilometers(r.Distance * 1.6);
            }

            public static explicit operator int(Miles t)
            {
                Console.WriteLine("Explicit conversion Miles to Kilometers");
                return (int)(t.Distance + 0.5);
            }

            public Miles(double miles)
            {
                Distance = miles;
            }
        }


        class kilometers
        {
            public double Distance { get; }

            public kilometers(double kilometers)
            {
                Distance = kilometers;
            }

        }

        public static void executeTest()
        {
            Miles m = new Miles(100);
            kilometers k = m;
            Console.WriteLine($"Kilometers {k.Distance}");

            int miles = (int)m;
            Console.WriteLine($"Miles {miles}");
            Console.ReadKey();


        }
    }
}

