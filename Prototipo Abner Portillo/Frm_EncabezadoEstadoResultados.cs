using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipo_Abner_Portillo
{
    public partial class Frm_EncabezadoEstadoResultados : Form
    {
        //Navegador nav = new Navegador();

        public Frm_EncabezadoEstadoResultados(DataGridView dgv)
        {
            InitializeComponent();
            //nav.dgv_datos(dgv);
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void Frm_EncabezadoEstadoResultados_Load(object sender, EventArgs e)
        {
           // nav.ingresarTabla("tbl_encabezado_estado_resultados");
        }
    }
}
