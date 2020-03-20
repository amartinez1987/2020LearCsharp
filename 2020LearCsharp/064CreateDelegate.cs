using System;
using System.Collections.Generic;
using System.Text;

namespace _2020LearCsharp
{
    public class _064CreateDelegate
    {
        class program
        {
            

            delegate int intOpetation(int a, int b);
            private static intOpetation op;


            static int Add(int a, int b)
            {
                return a + b;
            }

            static int Substract(int a, int b)
            {
                return a - b;
            }

            public static void run()
            {
                op = new intOpetation(Add);
                Console.WriteLine(op(1,2));

                op = Substract;
                Console.WriteLine(op(1, 2));

                Console.ReadKey();
            }


        }

        public static void excuteTest()
        {
            program.run();
        }

      
    }
}
