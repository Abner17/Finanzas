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
    public partial class _6600_Bancos : Form
    {
        Mdi_Principal principal = new Mdi_Principal();
        //Se crea el objeto navegador
        Navegador nv = new Navegador();
        public _6600_Bancos(DataGridView dgr)
        {
            InitializeComponent();
            //carga los datos del data grid en los campos correspondientes
            nv.dgv_datos(dgr);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Frm_GeneracionChequesPlanilla_Load(object sender, EventArgs e)
        {
            //se carga en el combobox el id de la moneda
            DataSet dt = nv.cargarCombobox("tbl_moneda", "id_moneda");
            Cmbo_Monto.DataSource = dt.Tables[0].DefaultView;
            Cmbo_Monto.ValueMember = "id_moneda";
            //se carga en el combobox de beneficiario el id del empleado
            DataSet dt2 = nv.cargarCombobox("tbl_empleados", "ID_Empleado");
            Cmbo_Beneficiario.DataSource = dt2.Tables[0].DefaultView;
            Cmbo_Beneficiario.ValueMember = "ID_Empleado";
            //se carga en el combobox de cuenta bancaria el No. de la cuenta bancaria
            DataSet dt3 = nv.cargarCombobox("tbl_cuenta_bancaria", "no_cuentabancaria");
            Cmbo_cuenta.DataSource = dt3.Tables[0].DefaultView;
            Cmbo_cuenta.ValueMember = "no_cuentabancaria";

            //se manda la tabla en la que se desea insertar los datos
            nv.ingresarTabla("tbl_cheque");
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            principal.Show();
        }
    }
}
