using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace _2020LearCsharp
{
    public class _104PropertyInfo
    {
        class Person
        {
            public string Name { get; set; }
            public string Age { get; }
        }

        public static void executeTest()
        {
            Type type = typeof(Person);
            foreach (PropertyInfo p in type.GetProperties())
            {
                Console.WriteLine($"Property Name {p.Name} ");

                if (p.CanRead)
                {
                    Console.WriteLine("Can Read");
                    Console.WriteLine($"Set Method {p.GetMethod}");
                }
                if (p.CanWrite)
                {
                    Console.WriteLine("Can Write");
                    Console.WriteLine($"Set Method {p.GetMethod}");
                }
            }

            Console.WriteLine("");
            Console.ReadKey();
        }

    }
}
