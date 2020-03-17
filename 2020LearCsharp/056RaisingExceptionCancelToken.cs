using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace _2020LearCsharp
{
    public class _056RaisingExceptionCancelToken
    {
        static CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
        static void Clock(CancellationToken cancellationToken)
        {
            int tickCount = 0;
            while (!cancellationTokenSource.IsCancellationRequested && tickCount<20)
            {
                tickCount++;
                Console.WriteLine("Tick");
                Thread.Sleep(500);
            }
            cancellationToken.ThrowIfCancellationRequested();
        }
        

        public static void executeTest()
        {
            Task.Run(() => Clock(cancellationTokenSource.Token));
            Console.WriteLine("Press any key to stop the clock");
            Console.ReadKey();
            cancellationTokenSource.Cancel();
            Console.WriteLine("Clock stopped");
            Console.ReadKey();
        }


    }
}
