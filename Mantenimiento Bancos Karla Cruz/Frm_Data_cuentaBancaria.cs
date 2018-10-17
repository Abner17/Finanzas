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
    public partial class Frm_Data_cuentaBancaria : Form
    {
        public Frm_Data_cuentaBancaria()
        {
            InitializeComponent();
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_M_cuentaBancaria CuentaB = new Frm_M_cuentaBancaria();
            CuentaB.Show();
        }
    }
}
