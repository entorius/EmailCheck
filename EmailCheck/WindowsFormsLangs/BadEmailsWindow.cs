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
    public partial class BadEmailsWindow : Form
    {
        MainWindow mainWindow;
        public BadEmailsWindow(MainWindow mainWindow, List<string> badEmails)
        {
            InitializeComponent();
            this.FormClosed += ClosedHandler;
            this.mainWindow = mainWindow;
            foreach (string email in badEmails) {
                RichTextBox_BadEmails.AppendText(email);
                RichTextBox_BadEmails.AppendText(Environment.NewLine);
            }
        }

        private void Button_OK_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.mainWindow.Enabled = true;
        }
        protected void ClosedHandler(object sender, EventArgs e)
        {
            this.mainWindow.Enabled = true;
        }
    }
}
