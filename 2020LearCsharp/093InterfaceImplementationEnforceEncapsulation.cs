using System;
using System.Collections.Generic;
using System.Text;

namespace _2020LearCsharp
{
    public class _093InterfaceImplementationEnforceEncapsulation
    {
        class Report : Iprintable
        {
            string Iprintable.GetPrintableText(int pageWidth, int pageHeight)
            {
                return "Report Texto to be Print.";
            }

            string Iprintable.GetTitle()
            {
                return "Report Title.";
            }
        }


        interface Iprintable
        {
          string  GetPrintableText(int pageWidth, int pageHeight);

            string GetTitle();
        }
    }

}
