using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace _2020LearCsharp
{
   public  class _046ConcurrentDictionary
    {
        public static void executeTest()
        {

            ConcurrentDictionary<string,int> ages = new ConcurrentDictionary<string,int>();
            if (ages.TryAdd("Rob", 21))
                Console.WriteLine("Rob add success");
            Console.WriteLine(ages["Rob"]);
            if (ages.TryUpdate("Rob",21,22))
                Console.WriteLine("Rob update success");
            Console.WriteLine(ages["Rob"]);
            // Increment Rob's age atomically using factory method
            Console.WriteLine("Rob's age updated to: {0}",
                ages.AddOrUpdate("Rob", 1, (name, age) => age = age + 1));
            Console.WriteLine("Rob's new age: {0}", ages["Rob"]);

            
            Console.ReadKey();

        }
    }
}
