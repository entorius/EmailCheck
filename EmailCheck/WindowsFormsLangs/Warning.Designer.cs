namespace EmailCheck
{
    partial class Warning
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
            this.TextBox_Warning = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Button_OK
            // 
            this.Button_OK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_OK.Location = new System.Drawing.Point(126, 165);
            this.Button_OK.Name = "Button_OK";
            this.Button_OK.Size = new System.Drawing.Size(106, 42);
            this.Button_OK.TabIndex = 1;
            this.Button_OK.Text = "Gerai";
            this.Button_OK.UseVisualStyleBackColor = true;
            this.Button_OK.Click += new System.EventHandler(this.Button_OK_Click);
            // 
            // TextBox_Warning
            // 
            this.TextBox_Warning.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_Warning.Location = new System.Drawing.Point(12, 12);
            this.TextBox_Warning.Multiline = true;
            this.TextBox_Warning.Name = "TextBox_Warning";
            this.TextBox_Warning.ReadOnly = true;
            this.TextBox_Warning.Size = new System.Drawing.Size(344, 147);
            this.TextBox_Warning.TabIndex = 2;
            // 
            // Warning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 242);
            this.Controls.Add(this.TextBox_Warning);
            this.Controls.Add(this.Button_OK);
            this.Name = "Warning";
            this.Text = "Perspėjimas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Button_OK;
        private System.Windows.Forms.TextBox TextBox_Warning;
    }
}