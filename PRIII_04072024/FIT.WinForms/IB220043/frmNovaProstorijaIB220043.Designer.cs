namespace FIT.WinForms.IB220043
{
    partial class frmNovaProstorijaIB220043
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pbLogo = new PictureBox();
            tbNaziv = new TextBox();
            tbOznaka = new TextBox();
            tbKapacitet = new TextBox();
            btnSacuvaj = new Button();
            errorProvider1 = new ErrorProvider(components);
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 0;
            label1.Text = "Logo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(530, 195);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 1;
            label2.Text = "Kapacitet:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(327, 195);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 2;
            label3.Text = "Oznaka:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(327, 32);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 3;
            label4.Text = "Naziv:";
            // 
            // pbLogo
            // 
            pbLogo.Location = new Point(12, 32);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(286, 299);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 4;
            pbLogo.TabStop = false;
            pbLogo.DoubleClick += pbLogo_DoubleClick;
            // 
            // tbNaziv
            // 
            tbNaziv.Location = new Point(327, 55);
            tbNaziv.Name = "tbNaziv";
            tbNaziv.Size = new Size(402, 27);
            tbNaziv.TabIndex = 5;
            // 
            // tbOznaka
            // 
            tbOznaka.Location = new Point(327, 218);
            tbOznaka.Name = "tbOznaka";
            tbOznaka.Size = new Size(198, 27);
            tbOznaka.TabIndex = 6;
            // 
            // tbKapacitet
            // 
            tbKapacitet.Location = new Point(531, 218);
            tbKapacitet.Name = "tbKapacitet";
            tbKapacitet.Size = new Size(198, 27);
            tbKapacitet.TabIndex = 7;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(635, 302);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(94, 29);
            btnSacuvaj.TabIndex = 8;
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
            // frmNovaProstorijaIB220043
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(745, 347);
            Controls.Add(btnSacuvaj);
            Controls.Add(tbKapacitet);
            Controls.Add(tbOznaka);
            Controls.Add(tbNaziv);
            Controls.Add(pbLogo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmNovaProstorijaIB220043";
            Text = "Podaci o prostoriji";
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pbLogo;
        private TextBox tbNaziv;
        private TextBox tbOznaka;
        private TextBox tbKapacitet;
        private Button btnSacuvaj;
        private ErrorProvider errorProvider1;
        private OpenFileDialog openFileDialog1;
    }
}