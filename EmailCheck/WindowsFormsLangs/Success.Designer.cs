namespace EmailCheck.WindowsFormsLangs
{
    partial class Success
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
            this.Label_Success = new System.Windows.Forms.Label();
            this.Button_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label_Success
            // 
            this.Label_Success.AutoSize = true;
            this.Label_Success.Location = new System.Drawing.Point(203, 88);
            this.Label_Success.Name = "Label_Success";
            this.Label_Success.Size = new System.Drawing.Size(0, 17);
            this.Label_Success.TabIndex = 0;
            // 
            // Button_OK
            // 
            this.Button_OK.Font = new System.Drawing.Font("Ubuntu", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Button_OK.Image = global::EmailCheck.Properties.Resources.image;
            this.Button_OK.Location = new System.Drawing.Point(160, 163);
            this.Button_OK.Name = "Button_OK";
            this.Button_OK.Size = new System.Drawing.Size(128, 55);
            this.Button_OK.TabIndex = 1;
            this.Button_OK.Text = "Gerai";
            this.Button_OK.UseVisualStyleBackColor = true;
            this.Button_OK.Click += new System.EventHandler(this.Button_OK_Click);
            // 
            // Success
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EmailCheck.Properties.Resources.backgroundForApp;
            this.ClientSize = new System.Drawing.Size(467, 256);
            this.Controls.Add(this.Button_OK);
            this.Controls.Add(this.Label_Success);
            this.Name = "Success";
            this.Text = "Sėkmingai atlikta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Success;
        private System.Windows.Forms.Button Button_OK;
    }
}