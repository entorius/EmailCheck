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
    public partial class Warning : Form
    {
        Form form;
        public Warning(Form form,string warningMessage)
        {
            InitializeComponent();
            this.TextBox_Warning.Text = warningMessage;
            this.FormClosed += ClosedHandler;
            this.form = form;
            this.form.Enabled = false;
        }

        private void Button_OK_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.form.Enabled = true;
        }
        protected void ClosedHandler(object sender, EventArgs e)
        {
            this.form.Enabled = true;
        }
    }
}
