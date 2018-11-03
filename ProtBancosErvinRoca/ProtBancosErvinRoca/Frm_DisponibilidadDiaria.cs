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
    public partial class Frm_DisponibilidadDiaria : Form
    {
        
        SenteciasDB dat = new SenteciasDB();
        Mdi_Principal principal;
        public Frm_DisponibilidadDiaria(Mdi_Principal frm)
        {
            InitializeComponent();
            principal = frm;
        }

        private void Frm_DisponibilidadDiaria_Load(object sender, EventArgs e)
        {
            Frm_ProcesoAutorizacionCompra pros = new Frm_ProcesoAutorizacionCompra();
            


            dat.DatosCuentas(Dgv_DisponibilidadDiaria);

            double suma = 0;
            foreach(DataGridViewRow row in Dgv_DisponibilidadDiaria.Rows)
            {
                suma += Convert.ToDouble(row.Cells["Saldo"].Value);
            }
            Lbl_SaldoDeCuentas.Text = "Q" + " " + Convert.ToString(suma);
          

        }
        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            principal.Show();
        }

        private void Lbl_SaldoCuentas_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
