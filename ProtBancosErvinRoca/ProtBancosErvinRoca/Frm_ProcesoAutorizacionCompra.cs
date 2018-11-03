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
    public partial class Frm_ProcesoAutorizacionCompra : Form
    {
        SenteciasDB dt = new SenteciasDB();
        Mdi_Principal principal;
        public Frm_ProcesoAutorizacionCompra(Mdi_Principal frm)
        {
            InitializeComponent();
            principal = frm;
        }

        public Frm_ProcesoAutorizacionCompra()
        {
            InitializeComponent();
          
        }

        private void Frm_ProcesoAutorizacionCompra_Load(object sender, EventArgs e)
        {
            dt.DatosDetalleProducto(Dgv_DetalleProducto);
            dt.DatosEmpleado(Cmb_Empleado);
            dt.OperacionAutorizacion(Cmb_Operacion);



            double suma = 0;
            foreach (DataGridViewRow row in Dgv_DetalleProducto.Rows)
            {
                suma += Convert.ToDouble(row.Cells["Precio"].Value);
            }
            Lbl_TotalProd.Text = "Q" +" "+ Convert.ToString(suma);
           
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            principal.Show();
        }

        private void Cmb_Operacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Pnl_ProcesoAurotizacion_MouseClick(object sender, MouseEventArgs e)
        {
            new Frm_Aprobacion().Show();
        }
    }
}
