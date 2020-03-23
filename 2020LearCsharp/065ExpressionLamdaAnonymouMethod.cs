using System;
using System.Collections.Generic;
using System.Text;

namespace _2020LearCsharp
{
    public class _065ExpressionLamdaAnonymouMethod
    {

        class program
        {
            delegate int intOperation(int a, int b);
            static intOperation op;



            public static void run()
            {
                op = (int a, int b) => { return a + b; };
                Console.WriteLine(op(3,6));
                Console.ReadLine();
                
            }
        }

        public static void excuteTest()
        {

            program.run();
        }

    }
}
