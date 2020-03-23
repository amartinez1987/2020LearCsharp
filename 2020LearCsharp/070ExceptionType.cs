using System;
using System.Collections.Generic;
using System.Text;

namespace _2020LearCsharp
{
   public  class _070ExceptionType
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
                int sum = 1 / result;
                Console.WriteLine($"Sum is {sum}");

            }
            catch (NotFiniteNumberException ex)
            {
                Console.WriteLine($"Invalid Number");             

            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Divide by Zero");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unpectec exception");

            }
            Console.ReadKey();
        }
    }
}
