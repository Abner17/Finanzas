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
    public partial class Frm_TipoCambio : Form
    {
        Mdi_Principal principal1;
        public Frm_TipoCambio(Mdi_Principal frm1)
        {
            InitializeComponent();
            principal1 = frm1;
        }

        public Frm_TipoCambio(Frm_TipoCambioGrid frm_TipoCambioGrid)
        {
        }

        public Frm_TipoCambio()
        {
        }

        private void Frm_Depositos_Load(object sender, EventArgs e)
        {
           
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            principal1.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
