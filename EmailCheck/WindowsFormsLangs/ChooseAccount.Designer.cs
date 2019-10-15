namespace EmailCheck
{
    partial class ChooseAccount
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
            this.AddAccount_Button = new System.Windows.Forms.Button();
            this.Button_ChooseAccount = new System.Windows.Forms.Button();
            this.ListBox_Accounts = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // AddAccount_Button
            // 
            this.AddAccount_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddAccount_Button.Location = new System.Drawing.Point(118, 304);
            this.AddAccount_Button.Name = "AddAccount_Button";
            this.AddAccount_Button.Size = new System.Drawing.Size(161, 53);
            this.AddAccount_Button.TabIndex = 0;
            this.AddAccount_Button.Text = "Pridėti naują";
            this.AddAccount_Button.UseVisualStyleBackColor = true;
            this.AddAccount_Button.Click += new System.EventHandler(this.AddAccount_Button_Click);
            // 
            // Button_ChooseAccount
            // 
            this.Button_ChooseAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_ChooseAccount.Location = new System.Drawing.Point(474, 304);
            this.Button_ChooseAccount.Name = "Button_ChooseAccount";
            this.Button_ChooseAccount.Size = new System.Drawing.Size(161, 53);
            this.Button_ChooseAccount.TabIndex = 1;
            this.Button_ChooseAccount.Text = "Pasirinkti";
            this.Button_ChooseAccount.UseVisualStyleBackColor = true;
            this.Button_ChooseAccount.Click += new System.EventHandler(this.Button_ChooseAccount_Click);
            // 
            // ListBox_Accounts
            // 
            this.ListBox_Accounts.FormattingEnabled = true;
            this.ListBox_Accounts.ItemHeight = 16;
            this.ListBox_Accounts.Location = new System.Drawing.Point(118, 60);
            this.ListBox_Accounts.Name = "ListBox_Accounts";
            this.ListBox_Accounts.Size = new System.Drawing.Size(517, 164);
            this.ListBox_Accounts.TabIndex = 4;
            this.ListBox_Accounts.SelectedIndexChanged += new System.EventHandler(this.ListBox_Accounts_SelectedIndexChanged);
            // 
            // ChooseAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListBox_Accounts);
            this.Controls.Add(this.Button_ChooseAccount);
            this.Controls.Add(this.AddAccount_Button);
            this.Name = "ChooseAccount";
            this.Text = "Pasirinkti paskyrą";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddAccount_Button;
        private System.Windows.Forms.Button Button_ChooseAccount;
        public  System.Windows.Forms.ListBox ListBox_Accounts;
    }
}