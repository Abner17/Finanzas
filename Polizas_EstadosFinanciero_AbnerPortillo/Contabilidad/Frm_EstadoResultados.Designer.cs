namespace Contabilidad
{
    partial class Frm_EstadoResultados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_EstadoResultados));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Minimizar = new System.Windows.Forms.Button();
            this.lbl_estadoResultados = new System.Windows.Forms.Label();
            this.Btn_Cerrar = new System.Windows.Forms.Button();
            this.Btn_Logo = new System.Windows.Forms.Button();
            this.navegador1 = new CapaDiseno.Navegador();
            this.dgv_estadoResultados = new System.Windows.Forms.DataGridView();
            this.lbl_noEstadoresultados = new System.Windows.Forms.Label();
            this.lbl_fechaInicio = new System.Windows.Forms.Label();
            this.lbl_fechaFin = new System.Windows.Forms.Label();
            this.lbl_noResponsable = new System.Windows.Forms.Label();
            this.lbl_nombreResponsable = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_noEstado = new System.Windows.Forms.TextBox();
            this.dtp_fechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtp_fechaFinal = new System.Windows.Forms.DateTimePicker();
            this.txt_noResponsable = new System.Windows.Forms.TextBox();
            this.txt_nombreResponsable = new System.Windows.Forms.TextBox();
            this.txt_utilidad = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_estadoResultados)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.Btn_Minimizar);
            this.panel1.Controls.Add(this.lbl_estadoResultados);
            this.panel1.Controls.Add(this.Btn_Cerrar);
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
            this.Btn_Minimizar.Location = new System.Drawing.Point(1143, 2);
            this.Btn_Minimizar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Minimizar.Name = "Btn_Minimizar";
            this.Btn_Minimizar.Size = new System.Drawing.Size(55, 50);
            this.Btn_Minimizar.TabIndex = 15;
            this.Btn_Minimizar.UseVisualStyleBackColor = false;
            this.Btn_Minimizar.Click += new System.EventHandler(this.Btn_Minimizar_Click);
            // 
            // lbl_estadoResultados
            // 
            this.lbl_estadoResultados.AutoSize = true;
            this.lbl_estadoResultados.BackColor = System.Drawing.Color.Transparent;
            this.lbl_estadoResultados.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estadoResultados.ForeColor = System.Drawing.Color.Black;
            this.lbl_estadoResultados.Location = new System.Drawing.Point(64, 6);
            this.lbl_estadoResultados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_estadoResultados.Name = "lbl_estadoResultados";
            this.lbl_estadoResultados.Size = new System.Drawing.Size(459, 40);
            this.lbl_estadoResultados.TabIndex = 12;
            this.lbl_estadoResultados.Text = "1520_Estado de Resultados";
            // 
            // Btn_Cerrar
            // 
            this.Btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(192)))), ((int)(((byte)(195)))));
            this.Btn_Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Cerrar.Image")));
            this.Btn_Cerrar.Location = new System.Drawing.Point(1186, 2);
            this.Btn_Cerrar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Size = new System.Drawing.Size(55, 50);
            this.Btn_Cerrar.TabIndex = 16;
            this.Btn_Cerrar.UseVisualStyleBackColor = false;
            this.Btn_Cerrar.Click += new System.EventHandler(this.Btn_Cerrar_Click);
            // 
            // Btn_Logo
            // 
            this.Btn_Logo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Logo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(192)))), ((int)(((byte)(195)))));
            this.Btn_Logo.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Logo.Image")));
            this.Btn_Logo.Location = new System.Drawing.Point(4, 1);
            this.Btn_Logo.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Logo.Name = "Btn_Logo";
            this.Btn_Logo.Size = new System.Drawing.Size(55, 50);
            this.Btn_Logo.TabIndex = 11;
            this.Btn_Logo.UseVisualStyleBackColor = false;
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.navegador1.DataGr = this.dgv_estadoResultados;
            this.navegador1.Forma = this;
            this.navegador1.Location = new System.Drawing.Point(45, 74);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.navegador1.Name = "navegador1";
            this.navegador1.Procedimiento = null;
            this.navegador1.pubNombrechm = null;
            this.navegador1.pubNombreHtml = null;
            this.navegador1.Size = new System.Drawing.Size(1143, 74);
            this.navegador1.TabIndex = 1;
            // 
            // dgv_estadoResultados
            // 
            this.dgv_estadoResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_estadoResultados.Location = new System.Drawing.Point(45, 179);
            this.dgv_estadoResultados.Name = "dgv_estadoResultados";
            this.dgv_estadoResultados.RowTemplate.Height = 24;
            this.dgv_estadoResultados.Size = new System.Drawing.Size(642, 490);
            this.dgv_estadoResultados.TabIndex = 2;
            // 
            // lbl_noEstadoresultados
            // 
            this.lbl_noEstadoresultados.AutoSize = true;
            this.lbl_noEstadoresultados.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_noEstadoresultados.Location = new System.Drawing.Point(45, 37);
            this.lbl_noEstadoresultados.Name = "lbl_noEstadoresultados";
            this.lbl_noEstadoresultados.Size = new System.Drawing.Size(249, 18);
            this.lbl_noEstadoresultados.TabIndex = 3;
            this.lbl_noEstadoresultados.Text = "Numero de Estado de Resultados";
            // 
            // lbl_fechaInicio
            // 
            this.lbl_fechaInicio.AutoSize = true;
            this.lbl_fechaInicio.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fechaInicio.Location = new System.Drawing.Point(13, 85);
            this.lbl_fechaInicio.Name = "lbl_fechaInicio";
            this.lbl_fechaInicio.Size = new System.Drawing.Size(123, 18);
            this.lbl_fechaInicio.TabIndex = 4;
            this.lbl_fechaInicio.Text = "Fecha de Inicio";
            // 
            // lbl_fechaFin
            // 
            this.lbl_fechaFin.AutoSize = true;
            this.lbl_fechaFin.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fechaFin.Location = new System.Drawing.Point(13, 138);
            this.lbl_fechaFin.Name = "lbl_fechaFin";
            this.lbl_fechaFin.Size = new System.Drawing.Size(92, 18);
            this.lbl_fechaFin.TabIndex = 5;
            this.lbl_fechaFin.Text = "Fecha Final";
            // 
            // lbl_noResponsable
            // 
            this.lbl_noResponsable.AutoSize = true;
            this.lbl_noResponsable.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_noResponsable.Location = new System.Drawing.Point(73, 195);
            this.lbl_noResponsable.Name = "lbl_noResponsable";
            this.lbl_noResponsable.Size = new System.Drawing.Size(189, 18);
            this.lbl_noResponsable.TabIndex = 6;
            this.lbl_noResponsable.Text = "Numero de Responsable";
            // 
            // lbl_nombreResponsable
            // 
            this.lbl_nombreResponsable.AutoSize = true;
            this.lbl_nombreResponsable.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombreResponsable.Location = new System.Drawing.Point(6, 243);
            this.lbl_nombreResponsable.Name = "lbl_nombreResponsable";
            this.lbl_nombreResponsable.Size = new System.Drawing.Size(190, 18);
            this.lbl_nombreResponsable.TabIndex = 7;
            this.lbl_nombreResponsable.Text = "Nombre de Responsable";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Utilidad Neta";
            // 
            // txt_noEstado
            // 
            this.txt_noEstado.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_noEstado.Location = new System.Drawing.Point(316, 29);
            this.txt_noEstado.Name = "txt_noEstado";
            this.txt_noEstado.Size = new System.Drawing.Size(110, 26);
            this.txt_noEstado.TabIndex = 9;
            // 
            // dtp_fechaInicio
            // 
            this.dtp_fechaInicio.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fechaInicio.Location = new System.Drawing.Point(150, 80);
            this.dtp_fechaInicio.Name = "dtp_fechaInicio";
            this.dtp_fechaInicio.Size = new System.Drawing.Size(244, 26);
            this.dtp_fechaInicio.TabIndex = 10;
            // 
            // dtp_fechaFinal
            // 
            this.dtp_fechaFinal.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fechaFinal.Location = new System.Drawing.Point(150, 133);
            this.dtp_fechaFinal.Name = "dtp_fechaFinal";
            this.dtp_fechaFinal.Size = new System.Drawing.Size(244, 26);
            this.dtp_fechaFinal.TabIndex = 11;
            // 
            // txt_noResponsable
            // 
            this.txt_noResponsable.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_noResponsable.Location = new System.Drawing.Point(294, 187);
            this.txt_noResponsable.Name = "txt_noResponsable";
            this.txt_noResponsable.Size = new System.Drawing.Size(100, 26);
            this.txt_noResponsable.TabIndex = 12;
            // 
            // txt_nombreResponsable
            // 
            this.txt_nombreResponsable.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombreResponsable.Location = new System.Drawing.Point(212, 235);
            this.txt_nombreResponsable.Name = "txt_nombreResponsable";
            this.txt_nombreResponsable.Size = new System.Drawing.Size(283, 26);
            this.txt_nombreResponsable.TabIndex = 13;
            // 
            // txt_utilidad
            // 
            this.txt_utilidad.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_utilidad.Location = new System.Drawing.Point(252, 286);
            this.txt_utilidad.Name = "txt_utilidad";
            this.txt_utilidad.Size = new System.Drawing.Size(100, 26);
            this.txt_utilidad.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_utilidad);
            this.groupBox1.Controls.Add(this.txt_nombreResponsable);
            this.groupBox1.Controls.Add(this.txt_noResponsable);
            this.groupBox1.Controls.Add(this.dtp_fechaFinal);
            this.groupBox1.Controls.Add(this.dtp_fechaInicio);
            this.groupBox1.Controls.Add(this.txt_noEstado);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbl_nombreResponsable);
            this.groupBox1.Controls.Add(this.lbl_noResponsable);
            this.groupBox1.Controls.Add(this.lbl_fechaFin);
            this.groupBox1.Controls.Add(this.lbl_fechaInicio);
            this.groupBox1.Controls.Add(this.lbl_noEstadoresultados);
            this.groupBox1.Location = new System.Drawing.Point(714, 246);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(506, 333);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Frm_EstadoResultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 700);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_estadoResultados);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_EstadoResultados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_EstadoResultados";
            this.Load += new System.EventHandler(this.Frm_EstadoResultados_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_estadoResultados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CapaDiseno.Navegador navegador1;
        private System.Windows.Forms.Button Btn_Logo;
        private System.Windows.Forms.Label lbl_estadoResultados;
        private System.Windows.Forms.DataGridView dgv_estadoResultados;
        private System.Windows.Forms.Label lbl_noEstadoresultados;
        private System.Windows.Forms.Label lbl_fechaInicio;
        private System.Windows.Forms.Label lbl_fechaFin;
        private System.Windows.Forms.Label lbl_noResponsable;
        private System.Windows.Forms.Label lbl_nombreResponsable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_noEstado;
        private System.Windows.Forms.DateTimePicker dtp_fechaInicio;
        private System.Windows.Forms.DateTimePicker dtp_fechaFinal;
        private System.Windows.Forms.TextBox txt_noResponsable;
        private System.Windows.Forms.TextBox txt_nombreResponsable;
        private System.Windows.Forms.TextBox txt_utilidad;
        private System.Windows.Forms.Button Btn_Minimizar;
        private System.Windows.Forms.Button Btn_Cerrar;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}