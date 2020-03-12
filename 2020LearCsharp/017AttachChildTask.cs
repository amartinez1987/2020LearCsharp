using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _2020LearCsharp
{
    public class _017AttachChildTask
    {
        public static void doChild(object state)
        {
            Console.WriteLine("Child {0} starting",state);
            Thread.Sleep(2000);
            Console.WriteLine("Child {0} finishing", state);
        }

        public static void ExcuteTest()
        {
            var parent = Task.Factory.StartNew(()=> 
            {
                Console.WriteLine("Parents Star");
                for (int i = 0; i < 10; i++)
                {
                    int taskNo = i;
                    Task.Factory.StartNew
                    (
                        (x) => doChild(x)
                        ,taskNo
                        ,TaskCreationOptions.AttachedToParent
                    );
                }
            });

            parent.Wait(); // will wait for all the attached children to complete
            Console.WriteLine("Parent finished. Press a key to end.");
            Console.ReadKey();

            
        }
    }
}
