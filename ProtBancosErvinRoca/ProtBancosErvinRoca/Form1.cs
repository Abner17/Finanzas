using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProtBancosErvinRoca
{
    public partial class Mdi_Principal : Form
    {
        public Mdi_Principal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MdiClient ctiMDI;
            foreach (Control ct1 in this.Controls)
            {
                try
                {
                    ctiMDI = (MdiClient)ct1;

                    ctiMDI.BackColor = this.BackColor;
                }
                catch (InvalidCastException exec)
                {
                }
            }
                }

        private void disponibilidadDiariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_DisponibilidadDiaria disponibilidad = new Frm_DisponibilidadDiaria(this);
            disponibilidad.Show();
        }

        private void tipoDeCambioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_TipoCambio tipo = new Frm_TipoCambio(this);
            tipo.Show();
        }

        private void procesoYAutorizacionDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ProcesoAutorizacionCompra autorizacion = new Frm_ProcesoAutorizacionCompra(this);
            autorizacion.Show();
        }

        private void Btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
