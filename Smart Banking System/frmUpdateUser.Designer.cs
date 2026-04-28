namespace Bank_C_
{
    partial class frmUpdateUser
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
            this.components = new System.ComponentModel.Container();
            this.pnlFormLoader = new System.Windows.Forms.Panel();
            this.chbAllPermissions = new Guna.UI2.WinForms.Guna2CheckBox();
            this.btnClear = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnSearchUpdate = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnBack = new Guna.UI2.WinForms.Guna2GradientButton();
            this.chbManageClients = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chbManageUsers = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chbTransactions = new Guna.UI2.WinForms.Guna2CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblSectionDescription = new System.Windows.Forms.Label();
            this.lblSection = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.chbLoginRegister = new Guna.UI2.WinForms.Guna2CheckBox();
            this.pnlFormLoader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFormLoader
            // 
            this.pnlFormLoader.BackColor = System.Drawing.Color.LightGray;
            this.pnlFormLoader.Controls.Add(this.chbLoginRegister);
            this.pnlFormLoader.Controls.Add(this.chbAllPermissions);
            this.pnlFormLoader.Controls.Add(this.btnClear);
            this.pnlFormLoader.Controls.Add(this.btnSearchUpdate);
            this.pnlFormLoader.Controls.Add(this.btnBack);
            this.pnlFormLoader.Controls.Add(this.chbManageClients);
            this.pnlFormLoader.Controls.Add(this.chbManageUsers);
            this.pnlFormLoader.Controls.Add(this.chbTransactions);
            this.pnlFormLoader.Controls.Add(this.label2);
            this.pnlFormLoader.Controls.Add(this.label1);
            this.pnlFormLoader.Controls.Add(this.tbPassword);
            this.pnlFormLoader.Controls.Add(this.label5);
            this.pnlFormLoader.Controls.Add(this.tbUsername);
            this.pnlFormLoader.Controls.Add(this.lblSectionDescription);
            this.pnlFormLoader.Controls.Add(this.lblSection);
            this.pnlFormLoader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFormLoader.ForeColor = System.Drawing.Color.DimGray;
            this.pnlFormLoader.Location = new System.Drawing.Point(0, 0);
            this.pnlFormLoader.Name = "pnlFormLoader";
            this.pnlFormLoader.Size = new System.Drawing.Size(784, 533);
            this.pnlFormLoader.TabIndex = 3;
            // 
            // chbAllPermissions
            // 
            this.chbAllPermissions.AutoSize = true;
            this.chbAllPermissions.BackColor = System.Drawing.Color.Transparent;
            this.chbAllPermissions.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbAllPermissions.CheckedState.BorderRadius = 2;
            this.chbAllPermissions.CheckedState.BorderThickness = 0;
            this.chbAllPermissions.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbAllPermissions.Enabled = false;
            this.chbAllPermissions.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbAllPermissions.ForeColor = System.Drawing.Color.Black;
            this.chbAllPermissions.Location = new System.Drawing.Point(77, 324);
            this.chbAllPermissions.Name = "chbAllPermissions";
            this.chbAllPermissions.Size = new System.Drawing.Size(180, 34);
            this.chbAllPermissions.TabIndex = 78;
            this.chbAllPermissions.Text = "All Permissions";
            this.chbAllPermissions.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbAllPermissions.UncheckedState.BorderRadius = 2;
            this.chbAllPermissions.UncheckedState.BorderThickness = 0;
            this.chbAllPermissions.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbAllPermissions.UseVisualStyleBackColor = false;
            this.chbAllPermissions.CheckedChanged += new System.EventHandler(this.chbAllPermissions_CheckedChanged);
            // 
            // btnClear
            // 
            this.btnClear.BorderRadius = 10;
            this.btnClear.BorderThickness = 2;
            this.btnClear.CheckedState.Parent = this.btnClear;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.CustomImages.Parent = this.btnClear;
            this.btnClear.FillColor = System.Drawing.Color.DarkGray;
            this.btnClear.FillColor2 = System.Drawing.Color.Gainsboro;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.HoverState.Parent = this.btnClear;
            this.btnClear.Location = new System.Drawing.Point(488, 476);
            this.btnClear.Name = "btnClear";
            this.btnClear.ShadowDecoration.Parent = this.btnClear;
            this.btnClear.Size = new System.Drawing.Size(139, 45);
            this.btnClear.TabIndex = 77;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSearchUpdate
            // 
            this.btnSearchUpdate.BorderRadius = 10;
            this.btnSearchUpdate.CheckedState.Parent = this.btnSearchUpdate;
            this.btnSearchUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchUpdate.CustomImages.Parent = this.btnSearchUpdate;
            this.btnSearchUpdate.Enabled = false;
            this.btnSearchUpdate.FillColor = System.Drawing.Color.Black;
            this.btnSearchUpdate.FillColor2 = System.Drawing.Color.DimGray;
            this.btnSearchUpdate.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchUpdate.ForeColor = System.Drawing.Color.White;
            this.btnSearchUpdate.HoverState.Parent = this.btnSearchUpdate;
            this.btnSearchUpdate.Location = new System.Drawing.Point(633, 476);
            this.btnSearchUpdate.Name = "btnSearchUpdate";
            this.btnSearchUpdate.ShadowDecoration.Parent = this.btnSearchUpdate;
            this.btnSearchUpdate.Size = new System.Drawing.Size(139, 45);
            this.btnSearchUpdate.TabIndex = 76;
            this.btnSearchUpdate.Text = "Search";
            this.btnSearchUpdate.Click += new System.EventHandler(this.btnSearchUpdate_Click);
            // 
            // btnBack
            // 
            this.btnBack.BorderRadius = 10;
            this.btnBack.CheckedState.Parent = this.btnBack;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.CustomImages.Parent = this.btnBack;
            this.btnBack.FillColor = System.Drawing.Color.Black;
            this.btnBack.FillColor2 = System.Drawing.Color.DimGray;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.HoverState.Parent = this.btnBack;
            this.btnBack.Location = new System.Drawing.Point(12, 476);
            this.btnBack.Name = "btnBack";
            this.btnBack.ShadowDecoration.Parent = this.btnBack;
            this.btnBack.Size = new System.Drawing.Size(139, 45);
            this.btnBack.TabIndex = 75;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // chbManageClients
            // 
            this.chbManageClients.AutoSize = true;
            this.chbManageClients.BackColor = System.Drawing.Color.Transparent;
            this.chbManageClients.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbManageClients.CheckedState.BorderRadius = 2;
            this.chbManageClients.CheckedState.BorderThickness = 0;
            this.chbManageClients.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbManageClients.Enabled = false;
            this.chbManageClients.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbManageClients.ForeColor = System.Drawing.Color.Black;
            this.chbManageClients.Location = new System.Drawing.Point(77, 367);
            this.chbManageClients.Name = "chbManageClients";
            this.chbManageClients.Size = new System.Drawing.Size(183, 34);
            this.chbManageClients.TabIndex = 74;
            this.chbManageClients.Text = "Manage Clients";
            this.chbManageClients.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbManageClients.UncheckedState.BorderRadius = 2;
            this.chbManageClients.UncheckedState.BorderThickness = 0;
            this.chbManageClients.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbManageClients.UseVisualStyleBackColor = false;
            this.chbManageClients.CheckedChanged += new System.EventHandler(this.chbManageClients_CheckedChanged);
            // 
            // chbManageUsers
            // 
            this.chbManageUsers.AutoSize = true;
            this.chbManageUsers.BackColor = System.Drawing.Color.Transparent;
            this.chbManageUsers.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbManageUsers.CheckedState.BorderRadius = 2;
            this.chbManageUsers.CheckedState.BorderThickness = 0;
            this.chbManageUsers.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbManageUsers.Enabled = false;
            this.chbManageUsers.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbManageUsers.ForeColor = System.Drawing.Color.Black;
            this.chbManageUsers.Location = new System.Drawing.Point(288, 324);
            this.chbManageUsers.Name = "chbManageUsers";
            this.chbManageUsers.Size = new System.Drawing.Size(169, 34);
            this.chbManageUsers.TabIndex = 73;
            this.chbManageUsers.Text = "Manage Users";
            this.chbManageUsers.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbManageUsers.UncheckedState.BorderRadius = 2;
            this.chbManageUsers.UncheckedState.BorderThickness = 0;
            this.chbManageUsers.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbManageUsers.UseVisualStyleBackColor = false;
            this.chbManageUsers.CheckedChanged += new System.EventHandler(this.chbManageUsers_CheckedChanged);
            // 
            // chbTransactions
            // 
            this.chbTransactions.AutoSize = true;
            this.chbTransactions.BackColor = System.Drawing.Color.Transparent;
            this.chbTransactions.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbTransactions.CheckedState.BorderRadius = 2;
            this.chbTransactions.CheckedState.BorderThickness = 0;
            this.chbTransactions.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbTransactions.Enabled = false;
            this.chbTransactions.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbTransactions.ForeColor = System.Drawing.Color.Black;
            this.chbTransactions.Location = new System.Drawing.Point(288, 367);
            this.chbTransactions.Name = "chbTransactions";
            this.chbTransactions.Size = new System.Drawing.Size(153, 34);
            this.chbTransactions.TabIndex = 70;
            this.chbTransactions.Text = "Transactions";
            this.chbTransactions.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbTransactions.UncheckedState.BorderRadius = 2;
            this.chbTransactions.UncheckedState.BorderThickness = 0;
            this.chbTransactions.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbTransactions.UseVisualStyleBackColor = false;
            this.chbTransactions.CheckedChanged += new System.EventHandler(this.chbTransactions_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(55, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 69;
            this.label2.Text = "Permissions";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(55, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 68;
            this.label1.Text = "Password";
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.Transparent;
            this.tbPassword.BorderColor = System.Drawing.Color.DimGray;
            this.tbPassword.BorderRadius = 10;
            this.tbPassword.BorderThickness = 2;
            this.tbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPassword.DefaultText = "";
            this.tbPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPassword.DisabledState.Parent = this.tbPassword;
            this.tbPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPassword.Enabled = false;
            this.tbPassword.FillColor = System.Drawing.Color.WhiteSmoke;
            this.tbPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPassword.FocusedState.Parent = this.tbPassword;
            this.tbPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.ForeColor = System.Drawing.Color.Black;
            this.tbPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPassword.HoverState.Parent = this.tbPassword;
            this.tbPassword.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.tbPassword.Location = new System.Drawing.Point(42, 218);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '\0';
            this.tbPassword.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.tbPassword.PlaceholderText = "";
            this.tbPassword.SelectedText = "";
            this.tbPassword.ShadowDecoration.Parent = this.tbPassword;
            this.tbPassword.Size = new System.Drawing.Size(538, 44);
            this.tbPassword.TabIndex = 67;
            this.tbPassword.TextOffset = new System.Drawing.Point(16, 0);
            this.tbPassword.TextChanged += new System.EventHandler(this.tbPassword_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(55, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 25);
            this.label5.TabIndex = 66;
            this.label5.Text = "Username";
            // 
            // tbUsername
            // 
            this.tbUsername.BackColor = System.Drawing.Color.Transparent;
            this.tbUsername.BorderColor = System.Drawing.Color.DimGray;
            this.tbUsername.BorderRadius = 10;
            this.tbUsername.BorderThickness = 2;
            this.tbUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbUsername.DefaultText = "";
            this.tbUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbUsername.DisabledState.Parent = this.tbUsername;
            this.tbUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbUsername.FillColor = System.Drawing.Color.WhiteSmoke;
            this.tbUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbUsername.FocusedState.Parent = this.tbUsername;
            this.tbUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.ForeColor = System.Drawing.Color.Black;
            this.tbUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbUsername.HoverState.Parent = this.tbUsername;
            this.tbUsername.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.tbUsername.Location = new System.Drawing.Point(42, 131);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.PasswordChar = '\0';
            this.tbUsername.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.tbUsername.PlaceholderText = "";
            this.tbUsername.SelectedText = "";
            this.tbUsername.ShadowDecoration.Parent = this.tbUsername;
            this.tbUsername.Size = new System.Drawing.Size(538, 44);
            this.tbUsername.TabIndex = 65;
            this.tbUsername.TextOffset = new System.Drawing.Point(16, 0);
            this.tbUsername.TextChanged += new System.EventHandler(this.tbUsername_TextChanged);
            this.tbUsername.Validating += new System.ComponentModel.CancelEventHandler(this.tbUsername_Validating);
            // 
            // lblSectionDescription
            // 
            this.lblSectionDescription.AutoSize = true;
            this.lblSectionDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblSectionDescription.Font = new System.Drawing.Font("Segoe UI Black", 13F, System.Drawing.FontStyle.Bold);
            this.lblSectionDescription.ForeColor = System.Drawing.Color.Black;
            this.lblSectionDescription.Location = new System.Drawing.Point(10, 48);
            this.lblSectionDescription.Name = "lblSectionDescription";
            this.lblSectionDescription.Size = new System.Drawing.Size(270, 25);
            this.lblSectionDescription.TabIndex = 34;
            this.lblSectionDescription.Text = "Here you can update a user...";
            // 
            // lblSection
            // 
            this.lblSection.AutoSize = true;
            this.lblSection.BackColor = System.Drawing.Color.Transparent;
            this.lblSection.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSection.ForeColor = System.Drawing.Color.Black;
            this.lblSection.Location = new System.Drawing.Point(10, 10);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(392, 37);
            this.lblSection.TabIndex = 33;
            this.lblSection.Text = "Users Section > Update User";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // chbLoginRegister
            // 
            this.chbLoginRegister.AutoSize = true;
            this.chbLoginRegister.BackColor = System.Drawing.Color.Transparent;
            this.chbLoginRegister.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbLoginRegister.CheckedState.BorderRadius = 2;
            this.chbLoginRegister.CheckedState.BorderThickness = 0;
            this.chbLoginRegister.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbLoginRegister.Enabled = false;
            this.chbLoginRegister.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbLoginRegister.ForeColor = System.Drawing.Color.Black;
            this.chbLoginRegister.Location = new System.Drawing.Point(488, 324);
            this.chbLoginRegister.Name = "chbLoginRegister";
            this.chbLoginRegister.Size = new System.Drawing.Size(173, 34);
            this.chbLoginRegister.TabIndex = 79;
            this.chbLoginRegister.Text = "Login Register";
            this.chbLoginRegister.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbLoginRegister.UncheckedState.BorderRadius = 2;
            this.chbLoginRegister.UncheckedState.BorderThickness = 0;
            this.chbLoginRegister.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbLoginRegister.UseVisualStyleBackColor = false;
            this.chbLoginRegister.CheckedChanged += new System.EventHandler(this.chbLoginRegister_CheckedChanged);
            // 
            // frmUpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 533);
            this.Controls.Add(this.pnlFormLoader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUpdateUser";
            this.Text = "Form1";
            this.pnlFormLoader.ResumeLayout(false);
            this.pnlFormLoader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFormLoader;
        private Guna.UI2.WinForms.Guna2CheckBox chbAllPermissions;
        private Guna.UI2.WinForms.Guna2GradientButton btnClear;
        private Guna.UI2.WinForms.Guna2GradientButton btnSearchUpdate;
        private Guna.UI2.WinForms.Guna2GradientButton btnBack;
        private Guna.UI2.WinForms.Guna2CheckBox chbManageClients;
        private Guna.UI2.WinForms.Guna2CheckBox chbManageUsers;
        private Guna.UI2.WinForms.Guna2CheckBox chbTransactions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox tbPassword;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox tbUsername;
        private System.Windows.Forms.Label lblSectionDescription;
        private System.Windows.Forms.Label lblSection;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2CheckBox chbLoginRegister;
    }
}