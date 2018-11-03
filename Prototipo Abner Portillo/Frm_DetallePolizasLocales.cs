using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using CapaDiseno;
using System.Data.Odbc;



namespace Prototipo_Abner_Portillo
{
    public partial class Frm_DetallePolizasLocales : Form
    {
        //Navegador nv = new Navegador();
        string IDPoliza;
        
        public Frm_DetallePolizasLocales(string NoPoliza)
        {
            InitializeComponent();
            IDPoliza = NoPoliza;
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Frm_DetallePolizasLocales_Load(object sender, EventArgs e)
        {
           // nv.ingresarTabla("tbl_detalle_poliza");
            txt_NoPoliza.Text = IDPoliza;

            /*consulta al catalogo de cuentas
            string sql = "Select id_cuenta, Nombre_cuenta from tbl_catalogo_cuentas_contables";
            int contador = 1;
            ConectarServidor nuevo = new ConectarServidor();
            OdbcCommand cmd = nuevo.conexion().CreateCommand();
            nuevo.conexion(); 
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();

            OdbcDataReader almacena = cmd.ExecuteReader();
            casillas.CreateCells(dgv_DetallePolizas);
            while (almacena.Read())
            {
                contador++;
                lst_cuentas.Refresh();
                lst_cuentas.Items.Add(almacena.GetString(0) + " - " + almacena.GetString(1));
            }
            nuevo.cerrarConexion();*/
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            //consulta al catalogo de cuentas
            string numero = textBox3.Text;
            string sql = "Select Nombre_cuenta from tbl_catalogo_cuentas_contables WHERE id_cuenta = '" + numero + "'";
            ConectarServidor nuevo = new ConectarServidor();
            OdbcCommand cmd = nuevo.conexion().CreateCommand();
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            OdbcDataReader almacena = cmd.ExecuteReader();
            if (almacena.Read())
            {
                textBox4.Text = almacena.ToString();
            }
                nuevo.cerrarConexion();
        }
    }
}
