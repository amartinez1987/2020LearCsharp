using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace _2020LearCsharp
{
    public class _044CouncurrentStack
    {
          public static void executeTest()
        {

            ConcurrentStack<string> stack = new ConcurrentStack<string>();
            stack.Push("Rob");
            stack.Push("Miles");
            while (!stack.IsEmpty)
            {
                string st;
                if (stack.TryPeek(out st))
                    Console.WriteLine($"peek {st} ");
                if (stack.TryPop(out st))
                    Console.WriteLine($"pop {st} ");
            }
            
            foreach (var item in stack)
            {
                Console.WriteLine($" elemento of queue {item}");                
            }

            Console.ReadKey();

        }
    }
}
