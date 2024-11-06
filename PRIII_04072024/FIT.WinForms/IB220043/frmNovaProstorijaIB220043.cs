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
    public partial class frmNovaProstorijaIB220043 : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        public frmNovaProstorijaIB220043()
        {
            InitializeComponent();
        }
        private void pbLogo_DoubleClick(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbLogo.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (ValidacijaPodataka())
            {
                var nova = new ProstorijeIB220043()
                {
                    Logo = Ekstenzije.ToByteArray(pbLogo.Image),
                    Naziv = tbNaziv.Text,
                    Oznaka = tbOznaka.Text,
                    Kapacitet = int.Parse(tbKapacitet.Text),
                };
                db.ProstorijeIB220043.Add(nova);
                db.SaveChanges();
                Close();
            }
        }

        private bool ValidacijaPodataka()
        {
            return Helpers.Validator.ProvjeriUnos(pbLogo, errorProvider1, Kljucevi.ReqiredValue) &&
                Helpers.Validator.ProvjeriUnos(tbNaziv, errorProvider1, Kljucevi.ReqiredValue) &&
                Helpers.Validator.ProvjeriUnos(tbOznaka, errorProvider1, Kljucevi.ReqiredValue) &&
                Helpers.Validator.ProvjeriUnos(tbKapacitet, errorProvider1, Kljucevi.ReqiredValue);
        }
    }
}
