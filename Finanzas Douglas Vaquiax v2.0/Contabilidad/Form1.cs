﻿using System;
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

        private void estoEsDeDouglasGayToolStripMenuItem_Click(object sender, EventArgs e)
        {

           
            
        }

        private void Lbl_Fecha_Click(object sender, EventArgs e)
        {

        }

        private void fiscalesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aquiVaAbsaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Pnl_PanelSuperior_Paint(object sender, PaintEventArgs e)
        {

        }

        private void diegoTambienTrabajaAcaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void estadoDeResultadosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void estadosFinancierosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mostrarActivosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ingresoActivosFijosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ActivosFijos ActivosFijos = new Frm_ActivosFijos();
            ActivosFijos.Show();
        }

        private void mostrarIngresosFijosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ActivosFijosGrid ActivosFijos = new Frm_ActivosFijosGrid();
            ActivosFijos.Show();
        }

        private void polizaActivosFIjosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void polizaActivosFijosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Frm_PolizaActivos ActivosFijosPoliza = new Frm_PolizaActivos();
            ActivosFijosPoliza.Show();
        }
    }
}
