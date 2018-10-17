using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contabilidad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                Logo ventana = new Logo();
                ventana.MdiParent = this;
                ventana.Show();

                MdiClient ctlMDI;
                foreach(Control ctl in this.Controls)
                {
                    try
                    {
                        ctlMDI = (MdiClient)ctl;

                        ctlMDI.BackColor = this.BackColor;
                    }

                    catch(InvalidCastException exc)
                    {
                   
                    }

                Lbl_FechaActual.Text = DateTime.Now.ToString("D");
                Lbl_HoraActual.Text = DateTime.Now.ToString("T");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Minimized;
        }

        private void cuentasBancariasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void cuentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void polizasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Polizas polizas = new Frm_Polizas(this);
            polizas.Show();
        }

        private void balancesContablesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Balance_Produccion_Click(object sender, EventArgs e)
        {
            Frm_balanceProduccion balanceProd = new Frm_balanceProduccion(this);
            balanceProd.Show();
        }

        private void Estado_Resultados_Click(object sender, EventArgs e)
        {
            Frm_EstadoResultados estadoResultados= new Frm_EstadoResultados(this);
            estadoResultados.Show();
        }

        private void Balance_General_Click(object sender, EventArgs e)
        {
            Frm_balanceGeneral balanceGeneral = new Frm_balanceGeneral(this);
            balanceGeneral.Show();
        }
    }
}
