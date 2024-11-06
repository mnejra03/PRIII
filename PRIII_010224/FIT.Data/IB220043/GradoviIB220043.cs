using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data.IB220043
{
    public class GradoviIB220043
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public bool Status { get; set; }
        public int DrzavaId { get; set; }
        public DrzaveIB220043 Drzava { get; set; }
        public override string ToString()
        {
            return Naziv;
        }
    }
}
