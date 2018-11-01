using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace BancosFinalProt
{
    public partial class Frm_VisorConciliacionBancaria : Form
    {
        string dir;
        public Frm_VisorConciliacionBancaria(string direccion)
        {
            InitializeComponent();
            dir = direccion;
        }

        private void axAcroPDF1_Enter(object sender, EventArgs e)
        {

        }

        private void Frm_VisorConciliacionBancaria_Load(object sender, EventArgs e)
        {
            axAcroPDF1.LoadFile(dir);
            /*MySqlCommand sql = new MySqlCommand(String.Format("pd_BuscarEmpleadoCodigo"), ConectarServidor.conexion());
            sql.CommandType = CommandType.StoredProcedure;*/ //para cargar los datos al data grid 
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void Btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Dgv_CierreContable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
