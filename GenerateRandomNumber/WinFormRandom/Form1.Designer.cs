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
            this.btnReset = new System.Windows.Forms.Button();
            this.tbMin = new System.Windows.Forms.TextBox();
            this.tbMax = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbrannumqt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnran
            // 
            this.btnran.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnran.Location = new System.Drawing.Point(51, 473);
            this.btnran.Margin = new System.Windows.Forms.Padding(4);
            this.btnran.Name = "btnran";
            this.btnran.Size = new System.Drawing.Size(203, 50);
            this.btnran.TabIndex = 1;
            this.btnran.Text = "產生一個亂數";
            this.btnran.UseVisualStyleBackColor = true;
            this.btnran.Click += new System.EventHandler(this.btnran_Click);
            // 
            // listBoxResult
            // 
            this.listBoxResult.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBoxResult.FormattingEnabled = true;
            this.listBoxResult.ItemHeight = 34;
            this.listBoxResult.Location = new System.Drawing.Point(51, 37);
            this.listBoxResult.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxResult.Name = "listBoxResult";
            this.listBoxResult.Size = new System.Drawing.Size(152, 412);
            this.listBoxResult.TabIndex = 3;
            // 
            // btnGenAll
            // 
            this.btnGenAll.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnGenAll.Location = new System.Drawing.Point(262, 473);
            this.btnGenAll.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenAll.Name = "btnGenAll";
            this.btnGenAll.Size = new System.Drawing.Size(203, 50);
            this.btnGenAll.TabIndex = 4;
            this.btnGenAll.Text = "產生所有亂數";
            this.btnGenAll.UseVisualStyleBackColor = true;
            this.btnGenAll.Click += new System.EventHandler(this.btnGenAll_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReset.Location = new System.Drawing.Point(472, 473);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(110, 50);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "重置";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // tbMin
            // 
            this.tbMin.Font = new System.Drawing.Font("新細明體", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbMin.Location = new System.Drawing.Point(306, 100);
            this.tbMin.Name = "tbMin";
            this.tbMin.Size = new System.Drawing.Size(159, 64);
            this.tbMin.TabIndex = 6;
            this.tbMin.Text = "1";
            // 
            // tbMax
            // 
            this.tbMax.Font = new System.Drawing.Font("新細明體", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbMax.Location = new System.Drawing.Point(306, 253);
            this.tbMax.Name = "tbMax";
            this.tbMax.Size = new System.Drawing.Size(159, 64);
            this.tbMax.TabIndex = 7;
            this.tbMax.Text = "10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(284, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 48);
            this.label1.TabIndex = 8;
            this.label1.Text = "最小數字";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(284, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 48);
            this.label2.TabIndex = 9;
            this.label2.Text = "最大數字";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(238, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(308, 48);
            this.label3.TabIndex = 9;
            this.label3.Text = "剩餘亂數數量";
            // 
            // lbrannumqt
            // 
            this.lbrannumqt.AutoSize = true;
            this.lbrannumqt.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbrannumqt.Location = new System.Drawing.Point(299, 407);
            this.lbrannumqt.Name = "lbrannumqt";
            this.lbrannumqt.Size = new System.Drawing.Size(37, 42);
            this.lbrannumqt.TabIndex = 10;
            this.lbrannumqt.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 593);
            this.Controls.Add(this.lbrannumqt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMax);
            this.Controls.Add(this.tbMin);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnGenAll);
            this.Controls.Add(this.listBoxResult);
            this.Controls.Add(this.btnran);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "亂數產生器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnran;
        private System.Windows.Forms.ListBox listBoxResult;
        private System.Windows.Forms.Button btnGenAll;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox tbMin;
        private System.Windows.Forms.TextBox tbMax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbrannumqt;
    }
}

