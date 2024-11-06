namespace FIT.WinForms.IB220043
{
    partial class frmNovoUvjerenjeIB220043
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
            btnSacuvaj = new Button();
            pbUplatnica = new PictureBox();
            label3 = new Label();
            tbSvrhaIzdavanja = new TextBox();
            label2 = new Label();
            cmbVrstaUvjerenja = new ComboBox();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pbUplatnica).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(792, 326);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(139, 29);
            btnSacuvaj.TabIndex = 13;
            btnSacuvaj.Text = "Sacuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // pbUplatnica
            // 
            pbUplatnica.Location = new Point(338, 33);
            pbUplatnica.Name = "pbUplatnica";
            pbUplatnica.Size = new Size(593, 283);
            pbUplatnica.SizeMode = PictureBoxSizeMode.StretchImage;
            pbUplatnica.TabIndex = 12;
            pbUplatnica.TabStop = false;
            pbUplatnica.DoubleClick += pbUplatnica_DoubleClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(338, 9);
            label3.Name = "label3";
            label3.Size = new Size(141, 20);
            label3.TabIndex = 11;
            label3.Text = "Skenirana uplatnica:";
            // 
            // tbSvrhaIzdavanja
            // 
            tbSvrhaIzdavanja.Location = new Point(14, 97);
            tbSvrhaIzdavanja.Multiline = true;
            tbSvrhaIzdavanja.Name = "tbSvrhaIzdavanja";
            tbSvrhaIzdavanja.Size = new Size(286, 258);
            tbSvrhaIzdavanja.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 74);
            label2.Name = "label2";
            label2.Size = new Size(119, 20);
            label2.TabIndex = 9;
            label2.Text = "Svrha izdavanja: ";
            // 
            // cmbVrstaUvjerenja
            // 
            cmbVrstaUvjerenja.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVrstaUvjerenja.FormattingEnabled = true;
            cmbVrstaUvjerenja.Items.AddRange(new object[] { "Potvrda o statusu studenta", "Uvjerenje o polozenim ispitima sa prosjecnom ocjenom" });
            cmbVrstaUvjerenja.Location = new Point(14, 32);
            cmbVrstaUvjerenja.Name = "cmbVrstaUvjerenja";
            cmbVrstaUvjerenja.Size = new Size(286, 28);
            cmbVrstaUvjerenja.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 7;
            label1.Text = "Vrsta uvjerenja: ";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmNovoUvjerenjeIB220043
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 369);
            Controls.Add(btnSacuvaj);
            Controls.Add(pbUplatnica);
            Controls.Add(label3);
            Controls.Add(tbSvrhaIzdavanja);
            Controls.Add(label2);
            Controls.Add(cmbVrstaUvjerenja);
            Controls.Add(label1);
            Name = "frmNovoUvjerenjeIB220043";
            Text = "frmNovoUvjerenjeIB220043";
            ((System.ComponentModel.ISupportInitialize)pbUplatnica).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSacuvaj;
        private PictureBox pbUplatnica;
        private Label label3;
        private TextBox tbSvrhaIzdavanja;
        private Label label2;
        private ComboBox cmbVrstaUvjerenja;
        private Label label1;
        private ErrorProvider errorProvider1;
        private OpenFileDialog openFileDialog1;
    }
}