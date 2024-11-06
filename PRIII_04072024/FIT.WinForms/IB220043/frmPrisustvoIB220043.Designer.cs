namespace FIT.WinForms.IB220043
{
    partial class frmPrisustvoIB220043
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
            lblNazivOznaka = new Label();
            lblBrojStudenata = new Label();
            label1 = new Label();
            label2 = new Label();
            cmbNastava = new ComboBox();
            cmbStudent = new ComboBox();
            btnDodaj = new Button();
            dgvPodaci = new DataGridView();
            Nastava = new DataGridViewTextBoxColumn();
            Student = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).BeginInit();
            SuspendLayout();
            // 
            // lblNazivOznaka
            // 
            lblNazivOznaka.AutoSize = true;
            lblNazivOznaka.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblNazivOznaka.Location = new Point(12, 36);
            lblNazivOznaka.Name = "lblNazivOznaka";
            lblNazivOznaka.Size = new Size(83, 32);
            lblNazivOznaka.TabIndex = 0;
            lblNazivOznaka.Text = "label1";
            // 
            // lblBrojStudenata
            // 
            lblBrojStudenata.AutoSize = true;
            lblBrojStudenata.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblBrojStudenata.Location = new Point(824, 36);
            lblBrojStudenata.Name = "lblBrojStudenata";
            lblBrojStudenata.Size = new Size(83, 32);
            lblBrojStudenata.TabIndex = 1;
            lblBrojStudenata.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 127);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 2;
            label1.Text = "Nastava:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(391, 127);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 3;
            label2.Text = "Student:";
            // 
            // cmbNastava
            // 
            cmbNastava.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNastava.FormattingEnabled = true;
            cmbNastava.Location = new Point(12, 150);
            cmbNastava.Name = "cmbNastava";
            cmbNastava.Size = new Size(373, 28);
            cmbNastava.TabIndex = 4;
            // 
            // cmbStudent
            // 
            cmbStudent.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStudent.FormattingEnabled = true;
            cmbStudent.Location = new Point(391, 150);
            cmbStudent.Name = "cmbStudent";
            cmbStudent.Size = new Size(373, 28);
            cmbStudent.TabIndex = 5;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(770, 149);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(137, 29);
            btnDodaj.TabIndex = 6;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // dgvPodaci
            // 
            dgvPodaci.AllowUserToAddRows = false;
            dgvPodaci.AllowUserToDeleteRows = false;
            dgvPodaci.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPodaci.Columns.AddRange(new DataGridViewColumn[] { Nastava, Student });
            dgvPodaci.Location = new Point(12, 184);
            dgvPodaci.Name = "dgvPodaci";
            dgvPodaci.ReadOnly = true;
            dgvPodaci.RowHeadersWidth = 51;
            dgvPodaci.RowTemplate.Height = 29;
            dgvPodaci.Size = new Size(895, 254);
            dgvPodaci.TabIndex = 7;
            // 
            // Nastava
            // 
            Nastava.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nastava.DataPropertyName = "Nastava";
            Nastava.HeaderText = "Predmet, Prostorija, Vrijeme";
            Nastava.MinimumWidth = 6;
            Nastava.Name = "Nastava";
            Nastava.ReadOnly = true;
            // 
            // Student
            // 
            Student.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Student.DataPropertyName = "Student";
            Student.HeaderText = "Student";
            Student.MinimumWidth = 6;
            Student.Name = "Student";
            Student.ReadOnly = true;
            // 
            // frmPrisustvoIB220043
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(919, 450);
            Controls.Add(dgvPodaci);
            Controls.Add(btnDodaj);
            Controls.Add(cmbStudent);
            Controls.Add(cmbNastava);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblBrojStudenata);
            Controls.Add(lblNazivOznaka);
            Name = "frmPrisustvoIB220043";
            Text = "Evidencija nastave";
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNazivOznaka;
        private Label lblBrojStudenata;
        private Label label1;
        private Label label2;
        private ComboBox cmbNastava;
        private ComboBox cmbStudent;
        private Button btnDodaj;
        private DataGridView dgvPodaci;
        private DataGridViewTextBoxColumn Nastava;
        private DataGridViewTextBoxColumn Student;
    }
}