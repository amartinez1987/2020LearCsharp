using System;
using System.Collections.Generic;
using System.Text;

namespace _2020LearCsharp
{
    public class _084Overriding
    {
        class Document
        {
            public void getDate()
            {
                Console.WriteLine("Hello from GetDate in Document.");
            }

            public virtual void DoPrint()
            {
                Console.WriteLine("Hello from DoPrint in Document.");
            }
        }

        class invoice : Document
        {
            public override void DoPrint()
            {
                Console.WriteLine("Hello from DoPrint in Invoice.");
            }

        }

        class PrePaidInvoice : invoice
        {
            public override void DoPrint()
            {
                base.DoPrint();
                Console.WriteLine("Hello from DoPrint in PrePaidInvoice.");
            }
        }

        public static void executeTest()
        {
            invoice c = new invoice();
            c.getDate();
            c.DoPrint();
            Console.ReadKey();
            PrePaidInvoice p = new PrePaidInvoice();
            p.getDate();
            p.DoPrint();
            Console.ReadKey();
        }
    }
}
