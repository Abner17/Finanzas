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
using System.Text.RegularExpressions;

namespace Contabilidad
{
    public partial class Presupuestos : Form
    {
        public Presupuestos()
        {
  
            InitializeComponent();
        }


        // cargo de fecha y parametros iniciales
        private void Presupuestos_Load(object sender, EventArgs e)
        {
            ejercicioPresupuesto.Items.Add("2018");
            ejercicioPresupuesto.Items.Add("2019");
            ejercicioPresupuesto.Items.Add("2020");
            ejercicioPresupuesto.Items.Add("2021");
            ejercicioPresupuesto.Items.Add("2022");
            ejercicioPresupuesto.Items.Add("2023");
            ejercicioPresupuesto.Items.Add("2024");
            ejercicioPresupuesto.Items.Add("2025");
            ejercicioPresupuesto.Items.Add("2026");
            ejercicioPresupuesto.Items.Add("2027");
            ejercicioPresupuesto.Items.Add("2028");
            ejercicioPresupuesto.Items.Add("2029");
            ejercicioPresupuesto.Items.Add("2030");

           
               
            lst_departamento.Items.Add("1. Contabilidad");
            lst_departamento.Items.Add("2. Administracion");
            lst_departamento.Items.Add("3. Ventas");
            lst_departamento.Items.Add("4. Servicio Al Cliente");
            lst_departamento.Items.Add("5. Seguridad");
            lst_departamento.Items.Add("6. Recursos Humanos");
            lst_departamento.Items.Add("7. Informatica");


            string sql = "Select id_cuenta, Nombre_Cuenta from tbl_catalogo_cuentas_contables";
            int contador = 1;
            Conexion nuevo = new Conexion();
            OdbcCommand cmd = nuevo.ObtenerConexion().CreateCommand();
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();

            OdbcDataReader almacena = cmd.ExecuteReader();
            lst_cuentas.Items.Clear();

            while (almacena.Read())
            {    contador++;
                lst_cuentas.Refresh();
                lst_cuentas.Items.Add( almacena.GetString(0) +" - "+ almacena.GetString(1));
            }
            nuevo.cerrarConexion();

        }



        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
         
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void departamento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }





        //obtener el codigo de cuenta
        string devuelveOcho(string cadena)
        {
            string cadenaAux = "";

            Regex.Replace(cadena, "[^0-9]", "").Take(8).ToList().ForEach(delegate (char c) {
                cadenaAux += c.ToString();
            });

            return cadenaAux;
        }




        bool validacionSiguientePaso = false;
        
        //pre llenado de presupuesto y validacion de datos
        private void button1_Click(object sender, EventArgs e)
        {
            validacionSiguientePaso = false;

            actualizarHeader();

            if (validacionSiguientePaso == false)
            {

                pnlContenido.Visible = false;
                dgv_Presupuesto.Visible = true;
                headerDescripcion.Visible = true;
                dgv_Presupuesto.Rows.Clear();



                foreach (var itemPresupuesto in lst_cuentasPresupuesto.Items)
                {
                    string sMyString;
                    string id_cuenta;
                    sMyString = itemPresupuesto.ToString();
                    id_cuenta = devuelveOcho(sMyString);





                    try
                    {
                        string sql = "Select id_cuenta, Nombre_Cuenta from tbl_catalogo_cuentas_contables where id_cuenta =" + id_cuenta;


                        Conexion nuevo = new Conexion();
                        OdbcCommand cmdTabla = nuevo.ObtenerConexion().CreateCommand();
                        cmdTabla.CommandText = sql;
                        cmdTabla.ExecuteNonQuery();

                        OdbcDataReader almacenaTab = cmdTabla.ExecuteReader();


                        while (almacenaTab.Read() == true)
                        {
                            DataGridViewRow filas = new DataGridViewRow();
                            filas.CreateCells(dgv_Presupuesto);

                            filas.Cells[0].Value = almacenaTab.GetString(0);
                            filas.Cells[1].Value = almacenaTab.GetString(1);
                            filas.Cells[2].Value = "0";
                            filas.Cells[3].Value = "0";
                            filas.Cells[4].Value = "0";
                            filas.Cells[5].Value = "0";
                            filas.Cells[6].Value = "0";
                            filas.Cells[7].Value = "0";
                            filas.Cells[8].Value = "0";
                            filas.Cells[9].Value = "0";
                            filas.Cells[10].Value = "0";
                            filas.Cells[11].Value = "0";
                            filas.Cells[12].Value = "0";
                            filas.Cells[13].Value = "0";





                            dgv_Presupuesto.Rows.Add(filas);
                        }
                        almacenaTab.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

                }
            }
            
        

        }


        //volver a mostrar el prellenado
        private void button2_Click(object sender, EventArgs e)
        {
            pnlContenido.Visible = true;
            dgv_Presupuesto.Visible = false;
            headerDescripcion.Visible = false;

        }

        private void headerDescripcion_Paint(object sender, PaintEventArgs e)
        {

        }


        //actualiza y valida el encabezado del presupuesto
        void actualizarHeader()
        {
            
            string MyString;

            int indicecuenta = lst_cuentas.SelectedIndex;
            int indicedept = lst_departamento.SelectedIndex;


            if(lst_cuentasPresupuesto.Items.Count > 0)
            {

            }
            else
            {
                MessageBox.Show("Debe seleccionar al menos una cuenta");
                validacionSiguientePaso = true;
            }
            txtEjercicioPresupuesto.Text = ejercicioPresupuesto.Text;

            if (lst_departamento.Items.Count > 0 && indicedept >= 0)
            {
            
                MyString = lst_departamento.Items[indicedept].ToString();
                txtDepartamento.Text = MyString.Remove(0, 3);
                
            }
            else
            {
                MessageBox.Show("Debe Seleccionar Un Departamento");
                validacionSiguientePaso = true;
            }


            if (pnl_opcionesPrellenado.Enabled == true)
            {
                label10.Visible = true;
                label11.Visible = true;
                txtPorcentajeIncremento.Visible = true;
                txtTomarSaldo.Visible = true;



                if (saldo1.Checked)
                    txtTomarSaldo.Text = saldo1.Text;
                else if (saldo2.Checked)
                    txtTomarSaldo.Text = saldo2.Text;
                else if (saldo3.Checked)
                    txtTomarSaldo.Text = saldo3.Text;
                else
                {
                    MessageBox.Show("Debe seleccionar un metodo de saldo");
                    validacionSiguientePaso = true;
                }



                if (textBox1.Text != "")
                    txtPorcentajeIncremento.Text = textBox1.Text + " %";
                else
                {
                    MessageBox.Show("Debe ingresar un porcentaje de incremento");
                    validacionSiguientePaso = true;

                }

            }
            else
            {
                label10.Visible = false;
                label11.Visible = false;
                txtPorcentajeIncremento.Visible = false;
                txtTomarSaldo.Visible = false;
            }
        }


        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Visible = true;
        }

