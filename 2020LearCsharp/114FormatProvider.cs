using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace _2020LearCsharp
{
    public class _114FormatProvider
    {
        static void sample1FormatProvider()
        {
            double bankBalance = 123.45;
            CultureInfo usProvider = new CultureInfo("en-US");
            Console.WriteLine($"US Balance {bankBalance.ToString("C",usProvider)}");
            CultureInfo ukProvider = new CultureInfo("en-GB");
            Console.WriteLine($"UK Balance {bankBalance.ToString("C", ukProvider)}");
            Console.ReadKey();

        }

        public static void execueTest()
        {
            sample1FormatProvider();
        }
    }

}
