using System;
using System.Collections.Generic;
using System.Text;

namespace _2020LearCsharp
{
   public class _069TryCatch
    {
        public static void executeTest()
        {
            try
            {
                Console.WriteLine("Write an intiger: ");
                string numberText = Console.ReadLine();
                int result;
                result = int.Parse(numberText);
                Console.WriteLine($"you entered {result} ");

            }
            catch (Exception e)
            {
                Console.WriteLine($"Message: {e.Message}");
                Console.WriteLine($"StackTrace: {e.StackTrace}");
                Console.WriteLine($"HelpLink: {e.HelpLink}");
                Console.WriteLine($"TargetSite: {e.TargetSite}");
                Console.WriteLine($"Source: {e.Source}");

            }
        }
    }
}
