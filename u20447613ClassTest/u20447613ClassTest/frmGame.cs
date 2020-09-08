using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace u20447613ClassTest
{
    public partial class frmGame : Form
    {
        public frmGame()
        {
            InitializeComponent();
        }

        //Words class wide string array & count to keep track of player progress
        string [] words = { "doors" , "believe" , "accusable" };
        int count = 0;
        int correctcount = 0;

        private void btnGo_Click(object sender, EventArgs e)
        {
            try
            {
                btnGo.Enabled = false;
                btnCheckWord.Enabled = true;
                string currentWord = words[count];

                // Creates random numbers to use as row and column index's
                Random rand = new Random();

                // Loops through the datagrid assigning each letter a random block
                for (int i = 0; i < currentWord.Length; i++)
                {
                    int rowindex = rand.Next(0, 3);
                    int colindex = rand.Next(0, 3);

                    // Checks if the cell is actually empty before assigning a value to it
                    // Reshuffles random numbers until and empty cell is found
                    if (dgWords[colindex, rowindex].Value == null)
                    {
                        dgWords[colindex, rowindex].Value = currentWord[i];
                    }
                    else if (dgWords[colindex, rowindex].Value != null)
                    {
                        while (dgWords[colindex, rowindex].Value != null)
                        {
                            rowindex = rand.Next(0, 3);
                            colindex = rand.Next(0, 3);
                        }
                        dgWords[colindex, rowindex].Value = currentWord[i];
                    }
                }
                // Each time the Go button is clicked add to count to keep track of progresss
                count++;
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Error! Array index out of range.");
            }
        }

        private void btnCheckWord_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtWord.Text))
            {
                if (txtWord.Text.Equals(words[count-1]))
                {
                    MessageBox.Show("Well done");
                    correctcount++;
                }
                else
                    MessageBox.Show("The correct word is " + words[count-1]);
            }else
                MessageBox.Show("You forgot to enter a word into the textbox.");

            // End game if count is equal to three
            if (count == 3)
            {
                MessageBox.Show("Game over");
                btnReset.Enabled = false;
                btnCheckWord.Enabled = false;
                txtWord.Clear();
                txtWord.Enabled = false;
                tsmiScore.Enabled = true;
                dgWords.Rows.Clear();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dgWords.Rows.Clear();
            txtWord.Clear();
            btnGo.Enabled = true;
            btnCheckWord.Enabled = false;
            dgWords.Rows.Add(3);
        }

        private void frmGame_Load(object sender, EventArgs e)
        {
            // Clears any datagrid selection and adds the three rows
            dgWords.Rows.Add(3);
            dgWords.ClearSelection();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Closes current form on click
            this.Close();
        }

        private void scoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You scored " + correctcount + " out of 3");
            
            // Write to text file
            try
            {
                StreamWriter outputfile;
                outputfile = new StreamWriter("scores.txt");
                string scoreContent = correctcount.ToString();
                outputfile.WriteLine(scoreContent);
                outputfile.Close();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Error there was a problem with your file path.");
            }
        }
    }
}
