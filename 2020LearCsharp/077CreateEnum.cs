using System;
using System.Collections.Generic;
using System.Text;

namespace _2020LearCsharp
{
    public class _077CreateEnum
    {
        enum AlienState
        {
            Sleeping,
            Attacking,
            Destroyed
        }

        enum AlienStateNum : byte
        {
            Sleeping = 0,
            Attacking = 2,
            Destroyed = 3
        }

        public static void executeTest()
        {
            AlienState x = AlienState.Attacking;
            Console.WriteLine(x);
            AlienStateNum xn = AlienStateNum.Attacking;
            Console.WriteLine(  xn );
            Console.ReadKey();
        }
    }
}
