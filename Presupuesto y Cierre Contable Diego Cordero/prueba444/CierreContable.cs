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
using prueba444;
using CapaDiseno;


namespace Contabilidad
{
    public partial class CierreContable : Form
    {
        Navegador nv2 = new Navegador();

        public CierreContable()
        {
            InitializeComponent();
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Visible = true;
            nv2.nombreForm(this);
            nv2.dgv_datos(null);
        }


        //funcion de actualizacion de montos
        string fecha1 = "";
        string fecha2 = "";
        private void button1_Click(object sender, EventArgs e)
        {
        

            double auxiliar = 0;
            foreach (DataGridViewRow row in dgv_tablaCierreContable.Rows)
            {
                double abono = Convert.ToDouble(row.Cells["ab"].Value);
                double abonoAcumulado = Convert.ToDouble(row.Cells["abc"].Value);
                double cargo = Convert.ToDouble(row.Cells["ca"].Value);
                double cargoAcumulado = Convert.ToDouble(row.Cells["cac"].Value);
                double saldoAnterior = Convert.ToDouble(row.Cells["saan"].Value);
                double saldoActual = Convert.ToDouble(row.Cells["saac"].Value);

                auxiliar = abono + abonoAcumulado;
                row.Cells["ab"].Value=0;
                row.Cells["abc"].Value = auxiliar;


                auxiliar = cargo+cargoAcumulado;
                row.Cells["ca"].Value=0;
                row.Cells["cac"].Value= auxiliar;


                auxiliar = saldoActual + saldoAnterior;
                row.Cells["saac"].Value=0;
                row.Cells["saan"].Value= auxiliar;


            }


        }



        //obtener cuentas 
        private void CierreContable_Load(object sender, EventArgs e)
        {
            nv2.insertData("tbl_detalle_presupuesto", dgv_tablaCierreContable, 0, 1, 2, 3, 4, 5, 6, 7, 8 );

            try
            {

                string sql = "Select id_cuenta, Nombre_Cuenta, Abono, Abono_acumulado,  Cargo, Cargo_Acumulado, " +
                    "Saldo_anterior, Saldo_Actual, Fecha from tbl_catalogo_cuentas_contables";

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
                    filas.CreateCells(dgv_tablaCierreContable);

                    filas.Cells[0].Value = almacena.GetString(0);
                    filas.Cells[1].Value = almacena.GetString(1);
                    filas.Cells[2].Value = almacena.GetString(2);
                    filas.Cells[3].Value = almacena.GetString(3);
                    filas.Cells[4].Value = almacena.GetString(4);
                    filas.Cells[5].Value = almacena.GetString(5);
                    filas.Cells[6].Value = almacena.GetString(6);
                    filas.Cells[7].Value = almacena.GetString(7);
                    filas.Cells[8].Value = almacena.GetString(8);


                    dgv_tablaCierreContable.Rows.Add(filas);
                }
               almacena.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tablaPresupuesto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgv_tablaCierreContable.Rows.Clear();
            int mes, dia;
            string smes = "", sdia = "";
            mes = dtm_fechainicio.Value.Month;
            dia = dtm_fechainicio.Value.Day;
            if (mes <= 9)
            {

                smes = "0" + mes.ToString();

            }
            else
            {
                smes = mes.ToString();
            }

            if (dia <= 9)
            {
                sdia = "0" + dia.ToString();
            }
            else
            {
                sdia = dia.ToString();

            }
            fecha1 = dtm_fechainicio.Value.Year.ToString() + smes + sdia ;


            mes = dtm_fechafin.Value.Month;
            dia = dtm_fechafin.Value.Day;
            if (mes <= 9)
            {

                smes = "0" + mes.ToString();

            }
            else
            {
                smes = mes.ToString();
            }

            if (dia <= 9)
            {
                sdia = "0" + dia.ToString();
            }
            else
            {
                sdia = dia.ToString();

            }
            fecha2 = dtm_fechafin.Value.Year.ToString() + smes + sdia;


            MessageBox.Show("fecha inicial= " + fecha1);
            MessageBox.Show("fecha final= " + fecha2);


            try
            {
                string sql = "Select id_cuenta, Nombre_Cuenta, Abono, Abono_acumulado,  Cargo, Cargo_Acumulado, " +
                    "Saldo_anterior, Saldo_Actual, Fecha from tbl_catalogo_cuentas_contables where Fecha between "+ fecha1+ " and " +fecha2;

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
                    filas.CreateCells(dgv_tablaCierreContable);

                    filas.Cells[0].Value = almacena.GetString(0);
                    filas.Cells[1].Value = almacena.GetString(1);
                    filas.Cells[2].Value = almacena.GetString(2);
                    filas.Cells[3].Value = almacena.GetString(3);
                    filas.Cells[4].Value = almacena.GetString(4);
                    filas.Cells[5].Value = almacena.GetString(5);
                    filas.Cells[6].Value = almacena.GetString(6);
                    filas.Cells[7].Value = almacena.GetString(7);
                    filas.Cells[8].Value = almacena.GetString(8);


                    dgv_tablaCierreContable.Rows.Add(filas);
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
