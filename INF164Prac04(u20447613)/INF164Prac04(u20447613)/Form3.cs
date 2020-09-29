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
    public partial class frmBookReg : Form
    {
        public frmBookReg()
        {
            InitializeComponent();
        }

        private void btnRegBook_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTitle.Text) && !string.IsNullOrEmpty(txtAuthor.Text) && !string.IsNullOrEmpty(cbGenre.Text))
            {
                Book newBook = new Book(txtTitle.Text, txtAuthor.Text, dtpPubDate.Text, cbGenre.Text, Convert.ToDouble(nudRating.Value));
                dgBooks.Rows.Add(newBook.Title, newBook.Author, newBook.PublishDate, newBook.Genre, newBook.Rating, newBook.eBookAvailable());
            }
            else
                MessageBox.Show("Error! One or more fields are missing.");
        }

        private void btnRatings_Click(object sender, EventArgs e)
        {
            int i;
            try
            {
                for (i = 0; i < dgBooks.RowCount; i++)
                {
                    double val = Convert.ToDouble(dgBooks[4, i].Value);
                    if (val < 2.4)
                    {
                        dgBooks[4, i].Style.BackColor = Color.Red;
                    }
                    else if (val >= 2.5 && val <= 3.9)
                    {
                        dgBooks[4, i].Style.BackColor = Color.Yellow;
                    }
                    else if (val > 3.9)
                    {
                        dgBooks[4, i].Style.ForeColor = Color.Green;
                    }
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Error!");
            }
            i = 0;
        }
    }
}
