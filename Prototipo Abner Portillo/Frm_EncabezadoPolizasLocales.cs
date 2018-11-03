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
    public partial class Frm_EncabezadoPolizasLocales : Form
    {
       Navegador nav = new Navegador();
        public Frm_EncabezadoPolizasLocales(DataGridView dgv)
        {
            InitializeComponent();
            nav.dgv_datos(dgv);
        }

        private void Frm_EncabezadoPolizasLocales_Load(object sender, EventArgs e)
        {
           nav.ingresarTabla("tbl_encabezado_poliza");
        }

        private void txt_NoPoliza_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string NoPoliza = txt_NoPoliza.Text;
            Frm_DetallePolizasLocales DPL = new Frm_DetallePolizasLocales(NoPoliza);
            DPL.Show();

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
           DataTable tabla = nav.cargarDatos("tbl_encabezado_poliza");
           dgv_EncPolizaDetalle.DataSource = tabla;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
