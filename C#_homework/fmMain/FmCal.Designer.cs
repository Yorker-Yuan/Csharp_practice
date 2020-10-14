namespace fmMain
{
    partial class FmCal
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNum2 = new System.Windows.Forms.TextBox();
            this.tbNum1 = new System.Windows.Forms.TextBox();
            this.tbAns = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnLess = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btnEx = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(86, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Num1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(86, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Num2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(74, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Answer:";
            // 
            // tbNum2
            // 
            this.tbNum2.Location = new System.Drawing.Point(179, 154);
            this.tbNum2.Name = "tbNum2";
            this.tbNum2.Size = new System.Drawing.Size(125, 22);
            this.tbNum2.TabIndex = 2;
            // 
            // tbNum1
            // 
            this.tbNum1.Location = new System.Drawing.Point(179, 66);
            this.tbNum1.Name = "tbNum1";
            this.tbNum1.Size = new System.Drawing.Size(125, 22);
            this.tbNum1.TabIndex = 1;
            // 
            // tbAns
            // 
            this.tbAns.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAns.Enabled = false;
            this.tbAns.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbAns.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tbAns.Location = new System.Drawing.Point(179, 242);
            this.tbAns.Name = "tbAns";
            this.tbAns.Size = new System.Drawing.Size(125, 25);
            this.tbAns.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(84, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "===============";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAdd.Location = new System.Drawing.Point(351, 55);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(67, 50);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnLess
            // 
            this.btnLess.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLess.Location = new System.Drawing.Point(351, 112);
            this.btnLess.Name = "btnLess";
            this.btnLess.Size = new System.Drawing.Size(67, 50);
            this.btnLess.TabIndex = 4;
            this.btnLess.Text = "-";
            this.btnLess.UseVisualStyleBackColor = true;
            this.btnLess.Click += new System.EventHandler(this.btnLess_Click);
            // 
            // btnMul
            // 
            this.btnMul.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMul.Location = new System.Drawing.Point(351, 169);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(67, 50);
            this.btnMul.TabIndex = 5;
            this.btnMul.Text = "*";
            this.btnMul.UseVisualStyleBackColor = true;
            this.btnMul.Click += new System.EventHandler(this.btnMul_Click);
            // 
            // btnEx
            // 
            this.btnEx.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnEx.Location = new System.Drawing.Point(351, 226);
            this.btnEx.Name = "btnEx";
            this.btnEx.Size = new System.Drawing.Size(67, 50);
            this.btnEx.TabIndex = 6;
            this.btnEx.Text = "/";
            this.btnEx.UseVisualStyleBackColor = true;
            this.btnEx.Click += new System.EventHandler(this.btnEx_Click);
            // 
            // FmCal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 349);
            this.Controls.Add(this.btnEx);
            this.Controls.Add(this.btnMul);
            this.Controls.Add(this.btnLess);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbAns);
            this.Controls.Add(this.tbNum1);
            this.Controls.Add(this.tbNum2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FmCal";
            this.Text = "FmCal";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FmCal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNum2;
        private System.Windows.Forms.TextBox tbNum1;
        private System.Windows.Forms.TextBox tbAns;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnLess;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btnEx;
    }
}