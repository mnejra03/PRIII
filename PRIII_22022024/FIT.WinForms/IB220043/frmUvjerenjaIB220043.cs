using FIT.Data;
using FIT.Data.IB220043;
using FIT.Infrastructure;
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
    public partial class frmUvjerenjaIB220043 : Form
    {
        private Student student;
        DLWMSDbContext db = new DLWMSDbContext();
        public frmUvjerenjaIB220043(Student student)
        {
            InitializeComponent();
            this.student = student;
            dgvPodaci.AutoGenerateColumns = false;
        }

        private void frmUvjerenjaIB220043_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
        }
        private void UcitajPodatke()
        {
            Text = $"Broj uvjerenja -> {db.StudentiUvjerenjaIB220043.Where(x => x.Student == student).Count()}";
            dgvPodaci.DataSource = null;
            dgvPodaci.DataSource = db.StudentiUvjerenjaIB220043.Where(x => x.Student == student).ToList();
        }

        private void dgvPodaci_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                var dialog = MessageBox.Show("Da li ste sigurni da zelite obrisati zapis?", "Provjera", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    var odabrano = dgvPodaci.SelectedRows[0].DataBoundItem as StudentiUvjerenjaIB220043;
                    db.StudentiUvjerenjaIB220043.Remove(odabrano);
                    db.SaveChanges();

                    MessageBox.Show("Uspjesno ste obrisali odabrani zapis!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UcitajPodatke();
                }
            }
            if (e.ColumnIndex == 6)
            {
                var odabrano = dgvPodaci.SelectedRows[0].DataBoundItem as StudentiUvjerenjaIB220043;
                if (odabrano != null)
                {
                    var forma = new frmIzvjestajIB220043(odabrano);
                    forma.ShowDialog();
                    odabrano.Printano = true;
                    db.Entry(odabrano).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    db.SaveChanges();
                    UcitajPodatke();
                }
            }
        }

        private void btnNoviZahtjev_Click(object sender, EventArgs e)
        {
            new frmNovoUvjerenjeIB220043(student).ShowDialog();
            UcitajPodatke();
        }
    }
}
