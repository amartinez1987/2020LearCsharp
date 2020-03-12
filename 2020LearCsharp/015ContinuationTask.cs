using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _2020LearCsharp
{
    public class _015ContinuationTask
    {
        public static void helloTask()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Hello");
        }

        public static void worldTask()
        {
            Thread.Sleep(1000);
            Console.WriteLine("World");
        }

        public static void ExecuteTest()
        {           
                Task task = Task.Run(() => helloTask());
                task.ContinueWith((prevTask) => worldTask());
                Console.WriteLine("Finished processing. Press a key to end.");
                Console.ReadKey();
        }
    }
}
