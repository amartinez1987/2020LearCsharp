using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _2020LearCsharp
{
    public class _019ThreadsAndLambdaExpression
    {
        public static void executeTest()
        {
            Thread thread = new Thread
            (
                () =>
                {
                    Console.WriteLine("Hello for thread");
                    Thread.Sleep(1000);
                }
            );

            thread.Start();
            Console.WriteLine("Press ant key");
            Console.ReadKey();
        }
            
    }
}
