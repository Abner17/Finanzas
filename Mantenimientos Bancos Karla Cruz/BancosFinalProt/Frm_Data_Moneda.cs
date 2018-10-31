using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDiseno;

namespace BancosFinalProt
{
    public partial class Frm_Data_Moneda : Form
    {
        Navegador nv = new Navegador();
        public Frm_Data_Moneda()
        {
            InitializeComponent();
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgr3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new Frm_M_Moneda(dgr3).Show();
        }

        private void Frm_Data_Moneda_Load(object sender, EventArgs e)
        {
            DataTable tabla = nv.cargarDatos("tbl_moneda");
            dgr3.DataSource = tabla;
        }
    }
}
