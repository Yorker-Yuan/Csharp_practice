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
    public partial class FmOXGame : Form
    {
        bool turn = true;  // true = X ; false = O
        int count = 0;  //用來計算翻開

        public FmOXGame()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";

            turn = !turn; // X => O
            b.Enabled = false; //選完後就不得再選同一個
            count++; //紀錄點擊次數，若全點完還沒勝負就平手
            gameOver();//進行遊戲
        
        }

        private void gameOver()
        {
            DialogResult dr;
            bool winner = false;
            //水平
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (A1.Enabled == false))
                winner = true;
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (B1.Enabled == false))
                winner = true;
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (C1.Enabled == false))
                winner = true;
            //垂直
            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (A1.Enabled == false))
                winner = true;
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (A2.Enabled == false))
                winner = true;
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (A3.Enabled == false))
                winner = true;
            //對角線
            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (A1.Enabled == false))
                winner = true;
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (C1.Enabled == false))
                winner = true;

            if (winner)
            {
                disableBtn();
                string win = "";
                if (turn)
                    win = "O";
                else
                    win = "X";

                dr = MessageBox.Show($"{win}is winner!!!","Final",MessageBoxButtons.OK);
                if (dr == 0)
                    btnReset.PerformClick();
            }
            else
            {
                if (count == 9)
                {
                    MessageBox.Show("Draw ~");

                }
                   
                    
            }
        }

        private void disableBtn()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            }
            catch { }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            count = 0;
            A1.Text = A2.Text = A3.Text = "";
            A1.Enabled = A2.Enabled = A3.Enabled = true;
            B1.Text = B2.Text = B3.Text = "";
            B1.Enabled = B2.Enabled = B3.Enabled = true;
            C1.Text = C2.Text = C3.Text = "";
            C1.Enabled = C2.Enabled = C3.Enabled = true;

        }
    }
}
