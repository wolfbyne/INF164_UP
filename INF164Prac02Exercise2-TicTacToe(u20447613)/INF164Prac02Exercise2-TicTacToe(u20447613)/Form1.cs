using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INF164Prac02Exercise2_TicTacToe_u20447613_
{
    public partial class frmTicTacToe : Form
    {
        public frmTicTacToe()
        {
            InitializeComponent();

            // Logic for form to decide on random start player
            Random num = new Random();
            int number = num.Next(0,2);
            if (number == 0)
            {
                rbO.Checked = true;
            }
            else if (number == 1)
            {
                rbX.Checked = true;
            }
        }
        // Changes players background colour...
        public string tikkaToe(Button buttonName)
        {
            buttonName.BackColor = Color.Red;
            if (rbX.Checked == true)
            {
                buttonName.Text = "X";
                return "";
            }
            else if (rbO.Checked == true)
            {
                buttonName.Text = "O";
                return "";
            }
            else
                return "Error!";
        }
        // Changes player turns
        private void takeTurn(Button btn)
        {
            if (rbX.Checked == true)
            {
                rbO.Checked = true;
            }else if (rbO.Checked == true)
            {
                rbX.Checked = true;
            }
        }

        private void checkWin()
        {
            if ((btn1.Text.Equals("X")&&btn2.Text.Equals("X")&&btn3.Text.Equals("X")) || (btn1.Text.Equals("O") && btn2.Text.Equals("O") && btn3.Text.Equals("O")))
            {
                checkWhoWon();
                disableAllButtons();
                resetGame();
            } else if ((btn4.Text.Equals("X") && btn5.Text.Equals("X") && btn6.Text.Equals("X")) || (btn4.Text.Equals("O") && btn5.Text.Equals("O") && btn6.Text.Equals("O")))
            {
                checkWhoWon();
                disableAllButtons();
            } else if ((btn7.Text.Equals("X") && btn8.Text.Equals("X") && btn9.Text.Equals("X")) || (btn7.Text.Equals("O") && btn8.Text.Equals("O") && btn9.Text.Equals("O")))
            {
                checkWhoWon();
                disableAllButtons();
            } else if ((btn1.Text.Equals("X") && btn4.Text.Equals("X") && btn7.Text.Equals("X")) || (btn1.Text.Equals("O") && btn4.Text.Equals("O") && btn7.Text.Equals("O")))
            {
                checkWhoWon();
                disableAllButtons();
            } else if ((btn2.Text.Equals("X") && btn5.Text.Equals("X") && btn8.Text.Equals("X")) || (btn2.Text.Equals("O") && btn5.Text.Equals("O") && btn8.Text.Equals("O")))
            {
                checkWhoWon();
                disableAllButtons();
            } else if ((btn3.Text.Equals("X") && btn6.Text.Equals("X") && btn9.Text.Equals("X")) || (btn3.Text.Equals("O") && btn6.Text.Equals("O") && btn9.Text.Equals("O")))
            {
                checkWhoWon();
                disableAllButtons();
            } else if ((btn5.Text.Equals("X") && btn1.Text.Equals("X") && btn9.Text.Equals("X")) || (btn5.Text.Equals("O") && btn1.Text.Equals("O") && btn9.Text.Equals("O")))
            {
                checkWhoWon();
                disableAllButtons();
            } else if ((btn5.Text.Equals("X") && btn3.Text.Equals("X") && btn7.Text.Equals("X")) || (btn5.Text.Equals("O") && btn3.Text.Equals("O") && btn7.Text.Equals("O")))
            {
                checkWhoWon();
                disableAllButtons();
            }
        }

        private void checkWhoWon()
        {
            if (rbX.Checked == true)
            {
                MessageBox.Show(rbO.Text + " is the winner!!!");
            }else if (rbO.Checked == true)
            {
                MessageBox.Show(rbX.Text + " is the winner!!!");
            } 
        }

        private void disableAllButtons()
        {
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;
        }

        private void resetGame()
        {
            frmTicTacToe.ActiveForm.Close();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            tikkaToe(btn1);
            takeTurn(btn1);
            checkWin();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            tikkaToe(btn2);
            takeTurn(btn2);
            checkWin();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            tikkaToe(btn3);
            takeTurn(btn3);
            checkWin();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            tikkaToe(btn4);
            takeTurn(btn4);
            checkWin();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            tikkaToe(btn5);
            takeTurn(btn5);
            checkWin();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            tikkaToe(btn6);
            takeTurn(btn6);
            checkWin();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            tikkaToe(btn7);
            takeTurn(btn7);
            checkWin();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            tikkaToe(btn8);
            takeTurn(btn8);
            checkWin();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            tikkaToe(btn9);
            takeTurn(btn9);
            checkWin();
        }
    }
}
