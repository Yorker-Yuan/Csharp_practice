namespace fmMain
{
    partial class FmHello
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEnName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbEnName = new System.Windows.Forms.Label();
            this.lbStar = new System.Windows.Forms.Label();
            this.lbSex = new System.Windows.Forms.Label();
            this.btnSayHello = new System.Windows.Forms.Button();
            this.btnSayHi = new System.Windows.Forms.Button();
            this.cbSex = new System.Windows.Forms.ComboBox();
            this.cbStar = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(373, 89);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 0;
            // 
            // txtEnName
            // 
            this.txtEnName.Location = new System.Drawing.Point(373, 133);
            this.txtEnName.Name = "txtEnName";
            this.txtEnName.Size = new System.Drawing.Size(100, 22);
            this.txtEnName.TabIndex = 1;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbName.Location = new System.Drawing.Point(299, 90);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(42, 21);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "姓名";
            // 
            // lbEnName
            // 
            this.lbEnName.AutoSize = true;
            this.lbEnName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbEnName.Location = new System.Drawing.Point(226, 133);
            this.lbEnName.Name = "lbEnName";
            this.lbEnName.Size = new System.Drawing.Size(115, 21);
            this.lbEnName.TabIndex = 1;
            this.lbEnName.Text = "English Name";
            // 
            // lbStar
            // 
            this.lbStar.AutoSize = true;
            this.lbStar.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbStar.Location = new System.Drawing.Point(299, 219);
            this.lbStar.Name = "lbStar";
            this.lbStar.Size = new System.Drawing.Size(42, 21);
            this.lbStar.TabIndex = 1;
            this.lbStar.Text = "星座";
            // 
            // lbSex
            // 
            this.lbSex.AutoSize = true;
            this.lbSex.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbSex.Location = new System.Drawing.Point(299, 176);
            this.lbSex.Name = "lbSex";
            this.lbSex.Size = new System.Drawing.Size(42, 21);
            this.lbSex.TabIndex = 1;
            this.lbSex.Text = "性別";
            // 
            // btnSayHello
            // 
            this.btnSayHello.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSayHello.Location = new System.Drawing.Point(252, 278);
            this.btnSayHello.Name = "btnSayHello";
            this.btnSayHello.Size = new System.Drawing.Size(126, 44);
            this.btnSayHello.TabIndex = 4;
            this.btnSayHello.Text = "say Hello";
            this.btnSayHello.UseVisualStyleBackColor = true;
            this.btnSayHello.Click += new System.EventHandler(this.btnSayHello_Click);
            // 
            // btnSayHi
            // 
            this.btnSayHi.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSayHi.Location = new System.Drawing.Point(400, 278);
            this.btnSayHi.Name = "btnSayHi";
            this.btnSayHi.Size = new System.Drawing.Size(126, 44);
            this.btnSayHi.TabIndex = 5;
            this.btnSayHi.Text = "say Hi";
            this.btnSayHi.UseVisualStyleBackColor = true;
            this.btnSayHi.Click += new System.EventHandler(this.btnSayHi_Click);
            // 
            // cbSex
            // 
            this.cbSex.FormattingEnabled = true;
            this.cbSex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cbSex.Location = new System.Drawing.Point(373, 177);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(100, 20);
            this.cbSex.TabIndex = 2;
            // 
            // cbStar
            // 
            this.cbStar.FormattingEnabled = true;
            this.cbStar.Items.AddRange(new object[] {
            "Aries(牡羊座)",
            "Taurus(金牛座)",
            "Gemini(雙子座)",
            "Cancer(巨蟹座)",
            "Leo(獅子座)",
            "Virgo(處女座)",
            "Libra(天秤座)",
            "Scorpio(天蠍座)",
            "Sagittarius(射手座)",
            "Capricorn(摩羯座)",
            "Aquarius(水瓶座)",
            "Pisces(雙魚座)"});
            this.cbStar.Location = new System.Drawing.Point(373, 219);
            this.cbStar.Name = "cbStar";
            this.cbStar.Size = new System.Drawing.Size(100, 20);
            this.cbStar.TabIndex = 3;
            // 
            // FmHello
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbStar);
            this.Controls.Add(this.cbSex);
            this.Controls.Add(this.btnSayHi);
            this.Controls.Add(this.btnSayHello);
            this.Controls.Add(this.lbSex);
            this.Controls.Add(this.lbStar);
            this.Controls.Add(this.lbEnName);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.txtEnName);
            this.Controls.Add(this.txtName);
            this.Name = "FmHello";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "FmHello";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEnName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbEnName;
        private System.Windows.Forms.Label lbStar;
        private System.Windows.Forms.Label lbSex;
        private System.Windows.Forms.Button btnSayHello;
        private System.Windows.Forms.Button btnSayHi;
        private System.Windows.Forms.ComboBox cbSex;
        private System.Windows.Forms.ComboBox cbStar;
    }
}