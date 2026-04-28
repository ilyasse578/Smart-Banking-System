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
    public partial class frmWithdraw : Form
    {
        public frmWithdraw()
        {
            InitializeComponent();
        }

        private void tbAccountNumber_Validating(object sender, CancelEventArgs e)
        {
            if (!tbAccountNumber.Text.All(char.IsLetterOrDigit))
            {
                e.Cancel = true;
                tbAccountNumber.Focus();
                errorProvider1.SetError(tbAccountNumber, "Please enter a valid Account Number!");
                btnSearchWithdraw.Enabled = false;
            }

            else
            {
                if (btnSearchWithdraw.Text == "Search")
                {
                    btnSearchWithdraw.Enabled = true;
                }

                errorProvider1.SetError(tbAccountNumber, "");
            }

        }

        private void _EnableWithdraw()
        {
            btnSearchWithdraw.Enabled = tbAmountToWithdraw.Text != "";
        }

        private void tbAccountNumber_TextChanged(object sender, EventArgs e)
        {
            if (btnSearchWithdraw.Text == "Search")
            {
                btnSearchWithdraw.Enabled = tbAccountNumber.Text != "";

            }

            if (btnSearchWithdraw.Text == "Withdraw")
            {
                _EnableWithdraw();

            }
        }

        private void tbAmountToWithdraw_Validating(object sender, CancelEventArgs e)
        {
            decimal balance;

            if (!decimal.TryParse(tbAmountToWithdraw.Text, out balance))
            {
                e.Cancel = true;
                tbBalance.Focus();
                errorProvider1.SetError(tbAmountToWithdraw, "Please enter a valid value.");
            }

            else
            {
                errorProvider1.SetError(tbAmountToWithdraw, "");
            }
        }

        private void tbAmountToWithdraw_TextChanged(object sender, EventArgs e)
        {
            _EnableWithdraw();
        }

        private clsClient _Client;

        private void btnSearchWithdraw_Click(object sender, EventArgs e)
        {
            switch (btnSearchWithdraw.Text)
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

                        btnSearchWithdraw.Text = "Withdraw";
                        btnSearchWithdraw.Enabled = false;
                        btnClear.Enabled = true;
                        tbAmountToWithdraw.Enabled = true;
                        tbAccountNumber.Enabled = false;
                    }

                    else
                    {
                        MessageBox.Show("Client not found!", "Update Client", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }

                    break;

                case "Withdraw":

                    _Client.Balance -= Convert.ToDecimal(tbAmountToWithdraw.Text);

                    if (_Client.Save())
                    {
                        MessageBox.Show("DONE!", "Withdraw", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        ResetControls();

                    }
                    break;

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
            tbAmountToWithdraw.Text = "";
            btnSearchWithdraw.Text = "Search";
            tbAccountNumber.Enabled = true;
            tbAmountToWithdraw.Enabled = false;
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
