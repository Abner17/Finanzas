using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;

using System.Data.Odbc;

namespace Contabilidad
{

    public partial class Frm_ActivosFijos : Form
    {
      
        public double doPC = 0.3333;
        public double doE = 0.05;
        public double doMe = 0.20;
        public double doV = 0.20;
        public double doMA = 0.20;
        public double doBMI = 0.10;
        public double doMAYP = 0.20;
        public double doDDLL = 0.10;
        public double doResultado = 0;
        public int iResultado = 1;
        public double doResultado2 = 0;
        public double doResultado3 = 0;
       
        public Frm_ActivosFijos()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Frm_ActivosFijos_Load(object sender, EventArgs e)
        {
            /*inicializacion de los componentes del formulario en el cual algunos deben de aparecer desahilitados, ya que
             la inforacion que se menaja en los mismos no puede ser alterada */
            Dtp_FecAct.Enabled = false;
            Cbo_PerDep.Enabled = false;
            Cbo_PerAmort.Enabled = false;
            Chk_AmortDigitosDecrecientes.Enabled = false;
            Chk_AmortLineal.Enabled = false;
            Txt_PersonaEncargada.Enabled = false;
            Chk_DepLineaRecta.Enabled = false;            
            Chk_DepSumDigAnual.Enabled = false;
            Chk_DepPorcentual.Enabled = false;
            Chk_AmortPorcentual.Enabled = false;
            //Aqui se cargan los datos de la tabla tbl_tipo_activo a el combobox de tipo de activo , desplegando todos los tipos de activos existentes
            try
            {
                OdbcCommand TipoActivos = new OdbcCommand(String.Format("SELECT Nombre_tipoactivo FROM tbl_tipo_activo"), ConectarServidor.conexion());
                OdbcDataAdapter da1 = new OdbcDataAdapter(TipoActivos);
                DataSet ds1 = new DataSet();


                da1.Fill(ds1);
                for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
                {
                    Cbo_TipoActivo.Items.Add(ds1.Tables[0].Rows[i][0]);
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Lbl_FechAct_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Calculo_Click(object sender, EventArgs e)
        {
           

        }

        private void Chk_Deprecicacion_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void Chk_Amortizacion_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Cbo_PerDep_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (Cbo_PerDep.Text == "Anual" && Cbo_TipoActivo.Text == "V")
            {
                Lbl_Porcentajedep.Text = "20% ";
            }
            if (Cbo_PerDep.Text == "Trimestral" && Cbo_TipoActivo.Text == "V")
            {
                Lbl_Porcentajedep.Text = "5% ";
            }
            if (Cbo_PerDep.Text == "Mensual" && Cbo_TipoActivo.Text == "V")
            {
                Lbl_Porcentajedep.Text = "1.66% ";
            }
            //condiciones de depreciaciones para equipo de computo
            if (Cbo_PerDep.Text == "Anual" && Cbo_TipoActivo.Text == "PC")
            {
                Lbl_Porcentajedep.Text = "33.33% ";
            }
            if (Cbo_PerDep.Text == "Trimestral" && Cbo_TipoActivo.Text == "PC")
            {
                Lbl_Porcentajedep.Text = "8.33% ";
            }
            if (Cbo_PerDep.Text == "Mensual" && Cbo_TipoActivo.Text == "PC")
            {
                Lbl_Porcentajedep.Text = "2.77% ";
            }
            //condiciones de depreciaciones para Edificios
            if (Cbo_PerDep.Text == "Anual" && Cbo_TipoActivo.Text == "E")
            {
                Lbl_Porcentajedep.Text = "5% ";
            }
            if (Cbo_PerDep.Text == "Trimestral" && Cbo_TipoActivo.Text == "E")
            {
                Lbl_Porcentajedep.Text = "1.25% ";
            }
            if (Cbo_PerDep.Text == "Mensual" && Cbo_TipoActivo.Text == "E")
            {
                Lbl_Porcentajedep.Text = "0.42% ";
            }
            //condiciones de depreciaciones para equipo de Maquinaria
            if (Cbo_PerDep.Text == "Anual" && (Cbo_TipoActivo.Text == "MA" || Cbo_TipoActivo.Text == "ME"))
            {
                Lbl_Porcentajedep.Text = "20% ";
            }
            if (Cbo_PerDep.Text == "Trimestral" && (Cbo_TipoActivo.Text == "MA" || Cbo_TipoActivo.Text == "ME"))
            {
                Lbl_Porcentajedep.Text = "5% ";
            }
            if (Cbo_PerDep.Text == "Mensual" && (Cbo_TipoActivo.Text == "MA" || Cbo_TipoActivo.Text == "ME"))
            {
                Lbl_Porcentajedep.Text = "1.66% ";
            }
            //condiciones de depreciaciones para bienes no indicados
            if (Cbo_PerDep.Text == "Anual" && Cbo_TipoActivo.Text == "BNI")
            {
                Lbl_Porcentajedep.Text = "10% ";
            }
            if (Cbo_PerDep.Text == "Trimestral" && Cbo_TipoActivo.Text == "BNI")
            {
                Lbl_Porcentajedep.Text = "3.33% ";
            }
            if (Cbo_PerDep.Text == "Mensual" && Cbo_TipoActivo.Text == "BNI")
            {
                Lbl_Porcentajedep.Text = "0.83% ";
            }

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Gpb_Busquedactivo_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Gpb_Periodo_Enter(object sender, EventArgs e)
        {

        }

        private void Cbo_TipoActivo_SelectedIndexChanged(object sender, EventArgs e)
        {

           
            if (Cbo_TipoActivo.Text == "V" || Cbo_TipoActivo.Text == "PC" || Cbo_TipoActivo.Text == "MA" || Cbo_TipoActivo.Text == "ME" || Cbo_TipoActivo.Text == "BNI" || Cbo_TipoActivo.Text == "E")
            {
                Cbo_PerDep.Enabled = true;
                Cbo_PerAmort.Enabled = false;
                Cbo_PerAmort.ResetText();
                Lbl_PorcentajeAmort.ResetText();
                Chk_DepLineaRecta.Enabled = true;
                Chk_DepSumDigAnual.Enabled = true;
                Chk_DepPorcentual.Enabled = true;
                Chk_AmortDigitosDecrecientes.Enabled = false;
                Chk_AmortLineal.Enabled = false;

                Chk_AmortPorcentual.Enabled = false;



            }
            if (Cbo_TipoActivo.Text == "MAYP" || Cbo_TipoActivo.Text == "DDLL")
            {
                Cbo_PerAmort.Enabled = true;
                Cbo_PerDep.Enabled = false;
                Cbo_PerDep.ResetText();
                Lbl_Porcentajedep.ResetText();
                Chk_AmortDigitosDecrecientes.Enabled = true;
                Chk_AmortLineal.Enabled = true;

                Chk_AmortPorcentual.Enabled = true;
                Chk_DepLineaRecta.Enabled = false;
                Chk_DepSumDigAnual.Enabled = false;
                Chk_DepPorcentual.Enabled = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //hace el calculo del resultado de las depreciaciones de manera lineal 
            doResultado = Convert.ToDouble(Txt_ValorInicialActivo.Text) / Convert.ToInt32(Txt_VidaUtil.Text);
            doResultado2 = Convert.ToDouble(Txt_ValorInicialActivo.Text) - doResultado;
            Txt_ValorActualActivo.Text = Convert.ToString(doResultado2);

        }

        private void Chk_AmortLineal_CheckedChanged(object sender, EventArgs e)
        {
            // realiza el calculo de las depreciaciones de manera lineal
            Txt_ValorActualActivo.Text = "";
            try
            {
                Txt_ValorActualActivo.ResetText();
                doResultado = Convert.ToDouble(Txt_ValorInicialActivo.Text) / Convert.ToDouble(Txt_VidaUtil.Text);

                Txt_ValorActualActivo.Text = Convert.ToString(doResultado);
            }
            catch (Exception)
            {

                MessageBox.Show("Llene los campos requeridos con los valores adecuados");

            }


        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void Cbo_PerAmort_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*en esta seccion se le asigna a dos labels en el diseño el valor que van a obtener al seleccionar el tipo 
             de periodo en el que se va a trabajar ya sea mensual , trimestral o anual*/ 
            if (Cbo_PerAmort.Text == "Anual" && Cbo_TipoActivo.Text == "MAYP" || Cbo_TipoActivo.Text == "DDLL")
            {
                Lbl_PorcentajeAmort.Text = "20% ";
            }
            if (Cbo_PerAmort.Text == "Trimestral" && Cbo_TipoActivo.Text == "MAYP" || Cbo_TipoActivo.Text == "DDLL")
            {
                Lbl_PorcentajeAmort.Text = "5% ";
            }
            if (Cbo_PerAmort.Text == "Mensual" && Cbo_TipoActivo.Text == "MAYP" || Cbo_TipoActivo.Text == "DDLL")
            {
                Lbl_PorcentajeAmort.Text = "1.66% ";
            }

        }

        private void Chk_AmortDigitosDecrecientes_CheckedChanged(object sender, EventArgs e)
        {
            /*calculo de la amortizacion por medio del metodo de la suma de digitos decrecientes en el cual tambien se
             utiliza el calculo del factorial de  la vida util del activo y posteriormente se le aplica el metodo 
             para luefo restarselo al valor inicial del activo*/
            Txt_ValorActualActivo.Text = "";
            try
            {
                for (int i = 1; i <= int.Parse(Txt_VidaUtil.Text); i++)
                {

                    iResultado = iResultado * i;
                    doResultado2 = Convert.ToDouble(Txt_ValorInicialActivo.Text) / iResultado;
                    doResultado3 = Convert.ToDouble(Txt_ValorInicialActivo.Text) - doResultado2;
                    Txt_ValorActualActivo.Text = Convert.ToString(doResultado3);

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Ingrese un numero");
            }


        }

        private void Txt_ValorActualActivo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Chk_AmortValorNetoContable_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Chk_AmortPorcentual_CheckedChanged(object sender, EventArgs e)
        {
            //se utiliza este comando para que el usuario a la hora de hacer la gention tenga datos los cuales pueda manipular 
            Txt_ValorActualActivo.Text = "";
            if (Cbo_PerAmort.Enabled == true && Cbo_PerAmort.Text == "")
            {
                MessageBox.Show("Seleccione el Periodo de la Amortizacion");
            }
            /*Depreciacion porcentual de Marcas y Patentes del cual se obtiene el porcentaje del mismo y loego se le resta
             al valor inicial del activo */
            if (Cbo_PerAmort.Text == "Anual")
            {
                doResultado = Convert.ToDouble(Txt_ValorInicialActivo.Text) * doMAYP;
                doResultado2 = Convert.ToDouble(Txt_ValorInicialActivo.Text) - doResultado;
                Txt_ValorActualActivo.Text = Convert.ToString(doResultado2);

            }

            else if (Cbo_PerAmort.Text == "Trimestral")
            {
                doResultado = Convert.ToDouble(Txt_ValorInicialActivo.Text) * (doMAYP / 4);
                doResultado2 = Convert.ToDouble(Txt_ValorInicialActivo.Text) - doResultado;
                Txt_ValorActualActivo.Text = Convert.ToString(doResultado2);
            }
            else if (Cbo_PerAmort.Text == "Mensual")
            {
                doResultado = Convert.ToDouble(Txt_ValorInicialActivo.Text) * (doMAYP / 12);
                doResultado2 = Convert.ToDouble(Txt_ValorInicialActivo.Text) - doResultado;
                Txt_ValorActualActivo.Text = Convert.ToString(doResultado2);
            }

            //Depreciacion porcentual de Derecho de llave el cual despues se le resta al valor inicial del activo
            if (Cbo_PerAmort.Text == "Anual")
            {
                doResultado = Convert.ToDouble(Txt_ValorInicialActivo.Text) * doDDLL;
                doResultado2 = Convert.ToDouble(Txt_ValorInicialActivo.Text) - doResultado;
                Txt_ValorActualActivo.Text = Convert.ToString(doResultado2);

            }

            else if (Cbo_PerAmort.Text == "Trimestral")
            {
                doResultado = Convert.ToDouble(Txt_ValorInicialActivo.Text) * (doDDLL / 4);
                doResultado2 = Convert.ToDouble(Txt_ValorInicialActivo.Text) - doResultado;
                Txt_ValorActualActivo.Text = Convert.ToString(doResultado2);
            }
            else if (Cbo_PerAmort.Text == "Mensual")
            {
                doResultado = Convert.ToDouble(Txt_ValorInicialActivo.Text) * (doDDLL / 12);
                doResultado2 = Convert.ToDouble(Txt_ValorInicialActivo.Text) - doResultado;
                Txt_ValorActualActivo.Text = Convert.ToString(doResultado2);
            }



        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           /*aplicacion del componente del datetimepicker para que posteriormente se compare con el valor de otro 
            el cual se deshabilita para comparar fechas, aqui el usuario selecciona la fecha en que se compro el activo */
            if (Dtp_FecAdquisicion.Value > Dtp_FecAct.Value)
            {
                MessageBox.Show ("La fecha de adquisicion del activo no puede ser mayor a la fecha Actual");
            }
        }
        //ingresamos el codigo del empleado al que se le asginara el activo y se buscara en la base de datos para luego ser asignado
    
        private void button1_Click_2(object sender, EventArgs e)
        {
            if (Txt_NumInventario.Text=="" && Txt_CodEmpleado.Text =="")
            {
                MessageBox.Show("Favor Llenar los campos requeridos");
            }
            try
            {
                OdbcCommand noencargado = new OdbcCommand(String.Format("SELECT Nombre FROM tbl_empleados Where "+Txt_CodEmpleado.Text+"= ID_Empleado"), ConectarServidor.conexion());
                OdbcDataReader leer;
                leer = noencargado.ExecuteReader();
                while (leer.Read() == true)
                {
                    Txt_PersonaEncargada.Text = leer["Nombre"].ToString();
                }


               
            }
            catch (Exception)
            {

                MessageBox.Show("El empleado no existe");
            }
        }

        private void Btn_CrearActivo_Click(object sender, EventArgs e)
        {
           
            try
            {
                /*OdbcCommand InfActivos 
                = new OdbcCommand(String.Format(
                "insert into `tbl_activos` (`id_activo`,`FechasIngreso_Activos`,`Cantidad_Activos`,`Descripcion_Activos`,`FechaActual_Activos`,`ValorInicial_Activos`,`Nombre_tipoactivo`,`VidaUtil_Activo`) VALUES('"+Txt_NoActivo.Text+"','"+Dtp_FecAdquisicion+"','"+Txt_CantidadActivos+ "','" +Txt_Descripcion+ "','" +Dtp_FecAct+ "','" +Txt_ValorInicialActivo+ "','" +Cbo_TipoActivo+ "','" +Txt_VidaUtil+ "')"), 
                ConectarServidor.conexion());
                OdbcDataAdapter da = new OdbcDataAdapter(InfActivos);
                DataSet ds = new DataSet();*/

                string consulta = "insert into `tbl_activos` (`id_activo`,`FechasIngreso_Activos`,`Cantidad_Activos`,`Descripcion_Activos`,`FechaActual_Activos`,`ValorInicial_Activos`,`Nombre_tipoactivo`,`VidaUtil_Activo`) values (@id_activoa, @FechaIngreso_Activos, @Cantidad_Activos,@Descripcion_Activos ,@FechaActual_Activos ,@ValorInicial_Activos ,@id_tipoactivo ,@VidaUtil_Activo )";
                OdbcCommand SQLComando = new OdbcCommand(consulta);
                SQLComando.Parameters.AddWithValue("@id_activo", Txt_NoActivo.Text);
                SQLComando.Parameters.AddWithValue("@FechaIngreso_Activos", Dtp_FecAdquisicion.Text);
                SQLComando.Parameters.AddWithValue("@Cantidad_Activos", Txt_CantidadActivos.Text);
                SQLComando.Parameters.AddWithValue("@Descripcion_Activos", Txt_Descripcion.Text);
                SQLComando.Parameters.AddWithValue("@FechaActual_Activos", Dtp_FecAct.Text);
                SQLComando.Parameters.AddWithValue("@ValorInicial_Activos", Txt_ValorInicialActivo.Text);
                SQLComando.Parameters.AddWithValue("@fk_id_tipoactivo", Cbo_TipoActivo.Text);
                SQLComando.Parameters.AddWithValue("@VidaUtil_Activo", Txt_VidaUtil.Text);


            }
            catch (Exception)
            {

                MessageBox.Show("Datos Cargados");
            }
        }

        private void Btn_Ingresar_Click(object sender, EventArgs e)
        {
            /*Asignamos en el gridview a cada una de las columnas los valores de cada campo unicamente para que el usuario lleve
             un control de los registros */
            DataGridViewRow casillas = new DataGridViewRow();
            casillas.CreateCells(Dgv_NuevoDato);
            casillas.Cells[0].Value = Cbo_TipoActivo.Text;
            casillas.Cells[1].Value = Txt_ValorInicialActivo.Text;
            if (Cbo_PerDep.Enabled == true)
            {
                casillas.Cells[2].Value = "Depreciacion";
            }
            else if (Cbo_PerAmort.Enabled == true)
            {
                casillas.Cells[2].Value = "Amortizacion";
            }
            casillas.Cells[3].Value = Txt_NumInventario.Text;
            casillas.Cells[4].Value = Txt_PersonaEncargada.Text; 
            casillas.Cells[5].Value = Cbo_TipoActivo.Text;
            if (Cbo_PerDep.Enabled == true)
            {
                casillas.Cells[6].Value = Cbo_PerDep.Text;
            }
            else if (Cbo_PerAmort.Enabled == true)
            {
                casillas.Cells[6].Value = Cbo_PerAmort.Text;
            }
            
            casillas.Cells[7].Value = Cbo_TipoActivo.Text;
            Dgv_NuevoDato.Rows.Add(casillas);

        }

        private void Chk_DepSumDigAnual_CheckedChanged(object sender, EventArgs e)
        {
            /*realiza el calculo de las depreciaciones con el valor de la vida util y el resultado se le resta al valor 
            se le resta a al valor inicial del activo*/
            doResultado = (Convert.ToInt32(Txt_VidaUtil.Text) * (Convert.ToInt32(Txt_VidaUtil.Text) + 1)) / 2;
            doResultado2 = Convert.ToInt32(Txt_VidaUtil.Text) / doResultado;
            doResultado3 = Convert.ToDouble(Txt_ValorInicialActivo.Text) * doResultado2;
            Txt_ValorActualActivo.Text = Convert.ToString(Convert.ToDouble(Txt_ValorInicialActivo.Text) - doResultado3);
        }

        private void Chk_DepPorcentual_CheckedChanged(object sender, EventArgs e)
        {
            Txt_ValorActualActivo.Text = "";
            if (Cbo_PerDep.Enabled == true && Cbo_PerDep.Text == "")
            {
                MessageBox.Show("Seleccione el Periodo de la Depreciacion");
            }
            
            /*Depreciacion porcentual de Vehiculos*/
            if (Cbo_PerDep.Text == "Anual")
            {
                doResultado = Convert.ToDouble(Txt_ValorInicialActivo.Text) * doV;
                doResultado2 = Convert.ToDouble(Txt_ValorInicialActivo.Text) - doResultado;
                Txt_ValorActualActivo.Text = Convert.ToString(doResultado2);

            }

            else if (Cbo_PerDep.Text == "Trimestral")
            {
                doResultado = Convert.ToDouble(Txt_ValorInicialActivo.Text) * (doV / 4);
                doResultado2 = Convert.ToDouble(Txt_ValorInicialActivo.Text) - doResultado;
                Txt_ValorActualActivo.Text = Convert.ToString(doResultado2);
            }
            else if (Cbo_PerDep.Text == "Mensual")
            {
                doResultado = Convert.ToDouble(Txt_ValorInicialActivo.Text) * (doV / 12);
                doResultado2 = Convert.ToDouble(Txt_ValorInicialActivo.Text) - doResultado;
                Txt_ValorActualActivo.Text = Convert.ToString(doResultado2);
            }
            
        
            /*Depreciacion porcentual de Edificios*/
            if (Cbo_PerDep.Text == "Anual")
            {
                doResultado = Convert.ToDouble(Txt_ValorInicialActivo.Text) * doE;
                doResultado2 = Convert.ToDouble(Txt_ValorInicialActivo.Text) - doResultado;
                Txt_ValorActualActivo.Text = Convert.ToString(doResultado2);

            }

            else if (Cbo_PerDep.Text == "Trimestral")
            {
                doResultado = Convert.ToDouble(Txt_ValorInicialActivo.Text) * (doE / 4);
                doResultado2 = Convert.ToDouble(Txt_ValorInicialActivo.Text) - doResultado;
                Txt_ValorActualActivo.Text = Convert.ToString(doResultado2);
            }
            else if (Cbo_PerDep.Text == "Mensual")
            {
                doResultado = Convert.ToDouble(Txt_ValorInicialActivo.Text) * (doE / 12);
                doResultado2 = Convert.ToDouble(Txt_ValorInicialActivo.Text) - doResultado;
                Txt_ValorActualActivo.Text = Convert.ToString(doResultado2);
            }
           
            /*Depreciacion porcentual de Equipo de Computo*/
            if (Cbo_PerDep.Text == "Anual")
            {
                doResultado = Convert.ToDouble(Txt_ValorInicialActivo.Text) * doPC;
                doResultado2 = Convert.ToDouble(Txt_ValorInicialActivo.Text) - doResultado;
                Txt_ValorActualActivo.Text = Convert.ToString(doResultado2);

            }

            else if (Cbo_PerDep.Text == "Trimestral")
            {
                doResultado = Convert.ToDouble(Txt_ValorInicialActivo.Text) * (doPC / 4);
                doResultado2 = Convert.ToDouble(Txt_ValorInicialActivo.Text) - doResultado;
                Txt_ValorActualActivo.Text = Convert.ToString(doResultado2);
            }
            else if (Cbo_PerDep.Text == "Mensual")
            {
                doResultado = Convert.ToDouble(Txt_ValorInicialActivo.Text) * (doPC / 12);
                doResultado2 = Convert.ToDouble(Txt_ValorInicialActivo.Text) - doResultado;
                Txt_ValorActualActivo.Text = Convert.ToString(doResultado2);
            }
           
            /*Depreciacion porcentual de Mobiliario y Equipo*/
            if (Cbo_PerDep.Text == "Anual")
            {
                doResultado = Convert.ToDouble(Txt_ValorInicialActivo.Text) * doMe;
                doResultado2 = Convert.ToDouble(Txt_ValorInicialActivo.Text) - doResultado;
                Txt_ValorActualActivo.Text = Convert.ToString(doResultado2);

            }

            else if (Cbo_PerDep.Text == "Trimestral")
            {
                doResultado = Convert.ToDouble(Txt_ValorInicialActivo.Text) * (doMe / 4);
                doResultado2 = Convert.ToDouble(Txt_ValorInicialActivo.Text) - doResultado;
                Txt_ValorActualActivo.Text = Convert.ToString(doResultado2);
            }
            else if (Cbo_PerDep.Text == "Mensual")
            {
                doResultado = Convert.ToDouble(Txt_ValorInicialActivo.Text) * (doMe / 12);
                doResultado2 = Convert.ToDouble(Txt_ValorInicialActivo.Text) - doResultado;
                Txt_ValorActualActivo.Text = Convert.ToString(doResultado2);
            }
           
            /*Depreciacion porcentual de Maquinaria*/
            if (Cbo_PerDep.Text == "Anual")
            {
                doResultado = Convert.ToDouble(Txt_ValorInicialActivo.Text) * doMA;
                doResultado2 = Convert.ToDouble(Txt_ValorInicialActivo.Text) - doResultado;
                Txt_ValorActualActivo.Text = Convert.ToString(doResultado2);

            }

            else if (Cbo_PerDep.Text == "Trimestral")
            {
                doResultado = Convert.ToDouble(Txt_ValorInicialActivo.Text) * (doMA / 4);
                doResultado2 = Convert.ToDouble(Txt_ValorInicialActivo.Text) - doResultado;
                Txt_ValorActualActivo.Text = Convert.ToString(doResultado2);
            }
            else if (Cbo_PerDep.Text == "Mensual")
            {
                doResultado = Convert.ToDouble(Txt_ValorInicialActivo.Text) * (doMA / 12);
                doResultado2 = Convert.ToDouble(Txt_ValorInicialActivo.Text) - doResultado;
                Txt_ValorActualActivo.Text = Convert.ToString(doResultado2);
            }
           
            /*Depreciacion porcentual de Bienes no Indicados*/
            if (Cbo_PerDep.Text == "Anual")
            {
                doResultado = Convert.ToDouble(Txt_ValorInicialActivo.Text) * doBMI;
                doResultado2 = Convert.ToDouble(Txt_ValorInicialActivo.Text) - doResultado;
                Txt_ValorActualActivo.Text = Convert.ToString(doResultado2);

            }

            else if (Cbo_PerDep.Text == "Trimestral")
            {
                doResultado = Convert.ToDouble(Txt_ValorInicialActivo.Text) * (doBMI / 4);
                doResultado2 = Convert.ToDouble(Txt_ValorInicialActivo.Text) - doResultado;
                Txt_ValorActualActivo.Text = Convert.ToString(doResultado2);
            }
            else if (Cbo_PerDep.Text == "Mensual")
            {
                doResultado = Convert.ToDouble(Txt_ValorInicialActivo.Text) * (doBMI / 12);
                doResultado2 = Convert.ToDouble(Txt_ValorInicialActivo.Text) - doResultado;
                Txt_ValorActualActivo.Text = Convert.ToString(doResultado2);
            }
            
           

        }

        private void Frm_ActivosFijos_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            try
            {
                Help.ShowHelp(this, "C:/ayudas Activos Fijos/Ayuda_General.html");
            }
            catch (Exception)
            {

                MessageBox.Show("Lo sentimos el archivo de la ayuda no se encuantra  en su directorio local");
            }
            
        }
    }
}

