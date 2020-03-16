using System;
using System.Collections.Generic;
using System.Text;

namespace _2020LearCsharp
{
    public class _052SequentialLocking
    {
        static object locking1 = new object();
        static object locking2 = new object();

        static void method1()
        {
            lock (locking1)
            {
                Console.WriteLine("Lock object 1");
                lock (locking2)
                {
                    Console.WriteLine("Lock object 2");
                }
            }
        }

        static void method2()
        {
            lock (locking2)
            {
                Console.WriteLine("Lock object 2");
                lock (locking1)
                {
                    Console.WriteLine("Lock object 1");
                }
            }
        }

        public static void executeTest()
        {
            method1();
            method2();
            Console.WriteLine("Finish");
            Console.ReadKey();
        }
    }
}
