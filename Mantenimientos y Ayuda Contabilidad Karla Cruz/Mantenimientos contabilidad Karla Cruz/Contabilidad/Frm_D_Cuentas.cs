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
    public partial class Frm_D_Cuentas : Form
    {
        Navegador nv = new Navegador();
        public Frm_D_Cuentas()
        {
            InitializeComponent();
        }

        private void Frm_D_Cuentas_Load(object sender, EventArgs e)
        {
            DataTable tabla = nv.cargarDatos("tbl_catalogo_cuentas_contables");
            dgv_cuentas.DataSource = tabla;
        }

        private void dgv_cuentas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new Form2(dgv_cuentas).Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
