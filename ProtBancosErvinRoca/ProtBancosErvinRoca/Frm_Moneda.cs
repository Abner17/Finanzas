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
    public partial class Frm_Moneda : Form
    {
        Navegador nav = new Navegador();
        public Frm_Moneda(DataGridView dgv)
        {
            InitializeComponent();
            nav.dgv_datos(dgv);
        }

        private void Frm_Moneda_Load(object sender, EventArgs e)
        {
         
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
