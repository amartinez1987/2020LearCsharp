using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _2020LearCsharp
{
    class _002ParallelForEach
    {
        public static void WorkOnItem(object item)
        {
            Console.WriteLine("Work On Item star "+ item);
            Thread.Sleep(200);
            Console.WriteLine("Work On Item end " + item);
        }

        public static void ExecuteTest()
        {
            var items = Enumerable.Range(0, 500);
            Parallel.ForEach(items, item => { WorkOnItem(item); });
            Console.WriteLine("Key press any key");
            Console.ReadKey();
        }
    }
}
