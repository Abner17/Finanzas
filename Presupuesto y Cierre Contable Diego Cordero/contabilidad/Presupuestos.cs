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
    public partial class Presupuestos : Form
    {
        public Presupuestos()
        {
            InitializeComponent();
        }

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

            cuentas.Items.Add("1. Caja");
            cuentas.Items.Add("2. Pagos");
            cuentas.Items.Add("3. Servicios");
            cuentas.Items.Add("4. Viaticos");
            cuentas.Items.Add("5. Medicamentos");
            cuentas.Items.Add("6. Seguridad");
            cuentas.Items.Add("7. Sueldos");
      


            departamento.Items.Add("1. Contabilidad");
            departamento.Items.Add("2. Administracion");
            departamento.Items.Add("3. Ventas");
            departamento.Items.Add("4. Servicio Al Cliente");
            departamento.Items.Add("5. Seguridad");
            departamento.Items.Add("6. Recursos Humanos");
            departamento.Items.Add("7. Informatica");

            cbMetodoPrellenado.Items.Add("1. Captura Directa Mensual");
            cbMetodoPrellenado.Items.Add("2. Captura Directa Anual");
            cbMetodoPrellenado.Items.Add("3. Copiar Presupuesto otro ejercicio");



            string sql = "Select id_cuenta, Nombre_Cuenta from catalogo_cuentas";
            int contador = 1;
            Conexion nuevo = new Conexion();
            OdbcCommand cmd = nuevo.ObtenerConexion().CreateCommand();
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();

            OdbcDataReader almacena = cmd.ExecuteReader();
            cuentas.Items.Clear();
            cuentas.Items.Add(" Seleccionar Todo");
            while (almacena.Read())
            {    contador++;
                cuentas.Refresh();
                cuentas.Items.Add( almacena.GetString(0) +" - "+ almacena.GetString(1));
            }

            sql = "Select id_departamento, nombre_departamento from departamentos";
            contador = 1;
           // Conexion nuevo = new Conexion();
            OdbcCommand cmdDepartamentos = nuevo.ObtenerConexion().CreateCommand();
            cmdDepartamentos.CommandText = sql;
            cmdDepartamentos.ExecuteNonQuery();

            almacena = cmdDepartamentos.ExecuteReader();
            departamento.Items.Clear();
            departamento.Items.Add(" Seleccionar Todo");
            while (almacena.Read())
            {
                contador++;
                departamento.Refresh();
                departamento.Items.Add(almacena.GetString(0) + " - " + almacena.GetString(1));
            }



            








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

        private void button1_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            tablaPresupuesto.Visible = true;
            headerDescripcion.Visible = true;

            try
            {
                string sql = "Select id_cuenta, Nombre_Cuenta from catalogo_cuentas";

                Conexion nuevo = new Conexion();
                OdbcCommand cmdTabla = nuevo.ObtenerConexion().CreateCommand();
                cmdTabla.CommandText = sql;
                cmdTabla.ExecuteNonQuery();

                OdbcDataReader almacenaTab = cmdTabla.ExecuteReader();
                //    cuentas.Items.Clear();
                //     cuentas.Items.Add(" Seleccionar Todo");



                while (almacenaTab.Read() == true)
                {
                    DataGridViewRow filas = new DataGridViewRow();
                    filas.CreateCells(tablaPresupuesto);

                    filas.Cells[0].Value = almacenaTab.GetString(0);
                    filas.Cells[1].Value = almacenaTab.GetString(1);




                    tablaPresupuesto.Rows.Add(filas);
                }
                almacenaTab.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            tablaPresupuesto.Visible = false;
            headerDescripcion.Visible = false;

        }

        private void headerDescripcion_Paint(object sender, PaintEventArgs e)
        {
            string MyString;
          
            int indicecuenta = cuentas.SelectedIndex;
            int indicedept = departamento.SelectedIndex;

            

            txtEjercicioPresupuesto.Text = ejercicioPresupuesto.Text;

            MyString = cuentas.Items[indicecuenta].ToString();
            txtSeleccionarCuentas.Text = MyString.Remove(0, 4);



            MyString = departamento.Items[indicedept].ToString();
            txtDepartamento.Text = MyString.Remove(0, 4);



            MyString = cbMetodoPrellenado.Text;
            txtMetodoPrellenado.Text = MyString.Remove(0,2);

            txtPorcentajeIncremento.Text = textBox1.Text + " %";




            if (saldo1.Checked)
                txtTomarSaldo.Text = saldo1.Text;
            else if (saldo2.Checked)
                txtTomarSaldo.Text = saldo2.Text;
            else if (saldo3.Checked)
                txtTomarSaldo.Text = saldo3.Text;
            else
                MessageBox.Show("Debe seleccionar un metodo de saldo");
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
