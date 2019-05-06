namespace WinFormRandom
{
    partial class Form1
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
            this.textRandom = new System.Windows.Forms.TextBox();
            this.btnran = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textRandom
            // 
            this.textRandom.Enabled = false;
            this.textRandom.Font = new System.Drawing.Font("PMingLiU", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textRandom.Location = new System.Drawing.Point(65, 25);
            this.textRandom.Multiline = true;
            this.textRandom.Name = "textRandom";
            this.textRandom.Size = new System.Drawing.Size(475, 307);
            this.textRandom.TabIndex = 0;
            this.textRandom.Text = "NO";
            // 
            // btnran
            // 
            this.btnran.Location = new System.Drawing.Point(117, 362);
            this.btnran.Name = "btnran";
            this.btnran.Size = new System.Drawing.Size(75, 23);
            this.btnran.TabIndex = 1;
            this.btnran.Text = "產生亂數";
            this.btnran.UseVisualStyleBackColor = true;
            this.btnran.Click += new System.EventHandler(this.btnran_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnran);
            this.Controls.Add(this.textRandom);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textRandom;
        private System.Windows.Forms.Button btnran;
    }
}

