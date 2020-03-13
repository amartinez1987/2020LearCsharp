using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _2020LearCsharp
{
    public class _042BlockingCollection
    {
        public static void executeTest()
        {

            BlockingCollection<int> data = new BlockingCollection<int>(new ConcurrentStack<int>(),5);
            Task.Run(()=> 
            {
                for (int i = 0; i<11;i++)
                {
                    data.Add(i);
                    Console.WriteLine($"succes {i}");
                }
                data.CompleteAdding();
            });

            

            Console.ReadKey();
            Console.WriteLine("Read Collection");

            Task.Run(()=> 
            {
                while (!data.IsCompleted)
                {
                    try
                    {
                        int v = data.Take();
                        Console.WriteLine($" data {v} taken succes");
                    }
                    catch (Exception ex)
                    {

                    }
                }
            });

            Console.ReadKey();

        }
    }
}
