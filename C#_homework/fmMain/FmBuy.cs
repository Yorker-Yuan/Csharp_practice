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
    public partial class FmBuy : Form
    {
        public FmBuy()
        {
            InitializeComponent();
            tbTotal.Text = "NT$ 0";
        }
        int w1 = 0,w2 = 0,w3 = 0,w4 = 0;
        int result = 0;

        public void showList()
        {
            string listMenu = "";
            tbTotal.Text = "NT$" + result;

            if (w1 != 0)
                listMenu += string.Format($"--------------\n{label2.Text},共{w1}支\n總計NT${w1*6600}元\n");
            if (w2 != 0)
                listMenu += string.Format($"--------------\n{label3.Text},共{w2}支\n總計NT${w1 * 2974}元\n");
            if (w3 != 0)
                listMenu += string.Format($"--------------\n{label4.Text},共{w3}支\n總計NT${w1 * 6200}元\n");
            if (w4 != 0)
                listMenu += string.Format($"--------------\n{label5.Text},共{w4}支\n總計NT${w1 * 1691}元\n");

            txtShow.Text = listMenu;
        }

        public void payment(int method)
        {
            double discount = Math.Round(result*0.9);
            DialogResult DResult;
            if (result == 0)
            {
                MessageBox.Show("尚未點餐", "付款確認", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DResult = DialogResult.No;
            }
            else
            {
                if (method == 0)
                    DResult = MessageBox.Show($"總金額:NT$ {result}", "付款確認", MessageBoxButtons.YesNo);
                else if (method == 1)
                {
                    DResult = MessageBox.Show($"總金額:NT${result}\r\n折扣後金額:NT${discount}", "付款確認", MessageBoxButtons.YesNo);
                }
                else
                {
                    MessageBox.Show("錯誤支付方式，請重新輸入");
                    DResult = DialogResult.No;
                }
                    
            }
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            payment(0);
        }

        private void btnW1_Click(object sender, EventArgs e)
        {
            result += 6600;
            w1 += 1;
            showList();
        }

        private void btnCredit_Click(object sender, EventArgs e)
        {
            payment(1);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        public void clearAll()
        {
            result = 0;
            w1 = 0;
            w2 = 0;
            w3 = 0;
            w4 = 0;
            txtShow.Text = "尚未點餐";
            tbTotal.Text = "NT$ 0";
        }


        private void btnW2_Click(object sender, EventArgs e)
        {
            result += 2974;
            w2 += 1;
            showList();
        }
        private void btnW3_Click(object sender, EventArgs e)
        {
            result += 6200;
            w3 += 1;
            showList();
        }
        private void btnW4_Click(object sender, EventArgs e)
        {
            result += 1691;
            w4 += 1;
            showList();
        }
    }
}
