using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _2020LearCsharp
{
    public class _068LambaExpressionTask
    {
        static void executeTest()
        {
            Task.Run(() => 
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(i);
                    Thread.Sleep(500);
                }
            });

            Console.WriteLine("");
            Console.ReadKey();
        }
    }
}
