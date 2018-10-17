using System;
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
    public partial class Frm_TipoCambioGrid : Form
    {
        Mdi_Principal principal;
        public Frm_TipoCambioGrid(Mdi_Principal frm)
        {
            InitializeComponent();
            principal = frm;
        }

        private void Frm_TipoCambioGrid_Load(object sender, EventArgs e)
        {
            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.HeaderText = "Codigo";
            c1.Width = 150;
            c1.ReadOnly = true;

            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.HeaderText = "Nombre";
            c2.Width = 200;
            c2.ReadOnly = true;

            DataGridViewTextBoxColumn c3 = new DataGridViewTextBoxColumn();
            c3.HeaderText = "Abreviatura";
            c3.Width = 150;
            c3.ReadOnly = true;

            DataGridViewTextBoxColumn c4 = new DataGridViewTextBoxColumn();
            c4.HeaderText = "Tipo de Cambio";
            c4.Width = 200;
            c4.ReadOnly = true;

            Dgv_TipoCambio.Columns.Add(c1);
            Dgv_TipoCambio.Columns.Add(c2);
            Dgv_TipoCambio.Columns.Add(c3);
            Dgv_TipoCambio.Columns.Add(c4);


            Dgv_TipoCambio.Rows.Add();
            Dgv_TipoCambio[0, 0].Value = "1";
            Dgv_TipoCambio[1, 0].Value = "Quetzales";
            Dgv_TipoCambio[2, 0].Value = "Q";
            Dgv_TipoCambio[3, 0].Value = "1.000000";

            Dgv_TipoCambio.Rows.Add();
            Dgv_TipoCambio[0, 1].Value = "2";
            Dgv_TipoCambio[1, 1].Value = "Dolar Americano";
            Dgv_TipoCambio[2, 1].Value = "$";
            Dgv_TipoCambio[3, 1].Value = "0.130000";

            Dgv_TipoCambio.Rows.Add();
            Dgv_TipoCambio[0, 2].Value = "3";
            Dgv_TipoCambio[1, 2].Value = "Euro";
            Dgv_TipoCambio[2, 2].Value = "€";
            Dgv_TipoCambio[3, 2].Value = "0.110000";

            Dgv_TipoCambio.Rows.Add();
            Dgv_TipoCambio[0, 3].Value = "4";
            Dgv_TipoCambio[1, 3].Value = "Libra Esterlina";
            Dgv_TipoCambio[2, 3].Value = "£";
            Dgv_TipoCambio[3, 3].Value = "0.098000";

           

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           

        }

        private void Dgv_TipoCambio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            principal.Show();

        }

        private void Dgv_TipoCambio_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Hide();
            Frm_TipoCambio cambio = new Frm_TipoCambio();
            cambio.Show();
        }
    }
}
