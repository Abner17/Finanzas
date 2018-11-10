using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace BancosFinalProt
{
    public partial class Frm_ConciliacionBancaria : Form
    {
        public Frm_ConciliacionBancaria()
        {
            InitializeComponent();
            this.openFileDialog1 = new OpenFileDialog();
        }

        private void Frm_ConciliacionBancaria_Load(object sender, EventArgs e)
        {
            Txt_Fecha.Text = DateTime.Now.ToString("d");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string direccion = Txt_DireccionEstadoDeCuenta.Text;
            string opcionAño = Cbo_Año.Text;
            string opcionMes = Cbo_Mes.Text;
 
            Frm_VisorConciliacionBancaria visor = new Frm_VisorConciliacionBancaria(direccion, opcionAño, opcionMes);
            visor.Show();

            Txt_DireccionEstadoDeCuenta.Clear();
            Cbo_Mes.SelectedIndex = -1;
            Cbo_Año.SelectedIndex = -1;
            Cbo_Mes.Enabled = false;
            Btn_GenerarConciliacion.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cbo_Mes.Enabled = true;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Btn_GenerarConciliacion.Enabled = true;
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Txt_NumeroConciliacion_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void navegador1_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Frm_ConciliacionBancaria_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Frm_ConciliacionBancaria_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void Frm_ConciliacionBancaria_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "C:/Ayuda/AyudaGeneralConciliacionBancaria.chm");
        }

        private void Txt_DireccionEstadoDeCuenta_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "C:/Ayuda/AyudaEspecificaConciliacionBancaria.chm");
        }

        private void Btn_Ayuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:/Ayuda/AyudaGeneralConciliacionBancaria.chm");
        }

        private void Btn_Examinar_Click(object sender, EventArgs e)
        {
            OpenFileDialog cuadro = new OpenFileDialog();

            if(cuadro.ShowDialog() == DialogResult.OK)
            {
                Txt_DireccionEstadoDeCuenta.Text = cuadro.FileName;
            }
        }
    }
}
