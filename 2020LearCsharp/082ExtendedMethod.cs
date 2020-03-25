using System;
using System.Collections.Generic;
using System.Text;

namespace _2020LearCsharp
{
    public class _082ExtendedMethod
    {
        public static void executeTest()
        {
            string text = @"A rocket explorer called Wright,
                            Once travelled much faster than light,
                            He set out one day,
                            In a relative way,
                            And returned on the previous night";
            Console.WriteLine(text.LineCount());


        }
    }

    static class MyExtensions
    {
        public static int LineCount(this string str)
        {
            return str.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}
