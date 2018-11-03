namespace ProtBancosErvinRoca
{
    partial class Frm_DisponibilidadDiaria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_DisponibilidadDiaria));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lbl_Modulo = new System.Windows.Forms.Label();
            this.Btn_Logo = new System.Windows.Forms.Button();
            this.Btn_cerrar = new System.Windows.Forms.Button();
            this.Dgv_DisponibilidadDiaria = new System.Windows.Forms.DataGridView();
            this.Lbl_SaldoCuentas = new System.Windows.Forms.Label();
            this.Lbl_Reservado = new System.Windows.Forms.Label();
            this.Lbl_Disponibilidad = new System.Windows.Forms.Label();
            this.Lbl_SaldoDeCuentas = new System.Windows.Forms.Label();
            this.Lbl_ReservadoB = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Pnl_DatosDisponibilidad = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_DisponibilidadDiaria)).BeginInit();
            this.Pnl_DatosDisponibilidad.SuspendLayout();
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
            this.Lbl_Modulo.Size = new System.Drawing.Size(319, 28);
            this.Lbl_Modulo.TabIndex = 9;
            this.Lbl_Modulo.Text = "6300_Disponibilidad Diaria";
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
            // Dgv_DisponibilidadDiaria
            // 
            this.Dgv_DisponibilidadDiaria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_DisponibilidadDiaria.Location = new System.Drawing.Point(52, 96);
            this.Dgv_DisponibilidadDiaria.Name = "Dgv_DisponibilidadDiaria";
            this.Dgv_DisponibilidadDiaria.RowTemplate.Height = 24;
            this.Dgv_DisponibilidadDiaria.Size = new System.Drawing.Size(1129, 331);
            this.Dgv_DisponibilidadDiaria.TabIndex = 3;
            // 
            // Lbl_SaldoCuentas
            // 
            this.Lbl_SaldoCuentas.AutoSize = true;
            this.Lbl_SaldoCuentas.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_SaldoCuentas.Location = new System.Drawing.Point(3, 80);
            this.Lbl_SaldoCuentas.Name = "Lbl_SaldoCuentas";
            this.Lbl_SaldoCuentas.Size = new System.Drawing.Size(376, 34);
            this.Lbl_SaldoCuentas.TabIndex = 10;
            this.Lbl_SaldoCuentas.Text = "Saldo Cuentas Bancarias : ";
            // 
            // Lbl_Reservado
            // 
            this.Lbl_Reservado.AutoSize = true;
            this.Lbl_Reservado.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Reservado.Location = new System.Drawing.Point(3, 135);
            this.Lbl_Reservado.Name = "Lbl_Reservado";
            this.Lbl_Reservado.Size = new System.Drawing.Size(182, 34);
            this.Lbl_Reservado.TabIndex = 12;
            this.Lbl_Reservado.Text = "Reservado : ";
            // 
            // Lbl_Disponibilidad
            // 
            this.Lbl_Disponibilidad.AutoSize = true;
            this.Lbl_Disponibilidad.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Disponibilidad.Location = new System.Drawing.Point(3, 205);
            this.Lbl_Disponibilidad.Name = "Lbl_Disponibilidad";
            this.Lbl_Disponibilidad.Size = new System.Drawing.Size(223, 34);
            this.Lbl_Disponibilidad.TabIndex = 13;
            this.Lbl_Disponibilidad.Text = "Disponibilidad :";
            // 
            // Lbl_SaldoDeCuentas
            // 
            this.Lbl_SaldoDeCuentas.AutoSize = true;
            this.Lbl_SaldoDeCuentas.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_SaldoDeCuentas.Location = new System.Drawing.Point(409, 74);
            this.Lbl_SaldoDeCuentas.Name = "Lbl_SaldoDeCuentas";
            this.Lbl_SaldoDeCuentas.Size = new System.Drawing.Size(26, 39);
            this.Lbl_SaldoDeCuentas.TabIndex = 18;
            this.Lbl_SaldoDeCuentas.Text = ".";
            // 
            // Lbl_ReservadoB
            // 
            this.Lbl_ReservadoB.AutoSize = true;
            this.Lbl_ReservadoB.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ReservadoB.Location = new System.Drawing.Point(409, 129);
            this.Lbl_ReservadoB.Name = "Lbl_ReservadoB";
            this.Lbl_ReservadoB.Size = new System.Drawing.Size(26, 39);
            this.Lbl_ReservadoB.TabIndex = 19;
            this.Lbl_ReservadoB.Text = ".";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(409, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 39);
            this.label4.TabIndex = 20;
            this.label4.Text = ".";
            // 
            // Pnl_DatosDisponibilidad
            // 
            this.Pnl_DatosDisponibilidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pnl_DatosDisponibilidad.Controls.Add(this.label4);
            this.Pnl_DatosDisponibilidad.Controls.Add(this.Lbl_SaldoCuentas);
            this.Pnl_DatosDisponibilidad.Controls.Add(this.Lbl_ReservadoB);
            this.Pnl_DatosDisponibilidad.Controls.Add(this.Lbl_Disponibilidad);
            this.Pnl_DatosDisponibilidad.Controls.Add(this.Lbl_SaldoDeCuentas);
            this.Pnl_DatosDisponibilidad.Controls.Add(this.Lbl_Reservado);
            this.Pnl_DatosDisponibilidad.Location = new System.Drawing.Point(52, 458);
            this.Pnl_DatosDisponibilidad.Name = "Pnl_DatosDisponibilidad";
            this.Pnl_DatosDisponibilidad.Size = new System.Drawing.Size(684, 315);
            this.Pnl_DatosDisponibilidad.TabIndex = 18;
            // 
            // Frm_DisponibilidadDiaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 862);
            this.Controls.Add(this.Pnl_DatosDisponibilidad);
            this.Controls.Add(this.Dgv_DisponibilidadDiaria);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_DisponibilidadDiaria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_DisponibilidadDiaria";
            this.Load += new System.EventHandler(this.Frm_DisponibilidadDiaria_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_DisponibilidadDiaria)).EndInit();
            this.Pnl_DatosDisponibilidad.ResumeLayout(false);
            this.Pnl_DatosDisponibilidad.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lbl_Modulo;
        private System.Windows.Forms.Button Btn_Logo;
        private System.Windows.Forms.Button Btn_cerrar;
        private System.Windows.Forms.DataGridView Dgv_DisponibilidadDiaria;
        private System.Windows.Forms.Label Lbl_SaldoCuentas;
        private System.Windows.Forms.Label Lbl_Reservado;
        private System.Windows.Forms.Label Lbl_Disponibilidad;
        private System.Windows.Forms.Label Lbl_SaldoDeCuentas;
        private System.Windows.Forms.Label Lbl_ReservadoB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel Pnl_DatosDisponibilidad;
    }
}