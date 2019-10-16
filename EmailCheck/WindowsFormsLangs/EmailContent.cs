using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmailCheck
{
    public partial class EmailContent : Form
    {
        MainWindow mainWindow;
        string workingDirectory = Environment.CurrentDirectory;
        public EmailContent(MainWindow mainWindow, Mail mail)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
            this.FormClosed += ClosedHandler;
            if (mail.GetBody() == "" || mail.GetSubject() == "")
            {
                string fileDirectory = Directory.GetParent(this.workingDirectory).Parent.FullName + @"\ConfidentialInformation\MessageContent.txt";
                mail = this.ReadMailFromFile(fileDirectory);
            }
            TextBox_Subject.Text = mail.GetSubject();
            TextBox_Body.Text = mail.GetBody();
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            string fileDirectory = Directory.GetParent(this.workingDirectory).Parent.FullName + @"\ConfidentialInformation\MessageContent.txt";
            File.WriteAllText(fileDirectory, "subj: \n" + TextBox_Subject.Text + "\n body:#$%&&*(* \n" + TextBox_Body.Text);
            this.mainWindow.mail.SetSubject(TextBox_Subject.Text);
            this.mainWindow.mail.SetBody(TextBox_Body.Text);
            mainWindow.Show();
            this.Dispose();
        }

        private void ButtonReject_Click(object sender, EventArgs e)
        {
            mainWindow.Show();
            this.Dispose();
        }
        private Mail ReadMailFromFile(string fileDirectory)
        {
            Mail mail = new Mail("", "");
            string mailContent = File.ReadAllText(fileDirectory);
            List<string> mailContentSeparated = mailContent.Split(' ').ToList();
            bool writeToBody = false;
            for (int i = 1; i < mailContentSeparated.Count; i++)
            {
                if (mailContentSeparated[i].Contains("body:#$%&&*(*"))
                {
                    writeToBody = true;
                }
                else if (writeToBody)
                {
                    mail.SetBody(mail.GetBody() + mailContentSeparated[i]);
                }
                else
                {
                    mail.SetSubject(mail.GetSubject() + mailContentSeparated[i]);
                }
            }
            return mail;
        }
        protected void ClosedHandler(object sender, EventArgs e)
        {
            this.mainWindow.Show();
        }
    }
}
