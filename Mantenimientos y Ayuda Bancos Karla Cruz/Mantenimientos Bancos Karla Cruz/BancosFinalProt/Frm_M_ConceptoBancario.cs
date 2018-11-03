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
    public partial class Frm_M_ConceptoBancario : Form
    {
        Navegador nv = new Navegador();
        public Frm_M_ConceptoBancario(DataGridView dgr)
        {
            InitializeComponent();
            nv.dgv_datos(dgr);
        }

        private void Frm_M_ConceptoBancario_Load(object sender, EventArgs e)
        {
            nv.ingresarTabla("tbl_concepto_bancario");
        }
    }
}
