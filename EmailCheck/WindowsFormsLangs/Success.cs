﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmailCheck.WindowsFormsLangs
{
    public partial class Success : Form
    {
        public Success(string text)
        {
            InitializeComponent();
            Label_Success.Text = text;
        }

        private void Button_OK_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
