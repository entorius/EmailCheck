﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Linq;
using MimeKit;
using EmailCheck.HelperClasses;
using System.Net.Mail;
using EmailCheck.WindowsFormsLangs;

namespace EmailCheck
{
    public partial class MainWindow : Form
    {
        public CheckEmail mailRepository;
        public User currentUser;
        public List<User> allUsers = new List<User>();
        public Mail mail = new Mail("", "");
        public List<string> emailsToSend = new List<string>();
        public bool datePickerEnabled = false;
        string workingDirectory = Environment.CurrentDirectory;
        BadEmailsWindow badEmailsWindow;
        private List<string> badEmailList = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
            this.email_Name_Box.Text = "Dabartinė paskyra:";

            string fileDirectory = Directory.GetParent(this.workingDirectory).Parent.FullName + @"\ConfidentialInformation\UsersEmailCredentials.txt";
            string allAccountsInformation = File.ReadAllText(fileDirectory);
            this.OpenFileDialog_ExportAddressList.Disposed += ClosedHandler;
            if (allAccountsInformation != "")
            {
                List<string> allEmailsInformation = allAccountsInformation.Split(' ').ToList();
                foreach (string email in allEmailsInformation)
                {
                }
                for (int i = 0; i < allEmailsInformation.Count; i = i + 3)
                {
                    if (allEmailsInformation[i] != "")
                    {
                        string email = StringCipher.Decrypt(allEmailsInformation[i], "125847elpu68795");
                        string password = StringCipher.Decrypt(allEmailsInformation[i + 2], "125847elpu62195");
                        allUsers.Add(new User(email, password));
                    }
                }
            }
            DateTimePicker_DateTo.Enabled = datePickerEnabled;
            DateTimePicker_DateFrom.Enabled = datePickerEnabled;
        }

        private void Button_AddAccount_Click(object sender, EventArgs e)
        {
            ChooseAccount chooseAccount = new ChooseAccount(this);
            this.Enabled = false;
            chooseAccount.Show();
        }

