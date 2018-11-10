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
            this.Btn_Minimizar = new System.Windows.Forms.Button();
            this.Btn_Cerrar = new System.Windows.Forms.Button();
            this.Lbl_ConciliacionBancaria = new System.Windows.Forms.Label();
            this.Pic_Logo = new System.Windows.Forms.Button();
            this.Gpb_Seleccion = new System.Windows.Forms.GroupBox();
            this.Gpb_InformacionConciliacion = new System.Windows.Forms.GroupBox();
            this.Txt_Fecha = new System.Windows.Forms.TextBox();
            this.Lbl_Fecha = new System.Windows.Forms.Label();
            this.Cbo_Mes = new System.Windows.Forms.ComboBox();
            this.Lbl_Mes = new System.Windows.Forms.Label();
            this.Lbl_Año = new System.Windows.Forms.Label();
            this.Cbo_Año = new System.Windows.Forms.ComboBox();
            this.Btn_GenerarConciliacion = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_Examinar = new System.Windows.Forms.Button();
            this.Txt_DireccionEstadoDeCuenta = new System.Windows.Forms.TextBox();
            this.Lbl_SeleccionArchivo = new System.Windows.Forms.Label();
            this.Btn_Ayuda = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Lbl_DireccionEstadoCuenta = new System.Windows.Forms.Label();
            this.Pnl_BarraDeEstado.SuspendLayout();
            this.Gpb_Seleccion.SuspendLayout();
            this.Gpb_InformacionConciliacion.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_BarraDeEstado
            // 
            this.Pnl_BarraDeEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(147)))), ((int)(((byte)(125)))));
            this.Pnl_BarraDeEstado.Controls.Add(this.Btn_Minimizar);
            this.Pnl_BarraDeEstado.Controls.Add(this.Btn_Cerrar);
            this.Pnl_BarraDeEstado.Controls.Add(this.Lbl_ConciliacionBancaria);
            this.Pnl_BarraDeEstado.Controls.Add(this.Pic_Logo);
            this.Pnl_BarraDeEstado.Location = new System.Drawing.Point(0, 0);
            this.Pnl_BarraDeEstado.Name = "Pnl_BarraDeEstado";
            this.Pnl_BarraDeEstado.Size = new System.Drawing.Size(933, 42);
            this.Pnl_BarraDeEstado.TabIndex = 0;
            // 
            // Btn_Minimizar
            // 
            this.Btn_Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Minimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(147)))), ((int)(((byte)(125)))));
            this.Btn_Minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Minimizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(147)))), ((int)(((byte)(125)))));
            this.Btn_Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Minimizar.Image")));
            this.Btn_Minimizar.Location = new System.Drawing.Point(850, 0);
            this.Btn_Minimizar.Name = "Btn_Minimizar";
            this.Btn_Minimizar.Size = new System.Drawing.Size(41, 41);
            this.Btn_Minimizar.TabIndex = 14;
            this.Btn_Minimizar.UseVisualStyleBackColor = false;
            this.Btn_Minimizar.Click += new System.EventHandler(this.Btn_Minimizar_Click);
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
            this.Gpb_Seleccion.Controls.Add(this.Cbo_Mes);
            this.Gpb_Seleccion.Controls.Add(this.Lbl_Mes);
            this.Gpb_Seleccion.Controls.Add(this.Lbl_Año);
            this.Gpb_Seleccion.Controls.Add(this.Cbo_Año);
            this.Gpb_Seleccion.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_Seleccion.Location = new System.Drawing.Point(3, 348);
            this.Gpb_Seleccion.Name = "Gpb_Seleccion";
            this.Gpb_Seleccion.Size = new System.Drawing.Size(916, 132);
            this.Gpb_Seleccion.TabIndex = 9;
            this.Gpb_Seleccion.TabStop = false;
            this.Gpb_Seleccion.Text = "Seleccion ";
            // 
            // Gpb_InformacionConciliacion
            // 
            this.Gpb_InformacionConciliacion.Controls.Add(this.Txt_Fecha);
            this.Gpb_InformacionConciliacion.Controls.Add(this.Lbl_Fecha);
            this.Gpb_InformacionConciliacion.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_InformacionConciliacion.Location = new System.Drawing.Point(287, 17);
            this.Gpb_InformacionConciliacion.Name = "Gpb_InformacionConciliacion";
            this.Gpb_InformacionConciliacion.Size = new System.Drawing.Size(233, 103);
            this.Gpb_InformacionConciliacion.TabIndex = 7;
            this.Gpb_InformacionConciliacion.TabStop = false;
            this.Gpb_InformacionConciliacion.Text = "Informacion de la Conciliacion";
            // 
            // Txt_Fecha
            // 
            this.Txt_Fecha.Enabled = false;
            this.Txt_Fecha.Location = new System.Drawing.Point(58, 36);
            this.Txt_Fecha.Name = "Txt_Fecha";
            this.Txt_Fecha.ReadOnly = true;
            this.Txt_Fecha.Size = new System.Drawing.Size(74, 21);
            this.Txt_Fecha.TabIndex = 5;
            // 
            // Lbl_Fecha
            // 
            this.Lbl_Fecha.AutoSize = true;
            this.Lbl_Fecha.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Fecha.Location = new System.Drawing.Point(27, 17);
            this.Lbl_Fecha.Name = "Lbl_Fecha";
            this.Lbl_Fecha.Size = new System.Drawing.Size(142, 16);
            this.Lbl_Fecha.TabIndex = 4;
            this.Lbl_Fecha.Text = "Fecha de Conciliacion";
            // 
            // Cbo_Mes
            // 
            this.Cbo_Mes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_Mes.Enabled = false;
            this.Cbo_Mes.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_Mes.FormattingEnabled = true;
            this.Cbo_Mes.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.Cbo_Mes.Location = new System.Drawing.Point(100, 48);
            this.Cbo_Mes.Name = "Cbo_Mes";
            this.Cbo_Mes.Size = new System.Drawing.Size(77, 23);
            this.Cbo_Mes.TabIndex = 3;
            this.Cbo_Mes.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            this.Cbo_Mes.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Txt_DireccionEstadoDeCuenta_HelpRequested);
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
            this.Cbo_Año.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Txt_DireccionEstadoDeCuenta_HelpRequested);
            // 
            // Btn_GenerarConciliacion
            // 
            this.Btn_GenerarConciliacion.Enabled = false;
            this.Btn_GenerarConciliacion.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_GenerarConciliacion.Location = new System.Drawing.Point(817, 512);
            this.Btn_GenerarConciliacion.Name = "Btn_GenerarConciliacion";
            this.Btn_GenerarConciliacion.Size = new System.Drawing.Size(102, 42);
            this.Btn_GenerarConciliacion.TabIndex = 6;
            this.Btn_GenerarConciliacion.Text = "Generar Conciliacion";
            this.Btn_GenerarConciliacion.UseVisualStyleBackColor = true;
            this.Btn_GenerarConciliacion.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Lbl_DireccionEstadoCuenta);
            this.groupBox1.Controls.Add(this.Btn_Examinar);
            this.groupBox1.Controls.Add(this.Txt_DireccionEstadoDeCuenta);
            this.groupBox1.Controls.Add(this.Lbl_SeleccionArchivo);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 144);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(916, 105);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estado de Cuenta";
            // 
            // Btn_Examinar
            // 
            this.Btn_Examinar.Location = new System.Drawing.Point(305, 39);
            this.Btn_Examinar.Name = "Btn_Examinar";
            this.Btn_Examinar.Size = new System.Drawing.Size(75, 31);
            this.Btn_Examinar.TabIndex = 2;
            this.Btn_Examinar.Text = "Examinar";
            this.Btn_Examinar.UseVisualStyleBackColor = true;
            this.Btn_Examinar.Click += new System.EventHandler(this.Btn_Examinar_Click);
            // 
            // Txt_DireccionEstadoDeCuenta
            // 
            this.Txt_DireccionEstadoDeCuenta.Location = new System.Drawing.Point(551, 43);
            this.Txt_DireccionEstadoDeCuenta.Name = "Txt_DireccionEstadoDeCuenta";
            this.Txt_DireccionEstadoDeCuenta.Size = new System.Drawing.Size(274, 22);
            this.Txt_DireccionEstadoDeCuenta.TabIndex = 1;
            this.Txt_DireccionEstadoDeCuenta.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Txt_DireccionEstadoDeCuenta_HelpRequested);
            // 
            // Lbl_SeleccionArchivo
            // 
            this.Lbl_SeleccionArchivo.AutoSize = true;
            this.Lbl_SeleccionArchivo.Location = new System.Drawing.Point(10, 46);
            this.Lbl_SeleccionArchivo.Name = "Lbl_SeleccionArchivo";
            this.Lbl_SeleccionArchivo.Size = new System.Drawing.Size(289, 16);
            this.Lbl_SeleccionArchivo.TabIndex = 0;
            this.Lbl_SeleccionArchivo.Text = "Seleccione el archivo PDF del estado de cuenta";
            // 
            // Btn_Ayuda
            // 
            this.Btn_Ayuda.Image = global::BancosFinalProt.Properties.Resources.Help_32x32;
            this.Btn_Ayuda.Location = new System.Drawing.Point(860, 60);
            this.Btn_Ayuda.Name = "Btn_Ayuda";
            this.Btn_Ayuda.Size = new System.Drawing.Size(61, 60);
            this.Btn_Ayuda.TabIndex = 22;
            this.Btn_Ayuda.Text = "Ayuda";
            this.Btn_Ayuda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Ayuda.UseVisualStyleBackColor = true;
            this.Btn_Ayuda.Click += new System.EventHandler(this.Btn_Ayuda_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Lbl_DireccionEstadoCuenta
            // 
            this.Lbl_DireccionEstadoCuenta.AutoSize = true;
            this.Lbl_DireccionEstadoCuenta.Location = new System.Drawing.Point(548, 18);
            this.Lbl_DireccionEstadoCuenta.Name = "Lbl_DireccionEstadoCuenta";
            this.Lbl_DireccionEstadoCuenta.Size = new System.Drawing.Size(135, 16);
            this.Lbl_DireccionEstadoCuenta.TabIndex = 3;
            this.Lbl_DireccionEstadoCuenta.Text = "Direccion del archivo";
            // 
            // Frm_ConciliacionBancaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 700);
            this.Controls.Add(this.Btn_Ayuda);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Btn_GenerarConciliacion);
            this.Controls.Add(this.Gpb_Seleccion);
            this.Controls.Add(this.Pnl_BarraDeEstado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_ConciliacionBancaria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_ConciliacionBancaria";
            this.Load += new System.EventHandler(this.Frm_ConciliacionBancaria_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Frm_ConciliacionBancaria_HelpRequested);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_ConciliacionBancaria_KeyDown);
            this.Pnl_BarraDeEstado.ResumeLayout(false);
            this.Pnl_BarraDeEstado.PerformLayout();
            this.Gpb_Seleccion.ResumeLayout(false);
            this.Gpb_Seleccion.PerformLayout();
            this.Gpb_InformacionConciliacion.ResumeLayout(false);
            this.Gpb_InformacionConciliacion.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_BarraDeEstado;
        private System.Windows.Forms.Button Btn_Cerrar;
        private System.Windows.Forms.Label Lbl_ConciliacionBancaria;
        private System.Windows.Forms.Button Pic_Logo;
        private System.Windows.Forms.GroupBox Gpb_Seleccion;
        private System.Windows.Forms.GroupBox Gpb_InformacionConciliacion;
        private System.Windows.Forms.TextBox Txt_Fecha;
        private System.Windows.Forms.Label Lbl_Fecha;
        private System.Windows.Forms.Button Btn_GenerarConciliacion;
        private System.Windows.Forms.ComboBox Cbo_Mes;
        private System.Windows.Forms.Label Lbl_Mes;
        private System.Windows.Forms.Label Lbl_Año;
        private System.Windows.Forms.ComboBox Cbo_Año;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Txt_DireccionEstadoDeCuenta;
        private System.Windows.Forms.Label Lbl_SeleccionArchivo;
        private System.Windows.Forms.Button Btn_Minimizar;
        private System.Windows.Forms.Button Btn_Ayuda;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Btn_Examinar;
        private System.Windows.Forms.Label Lbl_DireccionEstadoCuenta;
    }
}