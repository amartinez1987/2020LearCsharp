using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _2020LearCsharp
{
    public class _003ParallelFor
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
            Parallel.For(0,items.Length,i=> { WorkOnItem(items[i]); });
            Console.WriteLine("Key press any key");
            Console.ReadKey();
        }
    }
}
