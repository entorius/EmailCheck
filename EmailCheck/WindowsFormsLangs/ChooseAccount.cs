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
    public partial class ChooseAccount : Form
    {
        public MainWindow mainWindow;
        public ChooseAccount(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
            this.FormClosed += ClosedHandler;
            foreach(User user in mainWindow.allUsers)
            {
                ListBox_Accounts.Items.Add(user.GetEmail());
            }

        }

        private void AddAccount_Button_Click(object sender, EventArgs e)
        {
            AddAccount addAccount = new AddAccount(this);
            addAccount.Show();
            
        }

        private void Button_ChooseAccount_Click(object sender, EventArgs e)
        {
            if (ListBox_Accounts.SelectedItem == null)
            {
                Warning warning = new Warning(this,"Jūs nepasirinkote vartotojo");
                warning.Show();
            }
            else
            {
                string selectedEmail = ListBox_Accounts.SelectedItem.ToString();
                User user = mainWindow.allUsers.Find(x => x.GetEmail() == selectedEmail);
                mainWindow.currentUser = user;
                this.mainWindow.email_Name_Box.Text = "Current account: " + mainWindow.currentUser.GetEmail();
                this.mainWindow.Enabled = true;
                this.Dispose();
            }
        }

        private void ListBox_Accounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddAccount_Button.Enabled = true;
        }
        protected void ClosedHandler(object sender, EventArgs e)
        {
            this.mainWindow.Enabled = true;
        }
    }
}