        private async void Button_ExportAddressList_Click(object sender, EventArgs e)
        {
            bool correctDate = true;
            Warning DateWarning = new Warning(this,"Neteisinga data");
            if (this.CheckBox_UseDates.Checked)
            {
                if (this.DateTimePicker_DateFrom.Value > this.DateTimePicker_DateTo.Value)
                {
                    if (this.DateTimePicker_DateFrom.Value.Date != this.DateTimePicker_DateTo.Value.Date)
                    {
                        DateWarning = new Warning(this, "Data nuo yra didesnė nei data iki");
                        correctDate = false;
                    }
                }
                else if (DateTime.Now < this.DateTimePicker_DateTo.Value.Date)
                {
                    DateWarning = new Warning(this,"Data iki pasirinkta ateityje");
                    correctDate = false;
                }
                else if (DateTime.Now < this.DateTimePicker_DateFrom.Value.Date)
                {
                    DateWarning = new Warning(this,"Data nuo pasirinkta ateityje");
                    correctDate = false;
                }
            }
            if (!correctDate)
            {
                DateWarning.Show();
            }
            else if (currentUser != null)
            {
                this.Hide();
                string strfoldername = "C://";
                string workingDirectory = Environment.CurrentDirectory;
                string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
                string filePathSavingPath = projectDirectory + @"\PathToAddressList.txt";     //vieta kur bus saugomas pathas į Adresų lista
                string pathToFile = File.ReadAllText(filePathSavingPath);
                int lastIndex = pathToFile.LastIndexOf(@"\");
                pathToFile = pathToFile.Remove(lastIndex);

                if (pathToFile != "")
                {
                    FolderBrowserDialog_DefaultExcelSavingPath.SelectedPath = pathToFile;
                    OpenFileDialog_ExportAddressList.FileName = "";
                }
                else
                {
                    OpenFileDialog_ExportAddressList.InitialDirectory = projectDirectory;
                    OpenFileDialog_ExportAddressList.FileName = "";
                }
                DialogResult result = FolderBrowserDialog_DefaultExcelSavingPath.ShowDialog(this);

                if (result == DialogResult.OK)
                {
                    List<MimeMessage> allEmails = datePickerEnabled ?
                    await CheckEmail.FetchAllMailbotMessages(currentUser.GetEmail(), currentUser.GetPassword(), DateTimePicker_DateFrom.Value, DateTimePicker_DateTo.Value) :
                    await CheckEmail.FetchAllMailbotMessages(currentUser.GetEmail(), currentUser.GetPassword());
                    if (allEmails != null)
                    {
                        strfoldername = FolderBrowserDialog_DefaultExcelSavingPath.SelectedPath;

                        emailsToSend = CheckEmail.CollectToEmailsFromMessages(allEmails.ConvertAll(x => x.Body.ToString()));
                        var emailsToSengGrouped = emailsToSend.GroupBy(u => u).Select(grp => new { Text = grp.Key, Count = grp.Count() }).ToList();
                        emailsToSend = new List<string>();
                        foreach (var email in emailsToSengGrouped)
                        {
                            emailsToSend.Add(email.Text);
                        }
                        File.WriteAllText(filePathSavingPath, strfoldername);
                        EmailsSaveWindow saveWindow = new EmailsSaveWindow(this, datePickerEnabled, strfoldername, emailsToSend, DateTimePicker_DateFrom.Value, DateTimePicker_DateTo.Value);
                        saveWindow.Show();
                    }
                    else
                    {
                        this.Show();
                        Warning warning = new Warning(this, "Nesėkmingas išsaugojimas kuris galėjo įvykti dėl:" + Environment.NewLine
                        + "1.Nepavyko prisijungti prie google serverio" + Environment.NewLine + "2.Blogas interneto ryšys");
                    }
                }
                else
                {
                    this.Show();
                    this.Enabled = true;
                }
            }
            else
            {
                Warning warningWindow = new Warning(this,"Jūs nepasirinkote vartotojo");
                warningWindow.Show();
            }
        }
        private void Button_Send_Click(object sender, EventArgs e)
        {
            if (currentUser != null)
            {
                bool fromExcel = false;
                Regex rgx = new Regex(@"^\s+$");
                List<string> allEmailsList = new List<string>();
                List<string> goodEmailList = new List<string>();
                this.Enabled = false;
                badEmailList = new List<string>();

                OpenFileDialog_ExportAddressList.Disposed += MainWindowEnableHandler;
                if (rgx.IsMatch(TextBox_Emails.Text) || TextBox_Emails.Text == "")
                {
                    OpenFileDialog_ExportAddressList.Filter = "Excel Files|*.xlsx;*.xlsm;*.xlsb;*.xltx;*.xltm;*.xls;*.xlt;*.xls;*.xml;*.xml;*.xlam;*.xla;*.xlw;*.xlr;";
                    DialogResult result = OpenFileDialog_ExportAddressList.ShowDialog(this);
                    if (result == DialogResult.OK)
                    {
                        allEmailsList = ExcelFuncions.GetEmailsFromFile(OpenFileDialog_ExportAddressList.FileName);
                    }
                    if(result == DialogResult.Cancel || result == DialogResult.Abort)
                    {
                        OpenFileDialog_ExportAddressList.Dispose();
                    }
                    
                    fromExcel = true;
                }
                else
                {
                    string allEmailsString = TextBox_Emails.Text;
                    allEmailsList = allEmailsString.Split('\n').ToList();
                }


                for (int i = 0; i < allEmailsList.Count; i++)
                {
                    string newEmail = allEmailsList[i];
                    if (allEmailsList.Count - 1 != i && !fromExcel)
                    {
                        newEmail = newEmail.Remove(newEmail.Count() - 1);
                    }
                    try
                    {
                        if (newEmail != null && newEmail != "" && !newEmail.Contains(Environment.NewLine))
                        {
                            MailAddress m = new MailAddress(newEmail);
                            goodEmailList.Add(newEmail);
                        }
                    }
                    catch (FormatException)
                    {
                        this.badEmailList.Add(newEmail);
                    }
                }
                SendEmail sendEmail = new SendEmail(currentUser.GetEmail(), currentUser.GetPassword());
                List<string> emails = goodEmailList;
                sendEmail.SendEmails(emails, mail.GetSubject(), mail.GetBody());
                Success successWindow;
                if (goodEmailList.Count > 0)
                {
                    successWindow = new Success("Laiškai išsiųsti sėkmingai!");
                    successWindow.Show();
                    if (badEmailList.Count > 0)
                    {
                        successWindow.Disposed += SuccessClosedBadEmailsHandler;
                    }
                    else
                    {
                        successWindow.Disposed += MainWindowEnableHandler;
                    }
                }
                else if (badEmailList.Count > 0)
                {
                    BadEmailsWindow badEmailsWindow = new BadEmailsWindow(this, badEmailList);
                    badEmailsWindow.Show();
                }
            }
            else
            {
                Warning warningWindow = new Warning(this,"Jūs nepasirinkote vartotojo");
                warningWindow.Show();
            }
        }

        private void Button_EmailText_Click(object sender, EventArgs e)
        {
            EmailContent emailContent = new EmailContent(this, mail);
            this.Hide();
            emailContent.Show();
        }

        private void CheckBox_UseDates_CheckedChanged(object sender, EventArgs e)
        {
            datePickerEnabled = datePickerEnabled == true ? false : true;
            DateTimePicker_DateTo.Enabled = datePickerEnabled;
            DateTimePicker_DateFrom.Enabled = datePickerEnabled;
        }
        protected void ClosedHandler(object sender, EventArgs e)
        {
            this.Show();
        }
        protected void SuccessClosedBadEmailsHandler(object sender, EventArgs e)
        {
            this.badEmailsWindow = new BadEmailsWindow(this, badEmailList);
            this.badEmailsWindow.Show();
        }
        protected void MainWindowEnableHandler(object sender, EventArgs e)
        {
            this.Enabled = true;
        }

    }
}
