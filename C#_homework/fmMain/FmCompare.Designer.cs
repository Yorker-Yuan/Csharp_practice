namespace fmMain
{
    partial class FmCompare
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
            this.label4 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbCh = new System.Windows.Forms.TextBox();
            this.tbEn = new System.Windows.Forms.TextBox();
            this.tbMa = new System.Windows.Forms.TextBox();
            this.btnStore = new System.Windows.Forms.Button();
            this.btnPresent = new System.Windows.Forms.Button();
            this.btnCom = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbAvg = new System.Windows.Forms.Label();
            this.lbShow = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(98, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(98, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "國文:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(98, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "英文:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(98, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "數學:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(186, 58);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(128, 22);
            this.tbName.TabIndex = 1;
            // 
            // tbCh
            // 
            this.tbCh.Location = new System.Drawing.Point(186, 104);
            this.tbCh.Name = "tbCh";
            this.tbCh.Size = new System.Drawing.Size(128, 22);
            this.tbCh.TabIndex = 1;
            // 
            // tbEn
            // 
            this.tbEn.Location = new System.Drawing.Point(186, 150);
            this.tbEn.Name = "tbEn";
            this.tbEn.Size = new System.Drawing.Size(128, 22);
            this.tbEn.TabIndex = 1;
            // 
            // tbMa
            // 
            this.tbMa.Location = new System.Drawing.Point(186, 196);
            this.tbMa.Name = "tbMa";
            this.tbMa.Size = new System.Drawing.Size(128, 22);
            this.tbMa.TabIndex = 1;
            // 
            // btnStore
            // 
            this.btnStore.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnStore.Location = new System.Drawing.Point(95, 299);
            this.btnStore.Name = "btnStore";
            this.btnStore.Size = new System.Drawing.Size(108, 51);
            this.btnStore.TabIndex = 2;
            this.btnStore.Text = "儲存";
            this.btnStore.UseVisualStyleBackColor = true;
            this.btnStore.Click += new System.EventHandler(this.btnStore_Click);
            // 
            // btnPresent
            // 
            this.btnPresent.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPresent.Location = new System.Drawing.Point(240, 299);
            this.btnPresent.Name = "btnPresent";
            this.btnPresent.Size = new System.Drawing.Size(139, 51);
            this.btnPresent.TabIndex = 2;
            this.btnPresent.Text = "顯示儲存內容";
            this.btnPresent.UseVisualStyleBackColor = true;
            // 
            // btnCom
            // 
            this.btnCom.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCom.Location = new System.Drawing.Point(621, 367);
            this.btnCom.Name = "btnCom";
            this.btnCom.Size = new System.Drawing.Size(146, 51);
            this.btnCom.TabIndex = 2;
            this.btnCom.Text = "最高/低分科目";
            this.btnCom.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbAvg);
            this.groupBox1.Controls.Add(this.lbShow);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(394, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 335);
            this.groupBox1.TabIndex = 3;
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
            // FmCompare
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
            this.Name = "FmCompare";
            this.Text = "FmCompare";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbCh;
        private System.Windows.Forms.TextBox tbEn;
        private System.Windows.Forms.TextBox tbMa;
        private System.Windows.Forms.Button btnStore;
        private System.Windows.Forms.Button btnPresent;
        private System.Windows.Forms.Button btnCom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbShow;
        private System.Windows.Forms.Label lbAvg;
    }
}