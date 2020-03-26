using System;
using System.Collections.Generic;
using System.Text;

namespace _2020LearCsharp
{
    public class _085BoxingUnBoxing
    {
        public static void executeTest()
        {
            object o = 99;
            int oVal = (int)o;
            Console.WriteLine(oVal);
            Console.ReadKey();

            float x = 9.9f;
            int i = (int) x;
            Console.WriteLine(i);
        }
    }
}
