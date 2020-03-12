using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _2020LearCsharp
{
    public class _012CreateTaskMethodRun
    {
        public static void DoWork()
        {
            Console.WriteLine("Task Start");
            Thread.Sleep(200);
            Console.WriteLine("Task End");
        }

        public static void ExecuteTest()
        {
            Task newTask = Task.Run(() => DoWork());
            newTask.Wait();
            Console.WriteLine("Key Press Any key");
            Console.ReadKey();

        }
    }
}
