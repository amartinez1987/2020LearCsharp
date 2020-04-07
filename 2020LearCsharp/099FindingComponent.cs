using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using static _2020LearCsharp._094IComparable;

namespace _2020LearCsharp
{
    public class _099FindingComponent
    {
        public static void executeTest()
        {
            Assembly thisAssembly = Assembly.GetExecutingAssembly();

            List<Type> AccountyTypes = new List<Type>();

            foreach (Type t in thisAssembly.GetTypes())
            {
                if (t.IsInterface)
                    continue;
                if (typeof(IAccount).IsAssignableFrom(t))
                {
                    AccountyTypes.Add(t);
                }
            }

        }
    }
}
