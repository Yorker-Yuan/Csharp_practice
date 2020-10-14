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
    public partial class FmHello : Form
    {
        public FmHello()
        {
            InitializeComponent();
        }

        private void btnSayHello_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string EnName = txtEnName.Text;
            string sex = (string)cbSex.SelectedItem;
            string star = (string)cbStar.SelectedItem;

            string result = $"Hello，{name}\n英文名字是:{EnName}\n性別是:{sex}\n星座是:{star}\n很高興認識你!!";
            MessageBox.Show(result);

        }

        private void btnSayHi_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string EnName = txtEnName.Text;
            string sex = (string)cbSex.SelectedItem;
            string star = (string)cbStar.SelectedItem;

            string result = $"Hi，{name}\n英文名字是:{EnName}\n性別是:{sex}\n星座是:{star}\n很高興認識你!!";
            MessageBox.Show(result);
        }
    }
}
