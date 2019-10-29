namespace EmailCheck
{
    partial class EmailsSaveWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.CheckBox_UseGeneratedName = new System.Windows.Forms.CheckBox();
            this.Label_FileName = new System.Windows.Forms.Label();
            this.TextBox_FileName = new System.Windows.Forms.TextBox();
            this.Button_Save = new System.Windows.Forms.Button();
            this.Button_Reject = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(380, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 2;
            // 
            // CheckBox_UseGeneratedName
            // 
            this.CheckBox_UseGeneratedName.AutoSize = true;
            this.CheckBox_UseGeneratedName.BackColor = System.Drawing.Color.Transparent;
            this.CheckBox_UseGeneratedName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckBox_UseGeneratedName.Font = new System.Drawing.Font("Ubuntu", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.CheckBox_UseGeneratedName.Location = new System.Drawing.Point(119, 94);
            this.CheckBox_UseGeneratedName.Name = "CheckBox_UseGeneratedName";
            this.CheckBox_UseGeneratedName.Size = new System.Drawing.Size(380, 24);
            this.CheckBox_UseGeneratedName.TabIndex = 3;
            this.CheckBox_UseGeneratedName.Text = "Naudoti automatiškai sugeneruojamą pavadinimą";
            this.CheckBox_UseGeneratedName.UseVisualStyleBackColor = false;
            // 
            // Label_FileName
            // 
            this.Label_FileName.AutoSize = true;
            this.Label_FileName.BackColor = System.Drawing.Color.Transparent;
            this.Label_FileName.Font = new System.Drawing.Font("Ubuntu", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Label_FileName.Location = new System.Drawing.Point(9, 36);
            this.Label_FileName.Name = "Label_FileName";
            this.Label_FileName.Size = new System.Drawing.Size(134, 20);
            this.Label_FileName.TabIndex = 4;
            this.Label_FileName.Text = "Failo pavadinimas";
            // 
            // TextBox_FileName
            // 
            this.TextBox_FileName.Location = new System.Drawing.Point(149, 36);
            this.TextBox_FileName.Name = "TextBox_FileName";
            this.TextBox_FileName.Size = new System.Drawing.Size(280, 22);
            this.TextBox_FileName.TabIndex = 5;
            // 
            // Button_Save
            // 
            this.Button_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Save.Font = new System.Drawing.Font("Ubuntu", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Button_Save.Image = global::EmailCheck.Properties.Resources.image;
            this.Button_Save.Location = new System.Drawing.Point(341, 179);
            this.Button_Save.Name = "Button_Save";
            this.Button_Save.Size = new System.Drawing.Size(127, 44);
            this.Button_Save.TabIndex = 6;
            this.Button_Save.Text = "Išsaugoti";
            this.Button_Save.UseVisualStyleBackColor = true;
            this.Button_Save.Click += new System.EventHandler(this.Button_Save_Click);
            // 
            // Button_Reject
            // 
            this.Button_Reject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Reject.Font = new System.Drawing.Font("Ubuntu", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Button_Reject.Image = global::EmailCheck.Properties.Resources.image;
            this.Button_Reject.Location = new System.Drawing.Point(24, 179);
            this.Button_Reject.Name = "Button_Reject";
            this.Button_Reject.Size = new System.Drawing.Size(127, 44);
            this.Button_Reject.TabIndex = 7;
            this.Button_Reject.Text = "Atšaukti";
            this.Button_Reject.UseVisualStyleBackColor = true;
            this.Button_Reject.Click += new System.EventHandler(this.Button_Reject_Click);
            // 
            // EmailsSaveWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EmailCheck.Properties.Resources.backgroundForApp;
            this.ClientSize = new System.Drawing.Size(499, 245);
            this.Controls.Add(this.Button_Reject);
            this.Controls.Add(this.Button_Save);
            this.Controls.Add(this.TextBox_FileName);
            this.Controls.Add(this.Label_FileName);
            this.Controls.Add(this.CheckBox_UseGeneratedName);
            this.Controls.Add(this.label1);
            this.Name = "EmailsSaveWindow";
            this.Text = "Išsaugoti El. paštus Excel faile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox CheckBox_UseGeneratedName;
        private System.Windows.Forms.Label Label_FileName;
        private System.Windows.Forms.TextBox TextBox_FileName;
        private System.Windows.Forms.Button Button_Save;
        private System.Windows.Forms.Button Button_Reject;
    }
}