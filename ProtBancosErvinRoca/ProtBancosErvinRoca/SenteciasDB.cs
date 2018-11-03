using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProtBancosErvinRoca
{
    class SenteciasDB
    {
        MySqlConnection con = new MySqlConnection("server=localhost; Database=bd_ervin; Uid=root; Pwd=; Port=3306; SslMode=none;");


        public void DatosCuentas(DataGridView grid)
        {
            MySqlCommand cm = new MySqlCommand("select tbl_cuenta_bancaria.PK_idCuentaBancaria, tbl_cuenta_bancaria.Nombre_Banco," +
                " tbl_cuenta_bancaria.Estado, tbl_cuenta_bancaria.Saldo, tbl_disponibilidad_diaria.Fecha " +
                "from tbl_disponibilidad_diaria inner join " +
                "tbl_cuenta_bancaria on tbl_disponibilidad_diaria.FK_idCuentaBancaria = tbl_cuenta_bancaria.PK_idCuentaBancaria", con);
            MySqlDataAdapter da = new MySqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            grid.DataSource = dt;

        }

        public void DatosTipoCambio(DataGridView grid2)
        {

            MySqlCommand cm = new MySqlCommand("Select * from tbl_moneda;", con);
            MySqlDataAdapter da = new MySqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            grid2.DataSource = dt;
        }

        public void DatosDetalleProducto(DataGridView grid3)
        {
            MySqlCommand cm = new MySqlCommand("Select * from tbl_producto;", con);
            MySqlDataAdapter da = new MySqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            grid3.DataSource = dt;
        }

        public void DatosEmpleado(ComboBox combo1)
        {
            MySqlCommand cm = new MySqlCommand("Select * from tbl_empleado;", con);
            cm.CommandType = CommandType.Text;
            MySqlDataAdapter da = new MySqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);

            combo1.ValueMember = "PK_idEmpleado";
            combo1.DisplayMember = "nombre";

            combo1.DataSource = dt;

        }

        public void OperacionAutorizacion(ComboBox combo2)
        {
            MySqlCommand cm = new MySqlCommand("Select * from tbl_proceso_autorizacion_compra;", con);
            cm.CommandType = CommandType.Text;
            MySqlDataAdapter da = new MySqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);

            combo2.ValueMember = "PK_idProcesoAutorizacionCompra";
            combo2.DisplayMember = "Operacion";

            combo2.DataSource = dt;
        }

        public void numeroCompra(TextBox txt1)
        {
            MySqlCommand cm = new MySqlCommand("Select * from tbl_orden_de_compra_encabezado where PK_NumeroDeOrden = PK_NumeroDeOrden", con);
            string codmax = Convert.ToString(cm.ExecuteScalar());
            int cod = Convert.ToInt32(codmax) + 1;
            txt1.Text = Convert.ToString(cod);

        }
    }
}
