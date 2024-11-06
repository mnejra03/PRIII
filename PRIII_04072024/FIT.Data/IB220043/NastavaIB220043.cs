using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data.IB220043
{
    public class NastavaIB220043
    {
        public int Id { get; set; }
        public int ProstorijaId { get; set; }
        public ProstorijeIB220043 Prostorija { get; set; }
        public int PredmetId { get; set; }
        public PredmetiIB220043 Predmet { get; set; }
        public string Vrijeme { get; set; }
        public string Dan { get; set; }
        public string Oznaka { get; set; }
    }
}
