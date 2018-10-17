using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contabilidad
{
    public partial class Frm_Data_Catalogo : Form
    {
        public Frm_Data_Catalogo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_M_CatalogoCuentas CatalogoCuentas = new Frm_M_CatalogoCuentas();
            CatalogoCuentas.Show();
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}