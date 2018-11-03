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
    public partial class _6100_Bancos : Form
    {
        Mdi_Principal principal = new Mdi_Principal();
        Navegador nv = new Navegador();
        public _6100_Bancos()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void _1700_Bancos_Load(object sender, EventArgs e)
        {
            DataTable tabla = nv.cargarDatos("tbl_encabezado_movimiento_bancario");
            Dgv_MovimientosBancarios.DataSource = tabla;


            //cargar un combobox, mandar como parametros nombre de la tabla y nombre del campo que se quiere cargar
            DataSet dt = nv.cargarCombobox("tbl_cuenta_bancaria", "no_cuentabancaria");
            Cmbo_NoCuenta.DataSource = dt.Tables[0].DefaultView;
            Cmbo_NoCuenta.ValueMember = "no_cuentabancaria";

            nv.ingresarTabla("tbl_encabezado_movimiento_bancario");
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            principal.Show();
        }
    }
}
