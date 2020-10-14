using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fmMain
{
    public partial class FmCal : Form
    {
        public FmCal()
        {
            InitializeComponent();
        }

        private void FmCal_Load(object sender, EventArgs e)
        {
            tbNum1.Text = "";
            tbNum2.Text = "";
            tbAns.Text = "";
        }

        int result = 0;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = int.Parse(tbNum1.Text);
                int num2 = int.Parse(tbNum2.Text);

                result = num1 + num2;
                tbAns.Text = result.ToString();
            }
            catch
            {
                MessageBox.Show("輸入格式錯誤，請重新輸入數字");
                tbNum1.Text = "";
                tbNum2.Text = "";
            }
            
        }

        private void btnLess_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = int.Parse(tbNum1.Text);
                int num2 = int.Parse(tbNum2.Text);

                result = num1 - num2;
                tbAns.Text = result.ToString();
            }
            catch
            {
                MessageBox.Show("輸入格式錯誤，請重新輸入數字");
                tbNum1.Text = "";
                tbNum2.Text = "";
            }
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = int.Parse(tbNum1.Text);
                int num2 = int.Parse(tbNum2.Text);

                result = num1 * num2;
                tbAns.Text = result.ToString();
            }
            catch
            {
                MessageBox.Show("輸入格式錯誤，請重新輸入數字");
                tbNum1.Text = "";
                tbNum2.Text = "";
            }
        }

        private void btnEx_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = int.Parse(tbNum1.Text);
                int num2 = int.Parse(tbNum2.Text);

                result = num1 / num2;
                tbAns.Text = result.ToString();
            }
            catch
            {
                MessageBox.Show("輸入格式錯誤，請重新輸入數字");
                tbNum1.Text = "";
                tbNum2.Text = "";
            }
        }
    }
}
