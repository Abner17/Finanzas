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

namespace BancosFinalProt
{
    public partial class Frm_Data_ConBancario : Form
    {
        Navegador nv = new Navegador();
        public Frm_Data_ConBancario()
        {
            InitializeComponent();
        }

        private void Frm_Data_ConBancario_Load(object sender, EventArgs e)
        {
            DataTable tabla = nv.cargarDatos("tbl_concepto_bancario");
            dgr.DataSource = tabla;
        }

        private void dgr_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgr_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgr_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new Frm_M_ConceptoBancario(dgr).Show();
        }
    }
}
