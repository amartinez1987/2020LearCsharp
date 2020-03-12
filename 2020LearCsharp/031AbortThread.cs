using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _2020LearCsharp
{
    public class _031AbortThread
    {
        public static void executeTest()
        {
            Thread thread = new Thread(() =>
            {
                while (true)
                {
                    Console.WriteLine("Ticks");
                    Thread.Sleep(1000);
                }
            });
            thread.Start();
            Console.WriteLine("Press any key to stop");            
            Console.ReadKey();
            thread.Abort();
            Console.WriteLine("Abortado");
        }
    }
}
