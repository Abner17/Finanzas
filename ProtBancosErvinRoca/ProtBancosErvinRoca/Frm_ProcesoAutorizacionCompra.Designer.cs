namespace ProtBancosErvinRoca
{
    partial class Frm_ProcesoAutorizacionCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ProcesoAutorizacionCompra));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lbl_Modulo = new System.Windows.Forms.Label();
            this.Btn_Logo = new System.Windows.Forms.Button();
            this.Btn_cerrar = new System.Windows.Forms.Button();
            this.Pnl_DatosCompra = new System.Windows.Forms.Panel();
            this.Lbl_TotalProd = new System.Windows.Forms.Label();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.Dgv_DetalleProducto = new System.Windows.Forms.DataGridView();
            this.lbl_Detalle = new System.Windows.Forms.Label();
            this.Txt_NumeroCompra = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Txt_FechaSolicitud = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Cmb_Empleado = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Cmb_Operacion = new System.Windows.Forms.ComboBox();
            this.Pnl_ProcesoAurotizacion = new System.Windows.Forms.Panel();
            this.Dtp_FechaAutorizacion = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.Pnl_DatosCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_DetalleProducto)).BeginInit();
            this.Pnl_ProcesoAurotizacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(147)))), ((int)(((byte)(125)))));
            this.panel1.Controls.Add(this.Lbl_Modulo);
            this.panel1.Controls.Add(this.Btn_Logo);
            this.panel1.Controls.Add(this.Btn_cerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1244, 42);
            this.panel1.TabIndex = 2;
            // 
            // Lbl_Modulo
            // 
            this.Lbl_Modulo.AutoSize = true;
            this.Lbl_Modulo.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Modulo.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Modulo.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Modulo.Location = new System.Drawing.Point(47, 9);
            this.Lbl_Modulo.Name = "Lbl_Modulo";
            this.Lbl_Modulo.Size = new System.Drawing.Size(496, 28);
            this.Lbl_Modulo.TabIndex = 9;
            this.Lbl_Modulo.Text = "6500_Proceso Y Autorizacion De Compras";
            // 
            // Btn_Logo
            // 
            this.Btn_Logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.Btn_Logo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Logo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.Btn_Logo.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Logo.Image")));
            this.Btn_Logo.Location = new System.Drawing.Point(0, -2);
            this.Btn_Logo.Name = "Btn_Logo";
            this.Btn_Logo.Size = new System.Drawing.Size(41, 41);
            this.Btn_Logo.TabIndex = 8;
            this.Btn_Logo.UseVisualStyleBackColor = false;
            // 
            // Btn_cerrar
            // 
            this.Btn_cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.Btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.Btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_cerrar.Image")));
            this.Btn_cerrar.Location = new System.Drawing.Point(1203, -2);
            this.Btn_cerrar.Name = "Btn_cerrar";
            this.Btn_cerrar.Size = new System.Drawing.Size(41, 41);
            this.Btn_cerrar.TabIndex = 7;
            this.Btn_cerrar.UseVisualStyleBackColor = false;
            this.Btn_cerrar.Click += new System.EventHandler(this.Btn_cerrar_Click);
            // 
            // Pnl_DatosCompra
            // 
            this.Pnl_DatosCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pnl_DatosCompra.Controls.Add(this.Lbl_TotalProd);
            this.Pnl_DatosCompra.Controls.Add(this.lbl_Total);
            this.Pnl_DatosCompra.Controls.Add(this.Dgv_DetalleProducto);
            this.Pnl_DatosCompra.Controls.Add(this.lbl_Detalle);
            this.Pnl_DatosCompra.Controls.Add(this.Txt_NumeroCompra);
            this.Pnl_DatosCompra.Controls.Add(this.label7);
            this.Pnl_DatosCompra.Controls.Add(this.Txt_FechaSolicitud);
            this.Pnl_DatosCompra.Controls.Add(this.label6);
            this.Pnl_DatosCompra.Controls.Add(this.label5);
            this.Pnl_DatosCompra.Location = new System.Drawing.Point(41, 317);
            this.Pnl_DatosCompra.Name = "Pnl_DatosCompra";
            this.Pnl_DatosCompra.Size = new System.Drawing.Size(1171, 492);
            this.Pnl_DatosCompra.TabIndex = 11;
            // 
            // Lbl_TotalProd
            // 
            this.Lbl_TotalProd.AutoSize = true;
            this.Lbl_TotalProd.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TotalProd.Location = new System.Drawing.Point(242, 443);
            this.Lbl_TotalProd.Name = "Lbl_TotalProd";
            this.Lbl_TotalProd.Size = new System.Drawing.Size(116, 39);
            this.Lbl_TotalProd.TabIndex = 20;
            this.Lbl_TotalProd.Text = "label8";
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total.Location = new System.Drawing.Point(87, 443);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(110, 39);
            this.lbl_Total.TabIndex = 18;
            this.lbl_Total.Text = "Total :";
            // 
            // Dgv_DetalleProducto
            // 
            this.Dgv_DetalleProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_DetalleProducto.Location = new System.Drawing.Point(41, 237);
            this.Dgv_DetalleProducto.Name = "Dgv_DetalleProducto";
            this.Dgv_DetalleProducto.RowTemplate.Height = 24;
            this.Dgv_DetalleProducto.Size = new System.Drawing.Size(1095, 184);
            this.Dgv_DetalleProducto.TabIndex = 16;
            // 
            // lbl_Detalle
            // 
            this.lbl_Detalle.AutoSize = true;
            this.lbl_Detalle.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Detalle.Location = new System.Drawing.Point(53, 195);
            this.lbl_Detalle.Name = "lbl_Detalle";
            this.lbl_Detalle.Size = new System.Drawing.Size(115, 28);
            this.lbl_Detalle.TabIndex = 13;
            this.lbl_Detalle.Text = "Detalle  :";
            // 
            // Txt_NumeroCompra
            // 
            this.Txt_NumeroCompra.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_NumeroCompra.Location = new System.Drawing.Point(341, 129);
            this.Txt_NumeroCompra.Name = "Txt_NumeroCompra";
            this.Txt_NumeroCompra.Size = new System.Drawing.Size(205, 36);
            this.Txt_NumeroCompra.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(753, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 28);
            this.label7.TabIndex = 11;
            this.label7.Text = "Fecha Solicitud :";
            // 
            // Txt_FechaSolicitud
            // 
            this.Txt_FechaSolicitud.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_FechaSolicitud.Location = new System.Drawing.Point(970, 83);
            this.Txt_FechaSolicitud.Name = "Txt_FechaSolicitud";
            this.Txt_FechaSolicitud.Size = new System.Drawing.Size(131, 36);
            this.Txt_FechaSolicitud.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(53, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(261, 28);
            this.label6.TabIndex = 8;
            this.label6.Text = "Numero de Compra :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(358, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(432, 39);
            this.label5.TabIndex = 7;
            this.label5.Text = "Datos Orden De Compra :";
            // 
            // Cmb_Empleado
            // 
            this.Cmb_Empleado.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_Empleado.FormattingEnabled = true;
            this.Cmb_Empleado.Items.AddRange(new object[] {
            "Gerente",
            "Administrador",
            "Agente "});
            this.Cmb_Empleado.Location = new System.Drawing.Point(694, 132);
            this.Cmb_Empleado.Name = "Cmb_Empleado";
            this.Cmb_Empleado.Size = new System.Drawing.Size(245, 35);
            this.Cmb_Empleado.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(479, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "Autorizado por :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(254, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(388, 39);
            this.label3.TabIndex = 3;
            this.label3.Text = "Datos de Aprobacion : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(682, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha Autorizacion  :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Operacion :";
            // 
            // Cmb_Operacion
            // 
            this.Cmb_Operacion.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_Operacion.FormattingEnabled = true;
            this.Cmb_Operacion.Items.AddRange(new object[] {
            "Autorizado",
            "Denegado"});
            this.Cmb_Operacion.Location = new System.Drawing.Point(240, 135);
            this.Cmb_Operacion.Name = "Cmb_Operacion";
            this.Cmb_Operacion.Size = new System.Drawing.Size(176, 35);
            this.Cmb_Operacion.TabIndex = 0;
            this.Cmb_Operacion.SelectedIndexChanged += new System.EventHandler(this.Cmb_Operacion_SelectedIndexChanged);
            // 
            // Pnl_ProcesoAurotizacion
            // 
            this.Pnl_ProcesoAurotizacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pnl_ProcesoAurotizacion.Controls.Add(this.Dtp_FechaAutorizacion);
            this.Pnl_ProcesoAurotizacion.Controls.Add(this.label3);
            this.Pnl_ProcesoAurotizacion.Controls.Add(this.Cmb_Operacion);
            this.Pnl_ProcesoAurotizacion.Controls.Add(this.Cmb_Empleado);
            this.Pnl_ProcesoAurotizacion.Controls.Add(this.label1);
            this.Pnl_ProcesoAurotizacion.Controls.Add(this.label2);
            this.Pnl_ProcesoAurotizacion.Controls.Add(this.label4);
            this.Pnl_ProcesoAurotizacion.Location = new System.Drawing.Point(41, 92);
            this.Pnl_ProcesoAurotizacion.Name = "Pnl_ProcesoAurotizacion";
            this.Pnl_ProcesoAurotizacion.Size = new System.Drawing.Size(1171, 203);
            this.Pnl_ProcesoAurotizacion.TabIndex = 12;
            this.Pnl_ProcesoAurotizacion.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Pnl_ProcesoAurotizacion_MouseClick);
            // 
            // Dtp_FechaAutorizacion
            // 
            this.Dtp_FechaAutorizacion.Location = new System.Drawing.Point(954, 62);
            this.Dtp_FechaAutorizacion.Name = "Dtp_FechaAutorizacion";
            this.Dtp_FechaAutorizacion.Size = new System.Drawing.Size(170, 22);
            this.Dtp_FechaAutorizacion.TabIndex = 18;
            // 
            // Frm_ProcesoAutorizacionCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 862);
            this.Controls.Add(this.Pnl_ProcesoAurotizacion);
            this.Controls.Add(this.Pnl_DatosCompra);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_ProcesoAutorizacionCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_ProcesoAutorizacionCompra";
            this.Load += new System.EventHandler(this.Frm_ProcesoAutorizacionCompra_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Pnl_DatosCompra.ResumeLayout(false);
            this.Pnl_DatosCompra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_DetalleProducto)).EndInit();
            this.Pnl_ProcesoAurotizacion.ResumeLayout(false);
            this.Pnl_ProcesoAurotizacion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lbl_Modulo;
        private System.Windows.Forms.Button Btn_Logo;
        private System.Windows.Forms.Button Btn_cerrar;
        private System.Windows.Forms.Panel Pnl_DatosCompra;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.ComboBox Cmb_Empleado;
        private System.Windows.Forms.DataGridView Dgv_DetalleProducto;
        private System.Windows.Forms.Label lbl_Detalle;
        private System.Windows.Forms.TextBox Txt_NumeroCompra;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Txt_FechaSolicitud;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Cmb_Operacion;
        private System.Windows.Forms.Label Lbl_TotalProd;
        private System.Windows.Forms.Panel Pnl_ProcesoAurotizacion;
        private System.Windows.Forms.DateTimePicker Dtp_FechaAutorizacion;
    }
}