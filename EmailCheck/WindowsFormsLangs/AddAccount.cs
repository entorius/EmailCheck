using EmailCheck.HelperClasses;
using MailKit.Net.Imap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmailCheck
{
    public partial class AddAccount : Form
    {
        private ChooseAccount chooseAccountWindow;
        string workingDirectory = Environment.CurrentDirectory;
        public AddAccount(ChooseAccount chooseAccountWindow)
        {
            InitializeComponent();
            this.chooseAccountWindow = chooseAccountWindow;
            chooseAccountWindow.Enabled = false;
            this.FormClosed += ClosedHandler;
            Button_AddAccount.Enabled = false;
            
        }

        private async void Button_AddAccount_Click(object sender, EventArgs e)
        {
            RichTextBox_Error.Text = "";
            bool exceptionThrown = false;
            bool emailExists = false;
            foreach (User user in chooseAccountWindow.mainWindow.allUsers)
            {
                if (Regex.Replace(user.GetEmail(), @"\s+", "").Equals(Regex.Replace(this.TextBox_Email.Text, @"\s+", ""))) {
                    emailExists = true;
                }
            }
            if (!emailExists)
            {
                    ImapClient x = await CheckEmail.Login(this.TextBox_Email.Text, this.TextBox_Password.Text);

                if (x == null)
                {
                    Warning warning = new Warning(this, "Nesėkmingas prisijugimas kuri galėjo įvykti dėl:" + Environment.NewLine 
                        + "1.Ivedėte neteisingą el. paštą arba slaptažodį" + Environment.NewLine 
                        + "2.Nepavyko prisijungti prie google serverio" + Environment.NewLine + "3.Blogas interneto ryšys");
                    warning.Show();
                    RichTextBox_Error.Text = "Ivedėte neteisingą el. paštą arba slaptažodį";
                    exceptionThrown = true;
                }
                if (!exceptionThrown)
                {
                    String email = StringCipher.Encrypt(this.TextBox_Email.Text, "125847elpu68795");
                    String password = StringCipher.Encrypt(this.TextBox_Password.Text, "125847elpu62195");
                    string fileDirectory = Directory.GetParent(this.workingDirectory).Parent.FullName + @"\ConfidentialInformation\UsersEmailCredentials.txt";
                    File.WriteAllText(fileDirectory, File.ReadAllText(fileDirectory) + email + " \n " + password + " ");
                    chooseAccountWindow.mainWindow.allUsers.Add(new User(this.TextBox_Email.Text, this.TextBox_Password.Text));
                    chooseAccountWindow.ListBox_Accounts.Items.Add(this.TextBox_Email.Text);
                    chooseAccountWindow.Enabled = true;
                    this.Dispose();
                }
            }
            else
            {
                Warning warning = new Warning(this,"Įrašytas el.paštas jau egzistuoja");
                warning.Show();
            }
        }

        private void TextBox_Email_TextChanged(object sender, EventArgs e)
        {
            Button_AddAccount.Enabled = TextBox_Email.Text.Length == 0 || TextBox_Password.Text.Length == 0 ? false: true;
        }

        private void TextBox_Password_TextChanged(object sender, EventArgs e)
        {
            Button_AddAccount.Enabled = TextBox_Email.Text.Length == 0 || TextBox_Password.Text.Length == 0 ? false : true;
        }
        protected void ClosedHandler(object sender, EventArgs e)
        {
            chooseAccountWindow.Enabled = true;
        }

    }
}
