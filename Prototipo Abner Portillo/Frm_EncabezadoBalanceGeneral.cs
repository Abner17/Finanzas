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
    public partial class Frm_EncabezadoBalanceGeneral : Form
    {
       // Navegador nav = new Navegador();
        public Frm_EncabezadoBalanceGeneral(DataGridView dgv)
        {
            InitializeComponent();
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_EncabezadoBalanceGeneral_Load(object sender, EventArgs e)
        {

        }
    }
}
