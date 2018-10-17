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
            Frm_Cuentas cuentas = new Frm_Cuentas(this);
            cuentas.Show();
        }

        private void polizasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Polizas polizas = new Frm_Polizas(this);
            polizas.Show();
        }

        private void balancesContablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_BalancesContables balances = new Frm_BalancesContables(this);
            balances.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void movimientosBancariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void presupuestosDeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aquiTrabajaDiegoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Presupuestos presupuestos = new Presupuestos();
           presupuestos.Show();
        }

        private void diegoTambienTrabajaAcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CierreContable cierre = new CierreContable();
            cierre.Show();
        }
    }
}
