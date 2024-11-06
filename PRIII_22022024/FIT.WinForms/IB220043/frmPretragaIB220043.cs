using FIT.Data;
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
    public partial class frmPretragaIB220043 : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        List<Student> StudentiPodaci = new List<Student>();
        public frmPretragaIB220043()
        {
            InitializeComponent();
            dgvPodaci.AutoGenerateColumns = false;
        }

        private void frmPretragaIB220043_Load(object sender, EventArgs e)
        {
            UcitajSpolove();
        }
        private void UcitajSpolove()
        {
            var spol = db.Studenti.Select(x => x.Spol).Distinct().ToList();
            spol.Insert(0, "Svi spolovi");
            cmbSpol.DataSource = spol;
            cmbSpol.SelectedIndex = -1;
        }

        private void cmbSpol_SelectionChangeCommitted(object sender, EventArgs e)
        {
            UcitajPodatke();
        }
        private void dtpOd_ValueChanged(object sender, EventArgs e)
        {
            UcitajPodatke();
        }
        private void dtpDo_ValueChanged(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private bool ValidacijaPodataka()
        {
            return Helpers.Validator.ProvjeriUnos(cmbSpol, errorProvider1, Kljucevi.ReqiredValue) &&
                Helpers.Validator.ProvjeriUnos(dtpOd, errorProvider1, Kljucevi.ReqiredValue) &&
                Helpers.Validator.ProvjeriUnos(dtpDo, errorProvider1, Kljucevi.ReqiredValue);
        }
        private void UcitajPodatke()
        {
            if (ValidacijaPodataka())
            {
                DateTime dtmOd = dtpOd.Value;
                DateTime dtmDo = dtpDo.Value;
                string spol = cmbSpol.SelectedItem.ToString();

                StudentiPodaci = db.Studenti
                     .Where(x => (spol == "Svi spolovi" || x.Spol == spol) && // Provjera za "Svi spolovi"
                                 x.DatumRodjenja >= dtmOd && x.DatumRodjenja <= dtmDo)
                     .ToList();

                dgvPodaci.DataSource = null;

                if (StudentiPodaci.Count == 0)
                {
                    if (spol == "Svi spolovi")
                    {
                        MessageBox.Show($"U bazi podataka ne postoji evidencija o studentima " +
                                    $"rođenih u periodu od {dtmOd.ToShortDateString()} " +
                                    $"do {dtmDo.ToShortDateString()}");
                    }
                    else
                    {
                        MessageBox.Show($"U bazi podataka ne postoji evidencija o studentima {spol} spola " +
                                    $"rođenih u periodu od {dtmOd.ToShortDateString()} " +
                                    $"do {dtmDo.ToShortDateString()}");
                    }
                }
                else
                {
                    var tabela = new DataTable();
                    tabela.Columns.Add("BrojIndeksa");
                    tabela.Columns.Add("ImePrezime");
                    tabela.Columns.Add("Prosjek");
                    tabela.Columns.Add("DatumRodjenja");
                    tabela.Columns.Add("Aktivan");

                    for (int i = 0; i < StudentiPodaci.Count; i++)
                    {
                        var student = StudentiPodaci[i];
                        var red = tabela.NewRow();

                        red["BrojIndeksa"] = student.Indeks;
                        red["ImePrezime"] = student.Ime + " " + student.Prezime;
                        red["Prosjek"] = db.PolozeniPredmeti.Where(x => x.StudentId == student.Id).Count() == 0 ? "5" : db.PolozeniPredmeti.Where(x => x.StudentId == student.Id).Average(x => x.Ocjena).ToString();
                        red["DatumRodjenja"] = student.DatumRodjenja.ToString("dd.MM.yyyy");
                        red["Aktivan"] = student.Aktivan.ToString();

                        tabela.Rows.Add(red);
                    }

                    dgvPodaci.DataSource = null;
                    dgvPodaci.DataSource = tabela;
                }
            }
        }

        private void dgvPodaci_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.ColumnIndex <= 4 && e.RowIndex >= 0)
            {
                var student = StudentiPodaci[e.RowIndex];
                var nova = new frmStudentInfoIB220043(student);
                nova.ShowDialog();
            }
            if (e.ColumnIndex == 5)
            {
                var student = StudentiPodaci[e.RowIndex];
                var nova = new frmUvjerenjaIB220043(student);
                nova.ShowDialog();
            }
        }
    }
}
