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
    public partial class frmUsersMenu : Form
    {
        public frmUsersMenu()
        {
            InitializeComponent();
        }

        private void btnUsersList_Click(object sender, EventArgs e)
        {
            pnlFormLoader.Controls.Clear();
            frmUsersList frm = new frmUsersList();
            frm.TopLevel = false;
            pnlFormLoader.Controls.Add(frm);
            frm.Show();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            pnlFormLoader.Controls.Clear();
            frmAddNewUser frm = new frmAddNewUser();
            frm.TopLevel = false;
            pnlFormLoader.Controls.Add(frm);
            frm.Show();
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            pnlFormLoader.Controls.Clear();
            frmUpdateUser frm = new frmUpdateUser();
            frm.TopLevel = false;
            pnlFormLoader.Controls.Add(frm);
            frm.Show();
        }

        private void btnFindUser_Click(object sender, EventArgs e)
        {
            pnlFormLoader.Controls.Clear();
            frmFindUser frm = new frmFindUser();
            frm.TopLevel = false;
            pnlFormLoader.Controls.Add(frm);
            frm.Show();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            pnlFormLoader.Controls.Clear();
            frmDeleteUser frm = new frmDeleteUser();
            frm.TopLevel = false;
            pnlFormLoader.Controls.Add(frm);
            frm.Show();
        }
    }
}
