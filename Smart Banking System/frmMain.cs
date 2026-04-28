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
using Microsoft.VisualBasic.ApplicationServices;
using static BusinessLogicLayer.clsUser;



namespace Bank_C_
{
    public partial class frmMain : Form
    {
        private string _UserName;

        private clsUser _CurrentUser;
        private clsLoginRegister _LoginRegister;
        public frmMain(string Username)
        {
            InitializeComponent();
            _UserName = Username;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblUsername.Text = _UserName;
            _CurrentUser = clsUser.Find(_UserName);

            pnlFormLoader.Controls.Clear();

            if (_CheckAccessPermission(enPermissions.AllPermissions) || _CheckAccessPermission(enPermissions.ManageClient))
            {
                frmClientsMenu frm = new frmClientsMenu();
                frm.TopLevel = false;
                pnlFormLoader.Controls.Add(frm);
                frm.Show();
            }

            else
            {
                Label lblNoAccess = new Label();
                lblNoAccess.Text = "You don't have access to Manage Clients!";
                lblNoAccess.Font = new Font("Segoe UI", 24, FontStyle.Bold); // Set the font
                lblNoAccess.ForeColor = Color.Firebrick;
                lblNoAccess.AutoSize = true; // Allows the label to resize according to its content

                lblNoAccess.Location = new Point(82, 215);

                pnlFormLoader.Controls.Add(lblNoAccess);


            }

            _LoginRegister = new clsLoginRegister();
            _LoginRegister.Date = DateTime.Now;
            _LoginRegister.User = _CurrentUser;

            _LoginRegister.AddNewLoginRegister();
        }

        private void _ResetButtonBackgroundColor()
        {
            if (btnClients.BackColor == Color.LightGray)
            {
                btnClients.ForeColor = Color.White;
                btnClients.BackColor = Color.Transparent;
            }

            if (btnUsers.BackColor == Color.LightGray)
            {
                btnUsers.ForeColor = Color.White;
                btnUsers.BackColor = Color.Transparent;

            }

            if (btnTransactions.BackColor == Color.LightGray)
            {
                btnTransactions.ForeColor = Color.White;
                btnTransactions.BackColor = Color.Transparent;
            }

            if (btnLoginRegister.BackColor == Color.LightGray)
            {
                btnLoginRegister.ForeColor = Color.White;
                btnLoginRegister.BackColor = Color.Transparent;
            }
        }
        private bool _CheckAccessPermission(enPermissions Permission)
        {
            if (_CurrentUser.permissions == (int)enPermissions.AllPermissions)
                return true;
            if (((int)Permission & _CurrentUser.permissions) == (int)Permission)
                return true;
            else
                return false;
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            pnlNav.Top = btnClients.Top;
            _ResetButtonBackgroundColor();
            btnClients.BackColor = Color.LightGray;
            btnClients.ForeColor = Color.Black;

            pnlFormLoader.Controls.Clear();

            if (_CheckAccessPermission(enPermissions.AllPermissions) || _CheckAccessPermission(enPermissions.ManageClient))
            {
                frmClientsMenu frm = new frmClientsMenu();
                frm.TopLevel = false;
                pnlFormLoader.Controls.Add(frm);
                frm.Show();
            }

            else
            {
                Label lblNoAccess = new Label();
                lblNoAccess.Text = "You don't have access to Manage Clients!";
                lblNoAccess.Font = new Font("Segoe UI", 24, FontStyle.Bold); // Set the font
                lblNoAccess.ForeColor = Color.Firebrick;
                lblNoAccess.AutoSize = true; // Allows the label to resize according to its content

                lblNoAccess.Location = new Point(82, 215);

                pnlFormLoader.Controls.Add(lblNoAccess);

            }

        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            pnlNav.Top = btnUsers.Top;
            _ResetButtonBackgroundColor();
            btnUsers.BackColor = Color.LightGray;
            btnUsers.ForeColor = Color.Black;

            pnlFormLoader.Controls.Clear();

            if (_CheckAccessPermission(enPermissions.AllPermissions) || _CheckAccessPermission(enPermissions.ManageUser))
            {
                frmUsersMenu frm = new frmUsersMenu();
                frm.TopLevel = false;
                pnlFormLoader.Controls.Add(frm);
                frm.Show();
            }

            else
            {
                Label lblNoAccess = new Label();
                lblNoAccess.Text = "You don't have access to Manage Users!";
                lblNoAccess.Font = new Font("Segoe UI", 24, FontStyle.Bold); // Set the font
                lblNoAccess.ForeColor = Color.Firebrick;
                lblNoAccess.AutoSize = true; // Allows the label to resize according to its content

                lblNoAccess.Location = new Point(82, 215);

                pnlFormLoader.Controls.Add(lblNoAccess);

            }

        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            pnlNav.Top = btnTransactions.Top;
            _ResetButtonBackgroundColor();
            btnTransactions.BackColor = Color.LightGray;
            btnTransactions.ForeColor = Color.Black;

            pnlFormLoader.Controls.Clear();

            if (_CheckAccessPermission(enPermissions.AllPermissions) || _CheckAccessPermission(enPermissions.Transactions))
            {
                frmTransactionsMenu frm = new frmTransactionsMenu();
                frm.TopLevel = false;
                pnlFormLoader.Controls.Add(frm);
                frm.Show();
            }

            else
            {
                Label lblNoAccess = new Label();
                lblNoAccess.Text = "You don't have access to Transactions!";
                lblNoAccess.Font = new Font("Segoe UI", 24, FontStyle.Bold); // Set the font
                lblNoAccess.ForeColor = Color.Firebrick;
                lblNoAccess.AutoSize = true; // Allows the label to resize according to its content

                lblNoAccess.Location = new Point(82, 215);

                pnlFormLoader.Controls.Add(lblNoAccess);

            }

        }

        private void btnLoginRegister_Click(object sender, EventArgs e)
        {
            pnlNav.Top = btnLoginRegister.Top;
            _ResetButtonBackgroundColor();
            btnLoginRegister.BackColor = Color.LightGray;
            btnLoginRegister.ForeColor = Color.Black;

            pnlFormLoader.Controls.Clear();

            if (_CheckAccessPermission(enPermissions.AllPermissions) || _CheckAccessPermission(enPermissions.LoginRegister))
            {
                frmLoginRegisterList frm = new frmLoginRegisterList();
                frm.TopLevel = false;
                pnlFormLoader.Controls.Add(frm);
                frm.Show();
            }

            else
            {
                Label lblNoAccess = new Label();
                lblNoAccess.Text = "You don't have access to Login Register!";
                lblNoAccess.Font = new Font("Segoe UI", 24, FontStyle.Bold); // Set the font
                lblNoAccess.ForeColor = Color.Firebrick;
                lblNoAccess.AutoSize = true; // Allows the label to resize according to its content

                lblNoAccess.Location = new Point(82, 215);

                pnlFormLoader.Controls.Add(lblNoAccess);

            }

        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;  // Set DialogResult to Yes on logout
            this.Close();
        }

        
    }
}
