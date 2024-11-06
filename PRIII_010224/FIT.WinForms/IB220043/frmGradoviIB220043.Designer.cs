namespace FIT.WinForms.IB220043
{
    partial class frmGradoviIB220043
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
            pbSlika = new PictureBox();
            lblNazivDrzave = new Label();
            lblNoviGrad = new Label();
            tbNazivGrada = new TextBox();
            btnDodaj = new Button();
            gbGenerator = new GroupBox();
            tbInfo = new TextBox();
            btnGenerisi = new Button();
            cbStatus = new CheckBox();
            tbBrojGradova = new TextBox();
            lblInfo = new Label();
            lblBrojGradova = new Label();
            dgvPodaci = new DataGridView();
            Naziv = new DataGridViewTextBoxColumn();
            Status = new DataGridViewCheckBoxColumn();
            PromijeniStatus = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)pbSlika).BeginInit();
            gbGenerator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).BeginInit();
            SuspendLayout();
            // 
            // pbSlika
            // 
            pbSlika.Location = new Point(12, 12);
            pbSlika.Name = "pbSlika";
            pbSlika.Size = new Size(247, 131);
            pbSlika.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSlika.TabIndex = 0;
            pbSlika.TabStop = false;
            // 
            // lblNazivDrzave
            // 
            lblNazivDrzave.AutoSize = true;
            lblNazivDrzave.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblNazivDrzave.Location = new Point(279, 81);
            lblNazivDrzave.Name = "lblNazivDrzave";
            lblNazivDrzave.Size = new Size(96, 37);
            lblNazivDrzave.TabIndex = 1;
            lblNazivDrzave.Text = "label1";
            // 
            // lblNoviGrad
            // 
            lblNoviGrad.AutoSize = true;
            lblNoviGrad.Location = new Point(12, 174);
            lblNoviGrad.Name = "lblNoviGrad";
            lblNoviGrad.Size = new Size(188, 20);
            lblNoviGrad.TabIndex = 2;
            lblNoviGrad.Text = "Unesite naziv novog grada:";
            // 
            // tbNazivGrada
            // 
            tbNazivGrada.Location = new Point(206, 171);
            tbNazivGrada.Name = "tbNazivGrada";
            tbNazivGrada.Size = new Size(267, 27);
            tbNazivGrada.TabIndex = 3;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(482, 170);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(94, 29);
            btnDodaj.TabIndex = 4;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // gbGenerator
            // 
            gbGenerator.Controls.Add(tbInfo);
            gbGenerator.Controls.Add(btnGenerisi);
            gbGenerator.Controls.Add(cbStatus);
            gbGenerator.Controls.Add(tbBrojGradova);
            gbGenerator.Controls.Add(lblInfo);
            gbGenerator.Controls.Add(lblBrojGradova);
            gbGenerator.Location = new Point(12, 434);
            gbGenerator.Name = "gbGenerator";
            gbGenerator.Size = new Size(564, 232);
            gbGenerator.TabIndex = 5;
            gbGenerator.TabStop = false;
            gbGenerator.Text = "Generator";
            // 
            // tbInfo
            // 
            tbInfo.Location = new Point(6, 107);
            tbInfo.Multiline = true;
            tbInfo.Name = "tbInfo";
            tbInfo.Size = new Size(552, 119);
            tbInfo.TabIndex = 5;
            // 
            // btnGenerisi
            // 
            btnGenerisi.Location = new Point(442, 40);
            btnGenerisi.Name = "btnGenerisi";
            btnGenerisi.Size = new Size(94, 29);
            btnGenerisi.TabIndex = 4;
            btnGenerisi.Text = "Generiši";
            btnGenerisi.UseVisualStyleBackColor = true;
            // 
            // cbStatus
            // 
            cbStatus.AutoSize = true;
            cbStatus.Location = new Point(245, 42);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(76, 24);
            cbStatus.TabIndex = 3;
            cbStatus.Text = "Aktivni";
            cbStatus.UseVisualStyleBackColor = true;
            // 
            // tbBrojGradova
            // 
            tbBrojGradova.Location = new Point(110, 40);
            tbBrojGradova.Name = "tbBrojGradova";
            tbBrojGradova.Size = new Size(67, 27);
            tbBrojGradova.TabIndex = 2;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Location = new Point(6, 84);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(38, 20);
            lblInfo.TabIndex = 1;
            lblInfo.Text = "Info:";
            // 
            // lblBrojGradova
            // 
            lblBrojGradova.AutoSize = true;
            lblBrojGradova.Location = new Point(6, 43);
            lblBrojGradova.Name = "lblBrojGradova";
            lblBrojGradova.Size = new Size(98, 20);
            lblBrojGradova.TabIndex = 0;
            lblBrojGradova.Text = "Broj gradova:";
            // 
            // dgvPodaci
            // 
            dgvPodaci.AllowUserToAddRows = false;
            dgvPodaci.AllowUserToDeleteRows = false;
            dgvPodaci.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPodaci.Columns.AddRange(new DataGridViewColumn[] { Naziv, Status, PromijeniStatus });
            dgvPodaci.Location = new Point(12, 204);
            dgvPodaci.Name = "dgvPodaci";
            dgvPodaci.ReadOnly = true;
            dgvPodaci.RowHeadersWidth = 51;
            dgvPodaci.RowTemplate.Height = 29;
            dgvPodaci.Size = new Size(564, 224);
            dgvPodaci.TabIndex = 6;
            dgvPodaci.CellContentClick += dgvPodaci_CellContentClick;
            // 
            // Naziv
            // 
            Naziv.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Naziv.DataPropertyName = "Naziv";
            Naziv.HeaderText = "Naziv grada";
            Naziv.MinimumWidth = 6;
            Naziv.Name = "Naziv";
            Naziv.ReadOnly = true;
            // 
            // Status
            // 
            Status.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Aktivan";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.ReadOnly = true;
            // 
            // PromijeniStatus
            // 
            PromijeniStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PromijeniStatus.HeaderText = "";
            PromijeniStatus.MinimumWidth = 6;
            PromijeniStatus.Name = "PromijeniStatus";
            PromijeniStatus.ReadOnly = true;
            PromijeniStatus.Text = "Promijeni status";
            PromijeniStatus.UseColumnTextForButtonValue = true;
            // 
            // frmGradoviIB220043
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(586, 678);
            Controls.Add(dgvPodaci);
            Controls.Add(gbGenerator);
            Controls.Add(btnDodaj);
            Controls.Add(tbNazivGrada);
            Controls.Add(lblNoviGrad);
            Controls.Add(lblNazivDrzave);
            Controls.Add(pbSlika);
            Name = "frmGradoviIB220043";
            Text = "Podaci o gradu";
            TopMost = true;
            Load += frmGradoviIB220043_Load;
            ((System.ComponentModel.ISupportInitialize)pbSlika).EndInit();
            gbGenerator.ResumeLayout(false);
            gbGenerator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbSlika;
        private Label lblNazivDrzave;
        private Label lblNoviGrad;
        private TextBox tbNazivGrada;
        private Button btnDodaj;
        private GroupBox gbGenerator;
        private DataGridView dgvPodaci;
        private TextBox tbInfo;
        private Button btnGenerisi;
        private CheckBox cbStatus;
        private TextBox tbBrojGradova;
        private Label lblInfo;
        private Label lblBrojGradova;
        private DataGridViewTextBoxColumn Naziv;
        private DataGridViewCheckBoxColumn Status;
        private DataGridViewButtonColumn PromijeniStatus;
    }
}