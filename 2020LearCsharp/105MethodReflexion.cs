using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace _2020LearCsharp
{
    public class _105MethodReflexion
    {
        class Calculator
        {
            public int AddInt(int v1, int v2)
            {
                return v1 + v2;
            }

          

        }

        public static void executeTest()
        {
            Console.WriteLine("Get type information for the calculator class.");
            Type type = typeof(Calculator);

            Console.WriteLine("Get the method info for the AddInt Method");
            MethodInfo AddMethodInfo = type.GetMethod("AddInt");

            Console.WriteLine("Get the IL instruccion for the AddInt Method");
            MethodBody AddIntMethodBody = AddMethodInfo.GetMethodBody();

            Console.WriteLine("Print IL Instructions");
            foreach (byte b in AddIntMethodBody.GetILAsByteArray())
            {
                Console.WriteLine($"{b:X}");
            }

            Console.WriteLine();

            Console.WriteLine("Create Calculator Instance");
            Calculator cal = new Calculator();

            Console.WriteLine("Create paramether array for the method");
            object[] inputs = new object[] { 1, 2 };

            Console.WriteLine("Call invoke on the method info");
            Console.WriteLine("Cast the to and integer");
            int result = (int)AddMethodInfo.Invoke(cal, inputs);
            Console.WriteLine($"Result {result}");

            Console.WriteLine("Call invoke member on the type ");
            result = (int)type.InvokeMember("AddInt", BindingFlags.InvokeMethod | BindingFlags.Instance | BindingFlags.Public, null, cal, inputs);
            Console.WriteLine($"Result {result}");
            Console.ReadKey();



        }
    }
}
