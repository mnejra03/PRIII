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
    public partial class frmProstorijeIB220043 : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        List<ProstorijeIB220043> ProstorijaPodaci = new List<ProstorijeIB220043>();
        public frmProstorijeIB220043()
        {
            InitializeComponent();
            dgvPodaci.AutoGenerateColumns = false;
        }
        private void frmProstorijeIB220043_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
        }
        private void UcitajPodatke()
        {
            ProstorijaPodaci = db.ProstorijeIB220043.ToList();
            var tabela = new DataTable();
            tabela.Columns.Add("Logo", typeof(Image));
            tabela.Columns.Add("Naziv");
            tabela.Columns.Add("Oznaka");
            tabela.Columns.Add("Kapacitet");
            tabela.Columns.Add("BrojPredmeta");

            for (int i = 0; i < ProstorijaPodaci.Count; i++)
            {
                var prostorija = ProstorijaPodaci[i];
                var red = tabela.NewRow();

                red["Logo"] = Ekstenzije.ToImage(prostorija.Logo);
                red["Naziv"] = prostorija.Naziv.ToString();
                red["Oznaka"] = prostorija.Oznaka.ToString();
                red["Kapacitet"] = int.Parse(prostorija.Kapacitet.ToString());
                red["BrojPredmeta"] = db.NastavaIB220043.Where(x => x.ProstorijaId == prostorija.Id).Count().ToString();

                tabela.Rows.Add(red);
            }
            dgvPodaci.DataSource = null;
            dgvPodaci.DataSource = tabela;
        }
        private void btnNova_Click(object sender, EventArgs e)
        {
            new frmNovaProstorijaIB220043().ShowDialog();
            UcitajPodatke();
        }
        private void dgvPodaci_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                var nastava = ProstorijaPodaci[e.RowIndex];
                var nova = new frmNastavaIB220043(nastava);
                nova.ShowDialog();
            }
            if (e.ColumnIndex == 6)
            {
                var nastava = ProstorijaPodaci[e.RowIndex];
                var nova = new frmPrisustvoIB220043(nastava);
                nova.ShowDialog();
            }
        }
    }
}
