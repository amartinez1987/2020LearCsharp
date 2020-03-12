using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _2020LearCsharp
{
    public class _032ShareVariableThreads
    {
        static bool tickRunning;
        public static void executeTest()
        {
            tickRunning = true;

            Thread ticks = new Thread(()=> 
            {
                while (tickRunning)
                {
                    Console.WriteLine("Ticks");
                    Thread.Sleep(1000);
                }
            });

            ticks.Start();

            Console.WriteLine("Press Any key to stop.");
            Console.ReadKey();
            tickRunning = false;
            Console.WriteLine("Ticks stoped.");
        }
    }
}
