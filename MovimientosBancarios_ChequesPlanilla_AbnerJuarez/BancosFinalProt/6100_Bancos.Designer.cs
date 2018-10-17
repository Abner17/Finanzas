namespace BancosFinalProt
{
    partial class _6100_Bancos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_6100_Bancos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_cerrar = new System.Windows.Forms.Button();
            this.Lbl_Modulo = new System.Windows.Forms.Label();
            this.Btn_Logo = new System.Windows.Forms.Button();
            this.navegador1 = new CapaDiseno.Navegador();
            this.Dgv_MovimientosBancarios = new System.Windows.Forms.DataGridView();
            this.fechaMovimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoConcepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreConcepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoMovimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lbl_CuentaBancaria = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Fecha = new System.Windows.Forms.TextBox();
            this.Cbo_CodigoConcepto = new System.Windows.Forms.ComboBox();
            this.Txt_NoCuenta = new System.Windows.Forms.TextBox();
            this.Txt_Banco = new System.Windows.Forms.TextBox();
            this.Txt_Saldo = new System.Windows.Forms.TextBox();
            this.txt_Concepto = new System.Windows.Forms.TextBox();
            this.Cbo_tipoMovimiento = new System.Windows.Forms.ComboBox();
            this.Cbo_AbonoCargo = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_MovimientosBancarios)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(192)))), ((int)(((byte)(195)))));
            this.panel1.Controls.Add(this.Btn_cerrar);
            this.panel1.Controls.Add(this.Lbl_Modulo);
            this.panel1.Controls.Add(this.Btn_Logo);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 42);
            this.panel1.TabIndex = 0;
            // 
            // Btn_cerrar
            // 
            this.Btn_cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.Btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.Btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_cerrar.Image")));
            this.Btn_cerrar.Location = new System.Drawing.Point(900, 3);
            this.Btn_cerrar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_cerrar.Name = "Btn_cerrar";
            this.Btn_cerrar.Size = new System.Drawing.Size(31, 33);
            this.Btn_cerrar.TabIndex = 12;
            this.Btn_cerrar.UseVisualStyleBackColor = false;
            this.Btn_cerrar.Click += new System.EventHandler(this.Btn_cerrar_Click);
            // 
            // Lbl_Modulo
            // 
            this.Lbl_Modulo.AutoSize = true;
            this.Lbl_Modulo.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Modulo.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Modulo.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Modulo.Location = new System.Drawing.Point(43, 12);
            this.Lbl_Modulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Modulo.Name = "Lbl_Modulo";
            this.Lbl_Modulo.Size = new System.Drawing.Size(277, 23);
            this.Lbl_Modulo.TabIndex = 11;
            this.Lbl_Modulo.Text = "6100_Movimientos Bancarios";
            // 
            // Btn_Logo
            // 
            this.Btn_Logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.Btn_Logo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Logo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.Btn_Logo.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Logo.Image")));
            this.Btn_Logo.Location = new System.Drawing.Point(8, 3);
            this.Btn_Logo.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Logo.Name = "Btn_Logo";
            this.Btn_Logo.Size = new System.Drawing.Size(31, 33);
            this.Btn_Logo.TabIndex = 10;
            this.Btn_Logo.UseVisualStyleBackColor = false;
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.navegador1.DataGr = null;
            this.navegador1.Forma = null;
            this.navegador1.Location = new System.Drawing.Point(36, 41);
            this.navegador1.Name = "navegador1";
            this.navegador1.Procedimiento = null;
            this.navegador1.pubNombrechm = null;
            this.navegador1.pubNombreHtml = null;
            this.navegador1.Size = new System.Drawing.Size(857, 60);
            this.navegador1.TabIndex = 1;
            // 
            // Dgv_MovimientosBancarios
            // 
            this.Dgv_MovimientosBancarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_MovimientosBancarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fechaMovimiento,
            this.CodigoConcepto,
            this.nombreConcepto,
            this.tipoMovimiento,
            this.abono,
            this.cargo});
            this.Dgv_MovimientosBancarios.Location = new System.Drawing.Point(39, 360);
            this.Dgv_MovimientosBancarios.Name = "Dgv_MovimientosBancarios";
            this.Dgv_MovimientosBancarios.Size = new System.Drawing.Size(857, 306);
            this.Dgv_MovimientosBancarios.TabIndex = 2;
            // 
            // fechaMovimiento
            // 
            this.fechaMovimiento.HeaderText = "FECHA";
            this.fechaMovimiento.Name = "fechaMovimiento";
            // 
            // CodigoConcepto
            // 
            this.CodigoConcepto.HeaderText = "CODIGO";
            this.CodigoConcepto.Name = "CodigoConcepto";
            this.CodigoConcepto.Width = 115;
            // 
            // nombreConcepto
            // 
            this.nombreConcepto.HeaderText = "CONCEPTO";
            this.nombreConcepto.Name = "nombreConcepto";
            this.nombreConcepto.Width = 150;
            // 
            // tipoMovimiento
            // 
            this.tipoMovimiento.HeaderText = "TIPO DE MOVIMIENTO";
            this.tipoMovimiento.Name = "tipoMovimiento";
            this.tipoMovimiento.Width = 150;
            // 
            // abono
            // 
            this.abono.HeaderText = "ABONO";
            this.abono.Name = "abono";
            this.abono.Width = 150;
            // 
            // cargo
            // 
            this.cargo.HeaderText = "CARGO";
            this.cargo.Name = "cargo";
            this.cargo.Width = 150;
            // 
            // Lbl_CuentaBancaria
            // 
            this.Lbl_CuentaBancaria.AutoSize = true;
            this.Lbl_CuentaBancaria.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CuentaBancaria.Location = new System.Drawing.Point(38, 174);
            this.Lbl_CuentaBancaria.Name = "Lbl_CuentaBancaria";
            this.Lbl_CuentaBancaria.Size = new System.Drawing.Size(149, 16);
            this.Lbl_CuentaBancaria.TabIndex = 3;
            this.Lbl_CuentaBancaria.Text = "No. Cuenta Bancaria:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(383, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Banco:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(672, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Saldo Actual:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fecha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(357, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Codigo Concepto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(693, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Concepto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(366, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tipo Movimiento:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(666, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Abono/Cargo:";
            // 
            // txt_Fecha
            // 
            this.txt_Fecha.Location = new System.Drawing.Point(95, 214);
            this.txt_Fecha.Name = "txt_Fecha";
            this.txt_Fecha.Size = new System.Drawing.Size(124, 20);
            this.txt_Fecha.TabIndex = 11;
            // 
            // Cbo_CodigoConcepto
            // 
            this.Cbo_CodigoConcepto.FormattingEnabled = true;
            this.Cbo_CodigoConcepto.Location = new System.Drawing.Point(490, 214);
            this.Cbo_CodigoConcepto.Name = "Cbo_CodigoConcepto";
            this.Cbo_CodigoConcepto.Size = new System.Drawing.Size(121, 21);
            this.Cbo_CodigoConcepto.TabIndex = 12;
            // 
            // Txt_NoCuenta
            // 
            this.Txt_NoCuenta.Location = new System.Drawing.Point(193, 174);
            this.Txt_NoCuenta.Name = "Txt_NoCuenta";
            this.Txt_NoCuenta.Size = new System.Drawing.Size(100, 20);
            this.Txt_NoCuenta.TabIndex = 13;
            // 
            // Txt_Banco
            // 
            this.Txt_Banco.Location = new System.Drawing.Point(442, 175);
            this.Txt_Banco.Name = "Txt_Banco";
            this.Txt_Banco.Size = new System.Drawing.Size(169, 20);
            this.Txt_Banco.TabIndex = 14;
            // 
            // Txt_Saldo
            // 
            this.Txt_Saldo.Location = new System.Drawing.Point(774, 174);
            this.Txt_Saldo.Name = "Txt_Saldo";
            this.Txt_Saldo.Size = new System.Drawing.Size(121, 20);
            this.Txt_Saldo.TabIndex = 15;
            // 
            // txt_Concepto
            // 
            this.txt_Concepto.Location = new System.Drawing.Point(774, 213);
            this.txt_Concepto.Name = "txt_Concepto";
            this.txt_Concepto.Size = new System.Drawing.Size(121, 20);
            this.txt_Concepto.TabIndex = 16;
            // 
            // Cbo_tipoMovimiento
            // 
            this.Cbo_tipoMovimiento.FormattingEnabled = true;
            this.Cbo_tipoMovimiento.Items.AddRange(new object[] {
            "DEPOSITO",
            "RETIRO"});
            this.Cbo_tipoMovimiento.Location = new System.Drawing.Point(490, 257);
            this.Cbo_tipoMovimiento.Name = "Cbo_tipoMovimiento";
            this.Cbo_tipoMovimiento.Size = new System.Drawing.Size(121, 21);
            this.Cbo_tipoMovimiento.TabIndex = 17;
            // 
            // Cbo_AbonoCargo
            // 
            this.Cbo_AbonoCargo.FormattingEnabled = true;
            this.Cbo_AbonoCargo.Items.AddRange(new object[] {
            "ABONO",
            "CARGO"});
            this.Cbo_AbonoCargo.Location = new System.Drawing.Point(774, 255);
            this.Cbo_AbonoCargo.Name = "Cbo_AbonoCargo";
            this.Cbo_AbonoCargo.Size = new System.Drawing.Size(121, 21);
            this.Cbo_AbonoCargo.TabIndex = 18;
            // 
            // _6100_Bancos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(933, 700);
            this.Controls.Add(this.Cbo_AbonoCargo);
            this.Controls.Add(this.Cbo_tipoMovimiento);
            this.Controls.Add(this.txt_Concepto);
            this.Controls.Add(this.Txt_Saldo);
            this.Controls.Add(this.Txt_Banco);
            this.Controls.Add(this.Txt_NoCuenta);
            this.Controls.Add(this.Cbo_CodigoConcepto);
            this.Controls.Add(this.txt_Fecha);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lbl_CuentaBancaria);
            this.Controls.Add(this.Dgv_MovimientosBancarios);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "_6100_Bancos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "_6100_Bancos";
            this.Load += new System.EventHandler(this._1700_Bancos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_MovimientosBancarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lbl_Modulo;
        private System.Windows.Forms.Button Btn_Logo;
        private CapaDiseno.Navegador navegador1;
        private System.Windows.Forms.DataGridView Dgv_MovimientosBancarios;
        private System.Windows.Forms.Label Lbl_CuentaBancaria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Fecha;
        private System.Windows.Forms.ComboBox Cbo_CodigoConcepto;
        private System.Windows.Forms.TextBox Txt_NoCuenta;
        private System.Windows.Forms.TextBox Txt_Banco;
        private System.Windows.Forms.TextBox Txt_Saldo;
        private System.Windows.Forms.TextBox txt_Concepto;
        private System.Windows.Forms.ComboBox Cbo_tipoMovimiento;
        private System.Windows.Forms.ComboBox Cbo_AbonoCargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaMovimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoConcepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreConcepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoMovimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn abono;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargo;
        private System.Windows.Forms.Button Btn_cerrar;
    }
}