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
    public partial class Frm_ProcesoAutorizacionCompra : Form
    {
        Mdi_Principal principal;
        public Frm_ProcesoAutorizacionCompra(Mdi_Principal frm)
        {
            InitializeComponent();
            principal = frm;
        }

        private void Frm_Retiros_Load(object sender, EventArgs e)
        {
            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.HeaderText = "Codigo";
            c1.Width = 100;
            c1.ReadOnly = true;

            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.HeaderText = "Nombre";
            c2.Width = 100;
            c2.ReadOnly = true;

            DataGridViewTextBoxColumn c3 = new DataGridViewTextBoxColumn();
            c3.HeaderText = "Cantidad";
            c3.Width = 100;
            c3.ReadOnly = true;

            DataGridViewTextBoxColumn c4 = new DataGridViewTextBoxColumn();
            c4.HeaderText = "Precio";
            c4.Width = 100;
            c4.ReadOnly = true;

            DataGridViewTextBoxColumn c5 = new DataGridViewTextBoxColumn();
            c5.HeaderText = "Total";
            c5.Width = 100;
            c5.ReadOnly = true;

            DataGridViewTextBoxColumn c6 = new DataGridViewTextBoxColumn();
            c6.HeaderText = "Proveedor";
            c6.Width = 100;
            c6.ReadOnly = true;

            dataGridView1.Columns.Add(c1);
            dataGridView1.Columns.Add(c2);
            dataGridView1.Columns.Add(c3);
            dataGridView1.Columns.Add(c4);
            dataGridView1.Columns.Add(c5);
            dataGridView1.Columns.Add(c6);



            dataGridView1.Rows.Add();
            dataGridView1[0, 0].Value = "1";
            dataGridView1[1, 0].Value = "Laptop";
            dataGridView1[2, 0].Value = "2";
            dataGridView1[3, 0].Value = "Q5000";
            dataGridView1[4, 0].Value = "Q10000";
            dataGridView1[5, 0].Value = "DELL";

            dataGridView1.Rows.Add();
            dataGridView1[0, 1].Value = "2";
            dataGridView1[1, 1].Value = "Impresora";
            dataGridView1[2, 1].Value = "1";
            dataGridView1[3, 1].Value = "Q5000";
            dataGridView1[4, 1].Value = "Q5000";
            dataGridView1[5, 1].Value = "EPSON";


            txt_FechaAutorizacion.Text = "16/10/18";
            txt_FechaSolicitud.Text = "12/10/18";

        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            principal.Show();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
