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
    public partial class Frm_TipoCambio : Form
    {
        SenteciasDB da = new SenteciasDB();
        Mdi_Principal principal;
        public Frm_TipoCambio(Mdi_Principal frm)
        {
            InitializeComponent();
            principal = frm;
        }

        private void Frm_TipoCambio_Load(object sender, EventArgs e)
        {
            da.DatosTipoCambio(Dgv_TipoCambio);
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            principal.Show();
        }

        private void Frm_TipoCambio_MouseClick(object sender, MouseEventArgs e)
        {
            new Frm_Moneda(Dgv_TipoCambio).Show();
        }

        private void Dgv_TipoCambio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
