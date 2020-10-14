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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;  //設定為起始容器
        }

        private void btnHome01_Click(object sender, EventArgs e)
        {
            FmHello f = new FmHello();
            f.MdiParent = this;  //f 認定form1為其父表單
            f.Parent = panel2;
            f.Show();
        }

        private void btnHome03_Click(object sender, EventArgs e)
        {
            FmBuy f = new FmBuy();
            f.MdiParent = this;  //f 認定form1為其父表單
            f.Parent = panel2;
            f.Show();
        }

        private void btnHome04_Click(object sender, EventArgs e)
        {
            FmOXGame f = new FmOXGame();
            f.MdiParent = this;  //f 認定form1為其父表單
            f.Parent = panel2;
            f.Show();
        }

        private void btnHome05_Click(object sender, EventArgs e)
        {
            FmCal f = new FmCal();
            f.MdiParent = this;
            f.Parent = panel2;
            f.Show();
        }

        private void btnHome06_Click(object sender, EventArgs e)
        {
            FmCompare f = new FmCompare();
            f.MdiParent = this;  //f 認定form1為其父表單
            f.Parent = panel2;
            f.Show();
        }

        private void btnHome07_Click(object sender, EventArgs e)
        {
            FmAdd f = new FmAdd();
            f.MdiParent = this;  //f 認定form1為其父表單
            f.Parent = panel2;
            f.Show();
        }

        private void btnHome08_Click(object sender, EventArgs e)
        {
            FmArray f = new FmArray();
            f.MdiParent = this;  //f 認定form1為其父表單
            f.Parent = panel2;
            f.Show();
        }
    }
}
