using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INF164Prac05_u20447613_
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        BindingList<Instrument> myInstrument = new BindingList<Instrument>();

        private void btnVote_Click(object sender, EventArgs e)
        {
            if (dgInstument.SelectedRows.Count > 0)
            {
                int rowindex = dgInstument.CurrentCell.RowIndex;
                myInstrument[rowindex].AddVotes();
                dgInstument.Refresh();
            }
            else
                MessageBox.Show("Please make a selection");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgInstument.SelectedRows.Count > 0)
            {
                int rowindex = dgInstument.CurrentCell.RowIndex;

                frmEdit myEdit = new frmEdit();
                myEdit.EditedInstrument = myInstrument[rowindex];
                myEdit.ShowDialog();

                myInstrument[rowindex] = myEdit.EditedInstrument;
                MessageBox.Show(myEdit.EditedInstrument.Name + " has been updated!");
            }
            else
                MessageBox.Show("Please make a selection");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(dgInstument.SelectedRows.Count > 0)
            {
                try
                {
                    int rowindex = dgInstument.CurrentCell.RowIndex;
                    MessageBox.Show(myInstrument[rowindex].Name + " has been removed!");
                    myInstrument.RemoveAt(rowindex);
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("Null field, can't display message properly!");
                    int rowindex = dgInstument.CurrentCell.RowIndex;
                    myInstrument.RemoveAt(rowindex);
                }
            }
            else
                MessageBox.Show("Please make a selection");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAdd myAdd = new frmAdd();
            myAdd.ShowDialog();
            try
            {
                myInstrument.Add(myAdd.NewInstrument);
                MessageBox.Show(myAdd.NewInstrument.Name + " added!");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("You didn't fill-in any fields?");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var maxVote = myInstrument[myInstrument.Count-1];
            foreach (var instruments in myInstrument)
            {
                if (instruments.Votes.Equals(0))
                {
                    MessageBox.Show("No instrument has any votes yet");
                    break;
                }
                else if (!instruments.Votes.Equals(0))
                {
                    if (instruments.Votes > maxVote.Votes)
                    {
                        maxVote = instruments;
                    }
                    MessageBox.Show(maxVote.Name + " has the most votes with " + maxVote.Votes + "!");
                    break;
                }
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Instrument newInstrument;

            newInstrument = new Instrument("Guitar", "String", 0);
            myInstrument.Add(newInstrument);
            newInstrument = new Instrument("Trumpet", "Brass", 0);
            myInstrument.Add(newInstrument);

            dgInstument.DataSource = myInstrument;

            dgInstument.ClearSelection();
        }
    }
}
