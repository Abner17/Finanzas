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

namespace Prototipo_Abner_Portillo
{
    public partial class Frm_ListaEstadoResultados : Form
    {
        Navegador nav = new Navegador();
        public Frm_ListaEstadoResultados()
        {
            InitializeComponent();
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void Frm_ListaEstadoResultados_Load(object sender, EventArgs e)
        {
            DataTable tabla = nav.cargarDatos("tbl_encabezado_estado_resultados");
            dgv_EstadoResultados.DataSource = tabla;
        }

        private void dgv_EstadoResultados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new Frm_EncabezadoEstadoResultados(dgv_EstadoResultados).Show();
        }
    }
}
