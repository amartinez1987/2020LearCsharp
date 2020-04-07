using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace _2020LearCsharp
{
    public class _109StringWriter
    {
        public static void executeTest()
        {
            StringWriter sw = new StringWriter();
            sw.WriteLine("Hello World");
            sw.Close();
            Console.WriteLine(sw);
            Console.ReadKey();
        }
    }
}
