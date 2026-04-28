using BankBusinessLayer;
using BusinessLogicLayer;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BusinessLogicLayer.clsUser;

namespace Bank_C_
{
    public partial class frmFindUser : Form
    {
        public frmFindUser()
        {
            InitializeComponent();
        }

        private void _EnableSearch()
        {
            btnSearch.Enabled = tbUsername.Text != "";
        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {
            _EnableSearch();

        }
        private void tbUsername_Validating(object sender, CancelEventArgs e)
        {
            if (!tbUsername.Text.All(char.IsLetterOrDigit))
            {
                e.Cancel = true;
                tbUsername.Focus();
                errorProvider1.SetError(tbUsername, "Please enter a valid Username!");
                btnSearch.Enabled = false;
            }

            else
            {
                errorProvider1.SetError(tbUsername, "");
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (clsUser.isExist(tbUsername.Text))
            {
                _User = clsUser.Find(tbUsername.Text);
                tbPassword.Text = _User.password;

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

            }

            else
            {
                MessageBox.Show("User not found!", "Update User", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbUsername.Text = "";
            tbPassword.Text = "";

            chbAllPermissions.Checked = false;
            chbManageClients.Checked = false;
            chbManageUsers.Checked = false;
            chbTransactions.Checked = false;
            chbLoginRegister.Checked=false;
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
