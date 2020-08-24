using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INF164Prac03_Part2_u20447613_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgGuess.Rows.Add(3);
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            //initiate random class and then later use it
            Random rand = new Random();

            for (int x = 0; x < dgGuess.ColumnCount; x++)
            {
                for (int y = 0; y < dgGuess.RowCount-1; y++)
                {
                    //Generate new random number for each cell
                    int random = rand.Next(0, 10);
                    dgGuess[x, y].Value = random;
                }
            }

            int total1 = 0;
            int total2 = 0;
            int total3 = 0;
            int colIndex = dgGuess.SelectedCells[0].ColumnIndex;
            for(int x = 0; x < dgGuess.RowCount; x++)
            {
                total1 += Convert.ToInt32(dgGuess[0, x].Value);
                total2 += Convert.ToInt32(dgGuess[1, x].Value);
                total3 += Convert.ToInt32(dgGuess[2, x].Value);
            }
            
            int colWinner;
            if(total1 > total2 && total1 > total3)
            {
                colWinner = 1;
            }
            else if (total2 > total1 && total2 > total3)
            {
                colWinner = 2;
            }
            else
            {
                colWinner = 3;
            }
            if (nudCol.Value.Equals(colWinner))
            {
                MessageBox.Show("You guessed Correctly!\nColumn " + colWinner + " was highest!");
            }else
                MessageBox.Show("You guessed Wrong!\nColumn " + colWinner + " was highest!");
        }
    }
}
