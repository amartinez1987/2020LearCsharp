using System;
using System.Collections.Generic;
using System.Text;

namespace _2020LearCsharp
{
    public class _066Closures
    {
        delegate int getValue();
        static getValue getLocalInt;

        static void setLocalInt()
        {
            int localInt = 99;
            getLocalInt = () => localInt;
        }
        public static void excuteTest()
        {
            setLocalInt();
            Console.WriteLine(getLocalInt());
            Console.ReadKey();
        }


    }
}
