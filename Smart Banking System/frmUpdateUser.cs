using BankBusinessLayer;
using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BusinessLogicLayer.clsUser;

namespace Bank_C_
{
    public partial class frmUpdateUser : Form
    {
        public frmUpdateUser()
        {
            InitializeComponent();
        }

        private void _EnableUpdate()
        {
            btnSearchUpdate.Enabled = tbUsername.Text != "" & tbPassword.Text != ""
                    & (chbAllPermissions.Checked || chbManageClients.Checked || chbManageUsers.Checked || chbTransactions.Checked || chbLoginRegister.Checked);
        }


        private void tbUsername_TextChanged(object sender, EventArgs e)
        {
            if (btnSearchUpdate.Text == "Search")
            {
                btnSearchUpdate.Enabled = tbUsername.Text != "";

            }

            if (btnSearchUpdate.Text == "Update")
            {
                _EnableUpdate();

            }
        }

        private clsUser _User;
        private bool _CheckAccessPermission(enPermissions Permission)
        {
            if (_User.permissions == (int)enPermissions.AllPermissions)
                return true;
            if (((int)Permission & _User.permissions) == (int)Permission)
                return true;
            else
                return false;
        }

        private void btnSearchUpdate_Click(object sender, EventArgs e)
        {
            switch (btnSearchUpdate.Text)
            {
                case "Search":

                    if (clsUser.isExist(tbUsername.Text))
                    {
                        _User = clsUser.Find(tbUsername.Text);
                        tbPassword.Text = _User.password;

                        tbPassword.Enabled = true;
                        chbAllPermissions.Enabled = true;
                        chbManageClients.Enabled = true;
                        chbManageUsers.Enabled = true;
                        chbTransactions.Enabled = true;
                        chbLoginRegister.Enabled = true;

                        if (_CheckAccessPermission(enPermissions.AllPermissions))
                        {
                            chbAllPermissions.Checked = true;
                        }

                        else
                        {
                            if (_CheckAccessPermission(enPermissions.ManageClient))
                            {
                                chbManageClients.Checked = true;
                            }

                            if (_CheckAccessPermission(enPermissions.ManageUser))
                            {
                                chbManageUsers.Checked = true;
                            }

                            if (_CheckAccessPermission(enPermissions.Transactions))
                            {
                                chbTransactions.Checked = true;
                            }

                            if (_CheckAccessPermission(enPermissions.LoginRegister))
                            {
                                chbLoginRegister.Checked = true;
                            }
                        }

                        btnSearchUpdate.Text = "Update";
                        btnClear.Enabled = true;
                        
                    }

                    else
                    {
                        MessageBox.Show("User not found!", "Update User", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }

                    break;

                case "Update":

                    if (tbUsername.Text != _User.username & clsUser.isExist(tbUsername.Text))
                    {
                        MessageBox.Show("Another user with this username already exists!", "Update User", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                    }

                    else
                    {
                        _User.username = tbUsername.Text;
                        _User.password = tbPassword.Text;
                        _User.permissions = _Permissions;

                        if (_User.Save())
                        {
                            MessageBox.Show("User updated successfully!", "Update User", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                        }
                    }

                    break;

            }
        }

        private void tbUsername_Validating(object sender, CancelEventArgs e)
        {
            if (!tbUsername.Text.All(char.IsLetterOrDigit))
            {
                e.Cancel = true;
                tbUsername.Focus();
                errorProvider1.SetError(tbUsername, "Please enter a valid Username!");
                btnSearchUpdate.Enabled = false;
            }

            else
            {
                errorProvider1.SetError(tbUsername, "");
            }
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            _EnableUpdate();
        }

        private short _Permissions = 0;

        private void chbAllPermissions_CheckedChanged(object sender, EventArgs e)
        {
            chbManageClients.Enabled = !chbAllPermissions.Checked;
            chbManageUsers.Enabled = !chbAllPermissions.Checked;
            chbTransactions.Enabled = !chbAllPermissions.Checked;
            chbLoginRegister.Enabled = !chbAllPermissions.Checked;

            if (chbAllPermissions.Checked)
            {
                chbManageClients.Checked = false;
                chbManageUsers.Checked = false;
                chbTransactions.Checked = false;
                chbLoginRegister.Checked = false;

                _Permissions = Convert.ToInt16(clsUser.enPermissions.AllPermissions);

            }

            else
            {
                _Permissions = 0;
            }

            _EnableUpdate();
        }

        private void chbManageClients_CheckedChanged(object sender, EventArgs e)
        {
            _EnableUpdate();

            if (chbManageClients.Checked)
            {
                _Permissions += Convert.ToInt16(clsUser.enPermissions.ManageClient);

            }

            else
            {
                _Permissions -= Convert.ToInt16(clsUser.enPermissions.ManageClient);

            }
        }

        private void chbManageUsers_CheckedChanged(object sender, EventArgs e)
        {
            if (chbManageUsers.Checked)
            {
                _Permissions += Convert.ToInt16(clsUser.enPermissions.ManageUser);

            }

            else
            {
                _Permissions -= Convert.ToInt16(clsUser.enPermissions.ManageUser);

            }

            _EnableUpdate();
        }

        private void chbTransactions_CheckedChanged(object sender, EventArgs e)
        {
            if (chbTransactions.Checked)
            {
                _Permissions += Convert.ToInt16(clsUser.enPermissions.Transactions);

            }

            else
            {
                _Permissions -= Convert.ToInt16(clsUser.enPermissions.Transactions);

            }

            _EnableUpdate();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbUsername.Text = "";
            tbPassword.Text = "";
            tbPassword.Enabled = false;
            chbAllPermissions.Enabled = false;
            chbManageClients.Enabled = false;
            chbManageUsers.Enabled = false;
            chbTransactions.Enabled = false;
            chbLoginRegister.Enabled = false;
            chbAllPermissions.Checked = false;
            chbManageClients.Checked = false;
            chbManageUsers.Checked = false;
            chbTransactions.Checked = false;
            chbLoginRegister.Checked = false;
            btnSearchUpdate.Text = "Search";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pnlFormLoader.Controls.Clear();
            frmUsersMenu frm = new frmUsersMenu();
            frm.TopLevel = false;
            pnlFormLoader.Controls.Add(frm);
            frm.Show();
        }

        private void chbLoginRegister_CheckedChanged(object sender, EventArgs e)
        {
            if (chbLoginRegister.Checked)
            {
                _Permissions += Convert.ToInt16(clsUser.enPermissions.LoginRegister);

            }

            else
            {
                _Permissions -= Convert.ToInt16(clsUser.enPermissions.LoginRegister);

            }

            _EnableUpdate();
        }
    }
}
