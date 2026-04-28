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
    public partial class frmFindClient : Form
    {
        public frmFindClient()
        {
            InitializeComponent();
        }
        private void _EnableSearch()
        {
            btnSearch.Enabled = tbAccountNumber.Text != "";
        }

        private void tbAccountNumber_TextChanged(object sender, EventArgs e)
        {
            _EnableSearch();
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(clsClient.isClientExist(tbAccountNumber.Text))
            {
                clsClient _Client = clsClient.FindByAccountNumber(tbAccountNumber.Text);    
                tbFirstName.Text = _Client.FirstName;
                tbLastName.Text = _Client.LastName;
                tbPhoneNumber.Text = _Client.Phone;
                tbEmail.Text = _Client.Email;
                tbPinCode.Text = _Client.PinCode;
                tbBalance.Text = _Client.Balance.ToString();
            }

            else
            {
                MessageBox.Show("Client not found!", "Find Client", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbAccountNumber.Text = "";
            tbFirstName.Text = "";
            tbLastName.Text = "";
            tbPhoneNumber.Text = "";
            tbEmail.Text = "";
            tbPinCode.Text = "";
            tbBalance.Text = "";
        }

        private void tbAccountNumber_Validating(object sender, CancelEventArgs e)
        {
            if (!tbAccountNumber.Text.All(char.IsLetterOrDigit))
            {
                e.Cancel = true;
                tbAccountNumber.Focus();
                errorProvider1.SetError(tbAccountNumber, "Please enter a valid Account Number!");
                btnSearch.Enabled = false;
            }

            else
            {
                errorProvider1.SetError(tbAccountNumber, "");
            }
        }
    }
}
