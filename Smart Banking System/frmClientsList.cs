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
    public partial class frmClientsList : Form
    {
        public frmClientsList()
        {
            InitializeComponent();
        }

        private void frmClientsList_Load(object sender, EventArgs e)
        {
            dgvClients.DataSource = clsClient.ClientsList();

            dgvClients.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvClients.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            dgvClients.EnableHeadersVisualStyles = false;
            dgvClients.ColumnHeadersDefaultCellStyle.BackColor = Color.DimGray;
            dgvClients.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvClients.CellBorderStyle = DataGridViewCellBorderStyle.Single;

            if (dgvClients.Rows.Count > 0)
            {

                dgvClients.Columns[0].HeaderText = "Client ID";

                dgvClients.Columns[1].HeaderText = "Account No.";


                dgvClients.Columns[2].HeaderText = "Pin Code";

                dgvClients.Columns[3].HeaderText = "First Name";


                dgvClients.Columns[4].HeaderText = "Last Name";

                dgvClients.Columns[5].HeaderText = "Phone";

                dgvClients.Columns[6].HeaderText = "Email";
                

                dgvClients.Columns[7].HeaderText = "Balance";
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pnlFormLoader.Controls.Clear();
            frmClientsMenu frm = new frmClientsMenu();
            frm.TopLevel = false;
            pnlFormLoader.Controls.Add(frm);
            frm.Show();
        }

        
    }
}
