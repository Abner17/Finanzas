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
    public partial class Form2 : Form
    {
        Navegador nv = new Navegador();
        public Form2(DataGridView dgv_cuentas)
        {
            InitializeComponent();
            nv.dgv_datos(dgv_cuentas);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            nv.ingresarTabla("tbl_catalogo_cuentas_contables");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
