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
    public partial class frmGradoviIB220043 : Form
    {
        private DrzaveIB220043 drzava;
        DLWMSDbContext db = new DLWMSDbContext();
        List<GradoviIB220043> GradoviPodaci = new List<GradoviIB220043>();

        public frmGradoviIB220043(DrzaveIB220043 drzava)
        {
            InitializeComponent();
            dgvPodaci.AutoGenerateColumns = false;
            this.drzava = drzava;
        }

        private void frmGradoviIB220043_Load(object sender, EventArgs e)
        {
            pbSlika.Image = Ekstenzije.ToImage(drzava.Zastava);
            lblNazivDrzave.Text = drzava.ToString();
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            GradoviPodaci = db.GradoviIB220043.Where(x => x.DrzavaId == drzava.Id).ToList();
            dgvPodaci.DataSource = null;
            dgvPodaci.DataSource = GradoviPodaci;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbNazivGrada.Text) && !PostojiIsti())
            {
                var novi = new GradoviIB220043
                {
                    Naziv = tbNazivGrada.Text,
                    Status = true,
                    DrzavaId = drzava.Id,
                };
                db.GradoviIB220043.Add(novi);
                db.SaveChanges();
                UcitajPodatke();
            }
        }

        private bool PostojiIsti()
        {
            var Gradovi = db.GradoviIB220043.Where(x => x.Naziv == tbNazivGrada.Text).ToList();
            if (Gradovi.Count == 0)
            {
                return false;
            }
            else
            {
                MessageBox.Show($"Grad {tbNazivGrada.Text} se vec nalazi u bazi.");
                return true;
            }
        }

        private void dgvPodaci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                var grad = GradoviPodaci[e.RowIndex];
                grad.Status = grad.Status == true ? false : true;
                db.GradoviIB220043.Update(grad);
                db.SaveChanges();
                UcitajPodatke();
            }
        }

        private async void btnGenerisi_Click(object sender, EventArgs e)
        {
            int brojGradova;
            try
            {
                brojGradova = int.Parse(tbBrojGradova.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Niste unijeli broj u field.");
                return;
            }
            var status=cbStatus.Checked;
            tbInfo.ScrollBars = ScrollBars.Vertical;
            var thread = new Thread(()=>DodajThread(brojGradova, status));
            thread.Start();
        }

        private void DodajThread(int brojGradova, bool status)
        {
            for (int i = 0; i < brojGradova; i++)
            {
                var novo = new GradoviIB220043
                {
                    Naziv = $"Grad{i}",
                    Status = status,
                    DrzavaId = drzava.Id,
                };
                db.GradoviIB220043.Add(novo);
                db.SaveChanges();

                Action ac = () =>
                {
                    tbInfo.Text += $"{DateTime.Now} -> dodat grad {novo.Naziv} za drzavu {drzava}" + Environment.NewLine;
                };

                BeginInvoke(ac);
                Thread.Sleep(300);
            }
            BeginInvoke(UcitajPodatke);
        }
    }
}
