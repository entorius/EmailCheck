namespace EmailCheck
{
    partial class EmailContent
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
            this.TextBox_Subject = new System.Windows.Forms.TextBox();
            this.TextBox_Body = new System.Windows.Forms.TextBox();
            this.Label_Subject = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Button_Save = new System.Windows.Forms.Button();
            this.ButtonReject = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBox_Subject
            // 
            this.TextBox_Subject.Location = new System.Drawing.Point(137, 32);
            this.TextBox_Subject.MaxLength = 100;
            this.TextBox_Subject.Name = "TextBox_Subject";
            this.TextBox_Subject.Size = new System.Drawing.Size(612, 22);
            this.TextBox_Subject.TabIndex = 0;
            // 
            // TextBox_Body
            // 
            this.TextBox_Body.Location = new System.Drawing.Point(137, 91);
            this.TextBox_Body.Multiline = true;
            this.TextBox_Body.Name = "TextBox_Body";
            this.TextBox_Body.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBox_Body.Size = new System.Drawing.Size(612, 284);
            this.TextBox_Body.TabIndex = 1;
            // 
            // Label_Subject
            // 
            this.Label_Subject.AutoSize = true;
            this.Label_Subject.Location = new System.Drawing.Point(24, 32);
            this.Label_Subject.Name = "Label_Subject";
            this.Label_Subject.Size = new System.Drawing.Size(84, 17);
            this.Label_Subject.TabIndex = 2;
            this.Label_Subject.Text = "Laiško tema";
            this.Label_Subject.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Laiško turinys";
            // 
            // Button_Save
            // 
            this.Button_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Save.Location = new System.Drawing.Point(564, 381);
            this.Button_Save.Name = "Button_Save";
            this.Button_Save.Size = new System.Drawing.Size(185, 66);
            this.Button_Save.TabIndex = 4;
            this.Button_Save.Text = "Išsaugoti";
            this.Button_Save.UseVisualStyleBackColor = true;
            this.Button_Save.Click += new System.EventHandler(this.Button_Save_Click);
            // 
            // ButtonReject
            // 
            this.ButtonReject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonReject.Location = new System.Drawing.Point(137, 381);
            this.ButtonReject.Name = "ButtonReject";
            this.ButtonReject.Size = new System.Drawing.Size(185, 66);
            this.ButtonReject.TabIndex = 5;
            this.ButtonReject.Text = "Atšaukti";
            this.ButtonReject.UseVisualStyleBackColor = true;
            this.ButtonReject.Click += new System.EventHandler(this.ButtonReject_Click);
            // 
            // EmailContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonReject);
            this.Controls.Add(this.Button_Save);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Label_Subject);
            this.Controls.Add(this.TextBox_Body);
            this.Controls.Add(this.TextBox_Subject);
            this.Name = "EmailContent";
            this.Text = "Laiško struktūra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox_Subject;
        private System.Windows.Forms.TextBox TextBox_Body;
        private System.Windows.Forms.Label Label_Subject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button_Save;
        private System.Windows.Forms.Button ButtonReject;
    }
}