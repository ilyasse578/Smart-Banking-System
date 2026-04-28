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
    public partial class frmLoginRegisterList : Form
    {
        public frmLoginRegisterList()
        {
            InitializeComponent();
        }

        private void frmLoginRegisterList_Load(object sender, EventArgs e)
        {
            dgvLoginRegisters.DataSource = clsLoginRegister.LoginRegistersList();

        }
    }
}
