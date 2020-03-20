using System;
using System.Threading;
using System.Threading.Tasks;

namespace _2020LearCsharp
{
    public class _058UnsafeMethodThread
    {
        private class counter
        {
            private int totalValue = 0;

            public void increaseCounter(int amount)
            {
                totalValue = totalValue + amount;

            }


            public int Total { get { return totalValue; } }
        }
        public static void executeTest()
        {
           
        }
    }
}
