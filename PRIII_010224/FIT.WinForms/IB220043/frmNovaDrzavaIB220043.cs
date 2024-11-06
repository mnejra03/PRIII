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
    public partial class frmNovaDrzavaIB220043 : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        private DrzaveIB220043 drzaveIB220043;

        public frmNovaDrzavaIB220043(DrzaveIB220043 drzaveIB220043)
        {
            InitializeComponent();
            this.drzaveIB220043 = drzaveIB220043;
        }

        private void pbSlika_DoubleClick(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbSlika.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (validacija())
            {
                if (drzaveIB220043 == null)
                {
                    var nova = new DrzaveIB220043
                    {
                        Naziv = tbNaziv.Text,
                        Status = cbStatus.Checked,
                        Zastava = Ekstenzije.ToByteArray(pbSlika.Image),
                    };
                    db.DrzaveIB220043.Add(nova);
                    db.SaveChanges();
                    Close();
                }
                else
                {
                    drzaveIB220043.Zastava = Ekstenzije.ToByteArray(pbSlika.Image);
                    drzaveIB220043.Naziv=tbNaziv.Text;
                    drzaveIB220043.Status=cbStatus.Checked;
                    db.DrzaveIB220043.Update(drzaveIB220043);
                    db.SaveChanges(); Close();
                }
            }
        }

        private bool validacija()
        {
            return Helpers.Validator.ProvjeriUnos(pbSlika, errorProvider1, Kljucevi.ReqiredValue)
                && Helpers.Validator.ProvjeriUnos(tbNaziv, errorProvider1, Kljucevi.ReqiredValue);
        }

        private void frmNovaDrzavaIB220043_Load(object sender, EventArgs e)
        {
            if(drzaveIB220043 != null)
            {
                pbSlika.Image = Ekstenzije.ToImage(drzaveIB220043.Zastava);
                tbNaziv.Text = drzaveIB220043.ToString();
                cbStatus.Checked = drzaveIB220043.Status;
            }
        }
    }
}
