using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2020LearCsharp
{
    public class _047SingleTaksSumming
    {
        static int[] items = Enumerable.Range(0, 500000001).ToArray();
        public static void executeTest()
        {
            long total = 0;

            for (int i = 0; i < items.Length; i++)
            {
                total = total + items[i];
            }
            Console.WriteLine($"the total is { total }");

            Console.ReadKey();

        }
    }
}
