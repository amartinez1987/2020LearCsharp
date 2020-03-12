using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _2020LearCsharp
{
    public class _035ThreadContext
    {
        static void DisplayThread(Thread t)
        {
            Console.WriteLine("Name: {0}", t.Name);
            Console.WriteLine("Culture: {0}", t.CurrentCulture);
            Console.WriteLine("Priority: {0}", t.Priority);
            Console.WriteLine("Context: {0}", t.ExecutionContext);
            Console.WriteLine("IsBackground?: {0}", t.IsBackground);
            Console.WriteLine("IsPool?: {0}", t.IsThreadPoolThread);
           
        }
        public static void executeTest()
        {
            Thread.CurrentThread.Name = "Method";
            DisplayThread(Thread.CurrentThread);
        }
    }
}
