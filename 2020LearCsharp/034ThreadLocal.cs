using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _2020LearCsharp
{
    public class _034ThreadLocal
    {
        public static ThreadLocal<Random> r = new ThreadLocal<Random>
           (
              () =>
              {
                  return new Random(2);
              }
            );

        public static void executeTest()
        {
            Thread t1 = new Thread(() =>
            {
                for (int i=0;i<5;i++)
                {
                    Console.WriteLine("t1 {0}", r.Value.Next(10));
                    Thread.Sleep(500);
                }
            });

            Thread t2 = new Thread(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("t2 {0}", r.Value.Next(10));
                    Thread.Sleep(500);
                }
            });

            t1.Start();
            t2.Start();
            Console.ReadKey();
        }
    }
}
