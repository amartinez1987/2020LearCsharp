using System;
using System.Collections.Generic;
using System.Text;

namespace _2020LearCsharp
{
    public class _108StringBuilder
    {
        public static void executeTest()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Hello");
            stringBuilder.Append(" ");
            stringBuilder.Append("World");
            Console.WriteLine($"Result :{stringBuilder.ToString()}");
        }
    }
}
