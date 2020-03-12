using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _2020LearCsharp
{
    public class _014TaskWaitAll
    {
        public static void DoWork(int i)
        {
            Console.WriteLine("Task {0} starting", i);
            Thread.Sleep(2000);
            Console.WriteLine("Task {0} finished", i);
        }

        public static void ExecuteTest()
        {
            Task[] Tasks = new Task[10];
            for (int i = 0; i < 10; i++)
            {
                int taskNum = i;  // make a local copy of the loop counter so that the 
                                  // correct task number is passed into the  lambda expression
                Tasks[i] = Task.Run(() => DoWork(taskNum));
            }
            Task.WaitAll(Tasks);
            Console.WriteLine("Finished processing. Press a key to end.");
            Console.ReadKey();

             
        }


    }
}
