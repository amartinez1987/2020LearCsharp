using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _2020LearCsharp
{
    public class _036ThreadPool
    {
        static void DoWork(object state)
        {
            Console.WriteLine("Doing to work{0}", state);
            Thread.Sleep(500);
            Console.WriteLine("finish to work{0}", state);
        }
        public static void executeTest()
        {

            for (int i = 0; i < 50; i++)
            {
                int stateNumber = i;
                ThreadPool.QueueUserWorkItem(state => DoWork(stateNumber));
            }

            Console.ReadKey();
        }
    }
}
