namespace Contabilidad
{
    partial class Frm_balanceProduccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_balanceProduccion));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Minimizar = new System.Windows.Forms.Button();
            this.Btn_Cerrar = new System.Windows.Forms.Button();
            this.lbl_balanceProduccion = new System.Windows.Forms.Label();
            this.Btn_Logo = new System.Windows.Forms.Button();
            this.navegador1 = new CapaDiseno.Navegador();
            this.dgv_estadoResultados = new System.Windows.Forms.DataGridView();
            this.dgv_balanceProduccion = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.txt_moneda = new System.Windows.Forms.TextBox();
            this.dtp_fechaActual = new System.Windows.Forms.DateTimePicker();
            this.txt_noBalance = new System.Windows.Forms.TextBox();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_moneda = new System.Windows.Forms.Label();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.lbl_noBalance = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.noBalanceprod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monedaprod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.no_cuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCuentaprod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoCuentaProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartoAbonoProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalprod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_estadoResultados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_balanceProduccion)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.Btn_Minimizar);
            this.panel1.Controls.Add(this.Btn_Cerrar);
            this.panel1.Controls.Add(this.lbl_balanceProduccion);
            this.panel1.Controls.Add(this.Btn_Logo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1245, 52);
            this.panel1.TabIndex = 0;
            // 
            // Btn_Minimizar
            // 
            this.Btn_Minimizar.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Minimizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(169)))), ((int)(((byte)(206)))));
            this.Btn_Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Minimizar.Image")));
            this.Btn_Minimizar.Location = new System.Drawing.Point(1129, 1);
            this.Btn_Minimizar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Minimizar.Name = "Btn_Minimizar";
            this.Btn_Minimizar.Size = new System.Drawing.Size(55, 50);
            this.Btn_Minimizar.TabIndex = 4;
            this.Btn_Minimizar.UseVisualStyleBackColor = false;
            this.Btn_Minimizar.Click += new System.EventHandler(this.Btn_Minimizar_Click);
            // 
            // Btn_Cerrar
            // 
            this.Btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(192)))), ((int)(((byte)(195)))));
            this.Btn_Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Cerrar.Image")));
            this.Btn_Cerrar.Location = new System.Drawing.Point(1172, 1);
            this.Btn_Cerrar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Size = new System.Drawing.Size(55, 50);
            this.Btn_Cerrar.TabIndex = 4;
            this.Btn_Cerrar.UseVisualStyleBackColor = false;
            this.Btn_Cerrar.Click += new System.EventHandler(this.Btn_Cerrar_Click);
            // 
            // lbl_balanceProduccion
            // 
            this.lbl_balanceProduccion.AutoSize = true;
            this.lbl_balanceProduccion.BackColor = System.Drawing.Color.Transparent;
            this.lbl_balanceProduccion.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_balanceProduccion.ForeColor = System.Drawing.Color.Black;
            this.lbl_balanceProduccion.Location = new System.Drawing.Point(54, 6);
            this.lbl_balanceProduccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_balanceProduccion.Name = "lbl_balanceProduccion";
            this.lbl_balanceProduccion.Size = new System.Drawing.Size(498, 40);
            this.lbl_balanceProduccion.TabIndex = 6;
            this.lbl_balanceProduccion.Text = "1510_Balance de Producción";
            // 
            // Btn_Logo
            // 
            this.Btn_Logo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Logo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(192)))), ((int)(((byte)(195)))));
            this.Btn_Logo.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Logo.Image")));
            this.Btn_Logo.Location = new System.Drawing.Point(0, 0);
            this.Btn_Logo.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Logo.Name = "Btn_Logo";
            this.Btn_Logo.Size = new System.Drawing.Size(55, 50);
            this.Btn_Logo.TabIndex = 10;
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
            this.navegador1.Location = new System.Drawing.Point(41, 71);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.navegador1.Name = "navegador1";
            this.navegador1.Procedimiento = null;
            this.navegador1.pubNombrechm = null;
            this.navegador1.pubNombreHtml = null;
            this.navegador1.Size = new System.Drawing.Size(1143, 74);
            this.navegador1.TabIndex = 1;
            // 
            // dgv_balanceProduccion
            // 
            this.dgv_balanceProduccion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_balanceProduccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_balanceProduccion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noBalanceprod,
            this.fecha,
            this.monedaprod,
            this.no_cuenta,
            this.nombreCuentaprod,
            this.tipoCuentaProd,
            this.montoProd,
            this.cartoAbonoProd,
            this.totalprod});
            this.dgv_balanceProduccion.Location = new System.Drawing.Point(51, 407);
            this.dgv_balanceProduccion.Name = "dgv_balanceProduccion";
            this.dgv_balanceProduccion.RowTemplate.Height = 24;
            this.dgv_balanceProduccion.Size = new System.Drawing.Size(1159, 281);
            this.dgv_balanceProduccion.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_total);
            this.groupBox3.Controls.Add(this.txt_moneda);
            this.groupBox3.Controls.Add(this.dtp_fechaActual);
            this.groupBox3.Controls.Add(this.txt_noBalance);
            this.groupBox3.Controls.Add(this.lbl_total);
            this.groupBox3.Controls.Add(this.lbl_moneda);
            this.groupBox3.Controls.Add(this.lbl_fecha);
            this.groupBox3.Controls.Add(this.lbl_noBalance);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(51, 165);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(466, 192);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Encabezado Balance Produccion";
            // 
            // txt_total
            // 
            this.txt_total.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total.Location = new System.Drawing.Point(318, 142);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(116, 26);
            this.txt_total.TabIndex = 19;
            // 
            // txt_moneda
            // 
            this.txt_moneda.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_moneda.Location = new System.Drawing.Point(98, 142);
            this.txt_moneda.Name = "txt_moneda";
            this.txt_moneda.Size = new System.Drawing.Size(116, 26);
            this.txt_moneda.TabIndex = 18;
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
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(260, 150);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(42, 18);
            this.lbl_total.TabIndex = 15;
            this.lbl_total.Text = "Total";
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
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(713, 165);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 226);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle Balance de Produccion";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1. Cargo",
            "2. Abono"});
            this.comboBox1.Location = new System.Drawing.Point(278, 163);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 22;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(365, 113);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 26);
            this.textBox1.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "Cargo / Abono";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(156, 113);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(116, 26);
            this.textBox2.TabIndex = 19;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(185, 66);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(296, 26);
            this.textBox3.TabIndex = 18;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(296, 25);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(116, 26);
            this.textBox4.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(284, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "Monto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tipo de cuenta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nombre de cuenta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(123, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Numero de Cuenta";
            // 
            // noBalanceprod
            // 
            this.noBalanceprod.HeaderText = "No. Balance";
            this.noBalanceprod.Name = "noBalanceprod";
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            // 
            // monedaprod
            // 
            this.monedaprod.HeaderText = "Moneda";
            this.monedaprod.Name = "monedaprod";
            // 
            // no_cuenta
            // 
            this.no_cuenta.HeaderText = "No. Cuenta";
            this.no_cuenta.Name = "no_cuenta";
            // 
            // nombreCuentaprod
            // 
            this.nombreCuentaprod.HeaderText = "Nombre de Cuenta";
            this.nombreCuentaprod.Name = "nombreCuentaprod";
            // 
            // tipoCuentaProd
            // 
            this.tipoCuentaProd.HeaderText = "Tipo de Cuenta";
            this.tipoCuentaProd.Name = "tipoCuentaProd";
            // 
            // montoProd
            // 
            this.montoProd.HeaderText = "Monto";
            this.montoProd.Name = "montoProd";
            // 
            // cartoAbonoProd
            // 
            this.cartoAbonoProd.HeaderText = "Cargo / Abono";
            this.cartoAbonoProd.Name = "cartoAbonoProd";
            // 
            // totalprod
            // 
            this.totalprod.HeaderText = "Total";
            this.totalprod.Name = "totalprod";
            // 
            // Frm_balanceProduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 700);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dgv_balanceProduccion);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_balanceProduccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_balanceProduccion";
            this.Load += new System.EventHandler(this.Frm_balanceProduccion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_estadoResultados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_balanceProduccion)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_Logo;
        private System.Windows.Forms.Label lbl_balanceProduccion;
        private System.Windows.Forms.Button Btn_Cerrar;
        private System.Windows.Forms.Button Btn_Minimizar;
        private CapaDiseno.Navegador navegador1;
        private System.Windows.Forms.DataGridView dgv_balanceProduccion;
        private System.Windows.Forms.DataGridView dgv_estadoResultados;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.TextBox txt_moneda;
        private System.Windows.Forms.DateTimePicker dtp_fechaActual;
        private System.Windows.Forms.TextBox txt_noBalance;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label lbl_moneda;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.Label lbl_noBalance;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn noBalanceprod;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn monedaprod;
        private System.Windows.Forms.DataGridViewTextBoxColumn no_cuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCuentaprod;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoCuentaProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn cartoAbonoProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalprod;
    }
}