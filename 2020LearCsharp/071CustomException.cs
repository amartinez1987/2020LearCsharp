using System;
using System.Collections.Generic;
using System.Text;

namespace _2020LearCsharp
{
    public class _071CustomException
    {
        class calException : Exception
        {
            public enum calErrorCodes
            {
                InvalidNumberText,
                DivideByZero
            }

            public calErrorCodes Error { set; get; }

            public calException(string message, calErrorCodes error):base(message)
            {
                Error = error;
            }
        }

        public static void executeTest()
        {
            try
            {
                throw new calException("Cal Failed", calException.calErrorCodes.InvalidNumberText);
            }
            catch (calException ce)
            {
                Console.WriteLine(ce.Error);
            }
            Console.ReadKey();
        }
    }
}
