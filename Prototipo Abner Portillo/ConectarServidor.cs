using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.Odbc;

namespace Prototipo_Abner_Portillo
{
    class ConectarServidor
    {

        public OdbcConnection conexion()
        {
           OdbcConnection conectar = new OdbcConnection("Dsn=Colchoneria");
           //OdbcConnection conectar = new OdbcConnection("Server=localhost; Database=finanzas; Uid=root; Pwd=; Port=3306; SslMode=none;");
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
        public OdbcConnection cerrarConexion()
        {
            OdbcConnection conectar = new OdbcConnection("Dsn=Colchoneria");
            //OdbcConnection conectar = new OdbcConnection("Server=localhost; Database=finanzas; Uid=root; Pwd=; Port=3306;");
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
