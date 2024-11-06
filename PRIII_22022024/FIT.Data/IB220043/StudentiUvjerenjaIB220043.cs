﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data.IB220043
{
    public class StudentiUvjerenjaIB220043
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public DateTime VrijemeKreiranja { get; set; }
        public string VrstaUvjerenja { get; set; }
        public string SvrhaIzdavanja { get; set; }
        public byte[] Uplatnica { get; set; }
        public bool Printano { get; set; }
    }
}