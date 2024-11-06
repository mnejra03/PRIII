using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data.IB220043
{
    public class DrzaveIB220043
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public bool Status { get; set; }
        public byte[] Zastava { get; set; }
        public override string ToString()
        {
            return Naziv;
        }
    }
}
