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
    public partial class frmAdd : Form
    {
        public frmAdd()
        {
            InitializeComponent();
        }

        private Instrument mNewInstrument;

        public Instrument NewInstrument
        {
            get { return mNewInstrument; }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(txtType.Text))
            {
                mNewInstrument = new Instrument(txtName.Text, txtType.Text, Convert.ToInt32(nudVotes.Value));
                this.Close();
            }
            else
                MessageBox.Show("Please fill in the fields!");
        }
    }
}
