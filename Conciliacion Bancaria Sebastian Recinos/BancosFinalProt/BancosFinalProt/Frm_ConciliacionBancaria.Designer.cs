namespace BancosFinalProt
{
    partial class Frm_ConciliacionBancaria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ConciliacionBancaria));
            this.Pnl_BarraDeEstado = new System.Windows.Forms.Panel();
            this.Btn_Cerrar = new System.Windows.Forms.Button();
            this.Lbl_ConciliacionBancaria = new System.Windows.Forms.Label();
            this.Pic_Logo = new System.Windows.Forms.Button();
            this.Gpb_Seleccion = new System.Windows.Forms.GroupBox();
            this.Gpb_InformacionConciliacion = new System.Windows.Forms.GroupBox();
            this.Txt_Fecha = new System.Windows.Forms.TextBox();
            this.Txt_NumeroConciliacion = new System.Windows.Forms.TextBox();
            this.Lbl_Fecha = new System.Windows.Forms.Label();
            this.Lbl_NumeroConciliacion = new System.Windows.Forms.Label();
            this.Btn_GenerarConciliacion = new System.Windows.Forms.Button();
            this.Cbo_Mes = new System.Windows.Forms.ComboBox();
            this.Lbl_Mes = new System.Windows.Forms.Label();
            this.Lbl_Año = new System.Windows.Forms.Label();
            this.Cbo_Año = new System.Windows.Forms.ComboBox();
            this.Lbl_EstadodeCuenta = new System.Windows.Forms.Label();
            this.Lbl_CierreContable = new System.Windows.Forms.Label();
            this.Dgv_CierreContable = new System.Windows.Forms.DataGridView();
            this.Chequeo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.No_Movimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Concepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Abono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lbl_Movimientos = new System.Windows.Forms.Label();
            this.Lbl_NumeroMovimientos = new System.Windows.Forms.Label();
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.Pnl_BarraDeEstado.SuspendLayout();
            this.Gpb_Seleccion.SuspendLayout();
            this.Gpb_InformacionConciliacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_CierreContable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_BarraDeEstado
            // 
            this.Pnl_BarraDeEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(147)))), ((int)(((byte)(125)))));
            this.Pnl_BarraDeEstado.Controls.Add(this.Btn_Cerrar);
            this.Pnl_BarraDeEstado.Controls.Add(this.Lbl_ConciliacionBancaria);
            this.Pnl_BarraDeEstado.Controls.Add(this.Pic_Logo);
            this.Pnl_BarraDeEstado.Location = new System.Drawing.Point(0, 0);
            this.Pnl_BarraDeEstado.Name = "Pnl_BarraDeEstado";
            this.Pnl_BarraDeEstado.Size = new System.Drawing.Size(933, 42);
            this.Pnl_BarraDeEstado.TabIndex = 0;
            // 
            // Btn_Cerrar
            // 
            this.Btn_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(147)))), ((int)(((byte)(125)))));
            this.Btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(147)))), ((int)(((byte)(125)))));
            this.Btn_Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Cerrar.Image")));
            this.Btn_Cerrar.Location = new System.Drawing.Point(886, 1);
            this.Btn_Cerrar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Size = new System.Drawing.Size(45, 39);
            this.Btn_Cerrar.TabIndex = 13;
            this.Btn_Cerrar.UseVisualStyleBackColor = false;
            this.Btn_Cerrar.Click += new System.EventHandler(this.Btn_cerrar_Click);
            // 
            // Lbl_ConciliacionBancaria
            // 
            this.Lbl_ConciliacionBancaria.AutoSize = true;
            this.Lbl_ConciliacionBancaria.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ConciliacionBancaria.Location = new System.Drawing.Point(52, 5);
            this.Lbl_ConciliacionBancaria.Name = "Lbl_ConciliacionBancaria";
            this.Lbl_ConciliacionBancaria.Size = new System.Drawing.Size(378, 32);
            this.Lbl_ConciliacionBancaria.TabIndex = 12;
            this.Lbl_ConciliacionBancaria.Text = "6200_Conciliacion Bancaria";
            // 
            // Pic_Logo
            // 
            this.Pic_Logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(147)))), ((int)(((byte)(125)))));
            this.Pic_Logo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pic_Logo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(147)))), ((int)(((byte)(125)))));
            this.Pic_Logo.Image = ((System.Drawing.Image)(resources.GetObject("Pic_Logo.Image")));
            this.Pic_Logo.Location = new System.Drawing.Point(3, 4);
            this.Pic_Logo.Margin = new System.Windows.Forms.Padding(2);
            this.Pic_Logo.Name = "Pic_Logo";
            this.Pic_Logo.Size = new System.Drawing.Size(38, 33);
            this.Pic_Logo.TabIndex = 11;
            this.Pic_Logo.UseVisualStyleBackColor = false;
            // 
            // Gpb_Seleccion
            // 
            this.Gpb_Seleccion.Controls.Add(this.Gpb_InformacionConciliacion);
            this.Gpb_Seleccion.Controls.Add(this.Btn_GenerarConciliacion);
            this.Gpb_Seleccion.Controls.Add(this.Cbo_Mes);
            this.Gpb_Seleccion.Controls.Add(this.Lbl_Mes);
            this.Gpb_Seleccion.Controls.Add(this.Lbl_Año);
            this.Gpb_Seleccion.Controls.Add(this.Cbo_Año);
            this.Gpb_Seleccion.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_Seleccion.Location = new System.Drawing.Point(3, 58);
            this.Gpb_Seleccion.Name = "Gpb_Seleccion";
            this.Gpb_Seleccion.Size = new System.Drawing.Size(928, 132);
            this.Gpb_Seleccion.TabIndex = 9;
            this.Gpb_Seleccion.TabStop = false;
            this.Gpb_Seleccion.Text = "Seleccion ";
            // 
            // Gpb_InformacionConciliacion
            // 
            this.Gpb_InformacionConciliacion.Controls.Add(this.Txt_Fecha);
            this.Gpb_InformacionConciliacion.Controls.Add(this.Txt_NumeroConciliacion);
            this.Gpb_InformacionConciliacion.Controls.Add(this.Lbl_Fecha);
            this.Gpb_InformacionConciliacion.Controls.Add(this.Lbl_NumeroConciliacion);
            this.Gpb_InformacionConciliacion.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_InformacionConciliacion.Location = new System.Drawing.Point(313, 9);
            this.Gpb_InformacionConciliacion.Name = "Gpb_InformacionConciliacion";
            this.Gpb_InformacionConciliacion.Size = new System.Drawing.Size(590, 117);
            this.Gpb_InformacionConciliacion.TabIndex = 7;
            this.Gpb_InformacionConciliacion.TabStop = false;
            this.Gpb_InformacionConciliacion.Text = "Informacion de la Conciliacion";
            // 
            // Txt_Fecha
            // 
            this.Txt_Fecha.Enabled = false;
            this.Txt_Fecha.Location = new System.Drawing.Point(240, 60);
            this.Txt_Fecha.Name = "Txt_Fecha";
            this.Txt_Fecha.ReadOnly = true;
            this.Txt_Fecha.Size = new System.Drawing.Size(74, 21);
            this.Txt_Fecha.TabIndex = 5;
            // 
            // Txt_NumeroConciliacion
            // 
            this.Txt_NumeroConciliacion.Enabled = false;
            this.Txt_NumeroConciliacion.Location = new System.Drawing.Point(76, 60);
            this.Txt_NumeroConciliacion.Name = "Txt_NumeroConciliacion";
            this.Txt_NumeroConciliacion.ReadOnly = true;
            this.Txt_NumeroConciliacion.Size = new System.Drawing.Size(29, 21);
            this.Txt_NumeroConciliacion.TabIndex = 1;
            this.Txt_NumeroConciliacion.TextChanged += new System.EventHandler(this.Txt_NumeroConciliacion_TextChanged);
            this.Txt_NumeroConciliacion.DoubleClick += new System.EventHandler(this.Txt_NumeroConciliacion_TextChanged);
            // 
            // Lbl_Fecha
            // 
            this.Lbl_Fecha.AutoSize = true;
            this.Lbl_Fecha.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Fecha.Location = new System.Drawing.Point(210, 41);
            this.Lbl_Fecha.Name = "Lbl_Fecha";
            this.Lbl_Fecha.Size = new System.Drawing.Size(142, 16);
            this.Lbl_Fecha.TabIndex = 4;
            this.Lbl_Fecha.Text = "Fecha de Conciliacion";
            // 
            // Lbl_NumeroConciliacion
            // 
            this.Lbl_NumeroConciliacion.AutoSize = true;
            this.Lbl_NumeroConciliacion.Location = new System.Drawing.Point(44, 43);
            this.Lbl_NumeroConciliacion.Name = "Lbl_NumeroConciliacion";
            this.Lbl_NumeroConciliacion.Size = new System.Drawing.Size(98, 15);
            this.Lbl_NumeroConciliacion.TabIndex = 0;
            this.Lbl_NumeroConciliacion.Text = "No. Conciliacion";
            // 
            // Btn_GenerarConciliacion
            // 
            this.Btn_GenerarConciliacion.Enabled = false;
            this.Btn_GenerarConciliacion.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_GenerarConciliacion.Location = new System.Drawing.Point(193, 37);
            this.Btn_GenerarConciliacion.Name = "Btn_GenerarConciliacion";
            this.Btn_GenerarConciliacion.Size = new System.Drawing.Size(102, 42);
            this.Btn_GenerarConciliacion.TabIndex = 6;
            this.Btn_GenerarConciliacion.Text = "Generar Conciliacion";
            this.Btn_GenerarConciliacion.UseVisualStyleBackColor = true;
            this.Btn_GenerarConciliacion.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cbo_Mes
            // 
            this.Cbo_Mes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_Mes.Enabled = false;
            this.Cbo_Mes.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_Mes.FormattingEnabled = true;
            this.Cbo_Mes.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.Cbo_Mes.Location = new System.Drawing.Point(100, 48);
            this.Cbo_Mes.Name = "Cbo_Mes";
            this.Cbo_Mes.Size = new System.Drawing.Size(77, 23);
            this.Cbo_Mes.TabIndex = 3;
            this.Cbo_Mes.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // Lbl_Mes
            // 
            this.Lbl_Mes.AutoSize = true;
            this.Lbl_Mes.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Mes.Location = new System.Drawing.Point(97, 29);
            this.Lbl_Mes.Name = "Lbl_Mes";
            this.Lbl_Mes.Size = new System.Drawing.Size(32, 16);
            this.Lbl_Mes.TabIndex = 2;
            this.Lbl_Mes.Text = "Mes";
            // 
            // Lbl_Año
            // 
            this.Lbl_Año.AutoSize = true;
            this.Lbl_Año.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Año.Location = new System.Drawing.Point(10, 29);
            this.Lbl_Año.Name = "Lbl_Año";
            this.Lbl_Año.Size = new System.Drawing.Size(32, 16);
            this.Lbl_Año.TabIndex = 1;
            this.Lbl_Año.Text = "Año";
            // 
            // Cbo_Año
            // 
            this.Cbo_Año.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_Año.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_Año.FormattingEnabled = true;
            this.Cbo_Año.Items.AddRange(new object[] {
            "2018",
            "2017",
            "2016",
            "2015"});
            this.Cbo_Año.Location = new System.Drawing.Point(13, 48);
            this.Cbo_Año.Name = "Cbo_Año";
            this.Cbo_Año.Size = new System.Drawing.Size(67, 23);
            this.Cbo_Año.TabIndex = 0;
            this.Cbo_Año.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Lbl_EstadodeCuenta
            // 
            this.Lbl_EstadodeCuenta.AutoSize = true;
            this.Lbl_EstadodeCuenta.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_EstadodeCuenta.Location = new System.Drawing.Point(553, 218);
            this.Lbl_EstadodeCuenta.Name = "Lbl_EstadodeCuenta";
            this.Lbl_EstadodeCuenta.Size = new System.Drawing.Size(374, 32);
            this.Lbl_EstadodeCuenta.TabIndex = 16;
            this.Lbl_EstadodeCuenta.Text = "Estado de Cuenta Bancario";
            // 
            // Lbl_CierreContable
            // 
            this.Lbl_CierreContable.AutoSize = true;
            this.Lbl_CierreContable.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CierreContable.Location = new System.Drawing.Point(110, 215);
            this.Lbl_CierreContable.Name = "Lbl_CierreContable";
            this.Lbl_CierreContable.Size = new System.Drawing.Size(231, 32);
            this.Lbl_CierreContable.TabIndex = 15;
            this.Lbl_CierreContable.Text = "Cierre Contable ";
            this.Lbl_CierreContable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Dgv_CierreContable
            // 
            this.Dgv_CierreContable.AllowUserToOrderColumns = true;
            this.Dgv_CierreContable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_CierreContable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Chequeo,
            this.No_Movimiento,
            this.Concepto,
            this.Cargo,
            this.Abono});
            this.Dgv_CierreContable.Location = new System.Drawing.Point(7, 248);
            this.Dgv_CierreContable.Name = "Dgv_CierreContable";
            this.Dgv_CierreContable.Size = new System.Drawing.Size(540, 378);
            this.Dgv_CierreContable.TabIndex = 13;
            // 
            // Chequeo
            // 
            this.Chequeo.HeaderText = "";
            this.Chequeo.Name = "Chequeo";
            // 
            // No_Movimiento
            // 
            this.No_Movimiento.HeaderText = "No. Movimiento";
            this.No_Movimiento.Name = "No_Movimiento";
            // 
            // Concepto
            // 
            this.Concepto.HeaderText = "Concepto";
            this.Concepto.Name = "Concepto";
            // 
            // Cargo
            // 
            this.Cargo.HeaderText = "Cargo";
            this.Cargo.Name = "Cargo";
            // 
            // Abono
            // 
            this.Abono.HeaderText = "Abono";
            this.Abono.Name = "Abono";
            // 
            // Lbl_Movimientos
            // 
            this.Lbl_Movimientos.AutoSize = true;
            this.Lbl_Movimientos.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Movimientos.Location = new System.Drawing.Point(13, 645);
            this.Lbl_Movimientos.Name = "Lbl_Movimientos";
            this.Lbl_Movimientos.Size = new System.Drawing.Size(82, 16);
            this.Lbl_Movimientos.TabIndex = 17;
            this.Lbl_Movimientos.Text = "Movimientos";
            // 
            // Lbl_NumeroMovimientos
            // 
            this.Lbl_NumeroMovimientos.AutoSize = true;
            this.Lbl_NumeroMovimientos.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NumeroMovimientos.Location = new System.Drawing.Point(105, 645);
            this.Lbl_NumeroMovimientos.Name = "Lbl_NumeroMovimientos";
            this.Lbl_NumeroMovimientos.Size = new System.Drawing.Size(15, 16);
            this.Lbl_NumeroMovimientos.TabIndex = 18;
            this.Lbl_NumeroMovimientos.Text = "0";
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(556, 250);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(365, 376);
            this.axAcroPDF1.TabIndex = 19;
            // 
            // Frm_ConciliacionBancaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 700);
            this.Controls.Add(this.axAcroPDF1);
            this.Controls.Add(this.Lbl_NumeroMovimientos);
            this.Controls.Add(this.Lbl_Movimientos);
            this.Controls.Add(this.Lbl_EstadodeCuenta);
            this.Controls.Add(this.Lbl_CierreContable);
            this.Controls.Add(this.Dgv_CierreContable);
            this.Controls.Add(this.Gpb_Seleccion);
            this.Controls.Add(this.Pnl_BarraDeEstado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_ConciliacionBancaria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_ConciliacionBancaria";
            this.Load += new System.EventHandler(this.Frm_ConciliacionBancaria_Load);
            this.Pnl_BarraDeEstado.ResumeLayout(false);
            this.Pnl_BarraDeEstado.PerformLayout();
            this.Gpb_Seleccion.ResumeLayout(false);
            this.Gpb_Seleccion.PerformLayout();
            this.Gpb_InformacionConciliacion.ResumeLayout(false);
            this.Gpb_InformacionConciliacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_CierreContable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_BarraDeEstado;
        private System.Windows.Forms.Button Btn_Cerrar;
        private System.Windows.Forms.Label Lbl_ConciliacionBancaria;
        private System.Windows.Forms.Button Pic_Logo;
        private System.Windows.Forms.GroupBox Gpb_Seleccion;
        private System.Windows.Forms.GroupBox Gpb_InformacionConciliacion;
        private System.Windows.Forms.TextBox Txt_Fecha;
        private System.Windows.Forms.TextBox Txt_NumeroConciliacion;
        private System.Windows.Forms.Label Lbl_Fecha;
        private System.Windows.Forms.Label Lbl_NumeroConciliacion;
        private System.Windows.Forms.Button Btn_GenerarConciliacion;
        private System.Windows.Forms.ComboBox Cbo_Mes;
        private System.Windows.Forms.Label Lbl_Mes;
        private System.Windows.Forms.Label Lbl_Año;
        private System.Windows.Forms.ComboBox Cbo_Año;
        private System.Windows.Forms.Label Lbl_EstadodeCuenta;
        private System.Windows.Forms.Label Lbl_CierreContable;
        private System.Windows.Forms.DataGridView Dgv_CierreContable;
        private System.Windows.Forms.Label Lbl_Movimientos;
        private System.Windows.Forms.Label Lbl_NumeroMovimientos;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Chequeo;
        private System.Windows.Forms.DataGridViewTextBoxColumn No_Movimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Concepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abono;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
    }
}