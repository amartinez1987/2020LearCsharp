using System;
using System.Collections.Generic;
using System.Text;

namespace _2020LearCsharp
{
    public class _074ValueReferenceTypes
    {
        struct StrucStore
        {
            public int Data { set; get; }
        }

        class ClassStore
        {
            public int Data { set; get; }
        }

        public static void executeTest()
        {
            StrucStore xs, ys;

            ys = new StrucStore();
            ys.Data = 99;
            xs = ys;
            xs.Data = 100;
            Console.WriteLine($"xStrcut {xs.Data}");
            Console.WriteLine($"yStrcut {ys.Data}");

            ClassStore  xc, yc;

            yc = new ClassStore();
            yc.Data = 99;
            xc = yc;
            xc.Data = 100;
            Console.WriteLine($"xClass {xc.Data}");
            Console.WriteLine($"yClass {yc.Data}");

            Console.ReadKey();

        }
    }
}
