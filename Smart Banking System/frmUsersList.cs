using BankBusinessLayer;
using BusinessLogicLayer;
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
    public partial class frmUsersList : Form
    {
        public frmUsersList()
        {
            InitializeComponent();
        }

        private void frmUsersList_Load(object sender, EventArgs e)
        {
            dgvUsers.DataSource = clsUser.GetAllUsers();

            dgvUsers.DefaultCellStyle.Font = new Font("Segoe UI", 13);
            dgvUsers.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 13, FontStyle.Bold);
            dgvUsers.EnableHeadersVisualStyles = false;
            dgvUsers.ColumnHeadersDefaultCellStyle.BackColor = Color.DimGray;
            dgvUsers.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvUsers.CellBorderStyle = DataGridViewCellBorderStyle.Single;

            if (dgvUsers.Rows.Count > 0)
            {
                dgvUsers.Columns[0].HeaderText = "User ID";

                dgvUsers.Columns[1].HeaderText = "Username";

                dgvUsers.Columns[2].HeaderText = "Permissions";

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pnlFormLoader.Controls.Clear();
            frmUsersMenu frm = new frmUsersMenu();
            frm.TopLevel = false;
            pnlFormLoader.Controls.Add(frm);
            frm.Show();
        }
    }
}
