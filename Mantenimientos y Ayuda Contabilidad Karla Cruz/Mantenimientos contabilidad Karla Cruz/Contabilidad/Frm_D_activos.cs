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
    public partial class Frm_D_activos : Form
    {
        Navegador nv = new Navegador();
        public Frm_D_activos()
        {
            InitializeComponent();
        }

        private void Frm_D_activos_Load(object sender, EventArgs e)
        {
            DataTable tabla = nv.cargarDatos("tbl_activos");
            dgv_activos.DataSource = tabla;
        }

        private void dgv_activos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new Frm_M_activos(dgv_activos).Show();
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
