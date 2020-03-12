using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _2020LearCsharp
{
    public class _029PassingDataThread
    {
        static void workOnData(object data)
        {
            Console.WriteLine("Working on {0}",data);
            Thread.Sleep(1000);
        }

        public static void executeTest()
        {
            ParameterizedThreadStart p = new ParameterizedThreadStart(workOnData);
            Thread thread = new Thread(p);
            thread.Start(99);
            Console.WriteLine("Press ant key");
            Console.ReadKey();
        }


    }
}
