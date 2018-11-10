using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Windows.Forms;

namespace CapaDatosDiego
{
  public class BD_Conexion
    {

        public OdbcConnection ObtenerConexion()
        {
            OdbcConnection conectar = new OdbcConnection("Dsn=finanzas");
            try
            {
                conectar.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return conectar;
        }
        public OdbcConnection CerrarConexion()
        {
            OdbcConnection conectar = new OdbcConnection("Dsn=finanzas");
            try
            {
                conectar.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return conectar;
        }

    }
}
