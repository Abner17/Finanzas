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
    public partial class Frm_Retiros : Form
    {
        Mdi_Principal principal;
        public Frm_Retiros(Mdi_Principal frm)
        {
            InitializeComponent();
            principal = frm;
        }

        private void Frm_Retiros_Load(object sender, EventArgs e)
        {

        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            principal.Show();
        }
    }
}
