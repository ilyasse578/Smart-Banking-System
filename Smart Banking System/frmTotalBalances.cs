using BankBusinessLayer;
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
    public partial class frmTotalBalances : Form
    {
        public frmTotalBalances()
        {
            InitializeComponent();
        }

        private void frmTotalBalances_Load(object sender, EventArgs e)
        {
            dgvBalances.DataSource = clsClient.BalancesList();

            lblTotalBalances.Text = clsClient.TotalBalances().ToString();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pnlFormLoader.Controls.Clear();
            frmTransactionsMenu frm = new frmTransactionsMenu();
            frm.TopLevel = false;
            pnlFormLoader.Controls.Add(frm);
            frm.Show();
        }
    }
}
