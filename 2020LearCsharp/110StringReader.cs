using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace _2020LearCsharp
{
    public class _110StringReader
    {
        public static void executeTest()
        {
            string dataString = @"Rob Miles
21";
            StringReader sr = new StringReader(dataString);
            string name = sr.ReadLine();
            int age = int.Parse(sr.ReadLine());
            sr.Close();

            Console.WriteLine($"Name: {name} Age: {age}");

            Console.ReadKey();


        }
    }
}
