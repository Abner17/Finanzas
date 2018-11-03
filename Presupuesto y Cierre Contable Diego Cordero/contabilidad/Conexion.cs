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
        OdbcConnection conectar = new OdbcConnection("Dsn=finanzas");

        public OdbcConnection ObtenerConexion()
        {

            conectar.Open();
            return conectar;

        }
        public OdbcConnection cerrarConexion()
        {


            conectar.Close();
            return conectar;


        }
        public void funcion()
        {

        }

    }
}
