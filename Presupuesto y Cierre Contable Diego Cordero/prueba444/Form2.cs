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

namespace prueba444
{
    public partial class Form2 : Form
    {
        Navegador nv = new Navegador();   
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DataTable table2 = nv.cargarDatos("tbl_usuario");
            dgr2.DataSource = table2;
        }

        private void dgr2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new principal2(dgr2).Show();
        }
    }
}
