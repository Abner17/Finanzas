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
    public partial class Frm_M_activos : Form
    {
        Navegador nv = new Navegador();
        public Frm_M_activos(DataGridView dgv_activos)
        {
            InitializeComponent();
            nv.dgv_datos(dgv_activos);
        }

        private void Frm_M_activos_Load(object sender, EventArgs e)
        {
            nv.ingresarTabla("tbl_activos");
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
