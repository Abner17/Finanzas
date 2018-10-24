namespace Contabilidad
{
    partial class Frm_ActivosFijos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ActivosFijos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Cerrar = new System.Windows.Forms.Button();
            this.Lbl_Contabilidad = new System.Windows.Forms.Label();
            this.Btn_Logo = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Gpb_Periodo = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Lbl_PorcentajeAmort = new System.Windows.Forms.Label();
            this.Lbl_Porcentajedep = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Cbo_PerAmort = new System.Windows.Forms.ComboBox();
            this.Cbo_PerDep = new System.Windows.Forms.ComboBox();
            this.Btn_Calculo = new System.Windows.Forms.Button();
            this.Gpb_NuevoActivo = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Lbl_FechaActual = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_TipoActivo = new System.Windows.Forms.Label();
            this.Cbo_TipoActivo = new System.Windows.Forms.ComboBox();
            this.Lbl_FechAct = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_ValorActualActivo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_ValorInicialActivo = new System.Windows.Forms.TextBox();
            this.Gpb_MetodoDepAmort = new System.Windows.Forms.GroupBox();
            this.Chk_AmortValorNetoContable = new System.Windows.Forms.CheckBox();
            this.Chk_AmortDigitosDecrecientes = new System.Windows.Forms.CheckBox();
            this.Chk_AmortLineal = new System.Windows.Forms.CheckBox();
            this.Chk_DepSumDigAnual = new System.Windows.Forms.CheckBox();
            this.Chk_DepLineaRecta = new System.Windows.Forms.CheckBox();
            this.Chk_DepUniProd = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Gpb_NevoDato = new System.Windows.Forms.GroupBox();
            this.Btn_Ingresar = new System.Windows.Forms.Button();
            this.Dgv_NuevoDato = new System.Windows.Forms.DataGridView();
            this.Activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor_Inicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Depreciacion_Amoritzacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Porcentaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Periodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.Gpb_Periodo.SuspendLayout();
            this.Gpb_NuevoActivo.SuspendLayout();
            this.Gpb_MetodoDepAmort.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.Gpb_NevoDato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_NuevoDato)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(192)))), ((int)(((byte)(195)))));
            this.panel1.Controls.Add(this.Btn_Cerrar);
            this.panel1.Controls.Add(this.Lbl_Contabilidad);
            this.panel1.Controls.Add(this.Btn_Logo);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 42);
            this.panel1.TabIndex = 1;
            this.panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel1_DragDrop);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // Btn_Cerrar
            // 
            this.Btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(192)))), ((int)(((byte)(195)))));
            this.Btn_Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Cerrar.Image")));
            this.Btn_Cerrar.Location = new System.Drawing.Point(880, -2);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Size = new System.Drawing.Size(41, 41);
            this.Btn_Cerrar.TabIndex = 12;
            this.Btn_Cerrar.UseVisualStyleBackColor = false;
            this.Btn_Cerrar.Click += new System.EventHandler(this.Btn_Cerrar_Click);
            // 
            // Lbl_Contabilidad
            // 
            this.Lbl_Contabilidad.AutoSize = true;
            this.Lbl_Contabilidad.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Contabilidad.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Contabilidad.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Contabilidad.Location = new System.Drawing.Point(49, 9);
            this.Lbl_Contabilidad.Name = "Lbl_Contabilidad";
            this.Lbl_Contabilidad.Size = new System.Drawing.Size(368, 32);
            this.Lbl_Contabilidad.TabIndex = 11;
            this.Lbl_Contabilidad.Text = " 1310 _Activos Fijos Ingreso";
            // 
            // Btn_Logo
            // 
            this.Btn_Logo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Logo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(192)))), ((int)(((byte)(195)))));
            this.Btn_Logo.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Logo.Image")));
            this.Btn_Logo.Location = new System.Drawing.Point(3, 1);
            this.Btn_Logo.Name = "Btn_Logo";
            this.Btn_Logo.Size = new System.Drawing.Size(41, 41);
            this.Btn_Logo.TabIndex = 10;
            this.Btn_Logo.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(192)))), ((int)(((byte)(195)))));
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(192)))), ((int)(((byte)(195)))));
            this.button2.Location = new System.Drawing.Point(839, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(41, 41);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Gpb_Periodo
            // 
            this.Gpb_Periodo.Controls.Add(this.label10);
            this.Gpb_Periodo.Controls.Add(this.label9);
            this.Gpb_Periodo.Controls.Add(this.Lbl_PorcentajeAmort);
            this.Gpb_Periodo.Controls.Add(this.Lbl_Porcentajedep);
            this.Gpb_Periodo.Controls.Add(this.label6);
            this.Gpb_Periodo.Controls.Add(this.label5);
            this.Gpb_Periodo.Controls.Add(this.Cbo_PerAmort);
            this.Gpb_Periodo.Controls.Add(this.Cbo_PerDep);
            this.Gpb_Periodo.Location = new System.Drawing.Point(633, 65);
            this.Gpb_Periodo.Name = "Gpb_Periodo";
            this.Gpb_Periodo.Size = new System.Drawing.Size(254, 98);
            this.Gpb_Periodo.TabIndex = 7;
            this.Gpb_Periodo.TabStop = false;
            this.Gpb_Periodo.Text = "Periodos";
            this.Gpb_Periodo.Enter += new System.EventHandler(this.Gpb_Periodo_Enter);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(130, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "% Amortizacion";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "%  Depreciacion";
            // 
            // Lbl_PorcentajeAmort
            // 
            this.Lbl_PorcentajeAmort.AutoSize = true;
            this.Lbl_PorcentajeAmort.Location = new System.Drawing.Point(141, 78);
            this.Lbl_PorcentajeAmort.Name = "Lbl_PorcentajeAmort";
            this.Lbl_PorcentajeAmort.Size = new System.Drawing.Size(0, 13);
            this.Lbl_PorcentajeAmort.TabIndex = 5;
            // 
            // Lbl_Porcentajedep
            // 
            this.Lbl_Porcentajedep.AutoSize = true;
            this.Lbl_Porcentajedep.Location = new System.Drawing.Point(31, 78);
            this.Lbl_Porcentajedep.Name = "Lbl_Porcentajedep";
            this.Lbl_Porcentajedep.Size = new System.Drawing.Size(0, 13);
            this.Lbl_Porcentajedep.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(141, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Amortizacion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Depreciacion";
            // 
            // Cbo_PerAmort
            // 
            this.Cbo_PerAmort.FormattingEnabled = true;
            this.Cbo_PerAmort.Items.AddRange(new object[] {
            "Anual",
            "Trimestral",
            "Mensual"});
            this.Cbo_PerAmort.Location = new System.Drawing.Point(135, 31);
            this.Cbo_PerAmort.Name = "Cbo_PerAmort";
            this.Cbo_PerAmort.Size = new System.Drawing.Size(73, 21);
            this.Cbo_PerAmort.TabIndex = 1;
            this.Cbo_PerAmort.SelectedIndexChanged += new System.EventHandler(this.Cbo_PerAmort_SelectedIndexChanged);
            // 
            // Cbo_PerDep
            // 
            this.Cbo_PerDep.FormattingEnabled = true;
            this.Cbo_PerDep.Items.AddRange(new object[] {
            "Anual",
            "Trimestral",
            "Mensual"});
            this.Cbo_PerDep.Location = new System.Drawing.Point(29, 31);
            this.Cbo_PerDep.Name = "Cbo_PerDep";
            this.Cbo_PerDep.Size = new System.Drawing.Size(72, 21);
            this.Cbo_PerDep.TabIndex = 0;
            this.Cbo_PerDep.SelectedIndexChanged += new System.EventHandler(this.Cbo_PerDep_SelectedIndexChanged);
            // 
            // Btn_Calculo
            // 
            this.Btn_Calculo.Location = new System.Drawing.Point(766, 34);
            this.Btn_Calculo.Name = "Btn_Calculo";
            this.Btn_Calculo.Size = new System.Drawing.Size(75, 23);
            this.Btn_Calculo.TabIndex = 11;
            this.Btn_Calculo.Text = "Calcular";
            this.Btn_Calculo.UseVisualStyleBackColor = true;
            this.Btn_Calculo.Click += new System.EventHandler(this.Btn_Calculo_Click);
            // 
            // Gpb_NuevoActivo
            // 
            this.Gpb_NuevoActivo.Controls.Add(this.label11);
            this.Gpb_NuevoActivo.Controls.Add(this.textBox2);
            this.Gpb_NuevoActivo.Controls.Add(this.label8);
            this.Gpb_NuevoActivo.Controls.Add(this.textBox1);
            this.Gpb_NuevoActivo.Controls.Add(this.label7);
            this.Gpb_NuevoActivo.Controls.Add(this.Lbl_FechaActual);
            this.Gpb_NuevoActivo.Controls.Add(this.dateTimePicker1);
            this.Gpb_NuevoActivo.Controls.Add(this.label1);
            this.Gpb_NuevoActivo.Controls.Add(this.label2);
            this.Gpb_NuevoActivo.Controls.Add(this.lbl_TipoActivo);
            this.Gpb_NuevoActivo.Controls.Add(this.Cbo_TipoActivo);
            this.Gpb_NuevoActivo.Controls.Add(this.Lbl_FechAct);
            this.Gpb_NuevoActivo.Controls.Add(this.textBox3);
            this.Gpb_NuevoActivo.Location = new System.Drawing.Point(39, 65);
            this.Gpb_NuevoActivo.Name = "Gpb_NuevoActivo";
            this.Gpb_NuevoActivo.Size = new System.Drawing.Size(588, 236);
            this.Gpb_NuevoActivo.TabIndex = 9;
            this.Gpb_NuevoActivo.TabStop = false;
            this.Gpb_NuevoActivo.Text = "Nuevo Activo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(168, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Cantidad";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(171, 54);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(46, 20);
            this.textBox2.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(87, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 24);
            this.label8.TabIndex = 21;
            this.label8.Text = "-";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(110, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(50, 20);
            this.textBox1.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(127, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "No.";
            // 
            // Lbl_FechaActual
            // 
            this.Lbl_FechaActual.AutoSize = true;
            this.Lbl_FechaActual.Location = new System.Drawing.Point(96, 153);
            this.Lbl_FechaActual.Name = "Lbl_FechaActual";
            this.Lbl_FechaActual.Size = new System.Drawing.Size(70, 13);
            this.Lbl_FechaActual.TabIndex = 13;
            this.Lbl_FechaActual.Text = "Fecha Actual";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(28, 130);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Fecha de Adquisicion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(369, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Descripcion del Activo";
            // 
            // lbl_TipoActivo
            // 
            this.lbl_TipoActivo.AutoSize = true;
            this.lbl_TipoActivo.Location = new System.Drawing.Point(18, 39);
            this.lbl_TipoActivo.Name = "lbl_TipoActivo";
            this.lbl_TipoActivo.Size = new System.Drawing.Size(76, 13);
            this.lbl_TipoActivo.TabIndex = 5;
            this.lbl_TipoActivo.Text = "Tipo de Activo";
            // 
            // Cbo_TipoActivo
            // 
            this.Cbo_TipoActivo.FormattingEnabled = true;
            this.Cbo_TipoActivo.Items.AddRange(new object[] {
            "V",
            "E",
            "PC",
            "ME",
            "MA",
            "BNI",
            "MAYP",
            "DDLL"});
            this.Cbo_TipoActivo.Location = new System.Drawing.Point(30, 55);
            this.Cbo_TipoActivo.Name = "Cbo_TipoActivo";
            this.Cbo_TipoActivo.Size = new System.Drawing.Size(55, 21);
            this.Cbo_TipoActivo.TabIndex = 4;
            this.Cbo_TipoActivo.SelectedIndexChanged += new System.EventHandler(this.Cbo_TipoActivo_SelectedIndexChanged);
            // 
            // Lbl_FechAct
            // 
            this.Lbl_FechAct.AutoSize = true;
            this.Lbl_FechAct.Location = new System.Drawing.Point(46, 168);
            this.Lbl_FechAct.Name = "Lbl_FechAct";
            this.Lbl_FechAct.Size = new System.Drawing.Size(0, 13);
            this.Lbl_FechAct.TabIndex = 18;
            this.Lbl_FechAct.Click += new System.EventHandler(this.Lbl_FechAct_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(268, 55);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(300, 121);
            this.textBox3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(642, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Valor del activo Actual";
            // 
            // Txt_ValorActualActivo
            // 
            this.Txt_ValorActualActivo.Location = new System.Drawing.Point(659, 40);
            this.Txt_ValorActualActivo.Name = "Txt_ValorActualActivo";
            this.Txt_ValorActualActivo.Size = new System.Drawing.Size(74, 20);
            this.Txt_ValorActualActivo.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(492, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Valor Inicial de Adquisicion";
            // 
            // Txt_ValorInicialActivo
            // 
            this.Txt_ValorInicialActivo.Location = new System.Drawing.Point(516, 40);
            this.Txt_ValorInicialActivo.Name = "Txt_ValorInicialActivo";
            this.Txt_ValorInicialActivo.Size = new System.Drawing.Size(72, 20);
            this.Txt_ValorInicialActivo.TabIndex = 15;
            // 
            // Gpb_MetodoDepAmort
            // 
            this.Gpb_MetodoDepAmort.Controls.Add(this.Chk_AmortValorNetoContable);
            this.Gpb_MetodoDepAmort.Controls.Add(this.Chk_AmortDigitosDecrecientes);
            this.Gpb_MetodoDepAmort.Controls.Add(this.Chk_AmortLineal);
            this.Gpb_MetodoDepAmort.Controls.Add(this.Chk_DepSumDigAnual);
            this.Gpb_MetodoDepAmort.Controls.Add(this.Chk_DepLineaRecta);
            this.Gpb_MetodoDepAmort.Controls.Add(this.Btn_Calculo);
            this.Gpb_MetodoDepAmort.Controls.Add(this.Chk_DepUniProd);
            this.Gpb_MetodoDepAmort.Controls.Add(this.label4);
            this.Gpb_MetodoDepAmort.Controls.Add(this.Txt_ValorActualActivo);
            this.Gpb_MetodoDepAmort.Controls.Add(this.label3);
            this.Gpb_MetodoDepAmort.Controls.Add(this.Txt_ValorInicialActivo);
            this.Gpb_MetodoDepAmort.Location = new System.Drawing.Point(39, 307);
            this.Gpb_MetodoDepAmort.Name = "Gpb_MetodoDepAmort";
            this.Gpb_MetodoDepAmort.Size = new System.Drawing.Size(848, 81);
            this.Gpb_MetodoDepAmort.TabIndex = 24;
            this.Gpb_MetodoDepAmort.TabStop = false;
            this.Gpb_MetodoDepAmort.Text = "Metodo Dep/Amort";
            // 
            // Chk_AmortValorNetoContable
            // 
            this.Chk_AmortValorNetoContable.AutoSize = true;
            this.Chk_AmortValorNetoContable.Location = new System.Drawing.Point(226, 58);
            this.Chk_AmortValorNetoContable.Name = "Chk_AmortValorNetoContable";
            this.Chk_AmortValorNetoContable.Size = new System.Drawing.Size(274, 17);
            this.Chk_AmortValorNetoContable.TabIndex = 29;
            this.Chk_AmortValorNetoContable.Text = "Porcentaje Constante Sobre el valor neto Contable   ";
            this.Chk_AmortValorNetoContable.UseVisualStyleBackColor = true;
            // 
            // Chk_AmortDigitosDecrecientes
            // 
            this.Chk_AmortDigitosDecrecientes.AutoSize = true;
            this.Chk_AmortDigitosDecrecientes.Location = new System.Drawing.Point(226, 38);
            this.Chk_AmortDigitosDecrecientes.Name = "Chk_AmortDigitosDecrecientes";
            this.Chk_AmortDigitosDecrecientes.Size = new System.Drawing.Size(124, 17);
            this.Chk_AmortDigitosDecrecientes.TabIndex = 28;
            this.Chk_AmortDigitosDecrecientes.Text = "Digitos Decrecientes";
            this.Chk_AmortDigitosDecrecientes.UseVisualStyleBackColor = true;
            // 
            // Chk_AmortLineal
            // 
            this.Chk_AmortLineal.AutoSize = true;
            this.Chk_AmortLineal.Location = new System.Drawing.Point(226, 19);
            this.Chk_AmortLineal.Name = "Chk_AmortLineal";
            this.Chk_AmortLineal.Size = new System.Drawing.Size(54, 17);
            this.Chk_AmortLineal.TabIndex = 27;
            this.Chk_AmortLineal.Text = "Lineal";
            this.Chk_AmortLineal.UseVisualStyleBackColor = true;
            this.Chk_AmortLineal.CheckedChanged += new System.EventHandler(this.Chk_AmortLineal_CheckedChanged);
            // 
            // Chk_DepSumDigAnual
            // 
            this.Chk_DepSumDigAnual.AutoSize = true;
            this.Chk_DepSumDigAnual.Location = new System.Drawing.Point(21, 58);
            this.Chk_DepSumDigAnual.Name = "Chk_DepSumDigAnual";
            this.Chk_DepSumDigAnual.Size = new System.Drawing.Size(144, 17);
            this.Chk_DepSumDigAnual.TabIndex = 26;
            this.Chk_DepSumDigAnual.Text = "Suma de Digitos Anuales";
            this.Chk_DepSumDigAnual.UseVisualStyleBackColor = true;
            // 
            // Chk_DepLineaRecta
            // 
            this.Chk_DepLineaRecta.AutoSize = true;
            this.Chk_DepLineaRecta.Location = new System.Drawing.Point(21, 19);
            this.Chk_DepLineaRecta.Name = "Chk_DepLineaRecta";
            this.Chk_DepLineaRecta.Size = new System.Drawing.Size(84, 17);
            this.Chk_DepLineaRecta.TabIndex = 24;
            this.Chk_DepLineaRecta.Text = "Linea Recta";
            this.Chk_DepLineaRecta.UseVisualStyleBackColor = true;
            this.Chk_DepLineaRecta.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Chk_DepUniProd
            // 
            this.Chk_DepUniProd.AutoSize = true;
            this.Chk_DepUniProd.Location = new System.Drawing.Point(21, 38);
            this.Chk_DepUniProd.Name = "Chk_DepUniProd";
            this.Chk_DepUniProd.Size = new System.Drawing.Size(127, 17);
            this.Chk_DepUniProd.TabIndex = 25;
            this.Chk_DepUniProd.Text = "Unidades Producidas";
            this.Chk_DepUniProd.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.textBox5);
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(633, 178);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(254, 123);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Inventario y Persona Asignada";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(159, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Asignar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(13, 97);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(146, 20);
            this.textBox5.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(38, 48);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(37, 81);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Persona Encargada";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(48, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "No. Inventario";
            // 
            // Gpb_NevoDato
            // 
            this.Gpb_NevoDato.Controls.Add(this.Btn_Ingresar);
            this.Gpb_NevoDato.Controls.Add(this.Dgv_NuevoDato);
            this.Gpb_NevoDato.Location = new System.Drawing.Point(131, 394);
            this.Gpb_NevoDato.Name = "Gpb_NevoDato";
            this.Gpb_NevoDato.Size = new System.Drawing.Size(661, 294);
            this.Gpb_NevoDato.TabIndex = 27;
            this.Gpb_NevoDato.TabStop = false;
            this.Gpb_NevoDato.Text = "groupBox2";
            // 
            // Btn_Ingresar
            // 
            this.Btn_Ingresar.Location = new System.Drawing.Point(269, 256);
            this.Btn_Ingresar.Name = "Btn_Ingresar";
            this.Btn_Ingresar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Ingresar.TabIndex = 29;
            this.Btn_Ingresar.Text = "Ingresar";
            this.Btn_Ingresar.UseVisualStyleBackColor = true;
            // 
            // Dgv_NuevoDato
            // 
            this.Dgv_NuevoDato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_NuevoDato.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Activo,
            this.Valor_Inicial,
            this.Depreciacion_Amoritzacion,
            this.Porcentaje,
            this.Periodo,
            this.Total});
            this.Dgv_NuevoDato.Location = new System.Drawing.Point(6, 19);
            this.Dgv_NuevoDato.Name = "Dgv_NuevoDato";
            this.Dgv_NuevoDato.Size = new System.Drawing.Size(649, 231);
            this.Dgv_NuevoDato.TabIndex = 0;
            this.Dgv_NuevoDato.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Activo
            // 
            this.Activo.HeaderText = "Activo";
            this.Activo.Name = "Activo";
            // 
            // Valor_Inicial
            // 
            this.Valor_Inicial.HeaderText = "Valor Inicial";
            this.Valor_Inicial.Name = "Valor_Inicial";
            // 
            // Depreciacion_Amoritzacion
            // 
            this.Depreciacion_Amoritzacion.HeaderText = "Dep /Amort";
            this.Depreciacion_Amoritzacion.Name = "Depreciacion_Amoritzacion";
            // 
            // Porcentaje
            // 
            this.Porcentaje.HeaderText = "Porcentaje";
            this.Porcentaje.Name = "Porcentaje";
            // 
            // Periodo
            // 
            this.Periodo.HeaderText = "Periodo";
            this.Periodo.Name = "Periodo";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // Frm_ActivosFijos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 700);
            this.Controls.Add(this.Gpb_MetodoDepAmort);
            this.Controls.Add(this.Gpb_NevoDato);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Gpb_NuevoActivo);
            this.Controls.Add(this.Gpb_Periodo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_ActivosFijos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Frm_ActivosFijos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Gpb_Periodo.ResumeLayout(false);
            this.Gpb_Periodo.PerformLayout();
            this.Gpb_NuevoActivo.ResumeLayout(false);
            this.Gpb_NuevoActivo.PerformLayout();
            this.Gpb_MetodoDepAmort.ResumeLayout(false);
            this.Gpb_MetodoDepAmort.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.Gpb_NevoDato.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_NuevoDato)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox Gpb_Periodo;
        private System.Windows.Forms.GroupBox Gpb_NuevoActivo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_TipoActivo;
        private System.Windows.Forms.ComboBox Cbo_TipoActivo;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button Btn_Logo;
        private System.Windows.Forms.Label Lbl_Contabilidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_ValorInicialActivo;
        private System.Windows.Forms.Label Lbl_FechaActual;
        private System.Windows.Forms.TextBox Txt_ValorActualActivo;
        private System.Windows.Forms.Button Btn_Calculo;
        private System.Windows.Forms.Label Lbl_FechAct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Lbl_PorcentajeAmort;
        private System.Windows.Forms.Label Lbl_Porcentajedep;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Cbo_PerAmort;
        private System.Windows.Forms.ComboBox Cbo_PerDep;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox Gpb_NevoDato;
        private System.Windows.Forms.Button Btn_Ingresar;
        private System.Windows.Forms.DataGridView Dgv_NuevoDato;
        private System.Windows.Forms.Button Btn_Cerrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Activo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor_Inicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Depreciacion_Amoritzacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Porcentaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn Periodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.GroupBox Gpb_MetodoDepAmort;
        private System.Windows.Forms.CheckBox Chk_DepSumDigAnual;
        private System.Windows.Forms.CheckBox Chk_DepLineaRecta;
        private System.Windows.Forms.CheckBox Chk_DepUniProd;
        private System.Windows.Forms.CheckBox Chk_AmortValorNetoContable;
        private System.Windows.Forms.CheckBox Chk_AmortDigitosDecrecientes;
        private System.Windows.Forms.CheckBox Chk_AmortLineal;
    }
}