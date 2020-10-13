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

namespace u20447613ClassTest2
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        BindingList<Book> books = new BindingList<Book>();


        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Read the serialised data for all the books
                FileStream fileStream = new FileStream("books.ser", FileMode.Open, FileAccess.Read);
                BinaryFormatter bFormatter = new BinaryFormatter();
                books.Clear();
                var tempBooks = (BindingList<Book>)bFormatter.Deserialize(fileStream);
                foreach (Book b in tempBooks)
                {
                    books.Add(b);
                }
                fileStream.Close();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("File not found, sorry!");
            }

            dgvBooks.DataSource = books;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Uses the alrady made function and calls it in order to write to the file and save the latest data
            SerializeBooks();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Close the form when clicked 
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Open and create a new instance of the add form when clicked
            Book newBook;
            frmAdd myAdd = new frmAdd();
            myAdd.ShowDialog();
            newBook = myAdd.NewBook;
            books.Add(newBook);
            SerializeBooks();
        }

        public void SerializeBooks()
        {
            // Writes to the file to save the information to books.ser
            FileStream fileStream = new FileStream("books.ser", FileMode.Create, FileAccess.Write);
            BinaryFormatter bFormatter = new BinaryFormatter();
            bFormatter.Serialize(fileStream, books);
            fileStream.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvBooks.CurrentCell != null)
            {
                books.RemoveAt(dgvBooks.CurrentCell.RowIndex);
                SerializeBooks();
                MessageBox.Show("Book Deleted");
            }
            else
            {
                MessageBox.Show("Please select a book!");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Checks that a cell is actually selected
            if (dgvBooks.CurrentCell != null)
            {
                // Creates the object of Book, BookEdit and then uses it to updates the values of that current row
                Book BookEdit = books[dgvBooks.CurrentCell.RowIndex];
                frmEdit myEdit = new frmEdit();
                myEdit.BookEdit = BookEdit;
                myEdit.ShowDialog();
                books[dgvBooks.CurrentCell.RowIndex] = myEdit.BookEdit;
                SerializeBooks();
            }
            else
            {
                MessageBox.Show("Please select a book to update");
            }
        }
    }
}
