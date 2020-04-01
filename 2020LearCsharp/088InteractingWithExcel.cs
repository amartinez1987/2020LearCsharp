using System;
using System.Collections.Generic;
using System.Text;

namespace _2020LearCsharp
{
    public class _088InteractingWithExcel
    {
        public static void executeTest()
        {
            var excelApp = new Microsoft.Office.Interop.Excel.Application();
            excelApp.Visible = true;
            excelApp.Workbooks.Add();
            Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)excelApp.ActiveSheet;
            worksheet.Cells[1, "A"] = "HELLO";
            worksheet.Cells[1, "B"] = "from C#";
        }
    }
}
