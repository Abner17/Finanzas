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
    public partial class Frm_Data_cuentaBancaria : Form
    {
        Navegador nv = new Navegador();
        public Frm_Data_cuentaBancaria()
        {
            InitializeComponent();
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Data_cuentaBancaria_Load(object sender, EventArgs e)
        {
            DataTable tabla = nv.cargarDatos("tbl_cuenta_bancaria");
            dgr2.DataSource = tabla;
        }

        private void dgr2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new Frm_M_cuentaBancaria(dgr2).Show();
        }

        private void dgr2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
