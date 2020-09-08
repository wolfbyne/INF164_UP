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
    public partial class frmEditClient : Form
    {
        frmPetsRUs frmOne;

        public frmEditClient(frmPetsRUs gridview)
        {
            InitializeComponent();
            this.frmOne = gridview;
        }

        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtClientFirstName.Text) && !string.IsNullOrEmpty(txtClientLastName.Text) && !string.IsNullOrEmpty(txtIDnum.Text) && nudCredLim.Value != 0)
            {
                try
                {
                    int paymentamount = Convert.ToInt32(frmOne.nudPaymentAmount.Value);
                    int purchaseamount = Convert.ToInt32(frmOne.nudPurchaseAmount.Value);
                    int idnum = Convert.ToInt32(txtIDnum.Text);
                    int credlim = Convert.ToInt32(nudCredLim.Value);
                    int rowindex = frmOne.dgClients.CurrentCell.RowIndex;
                    Client newClient = new Client(idnum, txtClientFirstName.Text, txtClientLastName.Text, credlim, 0);
                    frmOne.dgPets.Refresh();
                    for (int i = 0; i < frmOne.dgPets.RowCount; i++)
                    {
                        if (frmOne.dgClients[0, rowindex].Value.Equals(frmOne.dgPets[3, i].Value))
                        {
                            frmOne.dgPets[3, i].Value = newClient.IDnum;
                        }
                    }
                    frmOne.dgClients.Rows[rowindex].SetValues(new object[] { newClient.IDnum, newClient.Name, newClient.Surname, newClient.CredLimit, newClient.calcCurrentBal(paymentamount, purchaseamount) });
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("Error! There is nothing to edit.");
                }
                catch (FormatException)
                {
                    MessageBox.Show("Error! You entered a string into the ID field.");
                }
            }
            else
                MessageBox.Show("Please fill in all fields.");
        }
    }
}
