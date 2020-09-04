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
    public partial class frm164 : Form
    {
        public frm164()
        {
            InitializeComponent();
        }

        private void btnPatReg_Click(object sender, EventArgs e)
        {
            frmPatron patron = new frmPatron();
            patron.ShowDialog();
        }

        private void btnBookReg_Click(object sender, EventArgs e)
        {
            frmBookReg registerbook = new frmBookReg();
            registerbook.ShowDialog();
        }
    }
}
