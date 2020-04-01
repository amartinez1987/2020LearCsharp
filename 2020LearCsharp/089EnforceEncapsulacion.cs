using System;
using System.Collections.Generic;
using System.Text;

namespace _2020LearCsharp
{
    public class _089EnforceEncapsulacion
    {
        class Customer
        {
            private string _nameValue;
            public string Name
            {
                get
                {
                    return _nameValue;
                }
                set
                {
                    if (string.IsNullOrEmpty(value))
                        throw new Exception("Invalid Customer Name");
                    _nameValue = value;
                }
            }
        }

        public static void executeTest()
        {
            Customer c = new Customer();
            c.Name = "Rob";
            Console.WriteLine($"Customer name {c.Name }");
            Console.ReadKey();
        }
    }
}
