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
    public partial class frmUpdate : Form
    {
        public frmUpdate()
        {
            InitializeComponent();
        }

        private Booking mBookingUpdate;

        public Booking BookingUpdate
        {
            get { return mBookingUpdate; }
            set { mBookingUpdate = value; }
        }

        private void frmUpdate_Load(object sender, EventArgs e)
        {
            txtName.Text = mBookingUpdate.Name;
            txtSurname.Text = mBookingUpdate.Surname;
            txtPhoneNum.Text = mBookingUpdate.PhoneNumber.ToString();
            dtpDate.Value = mBookingUpdate.Date;
            cbBookingSesh.Text = mBookingUpdate.Session;
            cbPaymentType.Text = mBookingUpdate.Type;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(txtPhoneNum.Text) && !string.IsNullOrEmpty(txtSurname.Text) && !string.IsNullOrEmpty(cbBookingSesh.Text) && !string.IsNullOrEmpty(cbPaymentType.Text))
            {
                mBookingUpdate.Name = txtName.Text;
                mBookingUpdate.Surname = txtSurname.Text;
                mBookingUpdate.PhoneNumber = Convert.ToInt32(txtPhoneNum.Text);
                mBookingUpdate.Date = dtpDate.Value;
                mBookingUpdate.Session = cbBookingSesh.Text;
                mBookingUpdate.Type = cbPaymentType.Text;

                this.Close();
            }
            else
            {
                MessageBox.Show("Please fill in all the fields.");
            }
        }
    }
}
