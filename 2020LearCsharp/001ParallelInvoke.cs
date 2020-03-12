using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _2020LearCsharp
{
    public class _001ParallelInvoke
    {
        public static void task1()
        {
            Console.WriteLine("Start Task 1");
            Thread.Sleep(200);
            Console.WriteLine("End Task 1");
        }

        public static void task2()
        {
            Console.WriteLine("Start Task 2");
            Thread.Sleep(200);
            Console.WriteLine("End Task 2");
        }

        public static void ExecuteTest()
        {
            Parallel.Invoke(() => task1(), () => task2());
            Console.WriteLine("Key Press Any Key");
            Console.ReadKey();
        }

      
    }
}
