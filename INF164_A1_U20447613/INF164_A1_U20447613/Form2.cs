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

namespace INF164_A1_U20447613
{
    public partial class frmCalc : Form
    {
        public frmCalc()
        {
            InitializeComponent();
        }
        
        //Calculates the growth percentage required to reach the required goal.
        public double growthPercentage(int desBal)
        {
            int currentBal = Convert.ToInt32(nudBal.Value);
            int months = Convert.ToInt32(nudNumMon.Value);
            double percentageGrowth;
            percentageGrowth = ((desBal - currentBal) / months);
            return percentageGrowth;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int desGrowth = Convert.ToInt32(nudDesBal.Value);
            MessageBox.Show("You will require a monthly growth of " + growthPercentage(desGrowth) + "% to achieve your goal.");
        }

        private void btnSaveClose_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter outputfile;
                outputfile = new StreamWriter("Current_Balance.txt");
                string nudContents = nudBal.Text;
                outputfile.WriteLine(nudContents);
                outputfile.Close();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Error there was a problem with your file path.");
            }

            frmCalc.ActiveForm.Close();
        }

        private void frmCalc_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader inputfile;
                inputfile = new StreamReader("current_balance.txt");
                string inputalllines;
                inputalllines = inputfile.ReadToEnd();

                //Tell user to enter a current value is the text file is blank
                if (inputalllines.Equals("") || inputalllines.Equals("0"))
                {
                    MessageBox.Show("When the form opens, please would you enter your current balance \n \t\t" +
                        "as it sits at 0 at the moment.");
                    inputfile.Close();
                }
                else
                {
                    nudBal.Text = inputalllines;
                    inputfile.Close();
                }           
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("the file that is trying to be read does not seem to exist.");
            }
        }
    }
}
