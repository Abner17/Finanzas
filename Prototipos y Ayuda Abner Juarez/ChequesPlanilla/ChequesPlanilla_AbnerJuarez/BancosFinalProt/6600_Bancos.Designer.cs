namespace BancosFinalProt
{
    partial class _6600_Bancos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_6600_Bancos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_cerrar = new System.Windows.Forms.Button();
            this.Lbl_Modulo = new System.Windows.Forms.Label();
            this.Btn_Logo = new System.Windows.Forms.Button();
            this.Txt_concepto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Lbl_CuentaBancaria = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_noCheque = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_monto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Dgv_MovimientosBancarios = new System.Windows.Forms.DataGridView();
            this.fechaMovimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoConcepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreConcepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoMovimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Cmbo_Monto = new System.Windows.Forms.ComboBox();
            this.Cmbo_Beneficiario = new System.Windows.Forms.ComboBox();
            this.Cmbo_cuenta = new System.Windows.Forms.ComboBox();
            this.navegador1 = new CapaDiseno.Navegador();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_MovimientosBancarios)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(147)))), ((int)(((byte)(125)))));
            this.panel1.Controls.Add(this.Btn_cerrar);
            this.panel1.Controls.Add(this.Lbl_Modulo);
            this.panel1.Controls.Add(this.Btn_Logo);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 42);
            this.panel1.TabIndex = 1;
            // 
            // Btn_cerrar
            // 
            this.Btn_cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.Btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.Btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_cerrar.Image")));
            this.Btn_cerrar.Location = new System.Drawing.Point(892, 3);
            this.Btn_cerrar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_cerrar.Name = "Btn_cerrar";
            this.Btn_cerrar.Size = new System.Drawing.Size(31, 33);
            this.Btn_cerrar.TabIndex = 42;
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
            this.Lbl_Modulo.Size = new System.Drawing.Size(414, 23);
            this.Lbl_Modulo.TabIndex = 11;
            this.Lbl_Modulo.Text = "6600_Generacion de Cheques para Planilla";
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
            // Txt_concepto
            // 
            this.Txt_concepto.Location = new System.Drawing.Point(212, 400);
            this.Txt_concepto.Multiline = true;
            this.Txt_concepto.Name = "Txt_concepto";
            this.Txt_concepto.Size = new System.Drawing.Size(569, 44);
            this.Txt_concepto.TabIndex = 32;
            this.Txt_concepto.Tag = "7";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(131, 400);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Concepto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(154, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Fecha:";
            // 
            // Lbl_CuentaBancaria
            // 
            this.Lbl_CuentaBancaria.AutoSize = true;
            this.Lbl_CuentaBancaria.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CuentaBancaria.Location = new System.Drawing.Point(599, 257);
            this.Lbl_CuentaBancaria.Name = "Lbl_CuentaBancaria";
            this.Lbl_CuentaBancaria.Size = new System.Drawing.Size(149, 16);
            this.Lbl_CuentaBancaria.TabIndex = 19;
            this.Lbl_CuentaBancaria.Text = "No. Cuenta Bancaria:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(116, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 33;
            this.label4.Text = "Beneficiario:";
            // 
            // Txt_noCheque
            // 
            this.Txt_noCheque.Location = new System.Drawing.Point(212, 258);
            this.Txt_noCheque.Name = "Txt_noCheque";
            this.Txt_noCheque.Size = new System.Drawing.Size(121, 20);
            this.Txt_noCheque.TabIndex = 36;
            this.Txt_noCheque.Tag = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(116, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 16);
            this.label6.TabIndex = 35;
            this.label6.Text = "No. Cheque:";
            // 
            // Txt_monto
            // 
            this.Txt_monto.Location = new System.Drawing.Point(721, 304);
            this.Txt_monto.Name = "Txt_monto";
            this.Txt_monto.Size = new System.Drawing.Size(169, 20);
            this.Txt_monto.TabIndex = 39;
            this.Txt_monto.Tag = "6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(612, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 16);
            this.label7.TabIndex = 38;
            this.label7.Text = "monto:";
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "YYYY-MM-DD";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(212, 301);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker1.TabIndex = 42;
            this.dateTimePicker1.Tag = "3";
            // 
            // Cmbo_Monto
            // 
            this.Cmbo_Monto.FormattingEnabled = true;
            this.Cmbo_Monto.Location = new System.Drawing.Point(670, 304);
            this.Cmbo_Monto.Name = "Cmbo_Monto";
            this.Cmbo_Monto.Size = new System.Drawing.Size(45, 21);
            this.Cmbo_Monto.TabIndex = 43;
            this.Cmbo_Monto.Tag = "4";
            // 
            // Cmbo_Beneficiario
            // 
            this.Cmbo_Beneficiario.FormattingEnabled = true;
            this.Cmbo_Beneficiario.Location = new System.Drawing.Point(212, 367);
            this.Cmbo_Beneficiario.Name = "Cmbo_Beneficiario";
            this.Cmbo_Beneficiario.Size = new System.Drawing.Size(569, 21);
            this.Cmbo_Beneficiario.TabIndex = 44;
            this.Cmbo_Beneficiario.Tag = "5";
            // 
            // Cmbo_cuenta
            // 
            this.Cmbo_cuenta.FormattingEnabled = true;
            this.Cmbo_cuenta.Location = new System.Drawing.Point(754, 257);
            this.Cmbo_cuenta.Name = "Cmbo_cuenta";
            this.Cmbo_cuenta.Size = new System.Drawing.Size(136, 21);
            this.Cmbo_cuenta.TabIndex = 45;
            this.Cmbo_cuenta.Tag = "2";
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.navegador1.Forma = this;
            this.navegador1.Location = new System.Drawing.Point(33, 90);
            this.navegador1.Name = "navegador1";
            this.navegador1.Procedimiento = null;
            this.navegador1.pubNombrechm = null;
            this.navegador1.pubNombreHtml = null;
            this.navegador1.Size = new System.Drawing.Size(857, 60);
            this.navegador1.TabIndex = 41;
            // 
            // _6600_Bancos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 700);
            this.Controls.Add(this.Cmbo_cuenta);
            this.Controls.Add(this.Cmbo_Beneficiario);
            this.Controls.Add(this.Cmbo_Monto);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.Txt_monto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Txt_noCheque);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Txt_concepto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Lbl_CuentaBancaria);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "_6600_Bancos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "6600_Bancos";
            this.Load += new System.EventHandler(this.Frm_GeneracionChequesPlanilla_Load);
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
        private System.Windows.Forms.TextBox Txt_concepto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Lbl_CuentaBancaria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_noCheque;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txt_monto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Btn_cerrar;
        private System.Windows.Forms.DataGridView Dgv_MovimientosBancarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaMovimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoConcepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreConcepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoMovimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn abono;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox Cmbo_Monto;
        private System.Windows.Forms.ComboBox Cmbo_Beneficiario;
        private System.Windows.Forms.ComboBox Cmbo_cuenta;
        private CapaDiseno.Navegador navegador1;
    }
}