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
using BusinessLogicLayer;

namespace Bank_C_
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        public string GetLoggedInUsername()
        {
            return tbUsername.Text;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(clsUser.isExist(tbUsername.Text, tbPassword.Text))
            {
                this.DialogResult = DialogResult.OK;  // Set dialog result to OK to indicate successful login
                this.Close(); // Close the login form
               
            }

            else
            {
                lblIncorrect.Visible = true;
            }
       
        }

        private void _EnableLoginButton()
        {
            btnLogin.Enabled = (tbUsername.Text != "" && tbPassword.Text != "");
        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {
            _EnableLoginButton();
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            _EnableLoginButton();
        }
    }
}
