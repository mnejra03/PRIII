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
            components = new System.ComponentModel.Container();
            dgvPodaci = new DataGridView();
            BrojIndeksa = new DataGridViewTextBoxColumn();
            ImePrezime = new DataGridViewTextBoxColumn();
            Prosjek = new DataGridViewTextBoxColumn();
            DatumRodjenja = new DataGridViewTextBoxColumn();
            Aktivan = new DataGridViewCheckBoxColumn();
            Uvjerenje = new DataGridViewButtonColumn();
            dtpDo = new DateTimePicker();
            dtpOd = new DateTimePicker();
            cmbSpol = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // dgvPodaci
            // 
            dgvPodaci.AllowUserToAddRows = false;
            dgvPodaci.AllowUserToDeleteRows = false;
            dgvPodaci.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPodaci.Columns.AddRange(new DataGridViewColumn[] { BrojIndeksa, ImePrezime, Prosjek, DatumRodjenja, Aktivan, Uvjerenje });
            dgvPodaci.Location = new Point(14, 58);
            dgvPodaci.Name = "dgvPodaci";
            dgvPodaci.ReadOnly = true;
            dgvPodaci.RowHeadersWidth = 51;
            dgvPodaci.RowTemplate.Height = 29;
            dgvPodaci.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPodaci.Size = new Size(906, 188);
            dgvPodaci.TabIndex = 13;
            dgvPodaci.CellClick += dgvPodaci_CellClick;
            // 
            // BrojIndeksa
            // 
            BrojIndeksa.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            BrojIndeksa.DataPropertyName = "BrojIndeksa";
            BrojIndeksa.HeaderText = "Broj indeksa";
            BrojIndeksa.MinimumWidth = 6;
            BrojIndeksa.Name = "BrojIndeksa";
            BrojIndeksa.ReadOnly = true;
            // 
            // ImePrezime
            // 
            ImePrezime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ImePrezime.DataPropertyName = "ImePrezime";
            ImePrezime.HeaderText = "Ime i prezime";
            ImePrezime.MinimumWidth = 6;
            ImePrezime.Name = "ImePrezime";
            ImePrezime.ReadOnly = true;
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
            // DatumRodjenja
            // 
            DatumRodjenja.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DatumRodjenja.DataPropertyName = "DatumRodjenja";
            DatumRodjenja.HeaderText = "Datum rodjenja";
            DatumRodjenja.MinimumWidth = 6;
            DatumRodjenja.Name = "DatumRodjenja";
            DatumRodjenja.ReadOnly = true;
            // 
            // Aktivan
            // 
            Aktivan.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Aktivan.DataPropertyName = "Aktivan";
            Aktivan.HeaderText = "Aktivan";
            Aktivan.MinimumWidth = 6;
            Aktivan.Name = "Aktivan";
            Aktivan.ReadOnly = true;
            // 
            // Uvjerenje
            // 
            Uvjerenje.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Uvjerenje.DataPropertyName = "Uvjerenje";
            Uvjerenje.HeaderText = "";
            Uvjerenje.MinimumWidth = 6;
            Uvjerenje.Name = "Uvjerenje";
            Uvjerenje.ReadOnly = true;
            Uvjerenje.Text = "Uvjerenje";
            Uvjerenje.UseColumnTextForButtonValue = true;
            // 
            // dtpDo
            // 
            dtpDo.Location = new Point(653, 10);
            dtpDo.Name = "dtpDo";
            dtpDo.Size = new Size(250, 27);
            dtpDo.TabIndex = 12;
            dtpDo.ValueChanged += dtpDo_ValueChanged;
            // 
            // dtpOd
            // 
            dtpOd.Location = new Point(364, 12);
            dtpOd.Name = "dtpOd";
            dtpOd.Size = new Size(250, 27);
            dtpOd.TabIndex = 11;
            dtpOd.ValueChanged += dtpOd_ValueChanged;
            // 
            // cmbSpol
            // 
            cmbSpol.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSpol.FormattingEnabled = true;
            cmbSpol.Location = new Point(59, 12);
            cmbSpol.Name = "cmbSpol";
            cmbSpol.Size = new Size(151, 28);
            cmbSpol.TabIndex = 10;
            cmbSpol.SelectionChangeCommitted += cmbSpol_SelectionChangeCommitted;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(620, 15);
            label3.Name = "label3";
            label3.Size = new Size(27, 20);
            label3.TabIndex = 9;
            label3.Text = "do";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(216, 15);
            label2.Name = "label2";
            label2.Size = new Size(142, 20);
            label2.TabIndex = 8;
            label2.Text = "rodjen u periodu od";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 15);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 7;
            label1.Text = "Spol";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmPretragaIB220043
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 264);
            Controls.Add(dgvPodaci);
            Controls.Add(dtpDo);
            Controls.Add(dtpOd);
            Controls.Add(cmbSpol);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmPretragaIB220043";
            Text = "Pretraga studenata";
            Load += frmPretragaIB220043_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPodaci;
        private DateTimePicker dtpDo;
        private DateTimePicker dtpOd;
        private ComboBox cmbSpol;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridViewTextBoxColumn BrojIndeksa;
        private DataGridViewTextBoxColumn ImePrezime;
        private DataGridViewTextBoxColumn Prosjek;
        private DataGridViewTextBoxColumn DatumRodjenja;
        private DataGridViewCheckBoxColumn Aktivan;
        private DataGridViewButtonColumn Uvjerenje;
        private ErrorProvider errorProvider1;
    }
}