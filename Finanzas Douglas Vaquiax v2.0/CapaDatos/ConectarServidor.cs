using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace CapaDatos
{
    public class ConectarServidor
    {
        public static OdbcConnection conexion()
        {
            OdbcConnection conectar = new OdbcConnection("Dsn=Colchoneria;server=35.225.5.123;uid=umg;database=Db_Colchoneria;port=3306");
            {
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

        }

    }
}
