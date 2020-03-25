using System;
using System.Collections.Generic;
using System.Text;

namespace _2020LearCsharp
{
   public  class _083IntArrayWrapper
    {

        class IntArrayWrapper
        {
            private int[] array = new int[100];

            public int this[int i]
            {
                get { return array[i]; }
                set { array[i] = value; }
            }
        }

        public  static void executeTest()
        {
            IntArrayWrapper intArray = new IntArrayWrapper();
            intArray[0] = 99;
            Console.WriteLine(intArray[0]);
            Console.ReadKey();
        }
    }
}
