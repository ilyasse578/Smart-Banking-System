namespace Bank_C_
{
    partial class frmTransactionsMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlFormLoader = new System.Windows.Forms.Panel();
            this.lblSectionDescription = new System.Windows.Forms.Label();
            this.lblSection = new System.Windows.Forms.Label();
            this.btnTotalBalances = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnWithdraw = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnDeposit = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pnlFormLoader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFormLoader
            // 
            this.pnlFormLoader.BackColor = System.Drawing.Color.LightGray;
            this.pnlFormLoader.Controls.Add(this.btnTotalBalances);
            this.pnlFormLoader.Controls.Add(this.btnWithdraw);
            this.pnlFormLoader.Controls.Add(this.btnDeposit);
            this.pnlFormLoader.Controls.Add(this.lblSectionDescription);
            this.pnlFormLoader.Controls.Add(this.lblSection);
            this.pnlFormLoader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFormLoader.ForeColor = System.Drawing.Color.DimGray;
            this.pnlFormLoader.Location = new System.Drawing.Point(0, 0);
            this.pnlFormLoader.Name = "pnlFormLoader";
            this.pnlFormLoader.Size = new System.Drawing.Size(784, 533);
            this.pnlFormLoader.TabIndex = 6;
            // 
            // lblSectionDescription
            // 
            this.lblSectionDescription.AutoSize = true;
            this.lblSectionDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblSectionDescription.Font = new System.Drawing.Font("Segoe UI Black", 13F, System.Drawing.FontStyle.Bold);
            this.lblSectionDescription.ForeColor = System.Drawing.Color.Black;
            this.lblSectionDescription.Location = new System.Drawing.Point(10, 48);
            this.lblSectionDescription.Name = "lblSectionDescription";
            this.lblSectionDescription.Size = new System.Drawing.Size(347, 25);
            this.lblSectionDescription.TabIndex = 34;
            this.lblSectionDescription.Text = "Here you can deal with transactions...";
            // 
            // lblSection
            // 
            this.lblSection.AutoSize = true;
            this.lblSection.BackColor = System.Drawing.Color.Transparent;
            this.lblSection.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSection.ForeColor = System.Drawing.Color.Black;
            this.lblSection.Location = new System.Drawing.Point(10, 10);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(289, 37);
            this.lblSection.TabIndex = 33;
            this.lblSection.Text = "Transactions Section";
            // 
            // btnTotalBalances
            // 
            this.btnTotalBalances.BackColor = System.Drawing.Color.Transparent;
            this.btnTotalBalances.BorderRadius = 10;
            this.btnTotalBalances.CheckedState.Parent = this.btnTotalBalances;
            this.btnTotalBalances.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTotalBalances.CustomImages.Parent = this.btnTotalBalances;
            this.btnTotalBalances.FillColor = System.Drawing.Color.Black;
            this.btnTotalBalances.FillColor2 = System.Drawing.Color.DimGray;
            this.btnTotalBalances.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalBalances.ForeColor = System.Drawing.Color.White;
            this.btnTotalBalances.HoverState.Parent = this.btnTotalBalances;
            this.btnTotalBalances.Image = global::Bank_C_.Properties.Resources.balance_sheet;
            this.btnTotalBalances.ImageSize = new System.Drawing.Size(100, 100);
            this.btnTotalBalances.Location = new System.Drawing.Point(479, 96);
            this.btnTotalBalances.Name = "btnTotalBalances";
            this.btnTotalBalances.ShadowDecoration.Parent = this.btnTotalBalances;
            this.btnTotalBalances.Size = new System.Drawing.Size(158, 411);
            this.btnTotalBalances.TabIndex = 78;
            this.btnTotalBalances.Text = "                Total Balances";
            this.btnTotalBalances.Click += new System.EventHandler(this.btnTotalBalances_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.BackColor = System.Drawing.Color.Transparent;
            this.btnWithdraw.BorderRadius = 10;
            this.btnWithdraw.CheckedState.Parent = this.btnWithdraw;
            this.btnWithdraw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWithdraw.CustomImages.Parent = this.btnWithdraw;
            this.btnWithdraw.FillColor = System.Drawing.Color.Black;
            this.btnWithdraw.FillColor2 = System.Drawing.Color.DimGray;
            this.btnWithdraw.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdraw.ForeColor = System.Drawing.Color.White;
            this.btnWithdraw.HoverState.Parent = this.btnWithdraw;
            this.btnWithdraw.Image = global::Bank_C_.Properties.Resources.cash_withdrawal;
            this.btnWithdraw.ImageSize = new System.Drawing.Size(100, 100);
            this.btnWithdraw.Location = new System.Drawing.Point(313, 96);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.ShadowDecoration.Parent = this.btnWithdraw;
            this.btnWithdraw.Size = new System.Drawing.Size(158, 411);
            this.btnWithdraw.TabIndex = 77;
            this.btnWithdraw.Text = "            Withdraw";
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.BackColor = System.Drawing.Color.Transparent;
            this.btnDeposit.BorderRadius = 10;
            this.btnDeposit.CheckedState.Parent = this.btnDeposit;
            this.btnDeposit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeposit.CustomImages.Parent = this.btnDeposit;
            this.btnDeposit.FillColor = System.Drawing.Color.Black;
            this.btnDeposit.FillColor2 = System.Drawing.Color.DimGray;
            this.btnDeposit.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeposit.ForeColor = System.Drawing.Color.White;
            this.btnDeposit.HoverState.Parent = this.btnDeposit;
            this.btnDeposit.Image = global::Bank_C_.Properties.Resources.investment;
            this.btnDeposit.ImageSize = new System.Drawing.Size(100, 100);
            this.btnDeposit.Location = new System.Drawing.Point(147, 96);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.ShadowDecoration.Parent = this.btnDeposit;
            this.btnDeposit.Size = new System.Drawing.Size(158, 411);
            this.btnDeposit.TabIndex = 76;
            this.btnDeposit.Text = "            Deposit";
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // frmTransactionsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 533);
            this.Controls.Add(this.pnlFormLoader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTransactionsMenu";
            this.Text = "Form1";
            this.pnlFormLoader.ResumeLayout(false);
            this.pnlFormLoader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFormLoader;
        private System.Windows.Forms.Label lblSectionDescription;
        private System.Windows.Forms.Label lblSection;
        private Guna.UI2.WinForms.Guna2GradientButton btnDeposit;
        private Guna.UI2.WinForms.Guna2GradientButton btnTotalBalances;
        private Guna.UI2.WinForms.Guna2GradientButton btnWithdraw;
    }
}