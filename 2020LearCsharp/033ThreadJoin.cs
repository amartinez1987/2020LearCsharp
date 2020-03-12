using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _2020LearCsharp
{
    public class _033ThreadJoin
    {

        public static void executeTest()
        {
            Thread tWait = new Thread(()=> 
            {
                Console.WriteLine("Start thread");
                Thread.Sleep(2000);
                Console.WriteLine("thread done");
            });

            tWait.Start();
            Console.WriteLine("Thread join");
            tWait.Join();
            Console.WriteLine("Press any key to stop");
            Console.ReadKey();
        }
    }
}
