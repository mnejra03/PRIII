using FIT.Data;
using FIT.Data.IB220043;
using FIT.Infrastructure;
using FIT.WinForms.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIT.WinForms.IB220043
{
    public partial class frmNovoUvjerenjeIB220043 : Form
    {
        Student student;
        DLWMSDbContext db = new DLWMSDbContext();
        public frmNovoUvjerenjeIB220043(Student student)
        {
            InitializeComponent();
            this.student = student;
        }
        private bool ValidacijaPodataka()
        {
            return Helpers.Validator.ProvjeriUnos(cmbVrstaUvjerenja, errorProvider1, Kljucevi.ReqiredValue) &&
                Helpers.Validator.ProvjeriUnos(tbSvrhaIzdavanja, errorProvider1, Kljucevi.ReqiredValue) &&
                Helpers.Validator.ProvjeriUnos(pbUplatnica, errorProvider1, Kljucevi.ReqiredValue);
        }
        private void pbUplatnica_DoubleClick(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbUplatnica.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (ValidacijaPodataka())
            {
                var novo = new StudentiUvjerenjaIB220043
                {
                    StudentId = student.Id,
                    VrijemeKreiranja = DateTime.Now,
                    VrstaUvjerenja = cmbVrstaUvjerenja.SelectedItem.ToString(),
                    SvrhaIzdavanja = tbSvrhaIzdavanja.Text,
                    Uplatnica = Ekstenzije.ToByteArray(pbUplatnica.Image),
                    Printano = false
                };

                db.StudentiUvjerenjaIB220043.Add(novo);
                db.SaveChanges(); // Ovdje spremamo promjene

                MessageBox.Show("Uspješno ste sačuvali novo uvjerenje!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }
    }
}
