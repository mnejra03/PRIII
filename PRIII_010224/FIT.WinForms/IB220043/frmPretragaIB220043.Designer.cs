namespace FIT.WinForms.IB220043
{
    partial class frmPretragaIB220043
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
            lblDrzava = new Label();
            lblGrad = new Label();
            cmbDrzava = new ComboBox();
            cmbGrad = new ComboBox();
            dgvPodaci = new DataGridView();
            Ime = new DataGridViewTextBoxColumn();
            Prezime = new DataGridViewTextBoxColumn();
            Grad = new DataGridViewTextBoxColumn();
            Drzava = new DataGridViewTextBoxColumn();
            Prosjek = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).BeginInit();
            SuspendLayout();
            // 
            // lblDrzava
            // 
            lblDrzava.AutoSize = true;
            lblDrzava.Location = new Point(12, 9);
            lblDrzava.Name = "lblDrzava";
            lblDrzava.Size = new Size(55, 20);
            lblDrzava.TabIndex = 0;
            lblDrzava.Text = "Država";
            // 
            // lblGrad
            // 
            lblGrad.AutoSize = true;
            lblGrad.Location = new Point(336, 9);
            lblGrad.Name = "lblGrad";
            lblGrad.Size = new Size(41, 20);
            lblGrad.TabIndex = 1;
            lblGrad.Text = "Grad";
            // 
            // cmbDrzava
            // 
            cmbDrzava.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDrzava.FormattingEnabled = true;
            cmbDrzava.Location = new Point(12, 32);
            cmbDrzava.Name = "cmbDrzava";
            cmbDrzava.Size = new Size(237, 28);
            cmbDrzava.TabIndex = 2;
            cmbDrzava.SelectedIndexChanged += cmbDrzava_SelectedIndexChanged;
            // 
            // cmbGrad
            // 
            cmbGrad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGrad.FormattingEnabled = true;
            cmbGrad.Location = new Point(336, 32);
            cmbGrad.Name = "cmbGrad";
            cmbGrad.Size = new Size(237, 28);
            cmbGrad.TabIndex = 3;
            cmbGrad.SelectedIndexChanged += cmbGrad_SelectedIndexChanged;
            // 
            // dgvPodaci
            // 
            dgvPodaci.AllowUserToAddRows = false;
            dgvPodaci.AllowUserToDeleteRows = false;
            dgvPodaci.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPodaci.Columns.AddRange(new DataGridViewColumn[] { Ime, Prezime, Grad, Drzava, Prosjek });
            dgvPodaci.Location = new Point(12, 84);
            dgvPodaci.Name = "dgvPodaci";
            dgvPodaci.ReadOnly = true;
            dgvPodaci.RowHeadersWidth = 51;
            dgvPodaci.RowTemplate.Height = 29;
            dgvPodaci.Size = new Size(730, 273);
            dgvPodaci.TabIndex = 4;
            // 
            // Ime
            // 
            Ime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Ime.DataPropertyName = "Ime";
            Ime.HeaderText = "Ime";
            Ime.MinimumWidth = 6;
            Ime.Name = "Ime";
            Ime.ReadOnly = true;
            // 
            // Prezime
            // 
            Prezime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Prezime.DataPropertyName = "Prezime";
            Prezime.HeaderText = "Prezime";
            Prezime.MinimumWidth = 6;
            Prezime.Name = "Prezime";
            Prezime.ReadOnly = true;
            // 
            // Grad
            // 
            Grad.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Grad.DataPropertyName = "Grad";
            Grad.HeaderText = "Grad";
            Grad.MinimumWidth = 6;
            Grad.Name = "Grad";
            Grad.ReadOnly = true;
            // 
            // Drzava
            // 
            Drzava.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Drzava.DataPropertyName = "Drzava";
            Drzava.HeaderText = "Drzava";
            Drzava.MinimumWidth = 6;
            Drzava.Name = "Drzava";
            Drzava.ReadOnly = true;
            // 
            // Prosjek
            // 
            Prosjek.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Prosjek.DataPropertyName = "Prosjek";
            Prosjek.HeaderText = "Prosjek";
            Prosjek.MinimumWidth = 6;
            Prosjek.Name = "Prosjek";
            Prosjek.ReadOnly = true;
            // 
            // frmPretragaIB220043
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(752, 369);
            Controls.Add(dgvPodaci);
            Controls.Add(cmbGrad);
            Controls.Add(cmbDrzava);
            Controls.Add(lblGrad);
            Controls.Add(lblDrzava);
            Name = "frmPretragaIB220043";
            Text = "Podaci o studentima";
            Load += frmPretragaIB220043_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDrzava;
        private Label lblGrad;
        private ComboBox cmbDrzava;
        private ComboBox cmbGrad;
        private DataGridView dgvPodaci;
        private DataGridViewTextBoxColumn Ime;
        private DataGridViewTextBoxColumn Prezime;
        private DataGridViewTextBoxColumn Grad;
        private DataGridViewTextBoxColumn Drzava;
        private DataGridViewTextBoxColumn Prosjek;
    }
}