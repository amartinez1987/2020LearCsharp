using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _2020LearCsharp
{
    public class _004ParallelLoopState1
    {
        public static void WorkOnItem(object item)
        {
            Console.WriteLine("Work On Item star " + item);
            Thread.Sleep(200);
            Console.WriteLine("Work On Item end " + item);
        }
        public static void ExecuteTest()
        {
            var items = Enumerable.Range(0, 500).ToArray();
            ParallelLoopResult result = Parallel.For(0, items.Length, (int i , ParallelLoopState loopState) => 
            {
                if(i>200)
                    loopState.Stop();
                    WorkOnItem(items[i]);
            });
            Console.WriteLine("Completed: " + result.IsCompleted);
            Console.WriteLine("Items: " + result.LowestBreakIteration);

           
            Console.WriteLine("Key press any key");
            Console.ReadKey();
        }
    }
}
