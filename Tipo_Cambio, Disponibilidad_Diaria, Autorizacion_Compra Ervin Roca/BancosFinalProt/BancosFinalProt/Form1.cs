﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancosFinalProt
{
    public partial class Mdi_Principal : Form
    {

        public Mdi_Principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
                lbl_Hora.Text = "Hora :" + " " + DateTime.Now.ToLongTimeString();
                Lbl_Fecha.Text = "Fecha :" + " " +DateTime.Now.ToLongDateString();
                Lbl_Moneda.Text = "Moneda :";
                lbl_Usuario.Text = "Usuario :" + "Administrador";

            }
        }

        private void cuentasBancariasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Frm_MovimientosBancarios movimientos = new Frm_MovimientosBancarios(this);

            movimientos.Show();
        }

        private void movimientosBancariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ConcilacionBancaria concilacion = new Frm_ConcilacionBancaria(this);
            concilacion.Show();
        }

        private void estadosCuentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_DisponibilidadDiaria disponibilidad = new Frm_DisponibilidadDiaria(this);
            disponibilidad.Show();
        }

        private void depositosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_TipoCambioGrid gridTipo = new Frm_TipoCambioGrid(this);
            gridTipo.Show();
            
        }

        private void retirosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ProcesoAutorizacionCompra autorizacion = new Frm_ProcesoAutorizacionCompra(this);
            autorizacion.Show();
        }

        private void transferenciasBancariasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ProcesoGeneracionChequesPlanilla planilla = new Frm_ProcesoGeneracionChequesPlanilla(this);
            planilla.Show();
        }

       

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


       

        private void lbl_HoraFecha_Click(object sender, EventArgs e)
        {
          
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void Lbl_Moneda_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void pnl_Top_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
