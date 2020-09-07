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
    public partial class frmAddClient : Form
    {
        frmPetsRUs frmOne;

        public frmAddClient(frmPetsRUs gridview)
        {
            InitializeComponent();
            this.frmOne = gridview;
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtClientFirstName.Text) && !string.IsNullOrEmpty(txtClientLastName.Text) && !string.IsNullOrEmpty(txtIDnum.Text) && nudCredLim.Value != 0)
            {
                try {
                int paymentamount = Convert.ToInt32(frmOne.nudPaymentAmount.Value);
                int purchaseamount = Convert.ToInt32(frmOne.nudPurchaseAmount.Value);
                int idnum = Convert.ToInt32(txtIDnum.Text);
                int credlim = Convert.ToInt32(nudCredLim.Value);
                Client newClient = new Client(idnum, txtClientFirstName.Text, txtClientLastName.Text, credlim, 0);
                frmOne.dgClients.Rows.Add(newClient.IDnum, newClient.Name, newClient.Surname, newClient.CredLimit, newClient.calcCurrentBal(paymentamount, purchaseamount));
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
