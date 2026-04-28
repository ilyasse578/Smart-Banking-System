namespace Bank_C_
{
    partial class frmLoginRegisterList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlFormLoader = new System.Windows.Forms.Panel();
            this.dgvLoginRegisters = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lblSectionDescription = new System.Windows.Forms.Label();
            this.lblSection = new System.Windows.Forms.Label();
            this.pnlFormLoader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoginRegisters)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFormLoader
            // 
            this.pnlFormLoader.BackColor = System.Drawing.Color.LightGray;
            this.pnlFormLoader.Controls.Add(this.dgvLoginRegisters);
            this.pnlFormLoader.Controls.Add(this.lblSectionDescription);
            this.pnlFormLoader.Controls.Add(this.lblSection);
            this.pnlFormLoader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFormLoader.Location = new System.Drawing.Point(0, 0);
            this.pnlFormLoader.Name = "pnlFormLoader";
            this.pnlFormLoader.Size = new System.Drawing.Size(784, 533);
            this.pnlFormLoader.TabIndex = 1;
            // 
            // dgvLoginRegisters
            // 
            this.dgvLoginRegisters.AllowUserToAddRows = false;
            this.dgvLoginRegisters.AllowUserToDeleteRows = false;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.White;
            this.dgvLoginRegisters.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvLoginRegisters.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoginRegisters.BackgroundColor = System.Drawing.Color.White;
            this.dgvLoginRegisters.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLoginRegisters.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvLoginRegisters.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLoginRegisters.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvLoginRegisters.ColumnHeadersHeight = 50;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLoginRegisters.DefaultCellStyle = dataGridViewCellStyle19;
            this.dgvLoginRegisters.EnableHeadersVisualStyles = false;
            this.dgvLoginRegisters.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvLoginRegisters.Location = new System.Drawing.Point(28, 91);
            this.dgvLoginRegisters.Name = "dgvLoginRegisters";
            this.dgvLoginRegisters.ReadOnly = true;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLoginRegisters.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvLoginRegisters.RowHeadersVisible = false;
            this.dgvLoginRegisters.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoginRegisters.Size = new System.Drawing.Size(725, 365);
            this.dgvLoginRegisters.TabIndex = 36;
            this.dgvLoginRegisters.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvLoginRegisters.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvLoginRegisters.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvLoginRegisters.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvLoginRegisters.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvLoginRegisters.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvLoginRegisters.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvLoginRegisters.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvLoginRegisters.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvLoginRegisters.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvLoginRegisters.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvLoginRegisters.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvLoginRegisters.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvLoginRegisters.ThemeStyle.HeaderStyle.Height = 50;
            this.dgvLoginRegisters.ThemeStyle.ReadOnly = true;
            this.dgvLoginRegisters.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvLoginRegisters.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvLoginRegisters.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvLoginRegisters.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvLoginRegisters.ThemeStyle.RowsStyle.Height = 22;
            this.dgvLoginRegisters.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvLoginRegisters.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // lblSectionDescription
            // 
            this.lblSectionDescription.AutoSize = true;
            this.lblSectionDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblSectionDescription.Font = new System.Drawing.Font("Segoe UI Black", 13F, System.Drawing.FontStyle.Bold);
            this.lblSectionDescription.ForeColor = System.Drawing.Color.Black;
            this.lblSectionDescription.Location = new System.Drawing.Point(10, 48);
            this.lblSectionDescription.Name = "lblSectionDescription";
            this.lblSectionDescription.Size = new System.Drawing.Size(332, 25);
            this.lblSectionDescription.TabIndex = 35;
            this.lblSectionDescription.Text = "Here you can see all login register...";
            // 
            // lblSection
            // 
            this.lblSection.AutoSize = true;
            this.lblSection.BackColor = System.Drawing.Color.Transparent;
            this.lblSection.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSection.ForeColor = System.Drawing.Color.Black;
            this.lblSection.Location = new System.Drawing.Point(10, 10);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(312, 37);
            this.lblSection.TabIndex = 34;
            this.lblSection.Text = "Login Register Section";
            // 
            // frmLoginRegisterList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 533);
            this.Controls.Add(this.pnlFormLoader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLoginRegisterList";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmLoginRegisterList_Load);
            this.pnlFormLoader.ResumeLayout(false);
            this.pnlFormLoader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoginRegisters)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFormLoader;
        private Guna.UI2.WinForms.Guna2DataGridView dgvLoginRegisters;
        private System.Windows.Forms.Label lblSectionDescription;
        private System.Windows.Forms.Label lblSection;
    }
}