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

namespace Contabilidad
{
    public partial class Frm_M_CatalogoCuentas : Form
    {
        Navegador nv = new Navegador();
        public Frm_M_CatalogoCuentas(DataGridView dgv_Cuentas)
        {
            InitializeComponent();
            nv.dgv_datos(dgv_Cuentas);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_M_CatalogoCuentas_Load(object sender, EventArgs e)
        {
            nv.ingresarTabla("tbl_catalogo_cuentas");
        }

        private void lbl_Codigo_Click(object sender, EventArgs e)
        {

        }
    }
}
