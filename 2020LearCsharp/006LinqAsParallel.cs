using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2020LearCsharp
{
    public class _006LinqAsParallel
    {
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

            var result = from person in people.AsParallel().
                         WithDegreeOfParallelism(4).
                         WithExecutionMode(ParallelExecutionMode.ForceParallelism)
                         where person.City == "Seattle"
                         select person;

            foreach (var person in result)
                Console.WriteLine(person.Name);

            Console.WriteLine("Finished processing. Press a key to end.");
            Console.ReadKey();

        }


    }
}
