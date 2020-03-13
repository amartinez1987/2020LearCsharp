using System;
using System.Collections.Generic;
using System.Text;

namespace _2020LearCsharp
{
    public class _037BlockingUserInterface
    {
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
        private static void StartButton_Click()
        {
            long noOfValues = 1000000000;
            Console.WriteLine( $"Result:{computeAverages(noOfValues)} ");
        }

        public static void executeTest()
        {

            StartButton_Click();
           
            Console.ReadKey();
        }


    }
}
