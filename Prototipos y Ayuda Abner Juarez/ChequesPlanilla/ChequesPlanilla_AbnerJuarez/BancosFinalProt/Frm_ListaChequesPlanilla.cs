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
    public partial class Frm_ListaChequesPlanilla : Form
    {
        Mdi_Principal principal = new Mdi_Principal();
        Navegador nv = new Navegador();
        public Frm_ListaChequesPlanilla()
        {
            InitializeComponent();
        }

        private void Frm_ListaChequesPlanilla_Load(object sender, EventArgs e)
        {
            //se carga en el datagrid el contenido de la tabla cheque
            DataTable tabla = nv.cargarDatos("tbl_cheque");
            dgr.DataSource = tabla;
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            principal.Show();
        }

        private void dgr_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgr_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //si se da dobleclick en un campo del datagrid se abre el segundo form para hacer los insert y update de los registros en la tabla cheque
            new _6600_Bancos(dgr).Show();
        }
    }
}
