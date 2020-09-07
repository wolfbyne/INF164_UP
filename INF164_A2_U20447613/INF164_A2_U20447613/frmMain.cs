using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INF164_A2_U20447613
{
    public partial class frmPetsRUs : Form
    {
        public frmPetsRUs()
        {
            InitializeComponent();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            frmAddClient addclient = new frmAddClient(this);
            addclient.ShowDialog();
        }

        private void btnEditPet_Click(object sender, EventArgs e)
        {
            frmEditPet editpet = new frmEditPet(this);
            editpet.ShowDialog();
        }

        private void btnEditClient_Click(object sender, EventArgs e)
        {
            frmEditClient editclient = new frmEditClient(this);
            editclient.ShowDialog();
        }

        private void btnAddPet_Click(object sender, EventArgs e)
        {
            frmAddPet addpet = new frmAddPet(this);
            addpet.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int rowindex = dgClients.CurrentCell.RowIndex;
                int currentBalOwed = Convert.ToInt32(dgClients[4, rowindex].Value);
                if (nudPaymentAmount.Value > currentBalOwed)
                {
                    MessageBox.Show("Error! You are trying to pay more than you owe.");
                }
                else
                    dgClients[4, rowindex].Value = Convert.ToInt32(dgClients[4, rowindex].Value) - Convert.ToInt32(nudPaymentAmount.Value);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Error! Something went wrong");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Error! There is no row from the datagrid selected.");
            }
        }

        private void btnMakePurchase_Click(object sender, EventArgs e)
        {
            try
            {
                int rowindex = dgClients.CurrentCell.RowIndex;
                int currentBalOwed = Convert.ToInt32(dgClients[4, rowindex].Value);
                int credbal = Convert.ToInt32(dgClients[3,rowindex].Value);
                if ((currentBalOwed + Convert.ToInt32(nudPurchaseAmount.Value)) > credbal)
                {
                    MessageBox.Show("Error! The credit limit cannot be exceeded.");
                }
                else
                    dgClients[4, rowindex].Value = Convert.ToInt32(dgClients[4, rowindex].Value) + Convert.ToInt32(nudPurchaseAmount.Value);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Error! There is no row from the datagrid selected.");
            }
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            try
            {
                int rowindex = dgClients.CurrentCell.RowIndex;
                for (int i = 0; i < dgPets.RowCount; i++)
                {
                    if (dgClients[0, rowindex].Value.Equals(dgPets[3, i].Value))
                    {
                        dgPets[3, i].Value = "NO OWNER";
                    }
                }
                dgClients.Rows.RemoveAt(rowindex);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("There are no more rows left to delete / No row is selected");
            }
        }

        private void btnDeletePet_Click(object sender, EventArgs e)
        {
            try
            {
                int rowindex = dgPets.CurrentCell.RowIndex;
                dgPets.Rows.RemoveAt(rowindex);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("There are no more rows left to delete / No row is selected");
            }
        }

        private void dgClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dgPetsMatched.Rows.Clear();
                dgPetsMatched.Refresh();
                int rowindex = dgClients.CurrentCell.RowIndex;
                string firstname = dgClients[1, rowindex].Value.ToString();
                string lastname = dgClients[2, rowindex].Value.ToString();
                int credLim = Convert.ToInt32(dgClients[3, rowindex].Value);

                for (int i = 0; i < dgPets.RowCount; i++)
                {
                    if (dgClients[0, rowindex].Value.ToString().Equals(dgPets[3, i].Value.ToString()))
                    {
                        dgPetsMatched.Visible = true;
                        lblDataGridDescription.Text = firstname + " " + lastname + " has R" + credLim + " credit remaining";
                        dgPetsMatched.Rows.Add(dgPets[0, i].Value, dgPets[1, i].Value, dgPets[2, i].Value, dgPets[3, i].Value);
                    }
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("There are no more rows left to delete / No row is selected");
            }
        }
    }
}