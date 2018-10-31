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
        Navegador nv = new Navegador();
        public Frm_M_Moneda(DataGridView dgr3)
        {
            InitializeComponent();
            nv.dgv_datos(dgr3);
        }

        private void Frm_M_Moneda_Load(object sender, EventArgs e)
        {
            nv.ingresarTabla("tbl_moneda");
        }
    }
}
