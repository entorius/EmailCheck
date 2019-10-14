namespace EmailCheck
{
    partial class AddAccount
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
            this.TextBox_Email = new System.Windows.Forms.TextBox();
            this.TextBox_Password = new System.Windows.Forms.TextBox();
            this.Label_Email = new System.Windows.Forms.Label();
            this.Label_Password = new System.Windows.Forms.Label();
            this.Button_AddAccount = new System.Windows.Forms.Button();
            this.Label_MustFields = new System.Windows.Forms.Label();
            this.RichTextBox_Error = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // TextBox_Email
            // 
            this.TextBox_Email.Location = new System.Drawing.Point(183, 73);
            this.TextBox_Email.Name = "TextBox_Email";
            this.TextBox_Email.Size = new System.Drawing.Size(313, 22);
            this.TextBox_Email.TabIndex = 0;
            this.TextBox_Email.TextChanged += new System.EventHandler(this.TextBox_Email_TextChanged);
            // 
            // TextBox_Password
            // 
            this.TextBox_Password.Location = new System.Drawing.Point(183, 146);
            this.TextBox_Password.Name = "TextBox_Password";
            this.TextBox_Password.Size = new System.Drawing.Size(313, 22);
            this.TextBox_Password.TabIndex = 1;
            this.TextBox_Password.UseSystemPasswordChar = true;
            this.TextBox_Password.TextChanged += new System.EventHandler(this.TextBox_Password_TextChanged);
            // 
            // Label_Email
            // 
            this.Label_Email.AutoSize = true;
            this.Label_Email.Location = new System.Drawing.Point(57, 76);
            this.Label_Email.Name = "Label_Email";
            this.Label_Email.Size = new System.Drawing.Size(51, 17);
            this.Label_Email.TabIndex = 2;
            this.Label_Email.Text = "*e-mail";
            // 
            // Label_Password
            // 
            this.Label_Password.AutoSize = true;
            this.Label_Password.Location = new System.Drawing.Point(53, 149);
            this.Label_Password.Name = "Label_Password";
            this.Label_Password.Size = new System.Drawing.Size(73, 17);
            this.Label_Password.TabIndex = 3;
            this.Label_Password.Text = "*password";
            // 
            // Button_AddAccount
            // 
            this.Button_AddAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_AddAccount.Location = new System.Drawing.Point(368, 205);
            this.Button_AddAccount.Name = "Button_AddAccount";
            this.Button_AddAccount.Size = new System.Drawing.Size(150, 47);
            this.Button_AddAccount.TabIndex = 4;
            this.Button_AddAccount.Text = "Pridėti";
            this.Button_AddAccount.UseVisualStyleBackColor = true;
            this.Button_AddAccount.Click += new System.EventHandler(this.Button_AddAccount_Click);
            // 
            // Label_MustFields
            // 
            this.Label_MustFields.AutoSize = true;
            this.Label_MustFields.Location = new System.Drawing.Point(34, 258);
            this.Label_MustFields.Name = "Label_MustFields";
            this.Label_MustFields.Size = new System.Drawing.Size(129, 17);
            this.Label_MustFields.TabIndex = 6;
            this.Label_MustFields.Text = "* Privalomi laukeliai";
            // 
            // RichTextBox_Error
            // 
            this.RichTextBox_Error.Cursor = System.Windows.Forms.Cursors.No;
            this.RichTextBox_Error.ForeColor = System.Drawing.Color.Red;
            this.RichTextBox_Error.Location = new System.Drawing.Point(27, 217);
            this.RichTextBox_Error.Name = "RichTextBox_Error";
            this.RichTextBox_Error.ReadOnly = true;
            this.RichTextBox_Error.Size = new System.Drawing.Size(310, 35);
            this.RichTextBox_Error.TabIndex = 7;
            this.RichTextBox_Error.Text = "";
            // 
            // AddAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 309);
            this.Controls.Add(this.RichTextBox_Error);
            this.Controls.Add(this.Label_MustFields);
            this.Controls.Add(this.Button_AddAccount);
            this.Controls.Add(this.Label_Password);
            this.Controls.Add(this.Label_Email);
            this.Controls.Add(this.TextBox_Password);
            this.Controls.Add(this.TextBox_Email);
            this.Name = "AddAccount";
            this.Text = "Pridėti paskyrą";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox_Email;
        private System.Windows.Forms.TextBox TextBox_Password;
        private System.Windows.Forms.Label Label_Email;
        private System.Windows.Forms.Label Label_Password;
        private System.Windows.Forms.Button Button_AddAccount;
        private System.Windows.Forms.Label Label_MustFields;
        private System.Windows.Forms.RichTextBox RichTextBox_Error;
    }
}