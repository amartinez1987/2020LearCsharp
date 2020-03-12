using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _2020LearCsharp
{
    public class _011CreateTasks
    {
        public static void DoWork()
        {
            Console.WriteLine("Task Start");
            Thread.Sleep(200);
            Console.WriteLine("Task End");
        }

        public static void ExecuteTest()
        {
            Task newTask = new Task(()=>DoWork());
            newTask.Start();
            newTask.Wait();
            Console.WriteLine("Key Press Any key");
            Console.ReadKey();

        }
    }
}
