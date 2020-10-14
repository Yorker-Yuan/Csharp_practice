using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fm_Load
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtPrice.Text = "100000";
            txtYear.Text = "2";
            txtRate.Text = "10";
            txtFirst.Text = "0";
        }

        public double Payment(int price,int year,int rate,int first,bool pay)
        {
            bool isPrcie = int.TryParse(txtPrice.Text,out price);
            if (!isPrcie)
                MessageBox.Show("請在金額欄位輸入正確數字");
            bool isYear = int.TryParse(txtYear.Text, out year);
            if (!isYear)
                MessageBox.Show("請在期數欄位輸入正確數字");
            bool isRate = int.TryParse(txtRate.Text, out rate);
            if (!isRate)
                MessageBox.Show("請在利率欄位輸入正確數字");
            bool isFirst = int.TryParse(txtFirst.Text, out first);
            if (!isFirst)
                MessageBox.Show("請在頭期款欄位輸入正確數字");

            int Money = price - first;
            int Month = year * 12;
            double MonthRate = (10 / 100) / 12;
            double RealRate = (Math.Pow((1 + MonthRate), Month) * MonthRate) / (Math.Pow((1 + MonthRate), Month) - 1);
            double FinalMoney = Math.Round(RealRate * Money);

            if (pay)
                return FinalMoney;
            else
                return FinalMoney * Month;
        }

        private void btnMonPay_Click(object sender, EventArgs e)
        {
            clsLoad cl;
            cl.Price = int.Parse(txtPrice.Text);
            cl.Year = int.Parse(txtYear.Text);
            cl.Rate = int.Parse(txtRate.Text);
            cl.First = int.Parse(txtFirst.Text);

            MessageBox.Show("月付額:"+Payment(cl.Price,cl.Year,cl.Rate,cl.First,true));
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            clsLoad cl;
            cl.Price = int.Parse(txtPrice.Text);
            cl.Year = int.Parse(txtYear.Text);
            cl.Rate = int.Parse(txtRate.Text);
            cl.First = int.Parse(txtFirst.Text);

            MessageBox.Show("總付額:" + Payment(cl.Price, cl.Year, cl.Rate, cl.First, false));
        }

        private void btnRep_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Owner = this;
            f.Show();
        }
    }
}
