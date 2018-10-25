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
    }
}
