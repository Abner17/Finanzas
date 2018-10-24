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

namespace Contabilidad
{
    public partial class CierreContable : Form
    {
        public CierreContable()
        {
            InitializeComponent();
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void CierreContable_Load(object sender, EventArgs e)
        {
            try
            {
                string sql = "Select id_cuenta, Nombre_Cuenta from catalogo_cuentas";

                Conexion nuevo = new Conexion();
                OdbcCommand cmd = nuevo.ObtenerConexion().CreateCommand();
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                OdbcDataReader almacena = cmd.ExecuteReader();
            //    cuentas.Items.Clear();
           //     cuentas.Items.Add(" Seleccionar Todo");


            
                while (almacena.Read() == true)
                {
                    DataGridViewRow filas = new DataGridViewRow();
                    filas.CreateCells(tablaPresupuesto);

                    filas.Cells[0].Value = almacena.GetString(0);
                    filas.Cells[1].Value = almacena.GetString(1);
                  



                   tablaPresupuesto.Rows.Add(filas);
                }
               almacena.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
