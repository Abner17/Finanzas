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
    public partial class Frm_DisponibilidadDiaria : Form
    {
        Mdi_Principal principal;
        public Frm_DisponibilidadDiaria(Mdi_Principal frm)
        {
            InitializeComponent();
            principal = frm;
        }

        private void Frm_EstadosCuenta_Load(object sender, EventArgs e)
        {
            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.HeaderText = "No.Cuenta";
            c1.Width = 100;
            c1.ReadOnly = true;

            DataGridViewTextBoxColumn c6 = new DataGridViewTextBoxColumn();
            c6.HeaderText = "Banco";
            c6.Width = 200;
            c6.ReadOnly = true;

            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.HeaderText = "Estado";
            c2.Width = 100;
            c2.ReadOnly = true;

            DataGridViewTextBoxColumn c3 = new DataGridViewTextBoxColumn();
            c3.HeaderText = "Saldo";
            c3.Width = 100;
            c3.ReadOnly = true;

            DataGridViewTextBoxColumn c4 = new DataGridViewTextBoxColumn();
            c4.HeaderText = "Fecha> ";
            c4.Width = 100;
            c4.ReadOnly = true;


            dataGridView1.Columns.Add(c1);
            dataGridView1.Columns.Add(c6);
            dataGridView1.Columns.Add(c2);
            dataGridView1.Columns.Add(c3);
            dataGridView1.Columns.Add(c4);


            dataGridView1.Rows.Add();
            dataGridView1[0, 0].Value = "000001";
            dataGridView1[1, 0].Value = "G&T CONTINENTAL";
            dataGridView1[2, 0].Value = "Activo";
            dataGridView1[3, 0].Value = "Q30000.00";
            dataGridView1[4, 0].Value = "16/10/18";

            dataGridView1.Rows.Add();
            dataGridView1[0, 1].Value = "000002";
            dataGridView1[1, 1].Value = "INDUSTRIAL";
            dataGridView1[2, 1].Value = "Activo";
            dataGridView1[3, 1].Value = "Q50000.00";
            dataGridView1[4, 1].Value = "16/10/18";

            dataGridView1.Rows.Add();
            dataGridView1[0, 2].Value = "000003";
            dataGridView1[1, 2].Value = "BANRURAL";
            dataGridView1[2, 2].Value = "Activo";
            dataGridView1[3, 2].Value = "Q70000.00";
            dataGridView1[4, 2].Value = "16/10/18";

            txtDisponibilidad.Text = "Q100000.00";

        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            principal.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void txtDisponibilidad_TextChanged(object sender, EventArgs e)
        {
            txtDisponibilidad.Text = "Q100000.00";
              
        }
    }
}
