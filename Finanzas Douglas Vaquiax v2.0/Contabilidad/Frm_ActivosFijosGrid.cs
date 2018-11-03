using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using CapaDatos;
namespace Contabilidad
{
    public partial class Frm_ActivosFijosGrid : Form
    {

        public Frm_ActivosFijosGrid()
        {
            InitializeComponent();
        }

        private void Lbl_Contabilidad_Click(object sender, EventArgs e)
        {

        }

        private void dataSet1BindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_ActivosFijosGrid_Load(object sender, EventArgs e)
        {
            try
            {
                 OdbcCommand InfActivos = new OdbcCommand(string.Format("Select * From tbl_detalle_activos"), ConectarServidor.conexion());
                 OdbcDataAdapter da = new OdbcDataAdapter(InfActivos);
                 DataSet ds = new DataSet();
                 da.Fill(ds);
                 Dgv_Activos.DataSource = ds.Tables[0];
                 Dgv_Activos.DataSource = ds.Tables[1];
                 Dgv_Activos.DataSource = ds.Tables[2];
                 Dgv_Activos.DataSource = ds.Tables[3];
                Dgv_Activos.DataSource = ds.Tables[4];
                 Dgv_Activos.DataSource = ds.Tables[5];

            }
            catch (Exception)
            {

               
            }

        }

        private void Dgv_GridActivosFijos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {


        }

        private void button3_Click_1(object sender, EventArgs e)
        {


          


        } 
    }
}
