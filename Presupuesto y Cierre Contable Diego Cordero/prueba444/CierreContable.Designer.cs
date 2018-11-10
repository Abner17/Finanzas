namespace Contabilidad
{
    partial class CierreContable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CierreContable));
            this.dgv_tablaCierreContable = new System.Windows.Forms.DataGridView();
            this.asdf1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lbl_Contabilidad = new System.Windows.Forms.Label();
            this.Btn_Cerrar = new System.Windows.Forms.Button();
            this.Btn_Logo = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.dtm_fechafin = new System.Windows.Forms.DateTimePicker();
            this.dtm_fechainicio = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.navegador1 = new CapaDiseno.Navegador();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tablaCierreContable)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_tablaCierreContable
            // 
            this.dgv_tablaCierreContable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tablaCierreContable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.asdf1,
            this.Column1,
            this.ab,
            this.abc,
            this.ca,
            this.cac,
            this.saan,
            this.saac,
            this.Column7});
            this.dgv_tablaCierreContable.Location = new System.Drawing.Point(35, 238);
            this.dgv_tablaCierreContable.Name = "dgv_tablaCierreContable";
            this.dgv_tablaCierreContable.ReadOnly = true;
            this.dgv_tablaCierreContable.Size = new System.Drawing.Size(864, 438);
            this.dgv_tablaCierreContable.TabIndex = 9;
            this.dgv_tablaCierreContable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaPresupuesto_CellContentClick);
            // 
            // asdf1
            // 
            this.asdf1.HeaderText = "No. Cuenta";
            this.asdf1.Name = "asdf1";
            this.asdf1.ReadOnly = true;
            this.asdf1.Width = 60;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // ab
            // 
            this.ab.HeaderText = "Abono";
            this.ab.Name = "ab";
            this.ab.ReadOnly = true;
            // 
            // abc
            // 
            this.abc.HeaderText = "Abono Acumulado";
            this.abc.Name = "abc";
            this.abc.ReadOnly = true;
            // 
            // ca
            // 
            this.ca.HeaderText = "Cargo";
            this.ca.Name = "ca";
            this.ca.ReadOnly = true;
            // 
            // cac
            // 
            this.cac.HeaderText = "Cargo Acumulado";
            this.cac.Name = "cac";
            this.cac.ReadOnly = true;
            // 
            // saan
            // 
            this.saan.HeaderText = "Saldo Anterior";
            this.saan.Name = "saan";
            this.saan.ReadOnly = true;
            this.saan.Width = 60;
            // 
            // saac
            // 
            this.saac.HeaderText = "Saldo Actual";
            this.saac.Name = "saac";
            this.saac.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Fecha";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(169)))), ((int)(((byte)(206)))));
            this.panel1.Controls.Add(this.Lbl_Contabilidad);
            this.panel1.Controls.Add(this.Btn_Cerrar);
            this.panel1.Controls.Add(this.Btn_Logo);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 42);
            this.panel1.TabIndex = 8;
            // 
            // Lbl_Contabilidad
            // 
            this.Lbl_Contabilidad.AutoSize = true;
            this.Lbl_Contabilidad.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Contabilidad.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Contabilidad.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Contabilidad.Location = new System.Drawing.Point(42, 5);
            this.Lbl_Contabilidad.Name = "Lbl_Contabilidad";
            this.Lbl_Contabilidad.Size = new System.Drawing.Size(297, 32);
            this.Lbl_Contabilidad.TabIndex = 5;
            this.Lbl_Contabilidad.Text = "1410_Cierre Contable";
            // 
            // Btn_Cerrar
            // 
            this.Btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(192)))), ((int)(((byte)(195)))));
            this.Btn_Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Cerrar.Image")));
            this.Btn_Cerrar.Location = new System.Drawing.Point(892, 0);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Size = new System.Drawing.Size(41, 41);
            this.Btn_Cerrar.TabIndex = 3;
            this.Btn_Cerrar.UseVisualStyleBackColor = false;
            this.Btn_Cerrar.Click += new System.EventHandler(this.Btn_Cerrar_Click);
            // 
            // Btn_Logo
            // 
            this.Btn_Logo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Logo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(192)))), ((int)(((byte)(195)))));
            this.Btn_Logo.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Logo.Image")));
            this.Btn_Logo.Location = new System.Drawing.Point(0, 0);
            this.Btn_Logo.Name = "Btn_Logo";
            this.Btn_Logo.Size = new System.Drawing.Size(41, 41);
            this.Btn_Logo.TabIndex = 9;
            this.Btn_Logo.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(30, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(881, 109);
            this.panel2.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(672, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Mostrar Cuentas";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel7.Controls.Add(this.label8);
            this.panel7.Controls.Add(this.dtm_fechafin);
            this.panel7.Controls.Add(this.dtm_fechainicio);
            this.panel7.Controls.Add(this.label7);
            this.panel7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel7.Location = new System.Drawing.Point(89, 8);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(208, 93);
            this.panel7.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Fecha de Fin:";
            // 
            // dtm_fechafin
            // 
            this.dtm_fechafin.Location = new System.Drawing.Point(3, 70);
            this.dtm_fechafin.Name = "dtm_fechafin";
            this.dtm_fechafin.Size = new System.Drawing.Size(200, 20);
            this.dtm_fechafin.TabIndex = 2;
            // 
            // dtm_fechainicio
            // 
            this.dtm_fechainicio.Location = new System.Drawing.Point(3, 28);
            this.dtm_fechainicio.Name = "dtm_fechainicio";
            this.dtm_fechainicio.Size = new System.Drawing.Size(200, 20);
            this.dtm_fechainicio.TabIndex = 1;
            this.dtm_fechainicio.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Fecha de Inicio:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.Controls.Add(this.radioButton2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(378, 11);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(208, 90);
            this.panel3.TabIndex = 13;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(16, 47);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(104, 17);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Generar Reporte";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Opcionalidades:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(635, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 30);
            this.button1.TabIndex = 13;
            this.button1.Text = "Realizar Cierre Contable";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.navegador1.DataGr = null;
            this.navegador1.Location = new System.Drawing.Point(39, 48);
            this.navegador1.Name = "navegador1";
            this.navegador1.Procedimiento = null;
            this.navegador1.pubNombrechm = null;
            this.navegador1.pubNombreHtml = null;
            this.navegador1.Size = new System.Drawing.Size(857, 60);
            this.navegador1.TabIndex = 13;
            // 
            // CierreContable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(207)))), ((int)(((byte)(248)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(933, 700);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgv_tablaCierreContable);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CierreContable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CierreContable";
            this.Load += new System.EventHandler(this.CierreContable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tablaCierreContable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_tablaCierreContable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lbl_Contabilidad;
        private System.Windows.Forms.Button Btn_Cerrar;
        private System.Windows.Forms.Button Btn_Logo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtm_fechafin;
        private System.Windows.Forms.DateTimePicker dtm_fechainicio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn asdf1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ab;
        private System.Windows.Forms.DataGridViewTextBoxColumn abc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ca;
        private System.Windows.Forms.DataGridViewTextBoxColumn cac;
        private System.Windows.Forms.DataGridViewTextBoxColumn saan;
        private System.Windows.Forms.DataGridViewTextBoxColumn saac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Button button2;
        private CapaDiseno.Navegador navegador1;
    }
}