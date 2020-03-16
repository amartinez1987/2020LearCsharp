using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _2020LearCsharp
{
    public class _053DeadLockedSequencial
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
            Task t1 = Task.Run(() => { method1(); });
            Task t2 = Task.Run(() => { method2(); });
            Console.WriteLine("Finish");
            Console.ReadKey();
        }
    }
}
