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
        }

        private void Frm_ConciliacionBancaria_Load(object sender, EventArgs e)
        {
            axAcroPDF1.LoadFile("C:/Users/sebas/Desktop/Estado.pdf");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Txt_NumeroConciliacion.Text = "1";
            Txt_Fecha.Text = DateTime.Now.ToString("d");
            Lbl_NumeroMovimientos.Text = this.Dgv_CierreContable.Rows.Count.ToString();

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
    }
}
