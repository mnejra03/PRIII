﻿using FIT.Data;
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
    public partial class frmStudentInfoIB220043 : Form
    {
        private Student student;
        DLWMSDbContext db = new DLWMSDbContext();
        public frmStudentInfoIB220043(Student student)
        {
            InitializeComponent();
            this.student = student;
        }

        private void frmStudentInfoIB220043_Load(object sender, EventArgs e)
        {
            this.Text = student.Indeks.ToString();
            pbSlika.Image = Ekstenzije.ToImage(student.Slika);
            lblImePrezime.Text = student.Ime.ToString() + " " + student.Prezime.ToString();
            var prosjek = db.PolozeniPredmeti.Where(x => x.StudentId == student.Id).Count() == 0 ? "5" : db.PolozeniPredmeti.Where(x => x.StudentId == student.Id).Average(x => x.Ocjena).ToString();
            lblProsjek.Text = $"Prosjek: {prosjek}";
        }
    }
}