namespace Contabilidad
{
    partial class Frm_PolizaActivos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_PolizaActivos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Cerrar = new System.Windows.Forms.Button();
            this.Lbl_Contabilidad = new System.Windows.Forms.Label();
            this.Btn_Logo = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Btn_Poliza = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Dgv_poliza = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Debe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gpb_periodo = new System.Windows.Forms.GroupBox();
            this.Lbl_año = new System.Windows.Forms.Label();
            this.Lbl_FechaFinal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Lbl_FechaInicial = new System.Windows.Forms.Label();
            this.Lbl_mes = new System.Windows.Forms.Label();
            this.Dtp_DateFinal = new System.Windows.Forms.DateTimePicker();
            this.Lbl_perid = new System.Windows.Forms.Label();
            this.v = new System.Windows.Forms.DateTimePicker();
            this.Lbl_Periodo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_poliza)).BeginInit();
            this.Gpb_periodo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(169)))), ((int)(((byte)(236)))));
            this.panel1.Controls.Add(this.Btn_Cerrar);
            this.panel1.Controls.Add(this.Lbl_Contabilidad);
            this.panel1.Controls.Add(this.Btn_Logo);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 42);
            this.panel1.TabIndex = 2;
            // 
            // Btn_Cerrar
            // 
            this.Btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(169)))), ((int)(((byte)(236)))));
            this.Btn_Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Cerrar.Image")));
            this.Btn_Cerrar.Location = new System.Drawing.Point(880, -2);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Size = new System.Drawing.Size(41, 41);
            this.Btn_Cerrar.TabIndex = 12;
            this.Btn_Cerrar.UseVisualStyleBackColor = false;
            this.Btn_Cerrar.Click += new System.EventHandler(this.Btn_Cerrar_Click);
            // 
            // Lbl_Contabilidad
            // 
            this.Lbl_Contabilidad.AutoSize = true;
            this.Lbl_Contabilidad.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Contabilidad.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Contabilidad.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Contabilidad.Location = new System.Drawing.Point(49, 9);
            this.Lbl_Contabilidad.Name = "Lbl_Contabilidad";
            this.Lbl_Contabilidad.Size = new System.Drawing.Size(368, 32);
            this.Lbl_Contabilidad.TabIndex = 11;
            this.Lbl_Contabilidad.Text = " 1310 _Activos Fijos Ingreso";
            // 
            // Btn_Logo
            // 
            this.Btn_Logo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Logo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(192)))), ((int)(((byte)(195)))));
            this.Btn_Logo.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Logo.Image")));
            this.Btn_Logo.Location = new System.Drawing.Point(3, 1);
            this.Btn_Logo.Name = "Btn_Logo";
            this.Btn_Logo.Size = new System.Drawing.Size(41, 41);
            this.Btn_Logo.TabIndex = 10;
            this.Btn_Logo.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(169)))), ((int)(((byte)(236)))));
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(169)))), ((int)(((byte)(236)))));
            this.button2.Location = new System.Drawing.Point(839, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(41, 41);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(757, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 60);
            this.button1.TabIndex = 29;
            this.button1.Text = "Ayuda";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Btn_Poliza
            // 
            this.Btn_Poliza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_Poliza.FlatAppearance.BorderSize = 0;
            this.Btn_Poliza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Poliza.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Poliza.Location = new System.Drawing.Point(747, 185);
            this.Btn_Poliza.Name = "Btn_Poliza";
            this.Btn_Poliza.Size = new System.Drawing.Size(61, 60);
            this.Btn_Poliza.TabIndex = 28;
            this.Btn_Poliza.Text = "Poliza";
            this.Btn_Poliza.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Poliza.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(192)))), ((int)(((byte)(195)))));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(68, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 19);
            this.label2.TabIndex = 26;
            this.label2.Text = "0000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(192)))), ((int)(((byte)(195)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(58, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "No Poliza";
            // 
            // Dgv_poliza
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_poliza.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Dgv_poliza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_poliza.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Cuenta,
            this.Debe,
            this.Column3,
            this.Column4});
            this.Dgv_poliza.Location = new System.Drawing.Point(46, 275);
            this.Dgv_poliza.Name = "Dgv_poliza";
            this.Dgv_poliza.Size = new System.Drawing.Size(772, 336);
            this.Dgv_poliza.TabIndex = 25;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "No.";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nomenclatura";
            this.Column2.Name = "Column2";
            this.Column2.Width = 135;
            // 
            // Cuenta
            // 
            this.Cuenta.HeaderText = "Cuenta";
            this.Cuenta.MinimumWidth = 15;
            this.Cuenta.Name = "Cuenta";
            this.Cuenta.Width = 220;
            // 
            // Debe
            // 
            this.Debe.HeaderText = "Debe";
            this.Debe.Name = "Debe";
            this.Debe.Width = 110;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Haber";
            this.Column3.Name = "Column3";
            this.Column3.Width = 110;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Total";
            this.Column4.Name = "Column4";
            this.Column4.Width = 110;
            // 
            // Gpb_periodo
            // 
            this.Gpb_periodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(192)))), ((int)(((byte)(195)))));
            this.Gpb_periodo.Controls.Add(this.Lbl_año);
            this.Gpb_periodo.Controls.Add(this.Lbl_FechaFinal);
            this.Gpb_periodo.Controls.Add(this.label6);
            this.Gpb_periodo.Controls.Add(this.Lbl_FechaInicial);
            this.Gpb_periodo.Controls.Add(this.Lbl_mes);
            this.Gpb_periodo.Controls.Add(this.Dtp_DateFinal);
            this.Gpb_periodo.Controls.Add(this.Lbl_perid);
            this.Gpb_periodo.Controls.Add(this.v);
            this.Gpb_periodo.Controls.Add(this.Lbl_Periodo);
            this.Gpb_periodo.Location = new System.Drawing.Point(133, 145);
            this.Gpb_periodo.Margin = new System.Windows.Forms.Padding(4);
            this.Gpb_periodo.Name = "Gpb_periodo";
            this.Gpb_periodo.Size = new System.Drawing.Size(592, 108);
            this.Gpb_periodo.TabIndex = 24;
            this.Gpb_periodo.TabStop = false;
            // 
            // Lbl_año
            // 
            this.Lbl_año.AutoSize = true;
            this.Lbl_año.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_año.Location = new System.Drawing.Point(313, 78);
            this.Lbl_año.Name = "Lbl_año";
            this.Lbl_año.Size = new System.Drawing.Size(36, 16);
            this.Lbl_año.TabIndex = 12;
            this.Lbl_año.Text = "2018";
            // 
            // Lbl_FechaFinal
            // 
            this.Lbl_FechaFinal.AutoSize = true;
            this.Lbl_FechaFinal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_FechaFinal.Location = new System.Drawing.Point(363, 15);
            this.Lbl_FechaFinal.Name = "Lbl_FechaFinal";
            this.Lbl_FechaFinal.Size = new System.Drawing.Size(99, 19);
            this.Lbl_FechaFinal.TabIndex = 7;
            this.Lbl_FechaFinal.Text = "Fecha Final";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(302, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "/";
            // 
            // Lbl_FechaInicial
            // 
            this.Lbl_FechaInicial.AutoSize = true;
            this.Lbl_FechaInicial.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_FechaInicial.Location = new System.Drawing.Point(139, 15);
            this.Lbl_FechaInicial.Name = "Lbl_FechaInicial";
            this.Lbl_FechaInicial.Size = new System.Drawing.Size(109, 19);
            this.Lbl_FechaInicial.TabIndex = 6;
            this.Lbl_FechaInicial.Text = "Fecha Inicial";
            // 
            // Lbl_mes
            // 
            this.Lbl_mes.AutoSize = true;
            this.Lbl_mes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_mes.Location = new System.Drawing.Point(290, 78);
            this.Lbl_mes.Name = "Lbl_mes";
            this.Lbl_mes.Size = new System.Drawing.Size(15, 16);
            this.Lbl_mes.TabIndex = 11;
            this.Lbl_mes.Text = "2";
            // 
            // Dtp_DateFinal
            // 
            this.Dtp_DateFinal.Location = new System.Drawing.Point(329, 42);
            this.Dtp_DateFinal.Name = "Dtp_DateFinal";
            this.Dtp_DateFinal.Size = new System.Drawing.Size(200, 20);
            this.Dtp_DateFinal.TabIndex = 5;
            // 
            // Lbl_perid
            // 
            this.Lbl_perid.AutoSize = true;
            this.Lbl_perid.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_perid.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_perid.Location = new System.Drawing.Point(236, 78);
            this.Lbl_perid.Name = "Lbl_perid";
            this.Lbl_perid.Size = new System.Drawing.Size(60, 16);
            this.Lbl_perid.TabIndex = 9;
            this.Lbl_perid.Text = "Período ";
            // 
            // v
            // 
            this.v.Location = new System.Drawing.Point(99, 42);
            this.v.Name = "v";
            this.v.Size = new System.Drawing.Size(200, 20);
            this.v.TabIndex = 4;
            // 
            // Lbl_Periodo
            // 
            this.Lbl_Periodo.AutoSize = true;
            this.Lbl_Periodo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Periodo.Location = new System.Drawing.Point(6, 42);
            this.Lbl_Periodo.Name = "Lbl_Periodo";
            this.Lbl_Periodo.Size = new System.Drawing.Size(68, 19);
            this.Lbl_Periodo.TabIndex = 3;
            this.Lbl_Periodo.Text = "Período";
            // 
            // Frm_PolizaActivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 700);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Btn_Poliza);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dgv_poliza);
            this.Controls.Add(this.Gpb_periodo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_PolizaActivos";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_poliza)).EndInit();
            this.Gpb_periodo.ResumeLayout(false);
            this.Gpb_periodo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_Cerrar;
        private System.Windows.Forms.Label Lbl_Contabilidad;
        private System.Windows.Forms.Button Btn_Logo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Btn_Poliza;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Dgv_poliza;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Debe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.GroupBox Gpb_periodo;
        private System.Windows.Forms.Label Lbl_año;
        private System.Windows.Forms.Label Lbl_FechaFinal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Lbl_FechaInicial;
        private System.Windows.Forms.Label Lbl_mes;
        private System.Windows.Forms.DateTimePicker Dtp_DateFinal;
        private System.Windows.Forms.Label Lbl_perid;
        private System.Windows.Forms.DateTimePicker v;
        private System.Windows.Forms.Label Lbl_Periodo;
    }
}