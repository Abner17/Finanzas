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
    public partial class Frm_Data_Catalogo : Form
    {
        Navegador nv = new Navegador();
        public Frm_Data_Catalogo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Data_Catalogo_Load(object sender, EventArgs e)
        {
            DataTable tabla = nv.cargarDatos("tbl_catalogo_cuentas");
            dgv_Cuentas.DataSource = tabla;
        }

        private void Pnl_PanelSuperior_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Lbl_Contabilidad_Click(object sender, EventArgs e)
        {

        }

        private void dgv_Cuentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_Cuentas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Frm_M_CatalogoCuentas form = new Frm_M_CatalogoCuentas(dgv_Cuentas);
            form.Show();
        }
    }
}
