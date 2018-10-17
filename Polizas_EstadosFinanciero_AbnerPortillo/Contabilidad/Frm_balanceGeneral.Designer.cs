namespace Contabilidad
{
    partial class Frm_balanceGeneral
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_balanceGeneral));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Minimizar = new System.Windows.Forms.Button();
            this.lbl_balanceGeneral = new System.Windows.Forms.Label();
            this.Btn_Cerrar = new System.Windows.Forms.Button();
            this.Btn_Logo = new System.Windows.Forms.Button();
            this.navegador1 = new CapaDiseno.Navegador();
            this.dgv_estadoResultados = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dtp_fechaActual = new System.Windows.Forms.DateTimePicker();
            this.txt_noBalance = new System.Windows.Forms.TextBox();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.lbl_moneda = new System.Windows.Forms.Label();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.lbl_noBalance = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_tipoCuenta = new System.Windows.Forms.TextBox();
            this.txt_nombreCuenta = new System.Windows.Forms.TextBox();
            this.txt_numeroCuenta = new System.Windows.Forms.TextBox();
            this.lbl_monto = new System.Windows.Forms.Label();
            this.lbl_tipoCuenta = new System.Windows.Forms.Label();
            this.lbl_nombreCuenta = new System.Windows.Forms.Label();
            this.lbl_numeroCuenta = new System.Windows.Forms.Label();
            this.lbl_cargoAbono = new System.Windows.Forms.Label();
            this.txt_monto = new System.Windows.Forms.TextBox();
            this.cbo_cargoAbono = new System.Windows.Forms.ComboBox();
            this.no_balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_actual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargoAbono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_estadoResultados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.Btn_Minimizar);
            this.panel1.Controls.Add(this.lbl_balanceGeneral);
            this.panel1.Controls.Add(this.Btn_Cerrar);
            this.panel1.Controls.Add(this.Btn_Logo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1232, 52);
            this.panel1.TabIndex = 0;
            // 
            // Btn_Minimizar
            // 
            this.Btn_Minimizar.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Minimizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(169)))), ((int)(((byte)(206)))));
            this.Btn_Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Minimizar.Image")));
            this.Btn_Minimizar.Location = new System.Drawing.Point(1134, 3);
            this.Btn_Minimizar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Minimizar.Name = "Btn_Minimizar";
            this.Btn_Minimizar.Size = new System.Drawing.Size(55, 50);
            this.Btn_Minimizar.TabIndex = 11;
            this.Btn_Minimizar.UseVisualStyleBackColor = false;
            this.Btn_Minimizar.Click += new System.EventHandler(this.Btn_Minimizar_Click);
            // 
            // lbl_balanceGeneral
            // 
            this.lbl_balanceGeneral.AutoSize = true;
            this.lbl_balanceGeneral.BackColor = System.Drawing.Color.Transparent;
            this.lbl_balanceGeneral.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_balanceGeneral.ForeColor = System.Drawing.Color.Black;
            this.lbl_balanceGeneral.Location = new System.Drawing.Point(59, 8);
            this.lbl_balanceGeneral.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_balanceGeneral.Name = "lbl_balanceGeneral";
            this.lbl_balanceGeneral.Size = new System.Drawing.Size(390, 40);
            this.lbl_balanceGeneral.TabIndex = 13;
            this.lbl_balanceGeneral.Text = "1530_Balance General";
            // 
            // Btn_Cerrar
            // 
            this.Btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(192)))), ((int)(((byte)(195)))));
            this.Btn_Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Cerrar.Image")));
            this.Btn_Cerrar.Location = new System.Drawing.Point(1177, 3);
            this.Btn_Cerrar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Size = new System.Drawing.Size(55, 50);
            this.Btn_Cerrar.TabIndex = 12;
            this.Btn_Cerrar.UseVisualStyleBackColor = false;
            this.Btn_Cerrar.Click += new System.EventHandler(this.Btn_Cerrar_Click);
            // 
            // Btn_Logo
            // 
            this.Btn_Logo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Logo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(192)))), ((int)(((byte)(195)))));
            this.Btn_Logo.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Logo.Image")));
            this.Btn_Logo.Location = new System.Drawing.Point(5, 2);
            this.Btn_Logo.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Logo.Name = "Btn_Logo";
            this.Btn_Logo.Size = new System.Drawing.Size(55, 50);
            this.Btn_Logo.TabIndex = 14;
            this.Btn_Logo.UseVisualStyleBackColor = false;
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            // 
            // dgv_estadoResultados
            // 
            this.dgv_estadoResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_estadoResultados.Location = new System.Drawing.Point(45, 179);
            this.dgv_estadoResultados.Name = "dgv_estadoResultados";
            this.dgv_estadoResultados.RowTemplate.Height = 24;
            this.dgv_estadoResultados.Size = new System.Drawing.Size(642, 490);
            this.dgv_estadoResultados.TabIndex = 2;
            this.navegador1.DataGr = this.dgv_estadoResultados;
            this.navegador1.Forma = this;
            this.navegador1.Location = new System.Drawing.Point(46, 68);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.navegador1.Name = "navegador1";
            this.navegador1.Procedimiento = null;
            this.navegador1.pubNombrechm = null;
            this.navegador1.pubNombreHtml = null;
            this.navegador1.Size = new System.Drawing.Size(1143, 74);
            this.navegador1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.no_balance,
            this.fecha_actual,
            this.noCuenta,
            this.nombreCuenta,
            this.tipoCuenta,
            this.Monto,
            this.cargoAbono,
            this.moneda,
            this.total_balance});
            this.dataGridView1.Location = new System.Drawing.Point(46, 407);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1159, 281);
            this.dataGridView1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(318, 142);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(116, 26);
            this.textBox2.TabIndex = 19;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(98, 142);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 26);
            this.textBox1.TabIndex = 18;
            // 
            // dtp_fechaActual
            // 
            this.dtp_fechaActual.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fechaActual.Location = new System.Drawing.Point(194, 85);
            this.dtp_fechaActual.Name = "dtp_fechaActual";
            this.dtp_fechaActual.Size = new System.Drawing.Size(240, 26);
            this.dtp_fechaActual.TabIndex = 17;
            // 
            // txt_noBalance
            // 
            this.txt_noBalance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_noBalance.Location = new System.Drawing.Point(278, 34);
            this.txt_noBalance.Name = "txt_noBalance";
            this.txt_noBalance.Size = new System.Drawing.Size(116, 26);
            this.txt_noBalance.TabIndex = 16;
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total.Location = new System.Drawing.Point(260, 150);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(42, 18);
            this.lbl_Total.TabIndex = 15;
            this.lbl_Total.Text = "Total";
            // 
            // lbl_moneda
            // 
            this.lbl_moneda.AutoSize = true;
            this.lbl_moneda.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_moneda.Location = new System.Drawing.Point(11, 150);
            this.lbl_moneda.Name = "lbl_moneda";
            this.lbl_moneda.Size = new System.Drawing.Size(71, 18);
            this.lbl_moneda.TabIndex = 14;
            this.lbl_moneda.Text = "Moneda";
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha.Location = new System.Drawing.Point(70, 93);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(110, 18);
            this.lbl_fecha.TabIndex = 13;
            this.lbl_fecha.Text = "Fecha Actual:";
            // 
            // lbl_noBalance
            // 
            this.lbl_noBalance.AutoSize = true;
            this.lbl_noBalance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_noBalance.Location = new System.Drawing.Point(104, 42);
            this.lbl_noBalance.Name = "lbl_noBalance";
            this.lbl_noBalance.Size = new System.Drawing.Size(157, 18);
            this.lbl_noBalance.TabIndex = 12;
            this.lbl_noBalance.Text = "Numero de Balance";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.dtp_fechaActual);
            this.groupBox1.Controls.Add(this.txt_noBalance);
            this.groupBox1.Controls.Add(this.lbl_Total);
            this.groupBox1.Controls.Add(this.lbl_moneda);
            this.groupBox1.Controls.Add(this.lbl_fecha);
            this.groupBox1.Controls.Add(this.lbl_noBalance);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(46, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 192);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Encabezado Balance General";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbo_cargoAbono);
            this.groupBox2.Controls.Add(this.txt_monto);
            this.groupBox2.Controls.Add(this.lbl_cargoAbono);
            this.groupBox2.Controls.Add(this.txt_tipoCuenta);
            this.groupBox2.Controls.Add(this.txt_nombreCuenta);
            this.groupBox2.Controls.Add(this.txt_numeroCuenta);
            this.groupBox2.Controls.Add(this.lbl_monto);
            this.groupBox2.Controls.Add(this.lbl_tipoCuenta);
            this.groupBox2.Controls.Add(this.lbl_nombreCuenta);
            this.groupBox2.Controls.Add(this.lbl_numeroCuenta);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(708, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(497, 226);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle Balance General";
            // 
            // txt_tipoCuenta
            // 
            this.txt_tipoCuenta.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tipoCuenta.Location = new System.Drawing.Point(156, 113);
            this.txt_tipoCuenta.Name = "txt_tipoCuenta";
            this.txt_tipoCuenta.Size = new System.Drawing.Size(116, 26);
            this.txt_tipoCuenta.TabIndex = 19;
            // 
            // txt_nombreCuenta
            // 
            this.txt_nombreCuenta.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombreCuenta.Location = new System.Drawing.Point(185, 66);
            this.txt_nombreCuenta.Name = "txt_nombreCuenta";
            this.txt_nombreCuenta.Size = new System.Drawing.Size(296, 26);
            this.txt_nombreCuenta.TabIndex = 18;
            // 
            // txt_numeroCuenta
            // 
            this.txt_numeroCuenta.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numeroCuenta.Location = new System.Drawing.Point(296, 25);
            this.txt_numeroCuenta.Name = "txt_numeroCuenta";
            this.txt_numeroCuenta.Size = new System.Drawing.Size(116, 26);
            this.txt_numeroCuenta.TabIndex = 16;
            // 
            // lbl_monto
            // 
            this.lbl_monto.AutoSize = true;
            this.lbl_monto.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_monto.Location = new System.Drawing.Point(284, 121);
            this.lbl_monto.Name = "lbl_monto";
            this.lbl_monto.Size = new System.Drawing.Size(55, 18);
            this.lbl_monto.TabIndex = 15;
            this.lbl_monto.Text = "Monto";
            // 
            // lbl_tipoCuenta
            // 
            this.lbl_tipoCuenta.AutoSize = true;
            this.lbl_tipoCuenta.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipoCuenta.Location = new System.Drawing.Point(12, 121);
            this.lbl_tipoCuenta.Name = "lbl_tipoCuenta";
            this.lbl_tipoCuenta.Size = new System.Drawing.Size(118, 18);
            this.lbl_tipoCuenta.TabIndex = 14;
            this.lbl_tipoCuenta.Text = "Tipo de cuenta";
            this.lbl_tipoCuenta.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_nombreCuenta
            // 
            this.lbl_nombreCuenta.AutoSize = true;
            this.lbl_nombreCuenta.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombreCuenta.Location = new System.Drawing.Point(12, 74);
            this.lbl_nombreCuenta.Name = "lbl_nombreCuenta";
            this.lbl_nombreCuenta.Size = new System.Drawing.Size(148, 18);
            this.lbl_nombreCuenta.TabIndex = 13;
            this.lbl_nombreCuenta.Text = "Nombre de cuenta";
            this.lbl_nombreCuenta.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbl_numeroCuenta
            // 
            this.lbl_numeroCuenta.AutoSize = true;
            this.lbl_numeroCuenta.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numeroCuenta.Location = new System.Drawing.Point(123, 33);
            this.lbl_numeroCuenta.Name = "lbl_numeroCuenta";
            this.lbl_numeroCuenta.Size = new System.Drawing.Size(149, 18);
            this.lbl_numeroCuenta.TabIndex = 12;
            this.lbl_numeroCuenta.Text = "Numero de Cuenta";
            // 
            // lbl_cargoAbono
            // 
            this.lbl_cargoAbono.AutoSize = true;
            this.lbl_cargoAbono.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cargoAbono.Location = new System.Drawing.Point(141, 169);
            this.lbl_cargoAbono.Name = "lbl_cargoAbono";
            this.lbl_cargoAbono.Size = new System.Drawing.Size(120, 18);
            this.lbl_cargoAbono.TabIndex = 20;
            this.lbl_cargoAbono.Text = "Cargo / Abono";
            // 
            // txt_monto
            // 
            this.txt_monto.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_monto.Location = new System.Drawing.Point(365, 113);
            this.txt_monto.Name = "txt_monto";
            this.txt_monto.Size = new System.Drawing.Size(116, 26);
            this.txt_monto.TabIndex = 21;
            // 
            // cbo_cargoAbono
            // 
            this.cbo_cargoAbono.FormattingEnabled = true;
            this.cbo_cargoAbono.Items.AddRange(new object[] {
            "1. Cargo",
            "2. Abono"});
            this.cbo_cargoAbono.Location = new System.Drawing.Point(278, 163);
            this.cbo_cargoAbono.Name = "cbo_cargoAbono";
            this.cbo_cargoAbono.Size = new System.Drawing.Size(121, 24);
            this.cbo_cargoAbono.TabIndex = 22;
            this.cbo_cargoAbono.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // no_balance
            // 
            this.no_balance.HeaderText = "No. Balance";
            this.no_balance.Name = "no_balance";
            // 
            // fecha_actual
            // 
            this.fecha_actual.HeaderText = "Fecha";
            this.fecha_actual.Name = "fecha_actual";
            // 
            // noCuenta
            // 
            this.noCuenta.HeaderText = "No. Cuenta";
            this.noCuenta.Name = "noCuenta";
            // 
            // nombreCuenta
            // 
            this.nombreCuenta.HeaderText = "Nombre Cuenta";
            this.nombreCuenta.Name = "nombreCuenta";
            // 
            // tipoCuenta
            // 
            this.tipoCuenta.HeaderText = "Tipo Cuenta";
            this.tipoCuenta.Name = "tipoCuenta";
            // 
            // Monto
            // 
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            // 
            // cargoAbono
            // 
            this.cargoAbono.HeaderText = "Cargo / Abono";
            this.cargoAbono.Name = "cargoAbono";
            // 
            // moneda
            // 
            this.moneda.HeaderText = "Monea de uso";
            this.moneda.Name = "moneda";
            // 
            // total_balance
            // 
            this.total_balance.HeaderText = "Total";
            this.total_balance.Name = "total_balance";
            // 
            // Frm_balanceGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 700);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_balanceGeneral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_balanceGeneral";
            this.Load += new System.EventHandler(this.Frm_balanceGeneral_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_estadoResultados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_Minimizar;
        private System.Windows.Forms.Button Btn_Cerrar;
        private System.Windows.Forms.Label lbl_balanceGeneral;
        private System.Windows.Forms.Button Btn_Logo;
        private CapaDiseno.Navegador navegador1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dtp_fechaActual;
        private System.Windows.Forms.TextBox txt_noBalance;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.Label lbl_moneda;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.Label lbl_noBalance;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_estadoResultados;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_tipoCuenta;
        private System.Windows.Forms.TextBox txt_nombreCuenta;
        private System.Windows.Forms.TextBox txt_numeroCuenta;
        private System.Windows.Forms.Label lbl_monto;
        private System.Windows.Forms.Label lbl_tipoCuenta;
        private System.Windows.Forms.Label lbl_nombreCuenta;
        private System.Windows.Forms.Label lbl_numeroCuenta;
        private System.Windows.Forms.Label lbl_cargoAbono;
        private System.Windows.Forms.ComboBox cbo_cargoAbono;
        private System.Windows.Forms.TextBox txt_monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn no_balance;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_actual;
        private System.Windows.Forms.DataGridViewTextBoxColumn noCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargoAbono;
        private System.Windows.Forms.DataGridViewTextBoxColumn moneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_balance;
    }
}