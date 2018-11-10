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
    public partial class principal2 : Form
    {
        Navegador nv2 = new Navegador();
        public principal2(DataGridView dgr)
        {
            InitializeComponent();
           // nv2.nombreForm(this);
          // nv2.dgv_datos(dgr);
        }

        private void principal2_Load(object sender, EventArgs e)
        {
           // nv2.ingresarTabla("tbl_usuario");
            /*metodo para cargar el contenido de un datagrid a la base de datos, hasta que se le de guardar se envia
              la informacion a la base de datos, para utilizarlo primero se envia el nombre de la tabla, despues el 
              datagrid, y por ultimo las columnas que deseen guardar en la tabla*/
            nv2.insertData("tbl_modulo", dgr1, 0, 2, 3);
        }
    }
}
