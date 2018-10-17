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
    public partial class _6600_Bancos : Form
    {
        Mdi_Principal principal = new Mdi_Principal();
        public _6600_Bancos()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Frm_GeneracionChequesPlanilla_Load(object sender, EventArgs e)
        {

        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            principal.Show();
        }
    }
}
