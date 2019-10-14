using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmailCheck
{
    public partial class EmailsSaveWindow : Form
    {
        string savingFolderName;
        List<string> allEmails;                                               //Currently choosen user
        DateTime dateFrom;
        DateTime dateTo;
        MainWindow mainWindow;
        bool saveWithDate;
        public EmailsSaveWindow(MainWindow mainWindow, bool saveWithDate,string savingFolderName,List<string> allEmails, DateTime dateFrom, DateTime dateTo)
        {
            InitializeComponent();
            this.allEmails = allEmails;
            this.savingFolderName = savingFolderName;
            this.dateFrom = dateFrom;
            this.dateTo = dateTo;
            this.mainWindow = mainWindow;
            this.saveWithDate = saveWithDate;
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            this.SaveWithNames(this.saveWithDate,this.dateFrom,this.dateTo,this.allEmails);
        }
        private void SaveWithNames(bool saveWithDate,DateTime dateFrom, DateTime dateTo, List<string> allEmails)
        {
            string excelFileName = "some";
            if (CheckBox_UseGeneratedName.Checked) {
                excelFileName = DateTime.Now.Date.ToString("MM/dd/yyyy") + "-AdresųEksportas";
                if (saveWithDate) {
                    excelFileName = excelFileName +"-" + dateFrom.Date.ToString("MM/dd/yyyy") + "-" + dateTo.Date.ToString("MM/dd/yyyy");
                }
            }
            else 
            {
                excelFileName = TextBox_FileName.Text;
            }
            Console.WriteLine(allEmails[1] + "es");
            ExcelFuncions.AddEmailsToFile(excelFileName, this.savingFolderName, allEmails);
            mainWindow.Show();
            this.Dispose();

        }

        private void Button_Reject_Click(object sender, EventArgs e)
        {
            mainWindow.Show();
            this.Dispose();
        }

        
    }
}
