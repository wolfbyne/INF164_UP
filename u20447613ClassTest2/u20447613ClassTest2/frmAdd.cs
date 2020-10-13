using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace u20447613ClassTest2
{
    public partial class frmAdd : Form
    {
        public frmAdd()
        {
            InitializeComponent();
        }
        // Creates the private object of the class Book
        private Book mNewBook = new Book();

        public Book NewBook
        {
            get { return mNewBook; }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Makes sure all fields are filled in
            if (!string.IsNullOrEmpty(txtAuthor.Text) && !string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(txtQuality.Text) && !string.IsNullOrEmpty(txtType.Text) && nudYear.Value != 0)
            {
                // Assignes each member of the class to its respective field from the form
                mNewBook.Name = txtName.Text;
                mNewBook.Author = txtAuthor.Text;
                mNewBook.Type = txtType.Text;
                mNewBook.Quality = txtQuality.Text;
                mNewBook.YearOfPublication = Convert.ToInt32(nudYear.Value);
                mNewBook.Price = mNewBook.PriceValue();

                this.Close();
            }
            else
            {
                MessageBox.Show("Please fill in all the fields!");
            }
        }
    }
}
