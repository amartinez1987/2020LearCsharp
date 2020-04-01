using System;
using System.Collections.Generic;
using System.Text;

namespace _2020LearCsharp
{
    public class _087BadDynamicCode
    {
        class MessageDisplay
        {
            public void DisplayMessage(string message)
            {
                Console.WriteLine(message);
            }
        }

        public static void executeTest()
        {
            MessageDisplay m = new MessageDisplay();
            m.DisplayMessage("Hello world");

            dynamic d = new MessageDisplay();
            //d.Banana("hello world");

            dynamic c = 99;
            c = c + 1;
            Console.WriteLine(c);

            c = "hello";
            c = c + " Rob";
            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
