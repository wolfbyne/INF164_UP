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
    public partial class frmEditPet : Form
    {
        frmPetsRUs frmOne;

        public frmEditPet(frmPetsRUs gridview)
        {
            InitializeComponent();
            this.frmOne = gridview;
        }

        private void btnUpdatePet_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(txtType.Text) && nudAge.Value != 0 && !string.IsNullOrEmpty(txtOwnerID.Text))
            {
                try
                {
                    Pet newPet = new Pet(txtName.Text, Convert.ToInt32(nudAge.Value), txtType.Text, Convert.ToInt32(txtOwnerID.Text));
                    int rowindex = frmOne.dgPets.CurrentCell.RowIndex;
                    frmOne.dgClients.Refresh();
                    for (int i = 0; i < frmOne.dgClients.RowCount; i++)
                    {
                        if (frmOne.dgPets[3, rowindex].Value.Equals(frmOne.dgClients[0, i].Value))
                        {
                            frmOne.dgClients[0, i].Value = txtOwnerID.Text;
                        }
                    }
                    frmOne.dgPets.Rows[rowindex].SetValues(new object[] { newPet.Name, newPet.Age, newPet.Type, newPet.IDnum });
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