        private void tablaPresupuesto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cuentas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        //validacion de cuentas duplicadas
        private void cuentas_DoubleClick(object sender, EventArgs e)
        {

            string sVariable;
            sVariable = lst_cuentas.SelectedItem.ToString();
            bool bValidacion = false;
            foreach (var item in lst_cuentasPresupuesto.Items)
            {
                if(sVariable == item.ToString())
                {
                    bValidacion = true;
                     MessageBox.Show("LA CUENTA: "+sVariable+ " YA ESTA INCLUIDA");
                  
                }

            }
              if(bValidacion == false)      {
                lst_cuentasPresupuesto.Items.Add(sVariable);
            }
    
        }


        //validacion de cuentas duplicadas

        private void button5_Click(object sender, EventArgs e)
        {
            bool bValidacion = false;
            string sVariableCuentas="";
            foreach (var itemCuentas in lst_cuentas.Items)
            {
                bValidacion = false;
                sVariableCuentas = itemCuentas.ToString();
                foreach (var itemPresupuesto in lst_cuentasPresupuesto.Items)
                {
                    if (sVariableCuentas == itemPresupuesto.ToString())
                    {
                        bValidacion = true;
                        MessageBox.Show("LA CUENTA: " + sVariableCuentas + " YA ESTA INCLUIDA");

                    }

                }
                if (bValidacion == false)
                {
                    lst_cuentasPresupuesto.Items.Add(sVariableCuentas);
                }
            }
        }



        //elimina cuenta seleccionada
        private void button3_Click(object sender, EventArgs e)
        {
            string ssVariable = " ";

            try
            {
                ssVariable = lst_cuentasPresupuesto.SelectedItem.ToString();
                lst_cuentasPresupuesto.Items.Remove(ssVariable);

            }
            catch (Exception)
            {

            }
         
        }


        //elimina todas las cuentas
        private void button4_Click(object sender, EventArgs e)
        {
            lst_cuentasPresupuesto.Items.Clear();
        }

        private void pnlMetodoPrellenado_Paint(object sender, PaintEventArgs e)
        {

        }



        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }


        bool activarPanel = false;
        //activa y desactiva funciones de prellenado
        private void rdb_opcionesdePrellenado_Click(object sender, EventArgs e)
        {

            if (activarPanel == true)
            {
                rdb_opcionesdePrellenado.Checked = false;
                pnl_opcionesPrellenado.Enabled = false;
                activarPanel = false;
            

            }
            else
            {
                rdb_opcionesdePrellenado.Checked = true;
                pnl_opcionesPrellenado.Enabled = true;
                activarPanel = true;
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
