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
            this.FormClosed += ClosedHandler;
            this.saveWithDate = saveWithDate;
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            bool saved = this.SaveWithNames(this.saveWithDate, CheckBox_UseGeneratedName.Checked,this.dateFrom,this.dateTo,this.allEmails);
            if (saved)
            {
                mainWindow.Show();
                this.mainWindow.Enabled = true;
                this.Dispose();
            }
            else
            {
                Warning warning = new Warning(this, "Išsaugojimas nesėkmingas." + Environment.NewLine + "Gali būti kad failas į kurį norite išsaugoti atidarytas");
                warning.Show();
            }
        }
        private bool SaveWithNames(bool savingWithDate,bool saveWithDate,DateTime dateFrom, DateTime dateTo, List<string> allEmails)            //savingWithDate - in main window checked to save with date, saveWithDate - save with date in file name
        {
            string excelFileName = "some";
            if (saveWithDate) {
                excelFileName = DateTime.Now.Date.ToString("MM/dd/yyyy") + "-AdresųEksportas";
                if (savingWithDate) {
                    excelFileName = excelFileName +"-" + dateFrom.Date.ToString("MM/dd/yyyy") + "-" + dateTo.Date.ToString("MM/dd/yyyy");
                }
            }
            else 
            {
                excelFileName = TextBox_FileName.Text;
            }
            bool saved = ExcelFuncions.AddEmailsToFile(excelFileName, this.savingFolderName, allEmails);
            return saved;
        }

        private void Button_Reject_Click(object sender, EventArgs e)
        {
            mainWindow.Show();
            this.mainWindow.Enabled = true;
            this.Dispose();
        }
        protected void ClosedHandler(object sender, EventArgs e)
        {
            this.mainWindow.Show();
            this.mainWindow.Enabled = true;
        }

    }
}
