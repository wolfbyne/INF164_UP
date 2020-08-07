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

namespace INF164Prac01_u20447613_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
            StreamWriter outputfile;
            outputfile = new StreamWriter("rtb.txt");
            string rtbContents = rtbApplicationLetter.Text;
            outputfile.WriteLine(rtbContents);
            outputfile.Close();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Error there was a problem with your file path.");
            }
            rtbApplicationLetter.Visible = false;
            btnContinue.Visible = true;
            lblDegree.Visible = true;
            lblUnderOrPost.Visible = true;
            cbDegree.Visible = true;
            cbUnderOrPost.Visible = true;
            gbApply.Visible = true;
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            //Step 1
            rtbApplicationLetter.Visible = true;
            btnSubmit.Visible = true;
            lblStep2.Visible = true;
            lblComeback.Visible = true;
            //Step 2
            gbApply.Visible = false;
            btnContinue.Visible = false;
            lblDegree.Visible = false;
            lblUnderOrPost.Visible = false;
            cbDegree.Visible = false;
            cbUnderOrPost.Visible = false;
        }

        private void cbUnderOrPost_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbUnderOrPost.SelectedItem != null)
            {
                cbDegree.Enabled = true;
            }
            else
                cbDegree.Enabled = false;

            //Logic to fill the combobox with content depending on the selected option
            string[] underDegrees = { "Computer Science" , "Informatics", "Computer Engineering" };
            string[] postDegrees = { "Hons Informatics" , "Hons Computer Science" };
            if (cbUnderOrPost.Text == "Undergraduate")
            {
                cbDegree.Items.AddRange(underDegrees);
            }
            else if (cbUnderOrPost.Text == "Postgraduate")
            {
                cbDegree.Items.AddRange(postDegrees);
            }
            else
                MessageBox.Show("Error!");
        }

        private void cbDegree_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDegree.SelectedItem != null)
            {
                btnContinue.Enabled = true;
            }
            else
                btnContinue.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader inputFile;
            inputFile = new StreamReader("rtb.txt");

            string inputAllLines;

            inputAllLines = inputFile.ReadToEnd();
            rtbApplicationLetter.Text = inputAllLines;

            inputFile.Close();
        }
    }
}
