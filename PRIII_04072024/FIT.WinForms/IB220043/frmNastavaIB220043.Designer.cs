namespace FIT.WinForms.IB220043
{
    partial class frmNastavaIB220043
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
            lblNazivOznaka = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cmbPredmet = new ComboBox();
            cmbDan = new ComboBox();
            cmbVrijeme = new ComboBox();
            btnDodaj = new Button();
            dgvPodaci = new DataGridView();
            Predmet = new DataGridViewTextBoxColumn();
            Dan = new DataGridViewTextBoxColumn();
            Vrijeme = new DataGridViewTextBoxColumn();
            err = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // lblNazivOznaka
            // 
            lblNazivOznaka.AutoSize = true;
            lblNazivOznaka.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblNazivOznaka.Location = new Point(12, 71);
            lblNazivOznaka.Name = "lblNazivOznaka";
            lblNazivOznaka.Size = new Size(83, 32);
            lblNazivOznaka.TabIndex = 0;
            lblNazivOznaka.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 146);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 1;
            label1.Text = "Predmet:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(498, 146);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 2;
            label2.Text = "Vrijeme:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(353, 146);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 3;
            label3.Text = "Dan:";
            // 
            // cmbPredmet
            // 
            cmbPredmet.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPredmet.FormattingEnabled = true;
            cmbPredmet.Location = new Point(12, 169);
            cmbPredmet.Name = "cmbPredmet";
            cmbPredmet.Size = new Size(332, 28);
            cmbPredmet.TabIndex = 4;
            // 
            // cmbDan
            // 
            cmbDan.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDan.FormattingEnabled = true;
            cmbDan.Location = new Point(353, 169);
            cmbDan.Name = "cmbDan";
            cmbDan.Size = new Size(139, 28);
            cmbDan.TabIndex = 5;
            // 
            // cmbVrijeme
            // 
            cmbVrijeme.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVrijeme.FormattingEnabled = true;
            cmbVrijeme.Location = new Point(498, 169);
            cmbVrijeme.Name = "cmbVrijeme";
            cmbVrijeme.Size = new Size(139, 28);
            cmbVrijeme.TabIndex = 6;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(643, 169);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(112, 29);
            btnDodaj.TabIndex = 7;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            // 
            // dgvPodaci
            // 
            dgvPodaci.AllowUserToAddRows = false;
            dgvPodaci.AllowUserToDeleteRows = false;
            dgvPodaci.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPodaci.Columns.AddRange(new DataGridViewColumn[] { Predmet, Dan, Vrijeme });
            dgvPodaci.Location = new Point(12, 203);
            dgvPodaci.Name = "dgvPodaci";
            dgvPodaci.ReadOnly = true;
            dgvPodaci.RowHeadersWidth = 51;
            dgvPodaci.RowTemplate.Height = 29;
            dgvPodaci.Size = new Size(743, 235);
            dgvPodaci.TabIndex = 8;
            // 
            // Predmet
            // 
            Predmet.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Predmet.DataPropertyName = "Predmet";
            Predmet.HeaderText = "Predmet";
            Predmet.MinimumWidth = 6;
            Predmet.Name = "Predmet";
            Predmet.ReadOnly = true;
            // 
            // Dan
            // 
            Dan.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Dan.DataPropertyName = "Dan";
            Dan.HeaderText = "Dan";
            Dan.MinimumWidth = 6;
            Dan.Name = "Dan";
            Dan.ReadOnly = true;
            // 
            // Vrijeme
            // 
            Vrijeme.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Vrijeme.DataPropertyName = "Vrijeme";
            Vrijeme.HeaderText = "Vrijeme";
            Vrijeme.MinimumWidth = 6;
            Vrijeme.Name = "Vrijeme";
            Vrijeme.ReadOnly = true;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // frmNastavaIB220043
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(767, 450);
            Controls.Add(dgvPodaci);
            Controls.Add(btnDodaj);
            Controls.Add(cmbVrijeme);
            Controls.Add(cmbDan);
            Controls.Add(cmbPredmet);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblNazivOznaka);
            Name = "frmNastavaIB220043";
            Text = "Nastava";
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNazivOznaka;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cmbPredmet;
        private ComboBox cmbDan;
        private ComboBox cmbVrijeme;
        private Button btnDodaj;
        private DataGridView dgvPodaci;
        private DataGridViewTextBoxColumn Predmet;
        private DataGridViewTextBoxColumn Dan;
        private DataGridViewTextBoxColumn Vrijeme;
        private ErrorProvider err;
    }
}