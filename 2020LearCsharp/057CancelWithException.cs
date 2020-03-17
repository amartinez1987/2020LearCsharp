using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _2020LearCsharp
{
    public class _057CancelWithException
    {
        static CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
        static void Clock(CancellationToken cancellationToken)
        {
            int tickCount = 0;
            while (!cancellationTokenSource.IsCancellationRequested && tickCount < 20)
            {
                tickCount++;
                Console.WriteLine("Tick");
                Thread.Sleep(500);
            }
           
        }


        public static void executeTest()
        {
            Task clock = Task.Run(() => Clock(cancellationTokenSource.Token));

            Console.WriteLine("Press any key to stop the clock");
            Console.ReadKey();
            if (clock.IsCompleted)
            {
                Console.WriteLine("Clock Complete");
            }
            else
            {
                try
                {
                    cancellationTokenSource.Cancel();
                    clock.Wait();
                }
                catch (AggregateException ex)
                {

                    Console.WriteLine($"Clock stopped {ex.StackTrace}");
                }
            }
            
            Console.ReadKey();
        }

    }
}
