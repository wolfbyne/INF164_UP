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
using System.Runtime.Serialization.Formatters.Binary;

namespace INF164Prac06_u20447613_
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        BindingList<Booking> bookings = new BindingList<Booking>();

        public void SerializeBookings()
        {
            FileStream fileStream = new FileStream("bookings.ser", FileMode.Create, FileAccess.Write);
            BinaryFormatter bFormatter = new BinaryFormatter();
            bFormatter.Serialize(fileStream, bookings);
            fileStream.Close();
        }

        private void btnSpringClean_Click(object sender, EventArgs e)
        {
            Booking newBooking;
            frmBooking myBooking = new frmBooking();
            myBooking.ShowDialog();
            newBooking = myBooking.NewBooking;
            bookings.Add(newBooking);
            SerializeBookings();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvBookings.CurrentCell != null)
            {
                int rowindex = dgvBookings.CurrentCell.RowIndex;
                Booking BookUpdate = bookings[rowindex];
                frmUpdate myUpdate = new frmUpdate();
                myUpdate.BookingUpdate = BookUpdate;
                myUpdate.ShowDialog();
                bookings[rowindex] = myUpdate.BookingUpdate;

            }
            else
            {
                MessageBox.Show("Please select a booking to update");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvBookings.CurrentCell != null)
            {
                bookings.RemoveAt(dgvBookings.CurrentCell.RowIndex);
                SerializeBookings();
                MessageBox.Show("Booking Deleted");
            }
            else
            {
                MessageBox.Show("Please select a boking to delete");
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fileStream = new FileStream("bookings.ser", FileMode.Open, FileAccess.Read);
                BinaryFormatter bFormatter = new BinaryFormatter();
                bookings.Clear();
                var tempBookings = (BindingList<Booking>)bFormatter.Deserialize(fileStream);
                foreach (Booking b in tempBookings)
                {
                    bookings.Add(b);
                }
                fileStream.Close();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("The file could not be found");
            }
            dgvBookings.DataSource = bookings;
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            SerializeBookings();
        }
    }
}
