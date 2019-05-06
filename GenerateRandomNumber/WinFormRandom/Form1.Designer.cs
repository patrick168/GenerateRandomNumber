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
            this.btnran = new System.Windows.Forms.Button();
            this.listBoxResult = new System.Windows.Forms.ListBox();
            this.btnGenAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnran
            // 
            this.btnran.Location = new System.Drawing.Point(117, 364);
            this.btnran.Name = "btnran";
            this.btnran.Size = new System.Drawing.Size(114, 23);
            this.btnran.TabIndex = 1;
            this.btnran.Text = "產生一個亂數";
            this.btnran.UseVisualStyleBackColor = true;
            this.btnran.Click += new System.EventHandler(this.btnran_Click);
            // 
            // listBoxResult
            // 
            this.listBoxResult.Font = new System.Drawing.Font("PMingLiU", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBoxResult.FormattingEnabled = true;
            this.listBoxResult.ItemHeight = 27;
            this.listBoxResult.Location = new System.Drawing.Point(117, 30);
            this.listBoxResult.Name = "listBoxResult";
            this.listBoxResult.Size = new System.Drawing.Size(138, 166);
            this.listBoxResult.TabIndex = 3;
            // 
            // btnGenAll
            // 
            this.btnGenAll.Location = new System.Drawing.Point(269, 364);
            this.btnGenAll.Name = "btnGenAll";
            this.btnGenAll.Size = new System.Drawing.Size(107, 23);
            this.btnGenAll.TabIndex = 4;
            this.btnGenAll.Text = "產生所有亂數";
            this.btnGenAll.UseVisualStyleBackColor = true;
            this.btnGenAll.Click += new System.EventHandler(this.btnGenAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGenAll);
            this.Controls.Add(this.listBoxResult);
            this.Controls.Add(this.btnran);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnran;
        private System.Windows.Forms.ListBox listBoxResult;
        private System.Windows.Forms.Button btnGenAll;
    }
}

