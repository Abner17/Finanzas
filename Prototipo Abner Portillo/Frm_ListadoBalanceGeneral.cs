using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using CapaDiseno;

namespace Prototipo_Abner_Portillo
{
    public partial class Frm_ListadoBalanceGeneral : Form
    {
       // Navegador nav = new Navegador();
        public Frm_ListadoBalanceGeneral()
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

        private void Frm_ListadoBalanceGeneral_Load(object sender, EventArgs e)
        {
           // DataTable tabla = nav.cargarDatos("tbl_encabezado_balance_general");
           // dgv_ListadoBalanceGeneral.DataSource = tabla;
        }

        private void dgv_ListadoBalanceGeneral_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new Frm_EncabezadoBalanceGeneral(dgv_ListadoBalanceGeneral).Show();
        }
    }
}
