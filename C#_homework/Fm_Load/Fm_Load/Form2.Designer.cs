namespace Fm_Load
{
    partial class Form2
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
            this.btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbYear = new System.Windows.Forms.Label();
            this.lbRate = new System.Windows.Forms.Label();
            this.lbMonthPay = new System.Windows.Forms.Label();
            this.lbTotalPay = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn.Location = new System.Drawing.Point(315, 246);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(101, 54);
            this.btn.TabIndex = 11;
            this.btn.Text = "Email";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(114, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "月付款";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(104, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "利率(%)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(102, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "期數(年)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(98, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "貸款金額";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbPrice.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbPrice.Location = new System.Drawing.Point(205, 61);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(52, 23);
            this.lbPrice.TabIndex = 6;
            this.lbPrice.Text = "          ";
            // 
            // lbYear
            // 
            this.lbYear.AutoSize = true;
            this.lbYear.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbYear.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbYear.Location = new System.Drawing.Point(205, 99);
            this.lbYear.Name = "lbYear";
            this.lbYear.Size = new System.Drawing.Size(52, 23);
            this.lbYear.TabIndex = 6;
            this.lbYear.Text = "          ";
            // 
            // lbRate
            // 
            this.lbRate.AutoSize = true;
            this.lbRate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbRate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbRate.Location = new System.Drawing.Point(205, 138);
            this.lbRate.Name = "lbRate";
            this.lbRate.Size = new System.Drawing.Size(52, 23);
            this.lbRate.TabIndex = 6;
            this.lbRate.Text = "          ";
            // 
            // lbMonthPay
            // 
            this.lbMonthPay.AutoSize = true;
            this.lbMonthPay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbMonthPay.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbMonthPay.Location = new System.Drawing.Point(205, 177);
            this.lbMonthPay.Name = "lbMonthPay";
            this.lbMonthPay.Size = new System.Drawing.Size(52, 23);
            this.lbMonthPay.TabIndex = 6;
            this.lbMonthPay.Text = "          ";
            // 
            // lbTotalPay
            // 
            this.lbTotalPay.AutoSize = true;
            this.lbTotalPay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbTotalPay.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbTotalPay.Location = new System.Drawing.Point(205, 216);
            this.lbTotalPay.Name = "lbTotalPay";
            this.lbTotalPay.Size = new System.Drawing.Size(52, 23);
            this.lbTotalPay.TabIndex = 6;
            this.lbTotalPay.Text = "          ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(114, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 21);
            this.label6.TabIndex = 3;
            this.label6.Text = "總付額";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 337);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbTotalPay);
            this.Controls.Add(this.lbMonthPay);
            this.Controls.Add(this.lbRate);
            this.Controls.Add(this.lbYear);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbYear;
        private System.Windows.Forms.Label lbRate;
        private System.Windows.Forms.Label lbMonthPay;
        private System.Windows.Forms.Label lbTotalPay;
        private System.Windows.Forms.Label label6;
    }
}