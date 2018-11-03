using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CapaDiseno;

namespace Prototipo_Abner_Portillo
{
    public partial class Frm_ListadoPolizasLocales : Form
    {
       Navegador nav = new Navegador();
        public Frm_ListadoPolizasLocales()
        {
            InitializeComponent();
        }

        private void Frm_ListadoPolizasLocales_Load(object sender, EventArgs e)
        {
            DataTable tabla = nav.cargarDatos("tbl_encabezado_poliza");
            dgv_ListadoPolizasLocales.DataSource = tabla;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_ListadoPolizasLocales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_ListadoPolizasLocales_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new Frm_EncabezadoPolizasLocales(dgv_ListadoPolizasLocales).Show();
        }
    }
}
