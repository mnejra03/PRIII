using FIT.Data.IB220043;
using FIT.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FIT.WinForms.IB220043
{
    public partial class frmPrisustvoIB220043 : Form
    {
        private ProstorijeIB220043 prostorija;
        DLWMSDbContext db = new DLWMSDbContext();
        public frmPrisustvoIB220043(ProstorijeIB220043 prostorija)
        {
            InitializeComponent();
            this.prostorija = prostorija;

            UcitajCmb();
            lblNazivOznaka.Text = prostorija.Naziv + " - " + prostorija.Oznaka;
        }

        private void UcitajCmb()
        {
            cmbNastava.DataSource = db.NastavaIB220043.Where(x => x.ProstorijaId == prostorija.Id).ToList();
            cmbNastava.DisplayMember = "Oznaka";
            cmbNastava.ValueMember = "Id";

            cmbStudent.DataSource = db.Studenti.ToList();
            cmbStudent.DisplayMember = "IndeksImePrezime";
            cmbStudent.ValueMember = "Id";
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            
        }
    }
}
