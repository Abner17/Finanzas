using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Prototipo_Abner_Portillo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            logo ventana = new logo();
            ventana.MdiParent = this;
            ventana.Show();

            MdiClient ctlMDI;
            foreach (Control ctl in this.Controls)
            {
                try
                {
                    ctlMDI = (MdiClient)ctl;

                    ctlMDI.BackColor = this.BackColor;
                }

                catch (InvalidCastException exc)
                {

                }

                Lbl_FechaActual.Text = DateTime.Now.ToString("D");
                Lbl_HoraActual.Text = DateTime.Now.ToString("T");
            }

        }

        private void Btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void polizasLocalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ListadoPolizasLocales LPL = new Frm_ListadoPolizasLocales();
            LPL.Show();
        }

        private void estadoDeResultadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ListaEstadoResultados LER = new Frm_ListaEstadoResultados();
            LER.Show();
        }
    }
}
