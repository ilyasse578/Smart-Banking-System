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
    public partial class frmClientsMenu : Form
    {
        public frmClientsMenu()
        {
            InitializeComponent();
        }

        private void btnClientsList_Click(object sender, EventArgs e)
        {
            pnlFormLoader.Controls.Clear();
            frmClientsList frm = new frmClientsList();
            frm.TopLevel = false;
            pnlFormLoader.Controls.Add(frm);
            frm.Show();
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            pnlFormLoader.Controls.Clear();
            frmAddClient frm = new frmAddClient();
            frm.TopLevel = false;
            pnlFormLoader.Controls.Add(frm);
            frm.Show();
        }

        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            pnlFormLoader.Controls.Clear();
            frmUpdateClient frm = new frmUpdateClient();
            frm.TopLevel = false;
            pnlFormLoader.Controls.Add(frm);
            frm.Show();
        }

        private void btnFindClient_Click(object sender, EventArgs e)
        {
            pnlFormLoader.Controls.Clear();
            frmFindClient frm = new frmFindClient();
            frm.TopLevel = false;
            pnlFormLoader.Controls.Add(frm);
            frm.Show();
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            pnlFormLoader.Controls.Clear();
            frmDeleteClient frm = new frmDeleteClient();
            frm.TopLevel = false;
            pnlFormLoader.Controls.Add(frm);
            frm.Show();
        }
    }
}
