using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INF164Prac04_u20447613_
{
    public partial class frmPatron : Form
    {
        public frmPatron()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtName.Text)&&!string.IsNullOrEmpty(txtSurname.Text)&&!string.IsNullOrEmpty(txtPhoneNumber.Text)&&nudAge.Value!=0)
            {
                int count = dgPatrons.RowCount;
                Patron newPatron = new Patron(txtName.Text, txtSurname.Text, txtPhoneNumber.Text, Convert.ToInt32(nudAge.Value));
                dgPatrons.Rows.Add(count, newPatron.Name, newPatron.Surname, newPatron.Phonenumber, newPatron.Age, newPatron.getPatronType());
            }
            else
                MessageBox.Show("Error! One or more fields are missing.");
        }
    }
}
