namespace EmailCheck
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Button_AddAccount = new System.Windows.Forms.Button();
            this.email_Name_Box = new System.Windows.Forms.TextBox();
            this.TextBox_Emails = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Button_EmailText = new System.Windows.Forms.Button();
            this.Button_Send = new System.Windows.Forms.Button();
            this.DateTimePicker_DateFrom = new System.Windows.Forms.DateTimePicker();
            this.DateTimePicker_DateTo = new System.Windows.Forms.DateTimePicker();
            this.Label_DateFrom = new System.Windows.Forms.Label();
            this.Label_DateTo = new System.Windows.Forms.Label();
            this.Button_ExportAddressList = new System.Windows.Forms.Button();
            this.OpenFileDialog_ExportAddressList = new System.Windows.Forms.OpenFileDialog();
            this.CheckBox_UseDates = new System.Windows.Forms.CheckBox();
            this.FolderBrowserDialog_DefaultExcelSavingPath = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // Button_AddAccount
            // 
            this.Button_AddAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_AddAccount.Location = new System.Drawing.Point(561, 49);
            this.Button_AddAccount.Name = "Button_AddAccount";
            this.Button_AddAccount.Size = new System.Drawing.Size(268, 43);
            this.Button_AddAccount.TabIndex = 0;
            this.Button_AddAccount.Text = "Pasirinkti paskyrą";
            this.Button_AddAccount.UseVisualStyleBackColor = true;
            this.Button_AddAccount.Click += new System.EventHandler(this.Button_AddAccount_Click);
            // 
            // email_Name_Box
            // 
            this.email_Name_Box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.email_Name_Box.Location = new System.Drawing.Point(495, 28);
            this.email_Name_Box.Name = "email_Name_Box";
            this.email_Name_Box.ReadOnly = true;
            this.email_Name_Box.Size = new System.Drawing.Size(280, 15);
            this.email_Name_Box.TabIndex = 3;
            // 
            // TextBox_Emails
            // 
            this.TextBox_Emails.Location = new System.Drawing.Point(12, 12);
            this.TextBox_Emails.Multiline = true;
            this.TextBox_Emails.Name = "TextBox_Emails";
            this.TextBox_Emails.Size = new System.Drawing.Size(458, 426);
            this.TextBox_Emails.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(480, 127);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(414, 10);
            this.textBox1.TabIndex = 5;
            // 
            // Button_EmailText
            // 
            this.Button_EmailText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_EmailText.Location = new System.Drawing.Point(613, 379);
            this.Button_EmailText.Name = "Button_EmailText";
            this.Button_EmailText.Size = new System.Drawing.Size(162, 43);
            this.Button_EmailText.TabIndex = 6;
            this.Button_EmailText.Text = "Parinkti laiško turinį";
            this.Button_EmailText.UseVisualStyleBackColor = true;
            this.Button_EmailText.Click += new System.EventHandler(this.Button_EmailText_Click);
            // 
            // Button_Send
            // 
            this.Button_Send.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Send.Location = new System.Drawing.Point(613, 316);
            this.Button_Send.Name = "Button_Send";
            this.Button_Send.Size = new System.Drawing.Size(162, 43);
            this.Button_Send.TabIndex = 7;
            this.Button_Send.Text = "Siųsti laiškus";
            this.Button_Send.UseVisualStyleBackColor = true;
            this.Button_Send.Click += new System.EventHandler(this.Button_Send_Click);
            // 
            // DateTimePicker_DateFrom
            // 
            this.DateTimePicker_DateFrom.Cursor = System.Windows.Forms.Cursors.Default;
            this.DateTimePicker_DateFrom.Location = new System.Drawing.Point(625, 158);
            this.DateTimePicker_DateFrom.Name = "DateTimePicker_DateFrom";
            this.DateTimePicker_DateFrom.Size = new System.Drawing.Size(268, 22);
            this.DateTimePicker_DateFrom.TabIndex = 8;
            // 
            // DateTimePicker_DateTo
            // 
            this.DateTimePicker_DateTo.Location = new System.Drawing.Point(625, 201);
            this.DateTimePicker_DateTo.Name = "DateTimePicker_DateTo";
            this.DateTimePicker_DateTo.Size = new System.Drawing.Size(268, 22);
            this.DateTimePicker_DateTo.TabIndex = 9;
            // 
            // Label_DateFrom
            // 
            this.Label_DateFrom.AutoSize = true;
            this.Label_DateFrom.Location = new System.Drawing.Point(518, 158);
            this.Label_DateFrom.Name = "Label_DateFrom";
            this.Label_DateFrom.Size = new System.Drawing.Size(64, 17);
            this.Label_DateFrom.TabIndex = 10;
            this.Label_DateFrom.Text = "data nuo";
            // 
            // Label_DateTo
            // 
            this.Label_DateTo.AutoSize = true;
            this.Label_DateTo.Location = new System.Drawing.Point(518, 201);
            this.Label_DateTo.Name = "Label_DateTo";
            this.Label_DateTo.Size = new System.Drawing.Size(53, 17);
            this.Label_DateTo.TabIndex = 11;
            this.Label_DateTo.Text = "data iki";
            // 
            // Button_ExportAddressList
            // 
            this.Button_ExportAddressList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_ExportAddressList.Location = new System.Drawing.Point(496, 255);
            this.Button_ExportAddressList.Name = "Button_ExportAddressList";
            this.Button_ExportAddressList.Size = new System.Drawing.Size(398, 43);
            this.Button_ExportAddressList.TabIndex = 12;
            this.Button_ExportAddressList.Text = "Eksportuoti adresų sąrašą";
            this.Button_ExportAddressList.UseVisualStyleBackColor = true;
            this.Button_ExportAddressList.Click += new System.EventHandler(this.Button_ExportAddressList_Click);
            // 
            // OpenFileDialog_ExportAddressList
            // 
            this.OpenFileDialog_ExportAddressList.FileName = "OpenFileDialog_ExportAddressList";
            // 
            // CheckBox_UseDates
            // 
            this.CheckBox_UseDates.AutoSize = true;
            this.CheckBox_UseDates.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckBox_UseDates.Location = new System.Drawing.Point(521, 231);
            this.CheckBox_UseDates.Name = "CheckBox_UseDates";
            this.CheckBox_UseDates.Size = new System.Drawing.Size(153, 21);
            this.CheckBox_UseDates.TabIndex = 14;
            this.CheckBox_UseDates.Text = "Naudoti datų rėžius";
            this.CheckBox_UseDates.UseVisualStyleBackColor = true;
            this.CheckBox_UseDates.CheckedChanged += new System.EventHandler(this.CheckBox_UseDates_CheckedChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 450);
            this.Controls.Add(this.CheckBox_UseDates);
            this.Controls.Add(this.Button_ExportAddressList);
            this.Controls.Add(this.Label_DateTo);
            this.Controls.Add(this.Label_DateFrom);
            this.Controls.Add(this.DateTimePicker_DateTo);
            this.Controls.Add(this.DateTimePicker_DateFrom);
            this.Controls.Add(this.Button_Send);
            this.Controls.Add(this.Button_EmailText);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TextBox_Emails);
            this.Controls.Add(this.email_Name_Box);
            this.Controls.Add(this.Button_AddAccount);
            this.Name = "MainWindow";
            this.Text = "Pagrindinis langas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_AddAccount;
        public System.Windows.Forms.TextBox email_Name_Box;
        private System.Windows.Forms.TextBox TextBox_Emails;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Button_EmailText;
        private System.Windows.Forms.Button Button_Send;
        private System.Windows.Forms.DateTimePicker DateTimePicker_DateFrom;
        private System.Windows.Forms.DateTimePicker DateTimePicker_DateTo;
        private System.Windows.Forms.Label Label_DateFrom;
        private System.Windows.Forms.Label Label_DateTo;
        private System.Windows.Forms.Button Button_ExportAddressList;
        public System.Windows.Forms.OpenFileDialog OpenFileDialog_ExportAddressList;
        private System.Windows.Forms.CheckBox CheckBox_UseDates;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog_DefaultExcelSavingPath;
    }
}

