using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INF164Prac03_u20447613_
{
    public partial class frmSalesCore : Form
    {
        public frmSalesCore()
        {
            InitializeComponent();
        }

        private void frmSalesCore_Load(object sender, EventArgs e)
        {
            dgSales.Rows.Add(3);
            //Headers
            dgSales.Rows[0].HeaderCell.Value = "Donald";
            dgSales.Rows[1].HeaderCell.Value = "Cyril";
            dgSales.Rows[2].HeaderCell.Value = "Boris";
            dgSales.RowHeadersWidth = 70;
            //Jan
            dgSales[0, 0].Value = 100;
            dgSales[0, 1].Value = 200;
            dgSales[0, 2].Value = 200;
            //Feb
            dgSales[1, 0].Value = 200;
            dgSales[1, 1].Value = 380;
            dgSales[1, 2].Value = 250;
            //March
            dgSales[2, 0].Value = 150;
            dgSales[2, 1].Value = 400;
            dgSales[2, 2].Value = 150;
            //April
            dgSales[3, 0].Value = 300;
            dgSales[3, 1].Value = 350;
            dgSales[3, 2].Value = 310;
            //May
            dgSales[4, 0].Value = 475;
            dgSales[4, 1].Value = 500;
            dgSales[4, 2].Value = 450;
            //June
            dgSales[5, 0].Value = 800;
            dgSales[5, 1].Value = 700;
            dgSales[5, 2].Value = 750;
            //July
            dgSales[6, 0].Value = 300;
            dgSales[6, 1].Value = 1000;
            dgSales[6, 2].Value = 500;
            //August
            dgSales[7, 0].Value = 400;
            dgSales[7, 1].Value = 1100;
            dgSales[7, 2].Value = 400;
        }

        private void btnCalcBestSeller_Click(object sender, EventArgs e)
        {
            int average1 = 0;
            int average2 = 0;
            int average3 = 0;
            for (int x = 0; x < dgSales.ColumnCount; x++)
            {
                for (int y = 0; y < dgSales.RowCount-1; y++)
                {
                    if (y==0)
                    {
                        average1 += Convert.ToInt32(dgSales[x, y].Value);
                    } else if (y == 1)
                    {
                        average2 += Convert.ToInt32(dgSales[x, y].Value);
                    } else if (y == 2)
                    {
                        average3 += Convert.ToInt32(dgSales[x,y].Value);
                    }
                }
            }
            double max = 0;
            int count = 0;
            for (int i = 0; i < dgSales.RowCount-1; i++)
            {
                if (average1>average2 && average1>average3)
                {
                    max = average1;
                    count=0;
                } else if (average2 > average1 && average2 > average3)
                {
                    max = average2;
                    count = 1;
                }
                else
                {
                    max = average3;
                    count = 2;
                }
            }
            MessageBox.Show("The best sales person is " + dgSales.Rows[count].HeaderCell.Value + " with an average of R" + max/dgSales.ColumnCount);
        }

        private void btnCalcWorstSeller_Click(object sender, EventArgs e)
        {
            int average1 = 0;
            int average2 = 0;
            int average3 = 0;
            for (int x = 0; x < dgSales.ColumnCount; x++)
            {
                for (int y = 0; y < dgSales.RowCount - 1; y++)
                {
                    if (y == 0)
                    {
                        average1 += Convert.ToInt32(dgSales[x, y].Value);
                    }
                    else if (y == 1)
                    {
                        average2 += Convert.ToInt32(dgSales[x, y].Value);
                    }
                    else if (y == 2)
                    {
                        average3 += Convert.ToInt32(dgSales[x, y].Value);
                    }
                }
            }
            double min = 0;
            int count = 0;
            for (int i = 0; i < dgSales.RowCount - 1; i++)
            {
                if (average1 < average2 && average1 < average3)
                {
                    min = average1;
                    count = 0;
                }
                else if (average2 < average1 && average2 < average3)
                {
                    min = average2;
                    count = 1;
                }
                else
                {
                    min = average3;
                    count = 2;
                }
            }
            MessageBox.Show("The worst sales person is " + dgSales.Rows[count].HeaderCell.Value + " with an average of R" + min / dgSales.ColumnCount);
        }

        private void btnCalcSelectAverg_Click(object sender, EventArgs e)
        {
            double average = 0;
            int rowIndex = dgSales.SelectedCells[0].RowIndex;
            for (int x = 0; x < dgSales.ColumnCount; x++)
            {
                    average += Convert.ToInt32(dgSales[x, rowIndex].Value);
            }
            MessageBox.Show("The worst sales person is " + dgSales.Rows[rowIndex].HeaderCell.Value + " with an average of R" + average / dgSales.ColumnCount);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSellerName.Text))
            {
                int rowIndex = dgSales.SelectedCells[0].RowIndex;
                string name = txtSellerName.Text;
                dgSales.Rows[rowIndex].HeaderCell.Value = name;

                MessageBox.Show("Seller name updated successfully");

                txtSellerName.Clear();
                txtSellerName.Focus();
            }
            else
                MessageBox.Show("Sorry! Please fill in the name field first.");
        }
    }
}