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

namespace BancosFinalProt
{
    public partial class Frm_ConcilacionBancaria : Form
    {
        Mdi_Principal principal;
        public Frm_ConcilacionBancaria(Mdi_Principal frm)
        {
            InitializeComponent();
            principal = frm;
        }

        private void Frm_MovimientosBancarios_Load(object sender, EventArgs e)
        {
           
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            principal.Show();
        }

        private void Btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "1";
            textBox2.Text = "00321665615";
            textBox3.Text = DateTime.Now.ToString("d");
            label10.Text = this.dataGridView1.Rows.Count.ToString();
            label11.Text = this.dataGridView1.Rows.Count.ToString();
        }
    }
}
