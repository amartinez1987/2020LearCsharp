using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace _2020LearCsharp
{
    public class _098AtributeClass
    {
        class ProgrammerAttribute : Attribute
        {
            private string ProgrammerValue;

            public ProgrammerAttribute(string programmer)
            {
                ProgrammerValue = programmer;
            }

            public string Programmer { get { return ProgrammerValue; } }
        }

        [ProgrammerAttribute(programmer: "Anibal Guillermo Martinez Aguas")]
        class Person
        {
            public string Name { get; set; }
        }

        public static void executeTest()
        {
            Attribute a = Attribute.GetCustomAttribute(typeof(Person), typeof(ProgrammerAttribute));

            ProgrammerAttribute p = (ProgrammerAttribute)a;
            Console.WriteLine($"Val variable p {p.Programmer}");
            Console.ReadKey();

            Person pe = new Person();
            Type type = pe.GetType();
            foreach (MemberInfo member in type.GetMembers())
            {
                Console.WriteLine($"Members: {member.ToString()}");
            }
            Console.WriteLine();

            //calling methos
            MethodInfo sm = type.GetMethod("set_Name");
            sm.Invoke(pe,new object []{"Fred"});
            Console.WriteLine(pe.Name);
            Console.ReadKey();

        }
    }
}


