using EmailCheck.HelperClasses;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace EmailCheck
{
    static class ExcelFuncions
    {
        public static List<string> GetEmailsFromFile(string ExcelFileLocation)          //this function gets all email addresses from A1 to An cells from excel file
        {
            List<string> emails = new List<string>();
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
            return emails;
        }
        public static bool AddEmailsToFile(string fileName, string savingFolderName, List<string> emails)
        {
            using (ExcelPackage excel = new ExcelPackage())
            {
                try
                {
                    string excelFilePath = savingFolderName + @"\" + fileName + ".xlsx";
                    for(int i=0;i<emails.Count;i++)
                    {
                        emails[i] = EmailStringFormater.deleteCC(emails[i]);
                        emails[i] = EmailStringFormater.deleteContentType(emails[i]);
                    }
                    FileInfo excelFile = new FileInfo(excelFilePath);
                    ExcelPackage pck = excel;
                    var ws = excel.Workbook.Worksheets.Add("El. paštų sąrašas");
                    excel.SaveAs(excelFile);
                    ws.View.ShowGridLines = false;
                    var sheetCells = ws.Cells["A1:A" + emails.Count];
                    sheetCells.LoadFromCollection(emails);
                    excel.SaveAs(excelFile);
                    return true;
                }
                catch (InvalidOperationException e)
                {
                    return false;
                }
            }
        }

    }
}
