using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Linq;
using MimeKit;
using EmailCheck.HelperClasses;
using System.Net.Mail;

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
        public MainWindow()
        {
            InitializeComponent();
            this.email_Name_Box.Text = "Current account:";

            string fileDirectory = Directory.GetParent(this.workingDirectory).Parent.FullName + @"\ConfidentialInformation\UsersEmailCredentials.txt";
            string allAccountsInformation = File.ReadAllText(fileDirectory);
            Console.WriteLine("Totaloutside");
            if (allAccountsInformation != "")
            {
                List<string> allEmailsInformation = allAccountsInformation.Split(' ').ToList();
                foreach (string email in allEmailsInformation)
                {
                    Console.WriteLine("--------------" + email + "---------------\n");
                }
                Console.WriteLine("Almoustoutside");
                for (int i = 0; i < allEmailsInformation.Count; i = i + 3)
                {
                    Console.WriteLine("outside");
                    if (allEmailsInformation[i] != "")
                    {
                        Console.WriteLine("inside");
                        string email = StringCipher.Decrypt(allEmailsInformation[i], "125847elpu68795");
                        string password = StringCipher.Decrypt(allEmailsInformation[i + 2], "125847elpu62195");
                        allUsers.Add(new User(email, password));
                        Console.WriteLine(email);
                        Console.WriteLine(password);
                    }
                }
            }
            DateTimePicker_DateTo.Enabled = datePickerEnabled;
            DateTimePicker_DateFrom.Enabled = datePickerEnabled;
        }

        private void Button_AddAccount_Click(object sender, EventArgs e)
        {
            ChooseAccount chooseAccount = new ChooseAccount(this);

            chooseAccount.Show();
        }

        private async void Button_ExportAddressList_Click(object sender, EventArgs e)
        {
            if (currentUser != null)
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
                    strfoldername = FolderBrowserDialog_DefaultExcelSavingPath.SelectedPath;
                    emailsToSend = CheckEmail.CollectToEmailsFromMessages(allEmails.ConvertAll(x => x.Body.ToString()));
                    File.WriteAllText(filePathSavingPath, strfoldername);
                    EmailsSaveWindow saveWindow = new EmailsSaveWindow(this, datePickerEnabled, strfoldername, emailsToSend, DateTimePicker_DateFrom.Value, DateTimePicker_DateTo.Value);
                    saveWindow.Show();
                }
                else
                {
                    this.Show();
                }
            }
            else
            {
                Warning warningWindow = new Warning("Jūs nepasirinkote vartotojo");
                warningWindow.Show();
            }
        }
        private void Button_Send_Click(object sender, EventArgs e)
        {
            if (currentUser != null)
            {
                Regex rgx = new Regex(@"^\s+$");
                List<string> allEmailsList = new List<string>();
                List<string> goodEmailList = new List<string>();
                List<string> badEmailList = new List<string>();
                if (rgx.IsMatch(TextBox_Emails.Text) || TextBox_Emails.Text == "")
                {
                    OpenFileDialog_ExportAddressList.Filter = "Excel Files|*.xlsx;*.xlsm;*.xlsb;*.xltx;*.xltm;*.xls;*.xlt;*.xls;*.xml;*.xml;*.xlam;*.xla;*.xlw;*.xlr;";
                    DialogResult result = OpenFileDialog_ExportAddressList.ShowDialog(this);
                    if (result == DialogResult.OK)
                    {
                        allEmailsList = ExcelFuncions.GetEmailsFromFile(OpenFileDialog_ExportAddressList.FileName);
                    }
                }
                else
                {
                    string allEmailsString = TextBox_Emails.Text;
                    allEmailsList = allEmailsString.Split('\n').ToList();
                }
                
                
                foreach (string email in allEmailsList)
                {
                    Console.WriteLine(email.Last());
                    Console.WriteLine(email);
                    string newEmail = email.Remove(email.Count()-1);
                    //if (regex.IsMatch(email))
                    //{
                    //    goodEmailList.Add(email);
                    //}
                    //else
                    //{
                    //    badEmailList.Add(email);
                    //}
                    try
                    {

                        MailAddress m = new MailAddress(newEmail);

                        goodEmailList.Add(newEmail);
                    }
                    catch (FormatException)
                    {
                        badEmailList.Add(newEmail);
                    }
                }
                SendEmail sendEmail = new SendEmail(currentUser.GetEmail(), currentUser.GetPassword());
                List<string> emails = goodEmailList;
                sendEmail.SendEmails(emails, mail.GetSubject(), mail.GetBody());
                if (badEmailList.Count > 0)
                {
                    BadEmailsWindow badEmailsWindow = new BadEmailsWindow(this,badEmailList);
                    badEmailsWindow.Show();
                }
            }
            else
            {
                Warning warningWindow = new Warning("Jūs nepasirinkote vartotojo");
                warningWindow.Show();
            }
        }

        private async void Button_ShowInbox_Click(object sender, EventArgs e)
        {

            List<MimeKit.MimeMessage> messageList = await CheckEmail.FetchAllMailbotMessages(currentUser.GetEmail(), currentUser.GetPassword());
            foreach (MimeKit.MimeMessage message in messageList)
            {
                string messageBody = message.Body.ToString();
                string[] splitedBody = messageBody.Split(' ');
                List<string> selectedEmails = new List<string>();
                for (int i = 1; i < splitedBody.Length; i++)
                {
                    if (splitedBody[i - 1].Contains("To:"))
                    {
                        string selectedEmail = splitedBody[i];
                        selectedEmail = selectedEmail.Replace("\"", string.Empty);
                        selectedEmails.Add(selectedEmail);
                    }
                }
            }
            Console.WriteLine("something");
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
    }
}
