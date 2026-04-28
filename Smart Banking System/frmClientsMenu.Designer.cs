namespace Bank_C_
{
    partial class frmClientsMenu
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnUpdateClient = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnFindClient = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnDeleteClient = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnAddClient = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnClientsList = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pnlFormLoader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFormLoader
            // 
            this.pnlFormLoader.Controls.Add(this.pictureBox1);
            this.pnlFormLoader.Controls.Add(this.btnUpdateClient);
            this.pnlFormLoader.Controls.Add(this.btnFindClient);
            this.pnlFormLoader.Controls.Add(this.btnDeleteClient);
            this.pnlFormLoader.Controls.Add(this.btnAddClient);
            this.pnlFormLoader.Controls.Add(this.btnClientsList);
            this.pnlFormLoader.Controls.Add(this.lblSectionDescription);
            this.pnlFormLoader.Controls.Add(this.lblSection);
            this.pnlFormLoader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFormLoader.Location = new System.Drawing.Point(0, 0);
            this.pnlFormLoader.Name = "pnlFormLoader";
            this.pnlFormLoader.Size = new System.Drawing.Size(784, 533);
            this.pnlFormLoader.TabIndex = 0;
            // 
            // lblSectionDescription
            // 
            this.lblSectionDescription.AutoSize = true;
            this.lblSectionDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblSectionDescription.Font = new System.Drawing.Font("Segoe UI Black", 13F, System.Drawing.FontStyle.Bold);
            this.lblSectionDescription.ForeColor = System.Drawing.Color.Black;
            this.lblSectionDescription.Location = new System.Drawing.Point(10, 48);
            this.lblSectionDescription.Name = "lblSectionDescription";
            this.lblSectionDescription.Size = new System.Drawing.Size(330, 25);
            this.lblSectionDescription.TabIndex = 34;
            this.lblSectionDescription.Text = "Here you can deal with the clients...";
            // 
            // lblSection
            // 
            this.lblSection.AutoSize = true;
            this.lblSection.BackColor = System.Drawing.Color.Transparent;
            this.lblSection.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSection.ForeColor = System.Drawing.Color.Black;
            this.lblSection.Location = new System.Drawing.Point(10, 10);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(210, 37);
            this.lblSection.TabIndex = 33;
            this.lblSection.Text = "Clients Section";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bank_C_.Properties.Resources.core_banking_blog_banner;
            this.pictureBox1.Location = new System.Drawing.Point(179, 261);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(421, 248);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // btnUpdateClient
            // 
            this.btnUpdateClient.BorderRadius = 10;
            this.btnUpdateClient.CheckedState.Parent = this.btnUpdateClient;
            this.btnUpdateClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateClient.CustomImages.Parent = this.btnUpdateClient;
            this.btnUpdateClient.FillColor = System.Drawing.Color.DimGray;
            this.btnUpdateClient.FillColor2 = System.Drawing.Color.Black;
            this.btnUpdateClient.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateClient.ForeColor = System.Drawing.Color.White;
            this.btnUpdateClient.HoverState.Parent = this.btnUpdateClient;
            this.btnUpdateClient.Image = global::Bank_C_.Properties.Resources.system_update;
            this.btnUpdateClient.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUpdateClient.ImageSize = new System.Drawing.Size(35, 35);
            this.btnUpdateClient.Location = new System.Drawing.Point(269, 147);
            this.btnUpdateClient.Name = "btnUpdateClient";
            this.btnUpdateClient.ShadowDecoration.Parent = this.btnUpdateClient;
            this.btnUpdateClient.Size = new System.Drawing.Size(240, 45);
            this.btnUpdateClient.TabIndex = 39;
            this.btnUpdateClient.Text = "Update Client";
            this.btnUpdateClient.Click += new System.EventHandler(this.btnUpdateClient_Click);
            // 
            // btnFindClient
            // 
            this.btnFindClient.BorderRadius = 10;
            this.btnFindClient.CheckedState.Parent = this.btnFindClient;
            this.btnFindClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFindClient.CustomImages.Parent = this.btnFindClient;
            this.btnFindClient.FillColor = System.Drawing.Color.DimGray;
            this.btnFindClient.FillColor2 = System.Drawing.Color.Black;
            this.btnFindClient.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindClient.ForeColor = System.Drawing.Color.White;
            this.btnFindClient.HoverState.Parent = this.btnFindClient;
            this.btnFindClient.Image = global::Bank_C_.Properties.Resources.magnifying_glass;
            this.btnFindClient.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnFindClient.ImageSize = new System.Drawing.Size(35, 35);
            this.btnFindClient.Location = new System.Drawing.Point(516, 147);
            this.btnFindClient.Name = "btnFindClient";
            this.btnFindClient.ShadowDecoration.Parent = this.btnFindClient;
            this.btnFindClient.Size = new System.Drawing.Size(240, 45);
            this.btnFindClient.TabIndex = 38;
            this.btnFindClient.Text = "Find Client";
            this.btnFindClient.Click += new System.EventHandler(this.btnFindClient_Click);
            // 
            // btnDeleteClient
            // 
            this.btnDeleteClient.BorderRadius = 10;
            this.btnDeleteClient.CheckedState.Parent = this.btnDeleteClient;
            this.btnDeleteClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteClient.CustomImages.Parent = this.btnDeleteClient;
            this.btnDeleteClient.FillColor = System.Drawing.Color.DimGray;
            this.btnDeleteClient.FillColor2 = System.Drawing.Color.Black;
            this.btnDeleteClient.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteClient.ForeColor = System.Drawing.Color.White;
            this.btnDeleteClient.HoverState.Parent = this.btnDeleteClient;
            this.btnDeleteClient.Image = global::Bank_C_.Properties.Resources.bin;
            this.btnDeleteClient.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDeleteClient.ImageSize = new System.Drawing.Size(35, 35);
            this.btnDeleteClient.Location = new System.Drawing.Point(23, 197);
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.ShadowDecoration.Parent = this.btnDeleteClient;
            this.btnDeleteClient.Size = new System.Drawing.Size(733, 45);
            this.btnDeleteClient.TabIndex = 37;
            this.btnDeleteClient.Text = "Delete Client";
            this.btnDeleteClient.Click += new System.EventHandler(this.btnDeleteClient_Click);
            // 
            // btnAddClient
            // 
            this.btnAddClient.BorderRadius = 10;
            this.btnAddClient.CheckedState.Parent = this.btnAddClient;
            this.btnAddClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddClient.CustomImages.Parent = this.btnAddClient;
            this.btnAddClient.FillColor = System.Drawing.Color.DimGray;
            this.btnAddClient.FillColor2 = System.Drawing.Color.Black;
            this.btnAddClient.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClient.ForeColor = System.Drawing.Color.White;
            this.btnAddClient.HoverState.Parent = this.btnAddClient;
            this.btnAddClient.Image = global::Bank_C_.Properties.Resources.add;
            this.btnAddClient.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddClient.ImageSize = new System.Drawing.Size(35, 35);
            this.btnAddClient.Location = new System.Drawing.Point(23, 147);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.ShadowDecoration.Parent = this.btnAddClient;
            this.btnAddClient.Size = new System.Drawing.Size(240, 45);
            this.btnAddClient.TabIndex = 36;
            this.btnAddClient.Text = "Add Client";
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // btnClientsList
            // 
            this.btnClientsList.BorderRadius = 10;
            this.btnClientsList.CheckedState.Parent = this.btnClientsList;
            this.btnClientsList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientsList.CustomImages.Parent = this.btnClientsList;
            this.btnClientsList.FillColor = System.Drawing.Color.DimGray;
            this.btnClientsList.FillColor2 = System.Drawing.Color.Black;
            this.btnClientsList.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientsList.ForeColor = System.Drawing.Color.White;
            this.btnClientsList.HoverState.Parent = this.btnClientsList;
            this.btnClientsList.Image = global::Bank_C_.Properties.Resources.public_relation;
            this.btnClientsList.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnClientsList.ImageSize = new System.Drawing.Size(35, 35);
            this.btnClientsList.Location = new System.Drawing.Point(23, 97);
            this.btnClientsList.Name = "btnClientsList";
            this.btnClientsList.ShadowDecoration.Parent = this.btnClientsList;
            this.btnClientsList.Size = new System.Drawing.Size(733, 45);
            this.btnClientsList.TabIndex = 35;
            this.btnClientsList.Text = "Clients List";
            this.btnClientsList.Click += new System.EventHandler(this.btnClientsList_Click);
            // 
            // frmClientsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(784, 533);
            this.Controls.Add(this.pnlFormLoader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmClientsMenu";
            this.Text = "Form1";
            this.pnlFormLoader.ResumeLayout(false);
            this.pnlFormLoader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFormLoader;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2GradientButton btnUpdateClient;
        private Guna.UI2.WinForms.Guna2GradientButton btnFindClient;
        private Guna.UI2.WinForms.Guna2GradientButton btnDeleteClient;
        private Guna.UI2.WinForms.Guna2GradientButton btnAddClient;
        private Guna.UI2.WinForms.Guna2GradientButton btnClientsList;
        private System.Windows.Forms.Label lblSectionDescription;
        private System.Windows.Forms.Label lblSection;
    }
}