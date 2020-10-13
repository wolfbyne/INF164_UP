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
    public partial class frmEdit : Form
    {
        public frmEdit()
        {
            InitializeComponent();
        }

        private Book mBookEdit;

        public Book BookEdit
        {
            get { return mBookEdit; }
            set { mBookEdit = value; }
        }

        private void frmEdit_Load(object sender, EventArgs e)
        {
            txtName.Text = mBookEdit.Name;
            txtAuthor.Text = mBookEdit.Author;
            txtQuality.Text = mBookEdit.Quality;
            txtType.Text = mBookEdit.Type;
            nudYear.Value = Convert.ToDecimal(mBookEdit.YearOfPublication);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAuthor.Text) && !string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(txtQuality.Text) && !string.IsNullOrEmpty(txtType.Text) && nudYear.Value != 0)
            {
                mBookEdit.Name = txtName.Text;
                mBookEdit.Author = txtAuthor.Text;
                mBookEdit.Quality = txtQuality.Text;
                mBookEdit.Type = txtType.Text;
                mBookEdit.YearOfPublication = Convert.ToInt32(nudYear.Value);
                mBookEdit.Price = mBookEdit.PriceValue();

                this.Close();
            }
            else
            {
                MessageBox.Show("Please fill in all the fields!");
            }
        }
    }
}
