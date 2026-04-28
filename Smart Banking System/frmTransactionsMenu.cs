using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_C_
{
    public partial class frmTransactionsMenu : Form
    {
        public frmTransactionsMenu()
        {
            InitializeComponent();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            pnlFormLoader.Controls.Clear();
            frmDeposit frm = new frmDeposit();
            frm.TopLevel = false;
            pnlFormLoader.Controls.Add(frm);
            frm.Show();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            pnlFormLoader.Controls.Clear();
            frmWithdraw frm = new frmWithdraw();
            frm.TopLevel = false;
            pnlFormLoader.Controls.Add(frm);
            frm.Show();
        }

        private void btnTotalBalances_Click(object sender, EventArgs e)
        {
            pnlFormLoader.Controls.Clear();
            frmTotalBalances frm = new frmTotalBalances();
            frm.TopLevel = false;
            pnlFormLoader.Controls.Add(frm);
            frm.Show();
        }
    }
}
