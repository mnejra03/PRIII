using FIT.Data.IB220043;
using FIT.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Reporting.WinForms;
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
    public partial class frmIzvjestajIB220043 : Form
    {
        private StudentiUvjerenjaIB220043 studentUvjerenje;
        DLWMSDbContext db = new DLWMSDbContext();
        public frmIzvjestajIB220043(StudentiUvjerenjaIB220043 studentUvjerenje)
        {
            InitializeComponent();
            this.studentUvjerenje = studentUvjerenje;
        }

        private void frmIzvjestajIB220043_Load(object sender, EventArgs e)
        {
            //ReportParameterCollection rpc = new ReportParameterCollection();
            //rpc.Add(new ReportParameter("pVrstaUvjerenja", studentUvjerenje.VrstaUvjerenja));
            //rpc.Add(new ReportParameter("pSvrha", studentUvjerenje.SvrhaIzdavanja));
            //rpc.Add(new ReportParameter("pStudent", studentUvjerenje.Student.ImePrezime));
            //rpc.Add(new ReportParameter("pIndeks", studentUvjerenje.Student.Indeks));
            //rpc.Add(new ReportParameter("pAktivan", studentUvjerenje.Student.Aktivaan));
            //rpc.Add(new ReportParameter("pPolozeniIspiti", db.PolozeniPredmeti.Where(x => x.Student == studentUvjerenje.Student).Count().ToString()));
            //rpc.Add(new ReportParameter("pIspiti", studentUvjerenje.Student.Indeks));
            //rpc.Add(new ReportParameter("pProsjecnaOcjena", studentUvjerenje.Student.Indeks));
            //reportViewer1.LocalReport.SetParameters(rpc);
            reportViewer1.RefreshReport();
        }
    }
}
