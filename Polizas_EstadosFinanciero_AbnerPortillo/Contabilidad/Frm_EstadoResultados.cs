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
    public partial class Frm_EstadoResultados : Form
    {
        Form1 principal;
        public Frm_EstadoResultados(Form1 frm)
        {
            InitializeComponent();
            principal = frm;
            CapaDiseno.Navegador nav = new Navegador();
        }

        private void Frm_EstadoResultados_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
