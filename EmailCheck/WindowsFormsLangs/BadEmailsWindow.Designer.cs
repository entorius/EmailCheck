namespace EmailCheck
{
    partial class BadEmailsWindow
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
            this.Button_OK = new System.Windows.Forms.Button();
            this.RichTextBox_BadEmails = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Button_OK
            // 
            this.Button_OK.BackgroundImage = global::EmailCheck.Properties.Resources.image;
            this.Button_OK.Font = new System.Drawing.Font("Ubuntu", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Button_OK.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Button_OK.Image = global::EmailCheck.Properties.Resources.image;
            this.Button_OK.Location = new System.Drawing.Point(279, 392);
            this.Button_OK.Name = "Button_OK";
            this.Button_OK.Size = new System.Drawing.Size(126, 37);
            this.Button_OK.TabIndex = 1;
            this.Button_OK.Text = "Gerai";
            this.Button_OK.UseVisualStyleBackColor = true;
            this.Button_OK.Click += new System.EventHandler(this.Button_OK_Click);
            // 
            // RichTextBox_BadEmails
            // 
            this.RichTextBox_BadEmails.BackColor = System.Drawing.SystemColors.Control;
            this.RichTextBox_BadEmails.ForeColor = System.Drawing.Color.Red;
            this.RichTextBox_BadEmails.Location = new System.Drawing.Point(12, 23);
            this.RichTextBox_BadEmails.Name = "RichTextBox_BadEmails";
            this.RichTextBox_BadEmails.ReadOnly = true;
            this.RichTextBox_BadEmails.Size = new System.Drawing.Size(686, 354);
            this.RichTextBox_BadEmails.TabIndex = 2;
            this.RichTextBox_BadEmails.Text = "";
            // 
            // BadEmailsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EmailCheck.Properties.Resources.backgroundForApp;
            this.ClientSize = new System.Drawing.Size(710, 450);
            this.Controls.Add(this.RichTextBox_BadEmails);
            this.Controls.Add(this.Button_OK);
            this.Name = "BadEmailsWindow";
            this.Text = "Blogi el. Paštai";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Button_OK;
        private System.Windows.Forms.RichTextBox RichTextBox_BadEmails;
    }
}