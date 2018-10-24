using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
namespace Contabilidad
{
    public class Conexion
    {
        public OdbcConnection ObtenerConexion()
        {

            OdbcConnection conectar = new OdbcConnection("Dsn=finanzas");
            conectar.Open();
            return conectar;
        }
        public void funcion()
        {

        }

    }
}
