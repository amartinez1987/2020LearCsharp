using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _2020LearCsharp
{
    public class _043ConcurrentQueue
    {
        public static void executeTest()
        {

            ConcurrentQueue<string> queue = new ConcurrentQueue<string>();
            queue.Enqueue("Rob");
            queue.Enqueue("Miles");
            while (!queue.IsEmpty)
            {
                string st;
                if (queue.TryPeek(out st))
                    Console.WriteLine($"peek {st} ");
                if (queue.TryDequeue(out st))
                    Console.WriteLine($"dequeue {st} ");
            }
            
            foreach (var item in queue)
            {
                Console.WriteLine($" elemento of queue {item}");                
            }

            Console.ReadKey();

        }
    }
}
