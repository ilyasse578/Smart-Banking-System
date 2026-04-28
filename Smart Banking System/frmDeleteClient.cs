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
    public partial class frmDeleteClient : Form
    {
        public frmDeleteClient()
        {
            InitializeComponent();
        }

        private void _EnableSearch()
        {
            btnSearchDelete.Enabled = tbAccountNumber.Text != "";
        }

        private void tbAccountNumber_TextChanged(object sender, EventArgs e)
        {
            _EnableSearch();

        }
        private void tbAccountNumber_Validating(object sender, CancelEventArgs e)
        {
            if (!tbAccountNumber.Text.All(char.IsLetterOrDigit))
            {
                e.Cancel = true;
                tbAccountNumber.Focus();
                errorProvider1.SetError(tbAccountNumber, "Please enter a valid Account Number!");
                btnSearchDelete.Enabled = false;
            }

            else
            {
                errorProvider1.SetError(tbAccountNumber, "");
            }
        }

        clsClient _Client = new clsClient();

        private void btnSearchDelete_Click(object sender, EventArgs e)
        {
            switch (btnSearchDelete.Text)
            {
                case "Search":

                    if (clsClient.isClientExist(tbAccountNumber.Text))
                    {
                        _Client = clsClient.FindByAccountNumber(tbAccountNumber.Text);
                        tbFirstName.Text = _Client.FirstName;
                        tbLastName.Text = _Client.LastName;
                        tbPhoneNumber.Text = _Client.Phone;
                        tbEmail.Text = _Client.Email;
                        tbPinCode.Text = _Client.PinCode;
                        tbBalance.Text = _Client.Balance.ToString();

                        btnSearchDelete.Text = "Delete";
                        tbAccountNumber.Enabled = false;

                    }

                    else
                    {
                        MessageBox.Show("Client not found!", "Delete Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    break;

                case "Delete":

                    if(MessageBox.Show("Are you sure you want to delete this client?", "Delete Client", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (clsClient.Delete(_Client.ClientID))
                        {
                            MessageBox.Show("Client deleted successfully!", "Delete Client", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            tbAccountNumber.Enabled = true;
                            tbAccountNumber.Text = "";
                            tbFirstName.Text = "";
                            tbPhoneNumber.Text = "";
                            tbPhoneNumber.Text = "";
                            tbEmail.Text = "";
                            tbPinCode.Text = "";
                            tbBalance.Text = "";
                            btnSearchDelete.Text = "Search";
                        }
                    }

                    break;

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
            tbAccountNumber.Enabled = true;
            tbAccountNumber.Text = "";
            tbFirstName.Text = "";
            tbPhoneNumber.Text = "";
            tbPhoneNumber.Text = "";
            tbEmail.Text = "";
            tbPinCode.Text = "";
            tbBalance.Text = "";
            btnSearchDelete.Text = "Search";

        }


    }

}
