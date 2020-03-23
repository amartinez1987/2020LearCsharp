using System;
using System.Collections.Generic;
using System.Text;

namespace _2020LearCsharp
{
   public  class _067BuiltdingDelegate1
    {
        public static void executeTest()
        {
            Func<int, int, int> add = (int a, int b) =>  a + b ;
            Console.WriteLine(add(3,6));
            Console.ReadLine();
            Action<string> logMessage = (message) => Console.WriteLine(message);
            logMessage("Ajo");
            Console.Read();
            Predicate<int> divByThreee = (i) => i % 3 == 0;
            Console.WriteLine(divByThreee(3));
            Console.ReadKey();
        }
    }
}
