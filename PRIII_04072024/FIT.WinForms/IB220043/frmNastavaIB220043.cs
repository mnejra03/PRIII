using FIT.Data;
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
    public partial class frmNastavaIB220043 : Form
    {
        public frmNastavaIB220043(ProstorijeIB220043 prostorija)
        {
            InitializeComponent();
        }
    }
}
