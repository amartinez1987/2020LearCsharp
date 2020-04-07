using System;
using System.Collections.Generic;
using System.Text;

namespace _2020LearCsharp
{
  public  class _115Interpolacion
    {
        static void sample1Interpolacion()
        {
            string name = "Anibal Guillermo Martinez Aguas";
            int age = 32;
            Console.WriteLine($"your name is {name} and your age is {age,-5:D}.");
            Console.ReadKey();
        }

        public static void executeTest()
        {
            sample1Interpolacion();
        }
    }
}
