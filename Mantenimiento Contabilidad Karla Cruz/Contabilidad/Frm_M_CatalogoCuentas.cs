﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDiseno;

namespace Contabilidad
{
    public partial class Frm_M_CatalogoCuentas : Form
    {
     
        public Frm_M_CatalogoCuentas  ()
        {
            InitializeComponent();
            CapaDiseno.Navegador nav = new Navegador();
        }

        private void Frm_CatalogoCuentas_Load(object sender, EventArgs e)
        {

        }
    }
}