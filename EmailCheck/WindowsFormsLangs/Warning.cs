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
        public Warning(string warningMessage)
        {
            InitializeComponent();
            this.TextBox_Warning.Text = warningMessage;
        }

        private void Button_OK_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
