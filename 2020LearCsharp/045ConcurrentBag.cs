using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace _2020LearCsharp
{
    public class _045ConcurrentBag
    {
        public static void executeTest()
        {

            ConcurrentBag<string> bag = new ConcurrentBag<string>();
            bag.Add("Rob");
            bag.Add("Miles");
            bag.Add("Ana");
            bag.Add("Daniela");
            while (!bag.IsEmpty)
            {
                string st;
                if (bag.TryPeek(out st))
                    Console.WriteLine($"peek {st} ");
                if (bag.TryTake(out st))
                    Console.WriteLine($"pop {st} ");
            }

            foreach (var item in bag)
            {
                Console.WriteLine($" elemento of queue {item}");
            }

            Console.ReadKey();

        }
    }
}
