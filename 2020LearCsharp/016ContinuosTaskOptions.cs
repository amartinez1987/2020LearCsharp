using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _2020LearCsharp
{
    public class _016ContinuosTaskOptions
    {
        public static void helloTask()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Hello");
            int[] a = new int []{0};
             var b = a[3];
        }

        public static void worldTask()
        {
            Thread.Sleep(1000);           
            Console.WriteLine("World");
        }

        public static void ExecuteTest()
        {
            Task task = Task.Run(() => helloTask());
            task.ContinueWith((prevTask) => worldTask(),TaskContinuationOptions.OnlyOnRanToCompletion);
            task.ContinueWith((prevTask) => exceptionTask(), TaskContinuationOptions.OnlyOnFaulted);
            Console.WriteLine("Finished processing. Press a key to end.");
            Console.ReadKey();
        }

        private static void exceptionTask()
        {
            Console.WriteLine("Exception");
        }
    }
}
