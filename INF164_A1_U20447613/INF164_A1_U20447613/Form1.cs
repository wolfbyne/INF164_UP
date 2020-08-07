using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INF164_A1_U20447613
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            frmCalc calc = new frmCalc();
            calc.ShowDialog();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            frmStocks stocks = new frmStocks();
            stocks.ShowDialog();
        }
    }
}
