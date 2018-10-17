namespace Contabilidad
{
    partial class Frm_M_Activos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_M_Activos));
            this.Pnl_Mantiemientos = new System.Windows.Forms.Panel();
            this.Lbl_Contabilidad = new System.Windows.Forms.Label();
            this.Btn_Logo = new System.Windows.Forms.Button();
            this.lbl_Activos = new System.Windows.Forms.Label();
            this.gpb_Activos = new System.Windows.Forms.GroupBox();
            this.txt_Cantidad = new System.Windows.Forms.TextBox();
            this.lbl_Cantidad = new System.Windows.Forms.Label();
            this.cbo_NombreTipo = new System.Windows.Forms.ComboBox();
            this.txt_FechaActual = new System.Windows.Forms.TextBox();
            this.txt_fechaIngreso = new System.Windows.Forms.TextBox();
            this.txt_Codigo = new System.Windows.Forms.TextBox();
            this.lbl_FechaActual = new System.Windows.Forms.Label();
            this.lbl_NombreTipo = new System.Windows.Forms.Label();
            this.lbl_FechaIngreso = new System.Windows.Forms.Label();
            this.lbl_Codigo = new System.Windows.Forms.Label();
            this.navegador1 = new CapaDiseno.Navegador();
            this.Pnl_Mantiemientos.SuspendLayout();
            this.gpb_Activos.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_Mantiemientos
            // 
            this.Pnl_Mantiemientos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.Pnl_Mantiemientos.Controls.Add(this.Lbl_Contabilidad);
            this.Pnl_Mantiemientos.Controls.Add(this.Btn_Logo);
            this.Pnl_Mantiemientos.Location = new System.Drawing.Point(-2, -8);
            this.Pnl_Mantiemientos.Name = "Pnl_Mantiemientos";
            this.Pnl_Mantiemientos.Size = new System.Drawing.Size(1074, 52);
            this.Pnl_Mantiemientos.TabIndex = 0;
            this.Pnl_Mantiemientos.Paint += new System.Windows.Forms.PaintEventHandler(this.Pnl_Mantiemientos_Paint);
            // 
            // Lbl_Contabilidad
            // 
            this.Lbl_Contabilidad.AutoSize = true;
            this.Lbl_Contabilidad.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Contabilidad.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Contabilidad.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Contabilidad.Location = new System.Drawing.Point(71, 16);
            this.Lbl_Contabilidad.Name = "Lbl_Contabilidad";
            this.Lbl_Contabilidad.Size = new System.Drawing.Size(295, 32);
            this.Lbl_Contabilidad.TabIndex = 13;
            this.Lbl_Contabilidad.Text = "1600_Mantenimientos";
            // 
            // Btn_Logo
            // 
            this.Btn_Logo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Logo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.Btn_Logo.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Logo.Image")));
            this.Btn_Logo.Location = new System.Drawing.Point(16, 9);
            this.Btn_Logo.Name = "Btn_Logo";
            this.Btn_Logo.Size = new System.Drawing.Size(48, 41);
            this.Btn_Logo.TabIndex = 11;
            this.Btn_Logo.UseVisualStyleBackColor = false;
            // 
            // lbl_Activos
            // 
            this.lbl_Activos.AutoSize = true;
            this.lbl_Activos.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Activos.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Activos.ForeColor = System.Drawing.Color.Black;
            this.lbl_Activos.Location = new System.Drawing.Point(409, 97);
            this.lbl_Activos.Name = "lbl_Activos";
            this.lbl_Activos.Size = new System.Drawing.Size(188, 36);
            this.lbl_Activos.TabIndex = 14;
            this.lbl_Activos.Text = "Activos Fijos";
            // 
            // gpb_Activos
            // 
            this.gpb_Activos.Controls.Add(this.txt_Cantidad);
            this.gpb_Activos.Controls.Add(this.lbl_Cantidad);
            this.gpb_Activos.Controls.Add(this.cbo_NombreTipo);
            this.gpb_Activos.Controls.Add(this.txt_FechaActual);
            this.gpb_Activos.Controls.Add(this.txt_fechaIngreso);
            this.gpb_Activos.Controls.Add(this.txt_Codigo);
            this.gpb_Activos.Controls.Add(this.lbl_FechaActual);
            this.gpb_Activos.Controls.Add(this.lbl_NombreTipo);
            this.gpb_Activos.Controls.Add(this.lbl_FechaIngreso);
            this.gpb_Activos.Controls.Add(this.lbl_Codigo);
            this.gpb_Activos.Location = new System.Drawing.Point(269, 338);
            this.gpb_Activos.Name = "gpb_Activos";
            this.gpb_Activos.Size = new System.Drawing.Size(359, 217);
            this.gpb_Activos.TabIndex = 17;
            this.gpb_Activos.TabStop = false;
            this.gpb_Activos.Text = "Datos";
            // 
            // txt_Cantidad
            // 
            this.txt_Cantidad.Location = new System.Drawing.Point(180, 180);
            this.txt_Cantidad.Name = "txt_Cantidad";
            this.txt_Cantidad.Size = new System.Drawing.Size(173, 20);
            this.txt_Cantidad.TabIndex = 9;
            // 
            // lbl_Cantidad
            // 
            this.lbl_Cantidad.AutoSize = true;
            this.lbl_Cantidad.Location = new System.Drawing.Point(33, 183);
            this.lbl_Cantidad.Name = "lbl_Cantidad";
            this.lbl_Cantidad.Size = new System.Drawing.Size(57, 13);
            this.lbl_Cantidad.TabIndex = 8;
            this.lbl_Cantidad.Text = "Cantidad";
            // 
            // cbo_NombreTipo
            // 
            this.cbo_NombreTipo.FormattingEnabled = true;
            this.cbo_NombreTipo.Location = new System.Drawing.Point(180, 102);
            this.cbo_NombreTipo.Name = "cbo_NombreTipo";
            this.cbo_NombreTipo.Size = new System.Drawing.Size(173, 21);
            this.cbo_NombreTipo.TabIndex = 7;
            // 
            // txt_FechaActual
            // 
            this.txt_FechaActual.Location = new System.Drawing.Point(180, 146);
            this.txt_FechaActual.Name = "txt_FechaActual";
            this.txt_FechaActual.Size = new System.Drawing.Size(173, 20);
            this.txt_FechaActual.TabIndex = 6;
            // 
            // txt_fechaIngreso
            // 
            this.txt_fechaIngreso.Location = new System.Drawing.Point(180, 66);
            this.txt_fechaIngreso.Name = "txt_fechaIngreso";
            this.txt_fechaIngreso.Size = new System.Drawing.Size(173, 20);
            this.txt_fechaIngreso.TabIndex = 5;
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.Location = new System.Drawing.Point(180, 31);
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.Size = new System.Drawing.Size(173, 20);
            this.txt_Codigo.TabIndex = 4;
            // 
            // lbl_FechaActual
            // 
            this.lbl_FechaActual.AutoSize = true;
            this.lbl_FechaActual.Location = new System.Drawing.Point(33, 153);
            this.lbl_FechaActual.Name = "lbl_FechaActual";
            this.lbl_FechaActual.Size = new System.Drawing.Size(82, 13);
            this.lbl_FechaActual.TabIndex = 3;
            this.lbl_FechaActual.Text = "Fecha Actual";
            // 
            // lbl_NombreTipo
            // 
            this.lbl_NombreTipo.AutoSize = true;
            this.lbl_NombreTipo.Location = new System.Drawing.Point(33, 110);
            this.lbl_NombreTipo.Name = "lbl_NombreTipo";
            this.lbl_NombreTipo.Size = new System.Drawing.Size(96, 13);
            this.lbl_NombreTipo.TabIndex = 2;
            this.lbl_NombreTipo.Text = "Nombre del tipo";
            // 
            // lbl_FechaIngreso
            // 
            this.lbl_FechaIngreso.AutoSize = true;
            this.lbl_FechaIngreso.Location = new System.Drawing.Point(33, 66);
            this.lbl_FechaIngreso.Name = "lbl_FechaIngreso";
            this.lbl_FechaIngreso.Size = new System.Drawing.Size(88, 13);
            this.lbl_FechaIngreso.TabIndex = 1;
            this.lbl_FechaIngreso.Text = "Fecha Ingreso";
            // 
            // lbl_Codigo
            // 
            this.lbl_Codigo.AutoSize = true;
            this.lbl_Codigo.Location = new System.Drawing.Point(33, 31);
            this.lbl_Codigo.Name = "lbl_Codigo";
            this.lbl_Codigo.Size = new System.Drawing.Size(46, 13);
            this.lbl_Codigo.TabIndex = 0;
            this.lbl_Codigo.Text = "Codigo";
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.navegador1.DataGr = null;
            this.navegador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navegador1.Forma = this;
            this.navegador1.Location = new System.Drawing.Point(8, 180);
            this.navegador1.Name = "navegador1";
            this.navegador1.Procedimiento = null;
            this.navegador1.Size = new System.Drawing.Size(857, 62);
            this.navegador1.TabIndex = 18;
            // 
            // Frm_M_Activos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(933, 700);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.gpb_Activos);
            this.Controls.Add(this.lbl_Activos);
            this.Controls.Add(this.Pnl_Mantiemientos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_M_Activos";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Frm_M_Activos_Load);
            this.Pnl_Mantiemientos.ResumeLayout(false);
            this.Pnl_Mantiemientos.PerformLayout();
            this.gpb_Activos.ResumeLayout(false);
            this.gpb_Activos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_Mantiemientos;
        private System.Windows.Forms.Button Btn_Logo;
        private System.Windows.Forms.Label Lbl_Contabilidad;
        private System.Windows.Forms.Label lbl_Activos;
        private System.Windows.Forms.GroupBox gpb_Activos;
        private System.Windows.Forms.ComboBox cbo_NombreTipo;
        private System.Windows.Forms.TextBox txt_FechaActual;
        private System.Windows.Forms.TextBox txt_fechaIngreso;
        private System.Windows.Forms.TextBox txt_Codigo;
        private System.Windows.Forms.Label lbl_FechaActual;
        private System.Windows.Forms.Label lbl_NombreTipo;
        private System.Windows.Forms.Label lbl_FechaIngreso;
        private System.Windows.Forms.Label lbl_Codigo;
        private System.Windows.Forms.TextBox txt_Cantidad;
        private System.Windows.Forms.Label lbl_Cantidad;
        private CapaDiseno.Navegador navegador1;
    }
}