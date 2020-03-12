using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _2020LearCsharp
{
    public class _018CreateThread
    {
        static void threadHello()
        {
            Console.WriteLine("Hello from the thread");
            Thread.Sleep(2000);
        }

        public static void executeTest()
        {
            Thread thread = new Thread(threadHello);
            thread.Start();
        }

    }
}
