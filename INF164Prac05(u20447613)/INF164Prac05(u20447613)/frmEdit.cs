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
    public partial class frmEdit : Form
    {
        public frmEdit()
        {
            InitializeComponent();
        }

        private Instrument mEditedInstrument;

        public Instrument EditedInstrument
        {
            get { return mEditedInstrument; }
            set { mEditedInstrument = value; }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            EditedInstrument = new Instrument(txtName.Text, txtType.Text, Convert.ToInt32(nudVotes.Value));
            this.Close();
        }

        private void frmEdit_Load(object sender, EventArgs e)
        {
            txtName.Text = EditedInstrument.Name;
            txtType.Text = EditedInstrument.Type;
            nudVotes.Value = Convert.ToDecimal(EditedInstrument.Votes);
        }
    }
}
