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
            //Frm_Cuentas cuentas = new Frm_Cuentas(this);
            //cuentas.Show();
        }

        private void polizasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Frm_Polizas polizas = new Frm_Polizas(this);
            //polizas.Show();
        }

        private void balancesContablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Frm_BalancesContables balances = new Frm_BalancesContables(this);
            //balances.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void estoEsDeDouglasGayToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //Frm_ActivosFijos ActivosFijos = new Frm_ActivosFijos();
            //ActivosFijos.Show();
            
        }

        private void Lbl_Fecha_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Data_Catalogo Dactivos = new Frm_Data_Catalogo();
            Dactivos.Show();

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_Data_Activos DActivos = new Frm_Data_Activos();
            DActivos.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Frm_Data_Impuestos Dimpuestos = new Frm_Data_Impuestos();
            Dimpuestos.Show();
        }
    }
}
