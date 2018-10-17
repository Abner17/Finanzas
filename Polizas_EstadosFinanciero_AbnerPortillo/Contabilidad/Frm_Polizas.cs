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
    public partial class Frm_Polizas : Form
    {
        Form1 principal;
        public Frm_Polizas(Form1 frm)
        {
            InitializeComponent();
            principal = frm;
            CapaDiseno.Navegador nav = new Navegador(); 
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void navegador1_Load(object sender, EventArgs e)
        {

        }

        private void Frm_Polizas_Load(object sender, EventArgs e)
        {

        }
    }
}
