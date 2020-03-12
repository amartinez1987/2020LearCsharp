using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _2020LearCsharp
{
    public class _030ParameterThreadLambda
    {
        public static void executeTest()
        {
           
            Thread thread = new Thread((data)=> 
            {
                Console.WriteLine("Working on {0}", data);
                Thread.Sleep(1000);
            });
            thread.Start(99);
            Console.WriteLine("Press ant key");
            Console.ReadKey();
        }
    }
}
