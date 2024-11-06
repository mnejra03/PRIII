using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data.IB220043
{
    public class PredmetiIB220043
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public int SemestarId { get; set; }
        public SemestriIB220043 Semestar { get; set; }
    }
}
