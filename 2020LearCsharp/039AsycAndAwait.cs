using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _2020LearCsharp
{
    public class _039AsycAndAwait
    {
        static bool stopTicks;
        private static double computeAverages(long noOfValues)
        {
            double total = 0;
            Random rand = new Random();
            for (long values = 0; values < noOfValues; values++)
            {
                total = total + rand.NextDouble();
            }
            return total / noOfValues;
        }
        private static async void StartButton_Click()
        {
            long noOfValues = 1000000000;

            double result = await (asyncComputeAverage(noOfValues));
            Console.WriteLine($"Resultado {result} ");
        }

        private static Task<double> asyncComputeAverage(long noOfValues)
        {
            return Task.Run(()=> 
            {
                return computeAverages(noOfValues);
            });
        }

        private static void ticks()
        {
            stopTicks = true;

            while (stopTicks)
            {
                Console.WriteLine("ticks");
                Thread.Sleep(2000);
            }

        }
        public static void executeTest()
        {

            StartButton_Click();
            Console.WriteLine("Other task");
            Task t1 = new Task(() => { ticks(); });
            t1.Start();
            Console.WriteLine("Press any key stop ticks");
            Console.ReadKey();
            stopTicks = false;
            Console.WriteLine("ticks is stop");
        }
    }
}
