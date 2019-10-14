using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;

namespace EmailCheck
{
    static class ExcelFuncions
    {
        public static List<string> GetEmailsFromFile(string ExcelFileLocation)          //this function gets all email addresses from A1 to An cells from excel file
        {
            List<string> emails = new List<string>();
            Console.WriteLine(ExcelFileLocation);
            FileInfo excelFile = new FileInfo(ExcelFileLocation);
            ExcelPackage pck = new ExcelPackage(excelFile);
            var ws = pck.Workbook.Worksheets[1];
            ws.View.ShowGridLines = false;
            int counter = 1;
            while (ws.Cells[counter,1].Text!="")
            {
                string value = ws.Cells[counter,1].Value.ToString();
                emails.Add(value);
                counter++;
            }
            foreach (string email in emails)
            {
                Console.WriteLine(email + "gg");
            }
            return emails;
        }
        public static void AddEmailsToFile(string fileName, string savingFolderName, List<string> emails)
        {
            using (ExcelPackage excel = new ExcelPackage())
            {
                string excelFilePath = savingFolderName + @"\" + fileName + ".xlsx";
                FileInfo excelFile = new FileInfo(excelFilePath);
                ExcelPackage pck = excel;
                var ws = excel.Workbook.Worksheets.Add("El. paštų sąrašas");
                excel.SaveAs(excelFile);
                ws.View.ShowGridLines = false;
                var sheetCells = ws.Cells["A1:A" + emails.Count];
                sheetCells.LoadFromCollection(emails);
                excel.SaveAs(excelFile);
            }
        }

    }
}
