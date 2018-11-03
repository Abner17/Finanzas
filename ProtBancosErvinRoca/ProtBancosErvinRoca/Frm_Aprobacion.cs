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

namespace ProtBancosErvinRoca
{
    public partial class Frm_Aprobacion : Form
    {
        Navegador nav = new Navegador();
        public Frm_Aprobacion()
        {
            InitializeComponent();
        }

        private void Frm_Aprobacion_Load(object sender, EventArgs e)
        {
            

        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
