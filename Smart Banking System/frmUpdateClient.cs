using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankBusinessLayer;


namespace Bank_C_
{
    public partial class frmUpdateClient : Form
    {
        public frmUpdateClient()
        {
            InitializeComponent();
        }

        private clsClient _Client;

        private void btnSearchUpdate_Click(object sender, EventArgs e)
        {
            switch(btnSearchUpdate.Text)
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

                        btnSearchUpdate.Text = "Update";
                        btnClear.Enabled = true;
                        tbFirstName.Enabled = true;
                        tbLastName.Enabled = true;
                        tbPhoneNumber.Enabled = true;
                        tbEmail.Enabled = true;
                        tbPinCode.Enabled = true;
                        tbBalance.Enabled = true;
                    }

                    else
                    {
                        MessageBox.Show("Client not found!", "Update Client", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }

                    break;

                case "Update":

                    if (tbAccountNumber.Text != _Client.AccountNumber & clsClient.isClientExist(tbAccountNumber.Text))
                    {
                        MessageBox.Show("Another client with this Account Number already exists!", "Update Client", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                    }

                    else
                    {
                        _Client.AccountNumber = tbAccountNumber.Text;
                        _Client.FirstName = tbFirstName.Text;
                        _Client.LastName = tbLastName.Text;
                        _Client.Phone = tbPhoneNumber.Text;
                        _Client.Email = tbEmail.Text;
                        _Client.PinCode = tbPinCode.Text;
                        _Client.Balance = Convert.ToDecimal(tbBalance.Text);

                        if (_Client.Save())
                        {
                            MessageBox.Show("Client updated successfully!", "Update Client", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                        }
                    }

                    break;

            }

        }

        private void _EnableUpdate()
        {
            btnSearchUpdate.Enabled = tbAccountNumber.Text != "" & tbFirstName.Text != "" & tbLastName.Text != "" & tbPhoneNumber.Text != "" &
                             tbEmail.Text != "" & tbPinCode.Text != "" & tbBalance.Text != "";
        }
        private void tbAccountNumber_TextChanged(object sender, EventArgs e)
        {
            if (btnSearchUpdate.Text == "Search")
            {
                btnSearchUpdate.Enabled = tbAccountNumber.Text != "";
         
            }
            
            if(btnSearchUpdate.Text == "Update")
            {
                _EnableUpdate();

            }
        }

        private void tbFirstName_TextChanged(object sender, EventArgs e)
        {
            _EnableUpdate();
        }

        private void tbLastName_TextChanged(object sender, EventArgs e)
        {
            _EnableUpdate();
        }

        private void tbPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            _EnableUpdate();
        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {
            _EnableUpdate();
        }

        private void tbPinCode_TextChanged(object sender, EventArgs e)
        {
            _EnableUpdate();
        }

        private void tbBalance_TextChanged(object sender, EventArgs e)
        {
            _EnableUpdate();
        }


        //Input Validation
        private void tbAccountNumber_Validating(object sender, CancelEventArgs e)
        {
            if (!tbAccountNumber.Text.All(char.IsLetterOrDigit))
            {
                e.Cancel = true;
                tbAccountNumber.Focus();
                errorProvider1.SetError(tbAccountNumber, "Please enter a valid Account Number!");
                btnSearchUpdate.Enabled = false;
            }

            else
            {
                if(btnSearchUpdate.Text == "Search")
                {
                    btnSearchUpdate.Enabled = true;
                }

                errorProvider1.SetError(tbAccountNumber, "");
            }
        }

        private void tbFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (!tbFirstName.Text.All(char.IsLetter))
            {
                e.Cancel = true;
                tbFirstName.Focus();
                errorProvider1.SetError(tbFirstName, "Please enter a valid first name!");
                btnSearchUpdate.Enabled = false;
            }

            else
            {
                errorProvider1.SetError(tbFirstName, "");
            }
        }

        private void tbLastName_Validating(object sender, CancelEventArgs e)
        {
            if (!tbLastName.Text.All(char.IsLetter))
            {
                e.Cancel = true;
                tbLastName.Focus();
                errorProvider1.SetError(tbLastName, "Please enter a valid last name!");
                btnSearchUpdate.Enabled = false;
            }

            else
            {
                errorProvider1.SetError(tbLastName, "");
            }
        }

        private void tbPhoneNumber_Validating(object sender, CancelEventArgs e)
        {
            if (!tbPhoneNumber.Text.All(char.IsDigit) || tbPhoneNumber.Text.Length != 10)
            {
                e.Cancel = true;
                tbPhoneNumber.Focus();
                errorProvider1.SetError(tbPhoneNumber, "Please enter a valid phone number!");
                btnSearchUpdate.Enabled = false;
            }

            else
            {
                errorProvider1.SetError(tbPhoneNumber, "");
            }
        }

        private void tbPinCode_Validating(object sender, CancelEventArgs e)
        {
            if (!tbPinCode.Text.All(char.IsDigit) || tbPinCode.Text.Length != 4)
            {
                e.Cancel = true;
                tbPinCode.Focus();
                errorProvider1.SetError(tbPinCode, "Please enter a valid Pin Code!");
                btnSearchUpdate.Enabled = false;
            }

            else
            {
                errorProvider1.SetError(tbPinCode, "");
            }
        }

        private void tbBalance_Validating(object sender, CancelEventArgs e)
        {
            decimal balance;

            if (!decimal.TryParse(tbBalance.Text, out balance))
            {
                e.Cancel = true;
                tbBalance.Focus();
                errorProvider1.SetError(tbBalance, "Please enter a valid value for balance.");
            }

            else
            {
                errorProvider1.SetError(tbBalance, "");
            }
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
            btnSearchUpdate.Text = "Search";
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
