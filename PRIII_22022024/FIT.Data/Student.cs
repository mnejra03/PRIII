﻿using FIT.Data.IB220043;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace FIT.Data
{
    public class Student
    {
        public int Id { get; set; }
        public string Indeks { get; set; }
        public string Lozinka { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public byte[] Slika { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public bool Aktivan { get; set; }        
        public int SemestarId { get; set; }
        public SemestriIB220043 Semestar { get; set; }
        public string Spol { get; set; }
        [NotMapped] public string ImePrezime => Ime + " " + Prezime;
        [NotMapped] public string Aktivaan => getAktivan();
        public override string ToString()
        {
            return $"{Indeks} {Ime} {Prezime}";
        }
        private string getAktivan()
        {
            if(Aktivan == true)
            {
                return "Aktivan";
            }
            else
            {
                return "Nije aktivan";
            }
        }
    }
}
