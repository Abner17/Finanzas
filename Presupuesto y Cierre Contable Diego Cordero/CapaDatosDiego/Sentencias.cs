using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace CapaDatosDiego
{
    public class Sentencias
    {

        BD_Conexion conexion = new BD_Conexion();
        OdbcCommand cmd = new OdbcCommand();
        //   List lst = new List();



        public void llenarListaCuentas(ListBox lst_cuentas)
        {

            string sql = "Select id_cuenta, Nombre_Cuenta from tbl_catalogo_cuentas_contables";
            int contador = 1;
            cmd = conexion.ObtenerConexion().CreateCommand();
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            OdbcDataReader almacena = cmd.ExecuteReader();
            lst_cuentas.Items.Clear();
            while (almacena.Read())
            {
                contador++;
                lst_cuentas.Refresh();
                lst_cuentas.Items.Add(almacena.GetString(0) + " - " + almacena.GetString(1));
            }
            conexion.CerrarConexion();

        }

        public void llenarAuxilires(DomainUpDown ejercicioPresupuesto, ListBox lst_departamento)
        {
            ejercicioPresupuesto.Items.Add("2018");
            ejercicioPresupuesto.Items.Add("2019");
            ejercicioPresupuesto.Items.Add("2020");
            ejercicioPresupuesto.Items.Add("2021");
            ejercicioPresupuesto.Items.Add("2022");
            ejercicioPresupuesto.Items.Add("2023");
            ejercicioPresupuesto.Items.Add("2024");
            ejercicioPresupuesto.Items.Add("2025");

            lst_departamento.Items.Add("1. Contabilidad");
            lst_departamento.Items.Add("2. Administracion");
            lst_departamento.Items.Add("3. Ventas");
            lst_departamento.Items.Add("4. Servicio Al Cliente");
            lst_departamento.Items.Add("5. Seguridad");
            lst_departamento.Items.Add("6. Recursos Humanos");
            lst_departamento.Items.Add("7. Informatica");
        }

    }
}
