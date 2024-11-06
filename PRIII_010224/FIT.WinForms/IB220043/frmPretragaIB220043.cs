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
            cmbDrzava.DataSource = db.DrzaveIB220043.ToList();
            var Drzava = db.DrzaveIB220043.First();
            cmbGrad.DataSource = db.GradoviIB220043.Where(x => x.DrzavaId == Drzava.Id).ToList();
        }

        private void cmbDrzava_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void cmbGrad_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajPodatke();
        }
        private void UcitajPodatke()
        {
            var Drzava = cmbDrzava.SelectedItem == null ? db.DrzaveIB220043.First() : cmbDrzava.SelectedItem as DrzaveIB220043;
            cmbGrad.DataSource = db.GradoviIB220043.Where(x => x.DrzavaId == Drzava.Id).ToList();

            var Grad = cmbGrad.SelectedItem == null ? db.GradoviIB220043.Where(x => x.DrzavaId == Drzava.Id).First() : cmbGrad.SelectedItem as GradoviIB220043;
            StudentiPodaci = db.Studenti.Where(x => x.GradId == Grad.Id).ToList();

            if (StudentiPodaci != null)
            {
                var Tabela = new DataTable();
                Tabela.Columns.Add("Ime");
                Tabela.Columns.Add("Prezime");
                Tabela.Columns.Add("Grad");
                Tabela.Columns.Add("Drzava");
                Tabela.Columns.Add("Prosjek");
                for(int i=0;i<StudentiPodaci.Count;i++)
                {
                    var student = StudentiPodaci[i];
                    var Red = Tabela.NewRow();
                    Red["Ime"] = student.Ime.ToString();
                    Red["Prezime"]=student.Prezime.ToString();
                    Red["Grad"]=student.Grad.ToString();
                    Red["Drzava"]=Drzava.ToString();
                    Red["Prosjek"]=db.PolozeniPredmeti.Where(x=>x.StudentId==student.Id).Count()==0?"5": db.PolozeniPredmeti.Where(x => x.StudentId == student.Id).Average(x=>x.Ocjena).ToString();
                    Tabela.Rows.Add(Red);
                }
                dgvPodaci.DataSource = null;
                dgvPodaci.DataSource = Tabela;
            }
        }
    }
}
