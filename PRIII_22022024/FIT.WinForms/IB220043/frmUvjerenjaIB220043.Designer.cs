namespace FIT.WinForms.IB220043
{
    partial class frmUvjerenjaIB220043
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
            groupBox1 = new GroupBox();
            label4 = new Label();
            txtInfo = new TextBox();
            btnDodaj = new Button();
            txtBrojZahtjeva = new TextBox();
            txtSvrha = new TextBox();
            label3 = new Label();
            label2 = new Label();
            cmbVrstaUvjerenja = new ComboBox();
            label1 = new Label();
            dgvPodaci = new DataGridView();
            VrijemeKreiranja = new DataGridViewTextBoxColumn();
            VrstaUvjerenja = new DataGridViewTextBoxColumn();
            SvrhaIzdavanja = new DataGridViewTextBoxColumn();
            Uplatnica = new DataGridViewImageColumn();
            Printano = new DataGridViewCheckBoxColumn();
            Obrisi = new DataGridViewButtonColumn();
            Printaj = new DataGridViewButtonColumn();
            btnNoviZahtjev = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtInfo);
            groupBox1.Controls.Add(btnDodaj);
            groupBox1.Controls.Add(txtBrojZahtjeva);
            groupBox1.Controls.Add(txtSvrha);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cmbVrstaUvjerenja);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(13, 245);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(871, 283);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dodavanje zahtjeva za izdavanjem uvjerenja";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 84);
            label4.Name = "label4";
            label4.Size = new Size(35, 20);
            label4.TabIndex = 8;
            label4.Text = "Info";
            // 
            // txtInfo
            // 
            txtInfo.Location = new Point(14, 107);
            txtInfo.Multiline = true;
            txtInfo.Name = "txtInfo";
            txtInfo.Size = new Size(851, 156);
            txtInfo.TabIndex = 7;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(771, 51);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(94, 29);
            btnDodaj.TabIndex = 6;
            btnDodaj.Text = "Dodaj =>";
            btnDodaj.UseVisualStyleBackColor = true;
            // 
            // txtBrojZahtjeva
            // 
            txtBrojZahtjeva.Location = new Point(656, 53);
            txtBrojZahtjeva.Name = "txtBrojZahtjeva";
            txtBrojZahtjeva.Size = new Size(109, 27);
            txtBrojZahtjeva.TabIndex = 5;
            // 
            // txtSvrha
            // 
            txtSvrha.Location = new Point(300, 53);
            txtSvrha.Name = "txtSvrha";
            txtSvrha.Size = new Size(350, 27);
            txtSvrha.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(656, 30);
            label3.Name = "label3";
            label3.Size = new Size(95, 20);
            label3.TabIndex = 3;
            label3.Text = "Broj zahtjeva";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(300, 30);
            label2.Name = "label2";
            label2.Size = new Size(112, 20);
            label2.TabIndex = 2;
            label2.Text = "Svrha izdavanja";
            // 
            // cmbVrstaUvjerenja
            // 
            cmbVrstaUvjerenja.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVrstaUvjerenja.FormattingEnabled = true;
            cmbVrstaUvjerenja.Items.AddRange(new object[] { "Potvrda o statusu studenta", "Uvjerenje o polozenim ispitima sa prosjecnom ocjenom" });
            cmbVrstaUvjerenja.Location = new Point(12, 53);
            cmbVrstaUvjerenja.Name = "cmbVrstaUvjerenja";
            cmbVrstaUvjerenja.Size = new Size(282, 28);
            cmbVrstaUvjerenja.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 32);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 0;
            label1.Text = "Vrsta uvjerenja";
            // 
            // dgvPodaci
            // 
            dgvPodaci.AllowUserToAddRows = false;
            dgvPodaci.AllowUserToDeleteRows = false;
            dgvPodaci.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPodaci.Columns.AddRange(new DataGridViewColumn[] { VrijemeKreiranja, VrstaUvjerenja, SvrhaIzdavanja, Uplatnica, Printano, Obrisi, Printaj });
            dgvPodaci.Location = new Point(12, 40);
            dgvPodaci.Name = "dgvPodaci";
            dgvPodaci.ReadOnly = true;
            dgvPodaci.RowHeadersWidth = 51;
            dgvPodaci.RowTemplate.Height = 29;
            dgvPodaci.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPodaci.Size = new Size(872, 188);
            dgvPodaci.TabIndex = 4;
            dgvPodaci.CellClick += dgvPodaci_CellClick;
            // 
            // VrijemeKreiranja
            // 
            VrijemeKreiranja.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            VrijemeKreiranja.DataPropertyName = "VrijemeKreiranja";
            VrijemeKreiranja.HeaderText = "Datum";
            VrijemeKreiranja.MinimumWidth = 6;
            VrijemeKreiranja.Name = "VrijemeKreiranja";
            VrijemeKreiranja.ReadOnly = true;
            // 
            // VrstaUvjerenja
            // 
            VrstaUvjerenja.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            VrstaUvjerenja.DataPropertyName = "VrstaUvjerenja";
            VrstaUvjerenja.HeaderText = "Vrsta";
            VrstaUvjerenja.MinimumWidth = 6;
            VrstaUvjerenja.Name = "VrstaUvjerenja";
            VrstaUvjerenja.ReadOnly = true;
            // 
            // SvrhaIzdavanja
            // 
            SvrhaIzdavanja.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SvrhaIzdavanja.DataPropertyName = "SvrhaIzdavanja";
            SvrhaIzdavanja.HeaderText = "Svrha";
            SvrhaIzdavanja.MinimumWidth = 6;
            SvrhaIzdavanja.Name = "SvrhaIzdavanja";
            SvrhaIzdavanja.ReadOnly = true;
            // 
            // Uplatnica
            // 
            Uplatnica.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Uplatnica.DataPropertyName = "Uplatnica";
            Uplatnica.HeaderText = "Uplatnica";
            Uplatnica.ImageLayout = DataGridViewImageCellLayout.Stretch;
            Uplatnica.MinimumWidth = 6;
            Uplatnica.Name = "Uplatnica";
            Uplatnica.ReadOnly = true;
            // 
            // Printano
            // 
            Printano.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Printano.DataPropertyName = "Printano";
            Printano.HeaderText = "Printano";
            Printano.MinimumWidth = 6;
            Printano.Name = "Printano";
            Printano.ReadOnly = true;
            // 
            // Obrisi
            // 
            Obrisi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Obrisi.DataPropertyName = "Obrisi";
            Obrisi.HeaderText = "";
            Obrisi.MinimumWidth = 6;
            Obrisi.Name = "Obrisi";
            Obrisi.ReadOnly = true;
            Obrisi.Text = "Obrisi";
            Obrisi.UseColumnTextForButtonValue = true;
            // 
            // Printaj
            // 
            Printaj.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Printaj.DataPropertyName = "Printaj";
            Printaj.HeaderText = "";
            Printaj.MinimumWidth = 6;
            Printaj.Name = "Printaj";
            Printaj.ReadOnly = true;
            Printaj.Text = "Printaj";
            Printaj.UseColumnTextForButtonValue = true;
            // 
            // btnNoviZahtjev
            // 
            btnNoviZahtjev.Location = new Point(759, 5);
            btnNoviZahtjev.Name = "btnNoviZahtjev";
            btnNoviZahtjev.Size = new Size(125, 29);
            btnNoviZahtjev.TabIndex = 3;
            btnNoviZahtjev.Text = "Novi zahtjev";
            btnNoviZahtjev.UseVisualStyleBackColor = true;
            btnNoviZahtjev.Click += btnNoviZahtjev_Click;
            // 
            // frmUvjerenjaIB220043
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(899, 550);
            Controls.Add(groupBox1);
            Controls.Add(dgvPodaci);
            Controls.Add(btnNoviZahtjev);
            Name = "frmUvjerenjaIB220043";
            Text = "frmUvjerenjaIB220043";
            Load += frmUvjerenjaIB220043_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private TextBox txtInfo;
        private Button btnDodaj;
        private TextBox txtBrojZahtjeva;
        private TextBox txtSvrha;
        private Label label3;
        private Label label2;
        private ComboBox cmbVrstaUvjerenja;
        private Label label1;
        private DataGridView dgvPodaci;
        private Button btnNoviZahtjev;
        private DataGridViewTextBoxColumn VrijemeKreiranja;
        private DataGridViewTextBoxColumn VrstaUvjerenja;
        private DataGridViewTextBoxColumn SvrhaIzdavanja;
        private DataGridViewImageColumn Uplatnica;
        private DataGridViewCheckBoxColumn Printano;
        private DataGridViewButtonColumn Obrisi;
        private DataGridViewButtonColumn Printaj;
    }
}