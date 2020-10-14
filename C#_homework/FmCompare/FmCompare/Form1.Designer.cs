namespace FmCompare
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbAvg = new System.Windows.Forms.Label();
            this.lbShow = new System.Windows.Forms.Label();
            this.btnCom = new System.Windows.Forms.Button();
            this.btnPresent = new System.Windows.Forms.Button();
            this.btnStore = new System.Windows.Forms.Button();
            this.tbMa = new System.Windows.Forms.TextBox();
            this.tbEn = new System.Windows.Forms.TextBox();
            this.tbCh = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbAvg);
            this.groupBox1.Controls.Add(this.lbShow);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(356, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 335);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "成績";
            // 
            // lbAvg
            // 
            this.lbAvg.BackColor = System.Drawing.SystemColors.Window;
            this.lbAvg.Location = new System.Drawing.Point(16, 202);
            this.lbAvg.Name = "lbAvg";
            this.lbAvg.Size = new System.Drawing.Size(357, 118);
            this.lbAvg.TabIndex = 0;
            // 
            // lbShow
            // 
            this.lbShow.BackColor = System.Drawing.SystemColors.Window;
            this.lbShow.Location = new System.Drawing.Point(16, 21);
            this.lbShow.Name = "lbShow";
            this.lbShow.Size = new System.Drawing.Size(357, 170);
            this.lbShow.TabIndex = 0;
            // 
            // btnCom
            // 
            this.btnCom.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCom.Location = new System.Drawing.Point(583, 370);
            this.btnCom.Name = "btnCom";
            this.btnCom.Size = new System.Drawing.Size(146, 51);
            this.btnCom.TabIndex = 12;
            this.btnCom.Text = "最高/低分科目";
            this.btnCom.UseVisualStyleBackColor = true;
            this.btnCom.Click += new System.EventHandler(this.btnCom_Click);
            // 
            // btnPresent
            // 
            this.btnPresent.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPresent.Location = new System.Drawing.Point(202, 302);
            this.btnPresent.Name = "btnPresent";
            this.btnPresent.Size = new System.Drawing.Size(139, 51);
            this.btnPresent.TabIndex = 13;
            this.btnPresent.Text = "顯示儲存內容";
            this.btnPresent.UseVisualStyleBackColor = true;
            this.btnPresent.Click += new System.EventHandler(this.btnPresent_Click);
            // 
            // btnStore
            // 
            this.btnStore.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnStore.Location = new System.Drawing.Point(57, 302);
            this.btnStore.Name = "btnStore";
            this.btnStore.Size = new System.Drawing.Size(108, 51);
            this.btnStore.TabIndex = 14;
            this.btnStore.Text = "儲存";
            this.btnStore.UseVisualStyleBackColor = true;
            this.btnStore.Click += new System.EventHandler(this.btnStore_Click);
            // 
            // tbMa
            // 
            this.tbMa.Location = new System.Drawing.Point(148, 199);
            this.tbMa.Name = "tbMa";
            this.tbMa.Size = new System.Drawing.Size(128, 22);
            this.tbMa.TabIndex = 8;
            // 
            // tbEn
            // 
            this.tbEn.Location = new System.Drawing.Point(148, 153);
            this.tbEn.Name = "tbEn";
            this.tbEn.Size = new System.Drawing.Size(128, 22);
            this.tbEn.TabIndex = 9;
            // 
            // tbCh
            // 
            this.tbCh.Location = new System.Drawing.Point(148, 107);
            this.tbCh.Name = "tbCh";
            this.tbCh.Size = new System.Drawing.Size(128, 22);
            this.tbCh.TabIndex = 10;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(148, 61);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(128, 22);
            this.tbName.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(60, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "數學:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(60, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "英文:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(60, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "國文:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(60, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "姓名:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCom);
            this.Controls.Add(this.btnPresent);
            this.Controls.Add(this.btnStore);
            this.Controls.Add(this.tbMa);
            this.Controls.Add(this.tbEn);
            this.Controls.Add(this.tbCh);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbAvg;
        private System.Windows.Forms.Label lbShow;
        private System.Windows.Forms.Button btnCom;
        private System.Windows.Forms.Button btnPresent;
        private System.Windows.Forms.Button btnStore;
        private System.Windows.Forms.TextBox tbMa;
        private System.Windows.Forms.TextBox tbEn;
        private System.Windows.Forms.TextBox tbCh;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

