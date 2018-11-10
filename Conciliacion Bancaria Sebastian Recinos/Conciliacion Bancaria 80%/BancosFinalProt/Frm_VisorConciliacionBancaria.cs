using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using MySql.Data.MySqlClient;
using CapaDeDatos;



namespace BancosFinalProt
{
    public partial class Frm_VisorConciliacionBancaria : Form
    {
        string dir;
        string año;
        string mes;
        public Frm_VisorConciliacionBancaria(string direccion, string añoEx, string mesEx)
        {
            InitializeComponent();
            dir = direccion;
            año = añoEx;
            mes = mesEx;
        }

        private void axAcroPDF1_Enter(object sender, EventArgs e)
        {

        }

        private void Frm_VisorConciliacionBancaria_Load(object sender, EventArgs e)
        {
            axAcroPDF1.LoadFile(dir);
            string fechaInicio = año + mes + "1";
            if(mes == "02")
            { 
                string fechaFinal = año + mes + "28";
            }
            else if (mes == "04" || mes == "06" || mes == "09" || mes == "11")
            {
                string fechaFinal = año + mes + "30";
            }
            else
            {
                string fechaFinal = año + mes + "30";
            }

           /* OdbcCommand sql = new OdbcCommand(String.Format("SELECT * FROM tbl_encabezado_movimiento_bancario"), ConectarServidor.conexion());
            OdbcDataAdapter da = new OdbcDataAdapter(sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Dgv_CierreContable.DataSource = dt*/

            MySqlCommand sql = new MySqlCommand(String.Format("SELECT * FROM tbl_encabezado_movimiento_bancario"), ConectarServidor.conexion());
            MySqlDataAdapter da = new MySqlDataAdapter(sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Dgv_CierreContable.DataSource = dt;

            int movimientos = Dgv_CierreContable.RowCount - 1;
            Lbl_NumeroMovimientos.Text = movimientos.ToString();
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void Btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Dgv_CierreContable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
