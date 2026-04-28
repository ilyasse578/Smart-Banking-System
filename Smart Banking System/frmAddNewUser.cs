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
    public partial class frmAddNewUser : Form
    {
        public frmAddNewUser()
        {
            InitializeComponent();
        }


        private void _EnableAdd()
        {
            btnAdd.Enabled = tbUsername.Text != "" & tbPassword.Text!="" 
                    & (chbAllPermissions.Checked || chbManageClients.Checked || chbManageUsers.Checked || chbTransactions.Checked || chbLoginRegister.Checked );       
        }
        
        private void tbUsername_TextChanged(object sender, EventArgs e)
        {
            _EnableAdd();

        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            _EnableAdd();
        }

        private void chbAllPermissions_CheckedChanged(object sender, EventArgs e)
        {
            chbManageClients.Enabled = !chbAllPermissions.Checked;
            chbManageUsers.Enabled = !chbAllPermissions.Checked;
            chbTransactions.Enabled = !chbAllPermissions.Checked;
            chbLoginRegister.Enabled = !chbAllPermissions.Checked;

            if(chbAllPermissions.Checked)
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

            _EnableAdd();
        }

        private void chbManageClients_CheckedChanged(object sender, EventArgs e)
        {
            _EnableAdd();

            if(chbManageClients.Checked)
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

            _EnableAdd();
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

            _EnableAdd();
        }

        private void tbUsername_Validating(object sender, CancelEventArgs e)
        {
            if (!tbUsername.Text.All(char.IsLetterOrDigit))
            {
                e.Cancel = true;
                tbUsername.Focus();
                errorProvider1.SetError(tbUsername, "Please enter a valid Username!");
                btnAdd.Enabled = false;
            }

            else
            {
                errorProvider1.SetError(tbUsername, "");
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
            chbLoginRegister.Checked = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pnlFormLoader.Controls.Clear();
            frmUsersMenu frm = new frmUsersMenu();
            frm.TopLevel = false;
            pnlFormLoader.Controls.Add(frm);
            frm.Show();
        }

        private clsUser _User;
        private short _Permissions = 0;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(clsUser.isExist(tbUsername.Text))
            {
                MessageBox.Show("User with this Username already exists!", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                _User = new clsUser();
                _User.username = tbUsername.Text;
                _User.password = tbPassword.Text;
                _User.permissions = _Permissions;

                if (_User.Save())
                {
                    MessageBox.Show("User added successfully!", "Add user", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show("Failed adding user!", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
           

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

            _EnableAdd();
        }
    }
}
