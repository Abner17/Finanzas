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
    public partial class Frm_Data_Activos : Form
    {
        Navegador nv = new Navegador();
        public Frm_Data_Activos()
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

        private void Frm_Data_Activos_Load(object sender, EventArgs e)
        {
            DataTable tabla = nv.cargarDatos("tbl_activos");
            dgv_Activos.DataSource = tabla;
        }

        private void dgv_Activos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgv_Activos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new Frm_M_Activos(dgv_Activos).Show();
        }
    }
}
