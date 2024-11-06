namespace FIT.WinForms.IB220043
{
    partial class frmNovaDrzavaIB220043
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
            lblZastava = new Label();
            pbSlika = new PictureBox();
            lblNaziv = new Label();
            tbNaziv = new TextBox();
            cbStatus = new CheckBox();
            btnSacuvaj = new Button();
            errorProvider1 = new ErrorProvider(components);
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pbSlika).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblZastava
            // 
            lblZastava.AutoSize = true;
            lblZastava.Location = new Point(12, 9);
            lblZastava.Name = "lblZastava";
            lblZastava.Size = new Size(63, 20);
            lblZastava.TabIndex = 0;
            lblZastava.Text = "Zastava:";
            // 
            // pbSlika
            // 
            pbSlika.Location = new Point(12, 32);
            pbSlika.Name = "pbSlika";
            pbSlika.Size = new Size(436, 240);
            pbSlika.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSlika.TabIndex = 1;
            pbSlika.TabStop = false;
            pbSlika.DoubleClick += pbSlika_DoubleClick;
            // 
            // lblNaziv
            // 
            lblNaziv.AutoSize = true;
            lblNaziv.Location = new Point(12, 284);
            lblNaziv.Name = "lblNaziv";
            lblNaziv.Size = new Size(49, 20);
            lblNaziv.TabIndex = 2;
            lblNaziv.Text = "Naziv:";
            // 
            // tbNaziv
            // 
            tbNaziv.Location = new Point(12, 307);
            tbNaziv.Name = "tbNaziv";
            tbNaziv.Size = new Size(436, 27);
            tbNaziv.TabIndex = 3;
            // 
            // cbStatus
            // 
            cbStatus.AutoSize = true;
            cbStatus.Location = new Point(12, 340);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(80, 24);
            cbStatus.TabIndex = 4;
            cbStatus.Text = "Aktivna";
            cbStatus.UseVisualStyleBackColor = true;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(353, 376);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(94, 29);
            btnSacuvaj.TabIndex = 5;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmNovaDrzavaIB220043
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 417);
            Controls.Add(btnSacuvaj);
            Controls.Add(cbStatus);
            Controls.Add(tbNaziv);
            Controls.Add(lblNaziv);
            Controls.Add(pbSlika);
            Controls.Add(lblZastava);
            Name = "frmNovaDrzavaIB220043";
            Text = "Podaci o državi";
            Load += frmNovaDrzavaIB220043_Load;
            ((System.ComponentModel.ISupportInitialize)pbSlika).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblZastava;
        private PictureBox pbSlika;
        private Label lblNaziv;
        private TextBox tbNaziv;
        private CheckBox cbStatus;
        private Button btnSacuvaj;
        private ErrorProvider errorProvider1;
        private OpenFileDialog openFileDialog1;
    }
}