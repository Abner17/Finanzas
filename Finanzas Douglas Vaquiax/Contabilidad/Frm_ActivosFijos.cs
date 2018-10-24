using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDiseno;


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

        public Frm_ActivosFijos()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Frm_ActivosFijos_Load(object sender, EventArgs e)
        {
            Lbl_FechAct.Text = DateTime.Now.ToLongDateString();
            Cbo_PerDep.Enabled = false;
            Cbo_PerAmort.Enabled = false;
            Chk_AmortDigitosDecrecientes.Enabled = false;
            Chk_AmortLineal.Enabled = false;
            Chk_AmortValorNetoContable.Enabled = false;
            Chk_DepLineaRecta.Enabled = false;
            Chk_DepUniProd.Enabled = false;
            Chk_DepSumDigAnual.Enabled = false;



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
            if (Convert.ToString(Cbo_TipoActivo) == "PC" && Convert.ToString(Cbo_PerDep)== "Anual" ) ;
            {
             Txt_ValorActualActivo.Text = Convert.ToString(Convert.ToInt32(Txt_ValorInicialActivo.Text) -  (Convert.ToInt32(Txt_ValorInicialActivo.Text) * doPC));
            }     
            if (Convert.ToString(Cbo_TipoActivo) == "PC")
            {
               Txt_ValorActualActivo.Text = Convert.ToString(Convert.ToInt32(Txt_ValorInicialActivo.Text) - (Convert.ToInt32(Txt_ValorInicialActivo.Text) * doPC));
            }
            if (Convert.ToString(Cbo_TipoActivo) == "PC")
            {
              Txt_ValorActualActivo.Text = Convert.ToString(Convert.ToInt32(Txt_ValorInicialActivo.Text) - (Convert.ToInt32(Txt_ValorInicialActivo.Text) * doPC));
            }
            if (Convert.ToString(Cbo_TipoActivo) == "PC")
            {
                Txt_ValorActualActivo.Text = Convert.ToString(Convert.ToInt32(Txt_ValorInicialActivo.Text) - (Convert.ToInt32(Txt_ValorInicialActivo.Text) * doPC));
            }

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
            if (Cbo_PerDep.Text == "Trimestral")
            {
                Lbl_Porcentajedep.Text = "5% ";
            }
            if (Cbo_PerDep.Text == "Mensual")
            {
                Lbl_Porcentajedep.Text = "1.66% ";
            }
            /*condiciones de depreciaciones para equipo de computo*/
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
            /*condiciones de depreciaciones para Edificios*/
            if (Cbo_PerDep.Text == "Anual" && Cbo_TipoActivo.Text == "E")
            {
                Lbl_Porcentajedep.Text = "5% ";
            }
            if (Cbo_PerDep.Text == "Trimestral")
            {
                Lbl_Porcentajedep.Text = "1.25% ";
            }
            if (Cbo_PerDep.Text == "Mensual")
            {
                Lbl_Porcentajedep.Text = "0.42% ";
            }
            /*condiciones de depreciaciones para equipo de Maquinaria*/
            if (Cbo_PerDep.Text == "Anual" && (Cbo_TipoActivo.Text == "MA" || Cbo_TipoActivo.Text == "ME"))
            {
                Lbl_Porcentajedep.Text = "20% ";
            }
            if (Cbo_PerDep.Text == "Trimestral"&&(Cbo_TipoActivo.Text == "MA" || Cbo_TipoActivo.Text == "ME"))
            {
                Lbl_Porcentajedep.Text = "5% ";
            }
            if (Cbo_PerDep.Text == "Mensual"&& (Cbo_TipoActivo.Text == "MA" || Cbo_TipoActivo.Text == "ME"))
            {
                Lbl_Porcentajedep.Text = "1.66% ";
            }
            /*condiciones de depreciaciones para bienes no indicados*/
            if (Cbo_PerDep.Text == "Anual" && Cbo_TipoActivo.Text == "BNI")
            {
                Lbl_Porcentajedep.Text = "10% ";
            }
            if (Cbo_PerDep.Text == "Trimestral")
            {
                Lbl_Porcentajedep.Text = "3.33% ";
            }
            if (Cbo_PerDep.Text == "Mensual")
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
                Chk_DepUniProd.Enabled = true;
                Chk_DepSumDigAnual.Enabled = true;
                Chk_AmortDigitosDecrecientes.Enabled = false;
                Chk_AmortLineal.Enabled = false;
                Chk_AmortValorNetoContable.Enabled = false;

            }
            if (Cbo_TipoActivo.Text == "MAYP" || Cbo_TipoActivo.Text == "DDLL")
            {
                Cbo_PerAmort.Enabled = true;
                Cbo_PerDep.Enabled = false;
                Cbo_PerDep.ResetText();
                Lbl_Porcentajedep.ResetText();
                Chk_AmortDigitosDecrecientes.Enabled = true;
                Chk_AmortLineal.Enabled = true;
                Chk_AmortValorNetoContable.Enabled = true;
                Chk_DepLineaRecta.Enabled = false;
                Chk_DepUniProd.Enabled = false;
                Chk_DepSumDigAnual.Enabled = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Chk_AmortLineal_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
           
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
          
        }

        private void Cbo_PerAmort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cbo_PerAmort.Text == "Anual" && Cbo_TipoActivo.Text == "MYPA")
            {
                Lbl_PorcentajeAmort.Text = "20% ";
            }
            if (Cbo_PerAmort.Text == "Trimestral")
            {
                Lbl_PorcentajeAmort.Text = "5% ";
            }
            if (Cbo_PerAmort.Text == "Mensual")
            {
               Lbl_PorcentajeAmort.Text = "1.66% ";
            }
            if (Cbo_PerAmort.Text == "Anual" && Cbo_TipoActivo.Text == "DDLL")
            {
                Lbl_PorcentajeAmort.Text = "20% ";
            }
            if (Cbo_PerAmort.Text == "Trimestral")
            {
                Lbl_PorcentajeAmort.Text = "5% ";
            }
            if (Cbo_PerAmort.Text == "Mensual")
            {
                Lbl_PorcentajeAmort.Text = "1.66% ";
            }
        }
    }
}
