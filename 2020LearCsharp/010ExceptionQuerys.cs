using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2020LearCsharp
{
    class _010ExceptionQuerys
    {

        public static bool CheckCity(string name)
        {
            if (string.IsNullOrEmpty( name) )
                throw new ArgumentException(name);
            return name == "Seattle";
        }

        class Person
        {
            public string Name { get; set; }
            public string City { get; set; }

        }

        public static void ExecuteTest()
        {
            Person[] people = new Person[]
            {
                new Person { Name = "Alan", City = "Hull" },
                new Person { Name = "Beryl", City = "Seattle" },
                new Person { Name = "Charles", City = "London" },
                new Person { Name = "David", City = "Seattle" },
                new Person { Name = "Eddy", City = "Paris" },
                new Person { Name = "Fred", City = "Berlin" },                
                new Person { Name = "Gordon", City = "Hull" },
                new Person { Name = "Henry", City = "Seattle" },
                new Person { Name = "Isaac", City = "Seattle" },
                new Person { Name = "James", City = "London" }
            };

            var result = from person in people.AsParallel()
                         where CheckCity(person.City)
                         select person;

            result.ForAll(person => Console.WriteLine(person.Name));


            Console.WriteLine("Finished processing. Press a key to end.");
            Console.ReadKey();

        }
    }
}
