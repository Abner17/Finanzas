namespace Contabilidad
{
    partial class Presupuestos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Presupuestos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lbl_Contabilidad = new System.Windows.Forms.Label();
            this.Btn_Cerrar = new System.Windows.Forms.Button();
            this.Btn_Logo = new System.Windows.Forms.Button();
            this.pnlEjercicio = new System.Windows.Forms.Panel();
            this.ejercicioPresupuesto = new System.Windows.Forms.DomainUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlContenido = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.btnEliminarTodo = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lst_cuentasPresupuesto = new System.Windows.Forms.ListBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.pnlMetodoPrellenado = new System.Windows.Forms.Panel();
            this.lst_departamento = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.saldo3 = new System.Windows.Forms.RadioButton();
            this.saldo2 = new System.Windows.Forms.RadioButton();
            this.saldo1 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlSeleccionCuentas = new System.Windows.Forms.Panel();
            this.btnAgregarTodo = new System.Windows.Forms.Button();
            this.lst_cuentas = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_Presupuesto = new System.Windows.Forms.DataGridView();
            this.asdf1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headerDescripcion = new System.Windows.Forms.Panel();
            this.txtDepartamento = new System.Windows.Forms.Label();
            this.txtPorcentajeIncremento = new System.Windows.Forms.Label();
            this.txtTomarSaldo = new System.Windows.Forms.Label();
            this.txtEjercicioPresupuesto = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.rdb_opcionesdePrellenado = new System.Windows.Forms.RadioButton();
            this.pnl_opcionesPrellenado = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlEjercicio.SuspendLayout();
            this.pnlContenido.SuspendLayout();
            this.panel7.SuspendLayout();
            this.pnlMetodoPrellenado.SuspendLayout();
            this.pnlSeleccionCuentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Presupuesto)).BeginInit();
            this.headerDescripcion.SuspendLayout();
            this.pnl_opcionesPrellenado.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(169)))), ((int)(((byte)(206)))));
            this.panel1.Controls.Add(this.Lbl_Contabilidad);
            this.panel1.Controls.Add(this.Btn_Cerrar);
            this.panel1.Controls.Add(this.Btn_Logo);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 42);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Lbl_Contabilidad
            // 
            this.Lbl_Contabilidad.AutoSize = true;
            this.Lbl_Contabilidad.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Contabilidad.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Contabilidad.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Contabilidad.Location = new System.Drawing.Point(42, 5);
            this.Lbl_Contabilidad.Name = "Lbl_Contabilidad";
            this.Lbl_Contabilidad.Size = new System.Drawing.Size(328, 32);
            this.Lbl_Contabilidad.TabIndex = 5;
            this.Lbl_Contabilidad.Text = "1110_Crear Presupuesto";
            // 
            // Btn_Cerrar
            // 
            this.Btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(192)))), ((int)(((byte)(195)))));
            this.Btn_Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Cerrar.Image")));
            this.Btn_Cerrar.Location = new System.Drawing.Point(892, 0);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Size = new System.Drawing.Size(41, 41);
            this.Btn_Cerrar.TabIndex = 3;
            this.Btn_Cerrar.UseVisualStyleBackColor = false;
            this.Btn_Cerrar.Click += new System.EventHandler(this.Btn_Cerrar_Click);
            // 
            // Btn_Logo
            // 
            this.Btn_Logo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Logo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(192)))), ((int)(((byte)(195)))));
            this.Btn_Logo.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Logo.Image")));
            this.Btn_Logo.Location = new System.Drawing.Point(0, 0);
            this.Btn_Logo.Name = "Btn_Logo";
            this.Btn_Logo.Size = new System.Drawing.Size(41, 41);
            this.Btn_Logo.TabIndex = 9;
            this.Btn_Logo.UseVisualStyleBackColor = false;
            // 
            // pnlEjercicio
            // 
            this.pnlEjercicio.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlEjercicio.Controls.Add(this.ejercicioPresupuesto);
            this.pnlEjercicio.Controls.Add(this.label1);
            this.pnlEjercicio.Location = new System.Drawing.Point(57, 14);
            this.pnlEjercicio.Name = "pnlEjercicio";
            this.pnlEjercicio.Size = new System.Drawing.Size(209, 74);
            this.pnlEjercicio.TabIndex = 5;
            // 
            // ejercicioPresupuesto
            // 
            this.ejercicioPresupuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ejercicioPresupuesto.Location = new System.Drawing.Point(26, 37);
            this.ejercicioPresupuesto.Name = "ejercicioPresupuesto";
            this.ejercicioPresupuesto.ReadOnly = true;
            this.ejercicioPresupuesto.Size = new System.Drawing.Size(157, 21);
            this.ejercicioPresupuesto.TabIndex = 1;
            this.ejercicioPresupuesto.Text = "2018";
            this.ejercicioPresupuesto.SelectedItemChanged += new System.EventHandler(this.domainUpDown1_SelectedItemChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ejercicio del Presupuesto";
            // 
            // pnlContenido
            // 
            this.pnlContenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(192)))), ((int)(((byte)(195)))));
            this.pnlContenido.Controls.Add(this.panel7);
            this.pnlContenido.Controls.Add(this.btnAceptar);
            this.pnlContenido.Controls.Add(this.pnlMetodoPrellenado);
            this.pnlContenido.Controls.Add(this.pnlSeleccionCuentas);
            this.pnlContenido.Controls.Add(this.pnlEjercicio);
            this.pnlContenido.Location = new System.Drawing.Point(166, 161);
            this.pnlContenido.Name = "pnlContenido";
            this.pnlContenido.Size = new System.Drawing.Size(618, 473);
            this.pnlContenido.TabIndex = 6;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel7.Controls.Add(this.label13);
            this.panel7.Controls.Add(this.btnEliminarTodo);
            this.panel7.Controls.Add(this.btnEliminar);
            this.panel7.Controls.Add(this.lst_cuentasPresupuesto);
            this.panel7.Location = new System.Drawing.Point(57, 268);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(209, 149);
            this.panel7.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(5, 7);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(195, 18);
            this.label13.TabIndex = 5;
            this.label13.Text = "Cuentas A Presupuestar:";
            // 
            // btnEliminarTodo
            // 
            this.btnEliminarTodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.btnEliminarTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarTodo.ForeColor = System.Drawing.Color.Black;
            this.btnEliminarTodo.Location = new System.Drawing.Point(85, 119);
            this.btnEliminarTodo.Name = "btnEliminarTodo";
            this.btnEliminarTodo.Size = new System.Drawing.Size(121, 27);
            this.btnEliminarTodo.TabIndex = 4;
            this.btnEliminarTodo.Text = "Eliminar Todo";
            this.btnEliminarTodo.UseVisualStyleBackColor = false;
            this.btnEliminarTodo.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Location = new System.Drawing.Point(4, 119);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 27);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.button3_Click);
            // 
            // lst_cuentasPresupuesto
            // 
            this.lst_cuentasPresupuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_cuentasPresupuesto.FormattingEnabled = true;
            this.lst_cuentasPresupuesto.ItemHeight = 15;
            this.lst_cuentasPresupuesto.Location = new System.Drawing.Point(3, 31);
            this.lst_cuentasPresupuesto.Name = "lst_cuentasPresupuesto";
            this.lst_cuentasPresupuesto.Size = new System.Drawing.Size(203, 79);
            this.lst_cuentasPresupuesto.TabIndex = 2;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.Black;
            this.btnAceptar.Location = new System.Drawing.Point(261, 429);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(107, 33);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlMetodoPrellenado
            // 
            this.pnlMetodoPrellenado.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlMetodoPrellenado.Controls.Add(this.pnl_opcionesPrellenado);
            this.pnlMetodoPrellenado.Controls.Add(this.rdb_opcionesdePrellenado);
            this.pnlMetodoPrellenado.Controls.Add(this.lst_departamento);
            this.pnlMetodoPrellenado.Controls.Add(this.label3);
            this.pnlMetodoPrellenado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMetodoPrellenado.Location = new System.Drawing.Point(353, 14);
            this.pnlMetodoPrellenado.Name = "pnlMetodoPrellenado";
            this.pnlMetodoPrellenado.Size = new System.Drawing.Size(218, 403);
            this.pnlMetodoPrellenado.TabIndex = 7;
            this.pnlMetodoPrellenado.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMetodoPrellenado_Paint);
            // 
            // lst_departamento
            // 
            this.lst_departamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_departamento.FormattingEnabled = true;
            this.lst_departamento.ItemHeight = 15;
            this.lst_departamento.Location = new System.Drawing.Point(8, 38);
            this.lst_departamento.Name = "lst_departamento";
            this.lst_departamento.Size = new System.Drawing.Size(202, 79);
            this.lst_departamento.TabIndex = 2;
            this.lst_departamento.SelectedIndexChanged += new System.EventHandler(this.departamento_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Seleccionar Departamento:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(9, 158);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(198, 21);
            this.textBox1.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(4, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Porcentaje de Incremento:";
            // 
            // saldo3
            // 
            this.saldo3.AutoSize = true;
            this.saldo3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saldo3.Location = new System.Drawing.Point(23, 89);
            this.saldo3.Name = "saldo3";
            this.saldo3.Size = new System.Drawing.Size(66, 19);
            this.saldo3.TabIndex = 10;
            this.saldo3.TabStop = true;
            this.saldo3.Text = "Abonos";
            this.saldo3.UseVisualStyleBackColor = true;
            // 
            // saldo2
            // 
            this.saldo2.AutoSize = true;
            this.saldo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saldo2.Location = new System.Drawing.Point(23, 66);
            this.saldo2.Name = "saldo2";
            this.saldo2.Size = new System.Drawing.Size(64, 19);
            this.saldo2.TabIndex = 9;
            this.saldo2.TabStop = true;
            this.saldo2.Text = "Cargos";
            this.saldo2.UseVisualStyleBackColor = true;
            // 
            // saldo1
            // 
            this.saldo1.AutoSize = true;
            this.saldo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saldo1.Location = new System.Drawing.Point(23, 43);
            this.saldo1.Name = "saldo1";
            this.saldo1.Size = new System.Drawing.Size(115, 19);
            this.saldo1.TabIndex = 8;
            this.saldo1.TabStop = true;
            this.saldo1.Text = "Cargos - Abonos";
            this.saldo1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tomar como saldo:";
            // 
            // pnlSeleccionCuentas
            // 
            this.pnlSeleccionCuentas.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlSeleccionCuentas.Controls.Add(this.btnAgregarTodo);
            this.pnlSeleccionCuentas.Controls.Add(this.lst_cuentas);
            this.pnlSeleccionCuentas.Controls.Add(this.label2);
            this.pnlSeleccionCuentas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlSeleccionCuentas.Location = new System.Drawing.Point(57, 101);
            this.pnlSeleccionCuentas.Name = "pnlSeleccionCuentas";
            this.pnlSeleccionCuentas.Size = new System.Drawing.Size(209, 155);
            this.pnlSeleccionCuentas.TabIndex = 6;
            // 
            // btnAgregarTodo
            // 
            this.btnAgregarTodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.btnAgregarTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarTodo.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarTodo.Location = new System.Drawing.Point(49, 122);
            this.btnAgregarTodo.Name = "btnAgregarTodo";
            this.btnAgregarTodo.Size = new System.Drawing.Size(118, 27);
            this.btnAgregarTodo.TabIndex = 4;
            this.btnAgregarTodo.Text = "Agregar Todo";
            this.btnAgregarTodo.UseVisualStyleBackColor = false;
            this.btnAgregarTodo.Click += new System.EventHandler(this.button5_Click);
            // 
            // lst_cuentas
            // 
            this.lst_cuentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_cuentas.FormattingEnabled = true;
            this.lst_cuentas.ItemHeight = 15;
            this.lst_cuentas.Location = new System.Drawing.Point(4, 34);
            this.lst_cuentas.Name = "lst_cuentas";
            this.lst_cuentas.Size = new System.Drawing.Size(202, 79);
            this.lst_cuentas.TabIndex = 1;
            this.lst_cuentas.SelectedIndexChanged += new System.EventHandler(this.cuentas_SelectedIndexChanged);
            this.lst_cuentas.DoubleClick += new System.EventHandler(this.cuentas_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Seleccionar Cuentas:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dgv_Presupuesto
            // 
            this.dgv_Presupuesto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Presupuesto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.asdf1,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13});
            this.dgv_Presupuesto.Location = new System.Drawing.Point(6, 243);
            this.dgv_Presupuesto.Name = "dgv_Presupuesto";
            this.dgv_Presupuesto.Size = new System.Drawing.Size(921, 381);
            this.dgv_Presupuesto.TabIndex = 7;
            this.dgv_Presupuesto.Visible = false;
            this.dgv_Presupuesto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaPresupuesto_CellContentClick);
            // 
            // asdf1
            // 
            this.asdf1.HeaderText = "No. Cuenta";
            this.asdf1.Name = "asdf1";
            this.asdf1.Width = 60;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Enero";
            this.Column2.Name = "Column2";
            this.Column2.Width = 60;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Febrero";
            this.Column3.Name = "Column3";
            this.Column3.Width = 60;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Marzo";
            this.Column4.Name = "Column4";
            this.Column4.Width = 60;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Abril";
            this.Column5.Name = "Column5";
            this.Column5.Width = 60;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Mayo";
            this.Column6.Name = "Column6";
            this.Column6.Width = 60;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Junio";
            this.Column7.Name = "Column7";
            this.Column7.Width = 60;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Julio";
            this.Column8.Name = "Column8";
            this.Column8.Width = 60;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Agosto";
            this.Column9.Name = "Column9";
            this.Column9.Width = 60;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Septiembre";
            this.Column10.Name = "Column10";
            this.Column10.Width = 60;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Octubre";
            this.Column11.Name = "Column11";
            this.Column11.Width = 60;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Noviembre";
            this.Column12.Name = "Column12";
            this.Column12.Width = 60;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Diciembre";
            this.Column13.Name = "Column13";
            this.Column13.Width = 60;
            // 
            // headerDescripcion
            // 
            this.headerDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(192)))), ((int)(((byte)(195)))));
            this.headerDescripcion.Controls.Add(this.label4);
            this.headerDescripcion.Controls.Add(this.txtDepartamento);
            this.headerDescripcion.Controls.Add(this.txtPorcentajeIncremento);
            this.headerDescripcion.Controls.Add(this.txtTomarSaldo);
            this.headerDescripcion.Controls.Add(this.txtEjercicioPresupuesto);
            this.headerDescripcion.Controls.Add(this.button2);
            this.headerDescripcion.Controls.Add(this.label7);
            this.headerDescripcion.Controls.Add(this.label9);
            this.headerDescripcion.Controls.Add(this.label10);
            this.headerDescripcion.Controls.Add(this.label11);
            this.headerDescripcion.Location = new System.Drawing.Point(12, 55);
            this.headerDescripcion.Name = "headerDescripcion";
            this.headerDescripcion.Size = new System.Drawing.Size(909, 95);
            this.headerDescripcion.TabIndex = 8;
            this.headerDescripcion.Visible = false;
            this.headerDescripcion.Paint += new System.Windows.Forms.PaintEventHandler(this.headerDescripcion_Paint);
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.AutoSize = true;
            this.txtDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartamento.Location = new System.Drawing.Point(163, 66);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(11, 16);
            this.txtDepartamento.TabIndex = 24;
            this.txtDepartamento.Text = " ";
            // 
            // txtPorcentajeIncremento
            // 
            this.txtPorcentajeIncremento.AutoSize = true;
            this.txtPorcentajeIncremento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPorcentajeIncremento.Location = new System.Drawing.Point(574, 66);
            this.txtPorcentajeIncremento.Name = "txtPorcentajeIncremento";
            this.txtPorcentajeIncremento.Size = new System.Drawing.Size(11, 16);
            this.txtPorcentajeIncremento.TabIndex = 22;
            this.txtPorcentajeIncremento.Text = " ";
            // 
            // txtTomarSaldo
            // 
            this.txtTomarSaldo.AutoSize = true;
            this.txtTomarSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTomarSaldo.Location = new System.Drawing.Point(526, 39);
            this.txtTomarSaldo.Name = "txtTomarSaldo";
            this.txtTomarSaldo.Size = new System.Drawing.Size(11, 16);
            this.txtTomarSaldo.TabIndex = 20;
            this.txtTomarSaldo.Text = " ";
            // 
            // txtEjercicioPresupuesto
            // 
            this.txtEjercicioPresupuesto.AutoSize = true;
            this.txtEjercicioPresupuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEjercicioPresupuesto.Location = new System.Drawing.Point(249, 39);
            this.txtEjercicioPresupuesto.Name = "txtEjercicioPresupuesto";
            this.txtEjercicioPresupuesto.Size = new System.Drawing.Size(11, 16);
            this.txtEjercicioPresupuesto.TabIndex = 19;
            this.txtEjercicioPresupuesto.Text = " ";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(789, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 33);
            this.button2.TabIndex = 18;
            this.button2.Text = "Editar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(48, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(206, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Ejercicio del Presupuesto:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(48, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 18);
            this.label9.TabIndex = 14;
            this.label9.Text = "Departamento:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label10.Location = new System.Drawing.Point(373, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(206, 18);
            this.label10.TabIndex = 17;
            this.label10.Text = "Porcentaje de Incremento:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(373, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(156, 18);
            this.label11.TabIndex = 16;
            this.label11.Text = "Tomar como saldo:";
            // 
            // rdb_opcionesdePrellenado
            // 
            this.rdb_opcionesdePrellenado.AutoSize = true;
            this.rdb_opcionesdePrellenado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_opcionesdePrellenado.Location = new System.Drawing.Point(9, 150);
            this.rdb_opcionesdePrellenado.Name = "rdb_opcionesdePrellenado";
            this.rdb_opcionesdePrellenado.Size = new System.Drawing.Size(160, 19);
            this.rdb_opcionesdePrellenado.TabIndex = 13;
            this.rdb_opcionesdePrellenado.TabStop = true;
            this.rdb_opcionesdePrellenado.Text = "Opciones de Prellenado:";
            this.rdb_opcionesdePrellenado.UseVisualStyleBackColor = true;
            this.rdb_opcionesdePrellenado.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            this.rdb_opcionesdePrellenado.Click += new System.EventHandler(this.rdb_opcionesdePrellenado_Click);
            // 
            // pnl_opcionesPrellenado
            // 
            this.pnl_opcionesPrellenado.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pnl_opcionesPrellenado.Controls.Add(this.label5);
            this.pnl_opcionesPrellenado.Controls.Add(this.saldo1);
            this.pnl_opcionesPrellenado.Controls.Add(this.saldo2);
            this.pnl_opcionesPrellenado.Controls.Add(this.textBox1);
            this.pnl_opcionesPrellenado.Controls.Add(this.saldo3);
            this.pnl_opcionesPrellenado.Controls.Add(this.label6);
            this.pnl_opcionesPrellenado.Enabled = false;
            this.pnl_opcionesPrellenado.Location = new System.Drawing.Point(3, 180);
            this.pnl_opcionesPrellenado.Name = "pnl_opcionesPrellenado";
            this.pnl_opcionesPrellenado.Size = new System.Drawing.Size(211, 211);
            this.pnl_opcionesPrellenado.TabIndex = 11;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(381, 651);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(179, 33);
            this.button3.TabIndex = 11;
            this.button3.Text = "Guardar Presupuesto";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(277, 24);
            this.label4.TabIndex = 25;
            this.label4.Text = "Informacion del Presupuesto";
            // 
            // Presupuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(207)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(933, 700);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.headerDescripcion);
            this.Controls.Add(this.pnlContenido);
            this.Controls.Add(this.dgv_Presupuesto);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Presupuestos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Presupuestos";
            this.Load += new System.EventHandler(this.Presupuestos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlEjercicio.ResumeLayout(false);
            this.pnlEjercicio.PerformLayout();
            this.pnlContenido.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.pnlMetodoPrellenado.ResumeLayout(false);
            this.pnlMetodoPrellenado.PerformLayout();
            this.pnlSeleccionCuentas.ResumeLayout(false);
            this.pnlSeleccionCuentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Presupuesto)).EndInit();
            this.headerDescripcion.ResumeLayout(false);
            this.headerDescripcion.PerformLayout();
            this.pnl_opcionesPrellenado.ResumeLayout(false);
            this.pnl_opcionesPrellenado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lbl_Contabilidad;
        private System.Windows.Forms.Button Btn_Cerrar;
        private System.Windows.Forms.Button Btn_Logo;
        private System.Windows.Forms.Panel pnlEjercicio;
        private System.Windows.Forms.DomainUpDown ejercicioPresupuesto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlContenido;
        private System.Windows.Forms.Panel pnlSeleccionCuentas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lst_cuentas;
        private System.Windows.Forms.ListBox lst_departamento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlMetodoPrellenado;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgv_Presupuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn asdf1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Panel headerDescripcion;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label txtDepartamento;
        private System.Windows.Forms.Label txtPorcentajeIncremento;
        private System.Windows.Forms.Label txtTomarSaldo;
        private System.Windows.Forms.Label txtEjercicioPresupuesto;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnEliminarTodo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ListBox lst_cuentasPresupuesto;
        private System.Windows.Forms.Button btnAgregarTodo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton saldo3;
        private System.Windows.Forms.RadioButton saldo2;
        private System.Windows.Forms.RadioButton saldo1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnl_opcionesPrellenado;
        private System.Windows.Forms.RadioButton rdb_opcionesdePrellenado;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
    }
}