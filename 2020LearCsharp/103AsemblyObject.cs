using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace _2020LearCsharp
{
    public class _103AsemblyObject
    {
        public static void executeTest()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Console.WriteLine($"Full name {assembly.FullName}");
            AssemblyName name = assembly.GetName();
            Console.WriteLine($"Major version { name.Version.Major }");
            Console.WriteLine($"Major version { name.Version.Minor }");
            Console.WriteLine($"In global assembly cache {assembly.GlobalAssemblyCache}");

            foreach (Module module in assembly.Modules)
            {
                Console.WriteLine($"------------Module {module.Name}--------------");
                foreach (Type moduleType in module.GetTypes())
                {
                    Console.WriteLine($"----------ModuleType: {moduleType.Name}---------------");
                    foreach (MemberInfo member in moduleType.GetMembers())
                    {
                        Console.WriteLine($"-----------------Member {member.Name}-----------------");
                    }
                }
                Console.WriteLine("---------------------------------------------");
            }
            Console.ReadKey();
        }
    }
}
