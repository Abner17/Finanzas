using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDiseno;

namespace BancosFinalProt
{
    public partial class Frm_M_Moneda : Form
    {
        public Frm_M_Moneda()
        {
            InitializeComponent();
            CapaDiseno.Navegador nav = new Navegador();
        }

        private void Frm_M_Moneda_Load(object sender, EventArgs e)
        {

        }
    }
}
