using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INF164_A1_U20447613
{ 
    public partial class frmStocks : Form
    {
        public frmStocks()
        {
            InitializeComponent();
        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            if (txtStockName.Text == "" || nud2017.Value.Equals(0) || nud2018.Value.Equals(0) || nud2019.Value.Equals(0))
            {
                MessageBox.Show("You have left one or more of the fields blank!");
            }
            else
            {
                dgStocks.Rows.Add(txtStockName.Text,nud2017.Value,nud2018.Value,nud2019.Value);
                MessageBox.Show(txtStockName.Text + " has been added to the table.");
            }
        }

        private void btnCalculateChange_Click(object sender, EventArgs e)
        {
            try
            {
                string[] stockRow = new string[4];
                double percentGrowth = Math.Round(((Convert.ToDouble(dgStocks.SelectedCells[3].Value) - Convert.ToDouble(dgStocks.SelectedCells[1].Value)) / Convert.ToDouble(dgStocks.SelectedCells[1].Value)) * 100, 2);
                MessageBox.Show(dgStocks.SelectedCells[0].Value.ToString() + " has grown by " + percentGrowth + "%");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Error. No cell is selected OR there is no data in the cell you have selected.");
            }
            catch(ArgumentOutOfRangeException)
            {
                MessageBox.Show("Error. You need to select a row!");
            }
        }

        private void frmStocks_Load(object sender, EventArgs e)
        {
            dgStocks.Rows.Add("Stock 1",10,20,30);
            dgStocks.Rows.Add("Stock 2", 15, 12, 14);
            dgStocks.Rows.Add("Stock 3", 20, 15, 10);
        }
    }
}
