using System;
using System.Windows.Forms;

namespace INF164Prac02_u20447613_
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public int calcAge(int id)
        {
            int convertedID;
            string currentyear = DateTime.Now.Year.ToString();
            int currentYr = Convert.ToInt32(currentyear);

            if (id < 20)
            {
                convertedID = id + 2000;
            }
            else
                convertedID = id + 1900;

            return currentYr - convertedID;
        }

        public double calcBMI(double height, double weight)
        {
            double bmi = Math.Round(weight / (Math.Pow(height, 2)), 3);

            return bmi;
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtSurname.Text) || String.IsNullOrEmpty(txtName.Text) || String.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Please Fill In All Fields!");
            }
            else
            {
                string year = txtID.Text.Substring(0, 2);
                int idConvert = Convert.ToInt32(year);
                gbBMI.Enabled = true;
                if (calcAge(idConvert) >= 18)
                {
                    MessageBox.Show("Welcome " + txtName.Text + " - Age " + calcAge(idConvert) + " You are old enough to skydive!");
                }
                else
                {
                    MessageBox.Show("We are sorry " + txtName.Text + " Age " + calcAge(idConvert) + " You need to be 18 or older to skydive");
                }
            }
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double h = Convert.ToDouble(txtHeight.Text);
            double w = Convert.ToDouble(txtWeight.Text);

            double bmi = calcBMI(h, w);

            lblYourBMI.Text = "Your BMI is: \n" + bmi;

            if (bmi >= 18.4 && bmi <= 24.9)
            {
                MessageBox.Show("You are eligible to Skydive!");
            }
            else
                MessageBox.Show("Your BMI is: " + bmi + ". Unfortunately you are not eligable to Skydive");
        }
    }
}
