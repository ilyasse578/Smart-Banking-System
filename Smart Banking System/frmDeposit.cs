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
    public partial class frmDeposit : Form
    {
        public frmDeposit()
        {
            InitializeComponent();
        }
        private void _EnableDeposit()
        {
            btnSearchDeposit.Enabled = tbAmountToDeposit.Text != "";
        }

        private void tbAccountNumber_TextChanged(object sender, EventArgs e)
        {
            if (btnSearchDeposit.Text == "Search")
            {
                btnSearchDeposit.Enabled = tbAccountNumber.Text != "";

            }

            if (btnSearchDeposit.Text == "Deposit")
            {
                _EnableDeposit();

            }
        }

        private void tbAccountNumber_Validating(object sender, CancelEventArgs e)
        {
            if (!tbAccountNumber.Text.All(char.IsLetterOrDigit))
            {
                e.Cancel = true;
                tbAccountNumber.Focus();
                errorProvider1.SetError(tbAccountNumber, "Please enter a valid Account Number!");
                btnSearchDeposit.Enabled = false;
            }

            else
            {
                if (btnSearchDeposit.Text == "Search")
                {
                    btnSearchDeposit.Enabled = true;
                }

                errorProvider1.SetError(tbAccountNumber, "");
            }
        }

        private clsClient _Client;

        private void btnSearchDeposit_Click(object sender, EventArgs e)
        {
            switch (btnSearchDeposit.Text)
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

                        btnSearchDeposit.Text = "Deposit";
                        btnSearchDeposit.Enabled = false;
                        btnClear.Enabled = true;
                        tbAmountToDeposit.Enabled = true;
                        tbAccountNumber.Enabled = false;
                    }

                    else
                    {
                        MessageBox.Show("Client not found!", "Update Client", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }

                    break;

                case "Deposit":

                    _Client.Balance += Convert.ToDecimal(tbAmountToDeposit.Text);

                    if (_Client.Save())
                    {
                        MessageBox.Show("DONE!", "Deposit", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        ResetControls();

                    }
                    break;

            }
        }

        private void tbBalanceToDeposit_TextChanged(object sender, EventArgs e)
        {
            _EnableDeposit();
        }

        private void tbBalanceToDeposit_Validating(object sender, CancelEventArgs e)
        {
            decimal balance;

            if (!decimal.TryParse(tbAmountToDeposit.Text, out balance))
            {
                e.Cancel = true;
                tbBalance.Focus();
                errorProvider1.SetError(tbAmountToDeposit, "Please enter a valid value.");
            }

            else
            {
                errorProvider1.SetError(tbAmountToDeposit, "");
            }
        }

        private void ResetControls()
        {
            tbAccountNumber.Text = "";
            tbFirstName.Text = "";
            tbLastName.Text = "";
            tbPhoneNumber.Text = "";
            tbEmail.Text = "";
            tbPinCode.Text = "";
            tbBalance.Text = "";
            tbAmountToDeposit.Text = "";
            btnSearchDeposit.Text = "Search";
            tbAccountNumber.Enabled = true;
            tbAmountToDeposit.Enabled = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ResetControls();

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