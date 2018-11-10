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
using CapaDiseno;
using CapaLogicaDiego;

namespace Contabilidad
{
    public partial class Presupuestos : Form
    {
        Navegador nv2 = new Navegador();


        public Presupuestos()
        {
  
            InitializeComponent();
            nv2.nombreForm(this);
            nv2.dgv_datos(null);


        }

          Logica logica = new Logica();

        // cargo de fecha y parametros iniciales
        private void Presupuestos_Load(object sender, EventArgs e)
        {
            nv2.ingresarTabla("");

            nv2.insertData("tbl_detalle_presupuesto", Dgv_detalle, 0, 1, 2, 3, 4);



                logica.LLenarDepartamentosYEjercicio(ejercicioPresupuesto, lst_departamento);
                logica.MostrarCuentas(lst_cuentas);
          

        }



        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
           // MessageBox.Show(txtEjercicioPresupuesto.Text);
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
        string variable_Departamento="";

        //pre llenado de presupuesto y validacion de datos
        private void button1_Click(object sender, EventArgs e)
        {


            validacionSiguientePaso = false;

            actualizarHeader();
            /// OdbcDataReader almacenaTab;
            bool validacionLectura = false;
            if (validacionSiguientePaso == false)
            {

              
                dgv_Presupuesto.Rows.Clear();



                foreach (var itemPresupuesto in lst_cuentasPresupuesto.Items)
                {
                    validacionLectura = false;
                    string sMyString;
                    string id_cuenta;
                    sMyString = itemPresupuesto.ToString();
                    id_cuenta = devuelveOcho(sMyString);

                   



                    try
                    {
                  //      MessageBox.Show("1:" +variable_Departamento);
                   //     MessageBox.Show("2:" + txtEjercicioPresupuesto.Text);


                        string sql = "Select id_cuenta, Nombre_Cuenta, Cargo, Abono from tbl_catalogo_cuentas_contables where id_cuenta = " + id_cuenta+
                            " AND NOT EXISTS (Select id_departamento, fecha from tbl_encabezado_presupuesto where id_departamento = " + variable_Departamento +" and fecha like '"+ txtEjercicioPresupuesto.Text+"%' )";


                        Conexion nuevo = new Conexion();
                        OdbcCommand cmdTabla = nuevo.ObtenerConexion().CreateCommand();
                        cmdTabla.CommandText = sql;
                        cmdTabla.ExecuteNonQuery();

                        OdbcDataReader almacenaTab = cmdTabla.ExecuteReader();


                        while (almacenaTab.Read() == true)
                        {
                            validacionLectura = true;
                            DataGridViewRow filas = new DataGridViewRow();
                            filas.CreateCells(dgv_Presupuesto);

                            filas.Cells[0].Value = almacenaTab.GetString(0);
                            filas.Cells[1].Value = almacenaTab.GetString(1);

                            for(int ni=2; ni < 14; ni++)
                            {
                                filas.Cells[ni].Value = "0";
                            }


                            if (pnl_opcionesPrellenado.Enabled == true)
                            {

                                int cargos,abonos;
                                double porcentaje = Convert.ToDouble(txtPorcentajeIncremento.Text);
                                if (porcentaje > 0)
                                {

                                }
                                else
                                {
                                    porcentaje = 1;
                                }
                                    cargos = almacenaTab.GetInt32(2);
                                abonos = almacenaTab.GetInt32(3);

                                if (txtTomarSaldo.Text == "Cargos")
                                {
                                    for (int ni = 2; ni < 14; ni++)
                                    {
                                        filas.Cells[ni].Value =cargos+ (cargos*porcentaje)/100;
                                    }

                                }

                                if (txtTomarSaldo.Text == "Abonos")
                                {
                                    for (int ni = 2; ni < 14; ni++)
                                    {
                                        filas.Cells[ni].Value =abonos+(abonos*porcentaje)/100;
                                    }

                                }

                                if (txtTomarSaldo.Text == "Cargos - Abonos")
                                {
                                    int valor= cargos - abonos;

                                    for (int ni = 2; ni < 14; ni++)
                                    {
                                        if (valor > 0)
                                        {
                                            filas.Cells[ni].Value =valor+(valor*porcentaje)/100;
                                        }
                                        else
                                        {
                                            filas.Cells[ni].Value = 0;
                                        }

                                    }

                                }


                            }

                                dgv_Presupuesto.Rows.Add(filas);

                        }
                       

                        almacenaTab.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

                }

                if (validacionLectura == false)
                {
                    MessageBox.Show("Ya existe un presupuesto para el departamento en el ejercicio seleccionado");
                }
                else
                {
                    pnlContenido.Visible = false;
                    dgv_Presupuesto.Visible = true;
                    headerDescripcion.Visible = true;
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
                variable_Departamento = devuelveOcho(MyString);
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
                label8.Visible = true;
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
                    txtPorcentajeIncremento.Text = textBox1.Text ;
                else
                {
                    txtPorcentajeIncremento.Text = " 0";
                    //    MessageBox.Show("Debe ingresar un porcentaje de incremento");
                    //  validacionSiguientePaso = true;

                }

            }
            else
            {
                label10.Visible = false;
                label11.Visible = false;
                label8.Visible = false;
                txtPorcentajeIncremento.Visible = false;
                txtTomarSaldo.Visible = false;
            }
        }


        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
          //  Form1 form1 = new Form1();
           // form1.Visible = true;
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
            bool bValidacion = false;
            string sVariable;
            try
            {
                sVariable = lst_cuentas.SelectedItem.ToString();
                foreach (var item in lst_cuentasPresupuesto.Items)
                {
                    if (sVariable == item.ToString())
                    {
                        bValidacion = true;
                        MessageBox.Show("LA CUENTA: " + sVariable + " YA ESTA INCLUIDA");

                    }

                }
                if (bValidacion == false)
                {
                    lst_cuentasPresupuesto.Items.Add(sVariable);
                }

            }
            catch(Exception )
            {

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

        string presupuesto;
        private void dgv_Presupuesto_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
        string detalle;
            Dgv_detalle.Rows.Clear();

            presupuesto = txtEjercicioPresupuesto.Text + variable_Departamento;


            foreach (DataGridViewRow row in dgv_Presupuesto.Rows)
            {

                int numerocuenta = Convert.ToInt32(row.Cells[0].Value);
                double monto;
                detalle = presupuesto + numerocuenta;

                if (numerocuenta != 0)
                {
                    int contadorMes = 1;
                    for (int ni = 2; ni < 14; ni++)
                    {
                        monto = Convert.ToDouble(row.Cells[ni].Value);
                        // MessageBox.Show("detalle:" + detalle + " idPresupuesto: " + presupuesto + " id_cuenta: " + numerocuenta + " monto: " +monto);
                        DataGridViewRow auxiliar = new DataGridViewRow();

                        auxiliar.CreateCells(Dgv_detalle);
                        auxiliar.Cells[0].Value = detalle+contadorMes;
                        auxiliar.Cells[1].Value = presupuesto;
                        auxiliar.Cells[2].Value = numerocuenta;
                        auxiliar.Cells[3].Value = monto;
                        auxiliar.Cells[4].Value = contadorMes;

                        contadorMes++;

                        Dgv_detalle.Rows.Add(auxiliar);
                    }


                }

            }
        }

        private void pnlContenido_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
