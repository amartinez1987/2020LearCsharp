using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _2020LearCsharp
{
    public class _013TaskReturnValue
    {
        public static int calculatingResutl()
        {
            Console.WriteLine("Work Starting");
            Thread.Sleep(200);
            Console.WriteLine("Work Ending");
            return 99;
        }

        public static void ExecuteTest()
        {
            Task<int> r = Task.Run
            (
                ()=> 
                {
                    return calculatingResutl();
                }
            );

            Console.WriteLine("Result " + r.Result.ToString());
            Console.WriteLine("Finish work");
            Console.ReadKey();
        }
    }
}
