using System;
using System.Collections.Generic;
using System.Text;

namespace _2020LearCsharp
{
    public class _106GarbageCollection
    {
        class Person
        {
            long[] personArray = new long[1000000];
        }

        public static void executeTest()
        {
            for (long i=0; i <= 10000000000; i++)
            {
                Person p = new Person();
                System.Threading.Thread.Sleep(3);

            }
        }
    }
}
