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
    public partial class principal1 : Form
    {
        //constructor del objeto navegador
        Navegador nv = new Navegador();
        //En el constructor recibir como parametro un datagrid
        public principal1(DataGridView dgr)
        {
            InitializeComponent();
            //metodo para referenciar el form que se esta utilizando, en este caso se utiliza this para referenciar al form actual
            nv.nombreForm(this);
            //metodo para cargar los datos de la fila seleccionada del datagrid a los textbox, se utiliza tag.
            nv.dgv_datos(dgr);
        }
        private void principal1_Load(object sender, EventArgs e)
        {
            DataSet dt = nv.cargarCombobox("prueba", "nombre");
            cboNombre.DataSource = dt.Tables[0].DefaultView;
            cboNombre.ValueMember = "nombre";
            //metodo para utilizar una tabla, se le pone tag a los textbox, combobox, etc...
            nv.ingresarTabla("prueba");

            //metodo para utilizar mas tablas, NO hay que poner tag a los textbox, combobox, etc...
            nv.otrasTablas("tbl_modulo", txtCodigo, cboNombre);
        }
    }
}
