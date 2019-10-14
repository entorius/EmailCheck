using EmailCheck.HelperClasses;
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
            Button_AddAccount.Enabled = false;
        }

        private async void Button_AddAccount_Click(object sender, EventArgs e)
        {
            bool exceptionThrown = false;
            try
            {
                List<MimeKit.MimeMessage> smtp = await CheckEmail.FetchAllMailbotMessages(this.TextBox_Email.Text, this.TextBox_Password.Text);
            }
            catch (Exception excep)
            {
                Warning warning = new Warning("Ivedėte neteisingą el. paštą arba slaptažodį");
                warning.Show();
                RichTextBox_Error.Text = "Ivedėte neteisingą el. paštą arba slaptažodį";
                exceptionThrown = true;
            }
            Console.WriteLine(exceptionThrown);
            if (!exceptionThrown)
            {
                String email = StringCipher.Encrypt(this.TextBox_Email.Text, "125847elpu68795");
                String password = StringCipher.Encrypt(this.TextBox_Password.Text, "125847elpu62195");
                string fileDirectory = Directory.GetParent(this.workingDirectory).Parent.FullName + @"\ConfidentialInformation\UsersEmailCredentials.txt";
                File.WriteAllText(fileDirectory, File.ReadAllText(fileDirectory) + email + " \n " + password + " ");
                chooseAccountWindow.mainWindow.allUsers.Add(new User(this.TextBox_Email.Text, this.TextBox_Password.Text));
                chooseAccountWindow.ListBox_Accounts.Items.Add(this.TextBox_Email.Text);
                this.Dispose();
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
    }
}
