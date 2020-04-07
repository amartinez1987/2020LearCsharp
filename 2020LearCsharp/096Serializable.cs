using System;
using System.Collections.Generic;
using System.Text;

namespace _2020LearCsharp
{
    public class _096Serializable
    {
        [Serializable]
        class Person
        {
            public string Name;
            public int Age;
            [NonSerialized]
            public int screenPosition;

            public Person(string name, int age)
            {
                Name = name;
                Age = age;
                screenPosition = 0;
            }
        }
    }
}
