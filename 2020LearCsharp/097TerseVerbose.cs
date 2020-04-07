#define TERSE
//#define VERBOSE

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace _2020LearCsharp
{
    public class _097TerseVerbose
    {
        [Conditional("VERBOSE"), Conditional("TERSE")]
        static void ReportHeader()
        {
            Console.WriteLine("This is the header report.");
            VerboseReport();
        }

        [Conditional("VERBOSE")]
        static void VerboseReport()
        {
            Console.WriteLine("This is the Verbose report.");
        }

        [Conditional("TERSE")]
        static void TerseReport()
        {
            Console.WriteLine("This is the Terse report.");
        }

        public static void executeTest()
        {
            ReportHeader();
            VerboseReport();
            TerseReport();
            Console.ReadKey();

        }
    }
}
