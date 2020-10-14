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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lbPrice.Text = ((Form1)this.Owner).txtPrice.Text;
            lbYear.Text = ((Form1)this.Owner).txtYear.Text;
            lbRate.Text = ((Form1)this.Owner).txtRate.Text;
            string lbFirst = ((Form1)this.Owner).txtFirst.Text;

            lbMonthPay.Text = ((Form1)this.Owner).Payment(int.Parse(lbPrice.Text),int.Parse(lbYear.Text),int.Parse(lbRate.Text),int.Parse(lbFirst),true).ToString();
            lbTotalPay.Text = ((Form1)this.Owner).Payment(int.Parse(lbPrice.Text), int.Parse(lbYear.Text), int.Parse(lbRate.Text), int.Parse(lbFirst), false).ToString();
        }
    }
}
