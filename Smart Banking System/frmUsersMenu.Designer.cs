namespace Bank_C_
{
    partial class frmUsersMenu
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
            this.btnUpdateUser = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnFindUser = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnDeleteUser = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnAddUser = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnUsersList = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lblSectionDescription = new System.Windows.Forms.Label();
            this.lblSection = new System.Windows.Forms.Label();
            this.pnlFormLoader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFormLoader
            // 
            this.pnlFormLoader.Controls.Add(this.btnUpdateUser);
            this.pnlFormLoader.Controls.Add(this.btnFindUser);
            this.pnlFormLoader.Controls.Add(this.btnDeleteUser);
            this.pnlFormLoader.Controls.Add(this.btnAddUser);
            this.pnlFormLoader.Controls.Add(this.btnUsersList);
            this.pnlFormLoader.Controls.Add(this.lblSectionDescription);
            this.pnlFormLoader.Controls.Add(this.lblSection);
            this.pnlFormLoader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFormLoader.Location = new System.Drawing.Point(0, 0);
            this.pnlFormLoader.Name = "pnlFormLoader";
            this.pnlFormLoader.Size = new System.Drawing.Size(784, 533);
            this.pnlFormLoader.TabIndex = 1;
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.BorderRadius = 15;
            this.btnUpdateUser.CheckedState.Parent = this.btnUpdateUser;
            this.btnUpdateUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateUser.CustomImages.Parent = this.btnUpdateUser;
            this.btnUpdateUser.FillColor = System.Drawing.Color.DimGray;
            this.btnUpdateUser.FillColor2 = System.Drawing.Color.Black;
            this.btnUpdateUser.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateUser.ForeColor = System.Drawing.Color.White;
            this.btnUpdateUser.HoverState.Parent = this.btnUpdateUser;
            this.btnUpdateUser.Image = global::Bank_C_.Properties.Resources.system_update;
            this.btnUpdateUser.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUpdateUser.ImageSize = new System.Drawing.Size(45, 45);
            this.btnUpdateUser.Location = new System.Drawing.Point(18, 261);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.ShadowDecoration.Parent = this.btnUpdateUser;
            this.btnUpdateUser.Size = new System.Drawing.Size(748, 61);
            this.btnUpdateUser.TabIndex = 39;
            this.btnUpdateUser.Text = "Update User";
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // btnFindUser
            // 
            this.btnFindUser.BorderRadius = 15;
            this.btnFindUser.CheckedState.Parent = this.btnFindUser;
            this.btnFindUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFindUser.CustomImages.Parent = this.btnFindUser;
            this.btnFindUser.FillColor = System.Drawing.Color.DimGray;
            this.btnFindUser.FillColor2 = System.Drawing.Color.Black;
            this.btnFindUser.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindUser.ForeColor = System.Drawing.Color.White;
            this.btnFindUser.HoverState.Parent = this.btnFindUser;
            this.btnFindUser.Image = global::Bank_C_.Properties.Resources.magnifying_glass;
            this.btnFindUser.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnFindUser.ImageSize = new System.Drawing.Size(45, 45);
            this.btnFindUser.Location = new System.Drawing.Point(18, 330);
            this.btnFindUser.Name = "btnFindUser";
            this.btnFindUser.ShadowDecoration.Parent = this.btnFindUser;
            this.btnFindUser.Size = new System.Drawing.Size(748, 61);
            this.btnFindUser.TabIndex = 38;
            this.btnFindUser.Text = "Find User";
            this.btnFindUser.Click += new System.EventHandler(this.btnFindUser_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.BorderRadius = 15;
            this.btnDeleteUser.CheckedState.Parent = this.btnDeleteUser;
            this.btnDeleteUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteUser.CustomImages.Parent = this.btnDeleteUser;
            this.btnDeleteUser.FillColor = System.Drawing.Color.DimGray;
            this.btnDeleteUser.FillColor2 = System.Drawing.Color.Black;
            this.btnDeleteUser.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUser.ForeColor = System.Drawing.Color.White;
            this.btnDeleteUser.HoverState.Parent = this.btnDeleteUser;
            this.btnDeleteUser.Image = global::Bank_C_.Properties.Resources.bin;
            this.btnDeleteUser.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDeleteUser.ImageSize = new System.Drawing.Size(45, 45);
            this.btnDeleteUser.Location = new System.Drawing.Point(18, 399);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.ShadowDecoration.Parent = this.btnDeleteUser;
            this.btnDeleteUser.Size = new System.Drawing.Size(748, 61);
            this.btnDeleteUser.TabIndex = 37;
            this.btnDeleteUser.Text = "Delete User";
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.BorderRadius = 15;
            this.btnAddUser.CheckedState.Parent = this.btnAddUser;
            this.btnAddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddUser.CustomImages.Parent = this.btnAddUser;
            this.btnAddUser.FillColor = System.Drawing.Color.DimGray;
            this.btnAddUser.FillColor2 = System.Drawing.Color.Black;
            this.btnAddUser.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.ForeColor = System.Drawing.Color.White;
            this.btnAddUser.HoverState.Parent = this.btnAddUser;
            this.btnAddUser.Image = global::Bank_C_.Properties.Resources.add;
            this.btnAddUser.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddUser.ImageSize = new System.Drawing.Size(45, 45);
            this.btnAddUser.Location = new System.Drawing.Point(18, 192);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.ShadowDecoration.Parent = this.btnAddUser;
            this.btnAddUser.Size = new System.Drawing.Size(748, 61);
            this.btnAddUser.TabIndex = 36;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnUsersList
            // 
            this.btnUsersList.BorderRadius = 15;
            this.btnUsersList.CheckedState.Parent = this.btnUsersList;
            this.btnUsersList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsersList.CustomImages.Parent = this.btnUsersList;
            this.btnUsersList.FillColor = System.Drawing.Color.DimGray;
            this.btnUsersList.FillColor2 = System.Drawing.Color.Black;
            this.btnUsersList.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsersList.ForeColor = System.Drawing.Color.White;
            this.btnUsersList.HoverState.Parent = this.btnUsersList;
            this.btnUsersList.Image = global::Bank_C_.Properties.Resources.public_relation;
            this.btnUsersList.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUsersList.ImageSize = new System.Drawing.Size(45, 45);
            this.btnUsersList.Location = new System.Drawing.Point(18, 125);
            this.btnUsersList.Name = "btnUsersList";
            this.btnUsersList.ShadowDecoration.Parent = this.btnUsersList;
            this.btnUsersList.Size = new System.Drawing.Size(748, 61);
            this.btnUsersList.TabIndex = 35;
            this.btnUsersList.Text = "Users List";
            this.btnUsersList.Click += new System.EventHandler(this.btnUsersList_Click);
            // 
            // lblSectionDescription
            // 
            this.lblSectionDescription.AutoSize = true;
            this.lblSectionDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblSectionDescription.Font = new System.Drawing.Font("Segoe UI Black", 13F, System.Drawing.FontStyle.Bold);
            this.lblSectionDescription.ForeColor = System.Drawing.Color.Black;
            this.lblSectionDescription.Location = new System.Drawing.Point(10, 48);
            this.lblSectionDescription.Name = "lblSectionDescription";
            this.lblSectionDescription.Size = new System.Drawing.Size(318, 25);
            this.lblSectionDescription.TabIndex = 34;
            this.lblSectionDescription.Text = "Here you can deal with the users...";
            // 
            // lblSection
            // 
            this.lblSection.AutoSize = true;
            this.lblSection.BackColor = System.Drawing.Color.Transparent;
            this.lblSection.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSection.ForeColor = System.Drawing.Color.Black;
            this.lblSection.Location = new System.Drawing.Point(10, 10);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(194, 37);
            this.lblSection.TabIndex = 33;
            this.lblSection.Text = "Users Section";
            // 
            // frmUsersMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(784, 533);
            this.Controls.Add(this.pnlFormLoader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUsersMenu";
            this.Text = "Form1";
            this.pnlFormLoader.ResumeLayout(false);
            this.pnlFormLoader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFormLoader;
        private Guna.UI2.WinForms.Guna2GradientButton btnUpdateUser;
        private Guna.UI2.WinForms.Guna2GradientButton btnFindUser;
        private Guna.UI2.WinForms.Guna2GradientButton btnDeleteUser;
        private Guna.UI2.WinForms.Guna2GradientButton btnAddUser;
        private Guna.UI2.WinForms.Guna2GradientButton btnUsersList;
        private System.Windows.Forms.Label lblSectionDescription;
        private System.Windows.Forms.Label lblSection;
    }
}