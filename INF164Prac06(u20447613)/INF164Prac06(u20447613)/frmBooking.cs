using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INF164Prac06_u20447613_
{
    public partial class frmBooking : Form
    {
        public frmBooking()
        {
            InitializeComponent();
        }

        private Booking mNewBooking = new Booking();

        public Booking NewBooking
        {
            get { return mNewBooking; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(txtPhoneNum.Text) && !string.IsNullOrEmpty(txtSurname.Text) && !string.IsNullOrEmpty(cbBookingSesh.Text) && !string.IsNullOrEmpty(cbPaymentType.Text))
            {
                try{
                    mNewBooking.Name = txtName.Text;
                    mNewBooking.Surname = txtSurname.Text;
                    mNewBooking.PhoneNumber = Convert.ToInt32(txtPhoneNum.Text);
                    mNewBooking.Date = dtpDate.Value;
                    mNewBooking.Session = cbBookingSesh.Text;
                    mNewBooking.Type = cbPaymentType.Text;

                    this.Close();
                }
                catch (FormatException)
                {
                    MessageBox.Show("One or more fields are in the wrong format.");
                }
            }
            else
            {
                MessageBox.Show("Please fill in all of the fields here.");
            }
        }
    }
}
