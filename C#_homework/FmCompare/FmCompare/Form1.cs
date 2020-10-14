using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FmCompare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        clsGrade cg;

        private void btnStore_Click(object sender, EventArgs e)
        {
            cg.Name = tbName.Text;
            cg.ChineseGrade = int.Parse(tbCh.Text);
            cg.EnglishGrade = int.Parse(tbEn.Text);
            cg.MathGrade = int.Parse(tbMa.Text);

        }

        private void btnPresent_Click(object sender, EventArgs e)
        {
            lbShow.Text = $"\n-------------\n姓名:{cg.Name}\n國文成績:{cg.ChineseGrade}分\n英文成績:{cg.EnglishGrade}分\n數學成績:{cg.MathGrade}分";
        }

        private void btnCom_Click(object sender, EventArgs e)
        {
            lbAvg.Text = "";
            if ((cg.ChineseGrade > cg.EnglishGrade) && (cg.ChineseGrade > cg.MathGrade))
            {
                if (cg.EnglishGrade > cg.MathGrade)
                {
                    lbAvg.Text += $"最高分:國文{cg.ChineseGrade}分\n";
                    lbAvg.Text += $"最低分:數學{cg.MathGrade}分\n";
                }
                else
                {
                    lbAvg.Text += $"最高分:國文{cg.ChineseGrade}分\n";
                    lbAvg.Text += $"最低分:英文{cg.EnglishGrade}分\n";
                }

            }

            if ((cg.EnglishGrade > cg.ChineseGrade) && (cg.EnglishGrade > cg.MathGrade))
            {
                if (cg.ChineseGrade > cg.MathGrade)
                {
                    lbAvg.Text += $"最高分:英文{cg.EnglishGrade}分\n";
                    lbAvg.Text += $"最低分:數學{cg.MathGrade}分\n";
                }
                else
                {
                    lbAvg.Text += $"最高分:英文{cg.EnglishGrade}分\n";
                    lbAvg.Text += $"最低分:國文{cg.ChineseGrade}分\n";
                }
            }
                
            if ((cg.MathGrade > cg.ChineseGrade) && (cg.MathGrade > cg.EnglishGrade))
            {
                if (cg.EnglishGrade > cg.ChineseGrade)
                {
                    lbAvg.Text += $"最高分:數學{cg.MathGrade}分\n";
                    lbAvg.Text += $"最低分:國文{cg.ChineseGrade}分\n";
                }
                else
                {
                    lbAvg.Text += $"最高分:數學{cg.MathGrade}分\n";
                    lbAvg.Text += $"最低分:英文{cg.EnglishGrade}分\n";
                }
            }
                
        }
    }
}
