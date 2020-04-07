using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading;

namespace _2020LearCsharp
{
    public class _112StringSearch
    {

         static void sample1Contains()
        {
            string input = "Rob Miles";
            if (input.Contains("Rob"))
                Console.WriteLine("Input contains Rob");
            Console.ReadKey();

        }

        private static void sample2TrimStartStartWith()
        {
            string input = "   Rob Miles";
            string trimmedString = input.TrimStart();
            if (trimmedString.StartsWith("Rob"))
                Console.WriteLine("Input start with Rob");
            Console.ReadKey();
        }

        private static void sample3IndexOfSubString()
        {
            string input = "   Rob Miles";
            int nameStart = input.IndexOf("Rob");
            string name = input.Substring(nameStart, 3);
            Console.WriteLine(name);
            Console.ReadKey();
        }

        private static void sample4Replace()
        {
            string stringInFormalName = "Ani Martinez";
            string stringFormalName = stringInFormalName.Replace("Ani", "Anibal");            
            Console.WriteLine(stringFormalName);
            Console.ReadKey();
        }

        private static void sample5Split()
        {

            string sentence = "the cat sat on the mat";
            string[] stringwords = sentence.Split(' ');
            foreach (string word in stringwords)
            {
                Console.WriteLine(word);
            }
            
            Console.ReadKey();
        }

        private static void sample6StringComparationAndCulture()
        {
            // Default comparison fails because the strings are different
            if (!"encyclopædia".Equals("encyclopaedia"))
                Console.WriteLine("Unicode encyclopaedias are not equal");
            // Set the curent culture for this thread to EN-US
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");
            // Using the current culture the strings are equal
            if ("encyclopædia".Equals("encyclopaedia", StringComparison.CurrentCulture))
                Console.WriteLine("Culture comparison encyclopaedias are equal");
            // We can use the IgnoreCase option to perform comparisions that ignore case
            if ("encyclopædia".Equals("ENCYCLOPAEDIA", StringComparison.CurrentCultureIgnoreCase))
                Console.WriteLine("Case culture comparison encyclopaedias are equal");
            if (!"encyclopædia".Equals("ENCYCLOPAEDIA", StringComparison.OrdinalIgnoreCase))
                Console.WriteLine("Ordinal comparison encyclopaedias are not equal");

            Console.ReadKey();
        }
        private static void sample7EnumerateStringMethods()
        {
            foreach (char ch in "Hello world")
            {
                Console.WriteLine($"val: {ch}");
            }
            Console.ReadKey();
        }

        public static void executeText()
        {
            sample1Contains();
            sample2TrimStartStartWith();
            sample3IndexOfSubString();
            sample4Replace();
            sample5Split();
            sample6StringComparationAndCulture();
            sample7EnumerateStringMethods();
        }

      
    }
}
