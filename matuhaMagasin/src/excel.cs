using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;

namespace matuhaMagasin
{
    internal class excel
    {
        public static void createExcelReport(List<report> report, string fileName)
        {
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            if (report != null)
            {
                Workbook wb = excelApp.Workbooks.Open(fileName,
                                                     0,
                                                     false,
                                                     5,
                                                     "",
                                                     "",
                                                     false,
                                                     XlPlatform.xlWindows,
                                                     "",
                                                     true,
                                                     false,
                                                     0,
                                                     true,
                                                     false,
                                                     false);
                Worksheet ws = wb.Sheets[1];
                ws.Cells[1][1] = "Поставщик";
                ws.Cells[2][1] = "Продукт";
                ws.Cells[3][1] = "Сумма заказа";
                ws.Cells[4][1] = "Оплаченная сумма";
                ws.Cells[5][1] = "Долг";
                for (int i = 0; i < report.Count; i++)
                {
                    ws.Cells[1][i + 2] = report[i].supplierName;
                    ws.Cells[2][i + 2] = report[i].productName;
                    ws.Cells[3][i + 2] = report[i].orderPrice;
                    ws.Cells[4][i + 2] = report[i].paidSum;
                    ws.Cells[5][i + 2] = report[i].debt;
                }

                wb.Save();
                wb.Close();
            }
        }
    }
}
