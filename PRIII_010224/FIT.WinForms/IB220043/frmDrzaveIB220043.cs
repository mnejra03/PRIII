using FIT.Data.IB220043;
using FIT.Infrastructure;
using FIT.WinForms.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace FIT.WinForms.IB220043
{
    public partial class frmDrzaveIB220043 : Form
    {
        private Timer timer;
        DLWMSDbContext db = new DLWMSDbContext();
        List<DrzaveIB220043> DrzavePodaci = new List<DrzaveIB220043>();
        public frmDrzaveIB220043()
        {
            InitializeComponent();
            dgvPodaci.AutoGenerateColumns = false;

            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += (sender, e) => lblTrenutnoVrijeme.Text = $"Trenutno vrijeme: {DateTime.Now.ToString("HH:mm:ss")}";
            timer.Start();
        }
        private void frmDrzaveIB220043_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
        }
        private void UcitajPodatke()
        {
            DrzavePodaci = db.DrzaveIB220043.ToList();
            var Tabela = new DataTable();
            Tabela.Columns.Add("Zastava", typeof(Image));
            Tabela.Columns.Add("Drzava");
            Tabela.Columns.Add("BrojGradova");
            Tabela.Columns.Add("Status");
            for (int i = 0; i < DrzavePodaci.Count; i++)
            {
                var drzava = DrzavePodaci[i];
                var Red = Tabela.NewRow();
                Red["Zastava"] = Ekstenzije.ToImage(drzava.Zastava);
                Red["Drzava"] = drzava.ToString();
                Red["BrojGradova"] = db.GradoviIB220043.Where(x => x.DrzavaId == drzava.Id).Count().ToString();
                Red["Status"] = drzava.Status;
                Tabela.Rows.Add(Red);
            }
            dgvPodaci.DataSource = null;
            dgvPodaci.DataSource = Tabela;
        }

        private void btnNovaDrzava_Click(object sender, EventArgs e)
        {
            var novaFroma = new frmNovaDrzavaIB220043(null);
            novaFroma.ShowDialog();
            UcitajPodatke();
        }

        private void dgvPodaci_CellContentClick(object sender, DataGridViewCellEventArgs e) 
        {
            if (e.ColumnIndex == 4) 
            {
                var drzava = DrzavePodaci[e.RowIndex];
                var novaForma = new frmGradoviIB220043(drzava);
                novaForma.ShowDialog();
            }
            else
            {
                var novaFroma = new frmNovaDrzavaIB220043(DrzavePodaci[e.RowIndex]);
                novaFroma.ShowDialog();
                UcitajPodatke();
            }
        }
    }
}
