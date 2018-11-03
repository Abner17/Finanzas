namespace Prototipo_Abner_Portillo
{
    partial class Frm_EncabezadoPolizasLocales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_EncabezadoPolizasLocales));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Cerrar = new System.Windows.Forms.Button();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.Btn_Logo = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbl_NoPoliza = new System.Windows.Forms.Label();
            this.lbl_FechaActual = new System.Windows.Forms.Label();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.txt_Total = new System.Windows.Forms.TextBox();
            this.dgv_EncPolizaDetalle = new System.Windows.Forms.DataGridView();
            this.txt_NoPoliza = new System.Windows.Forms.TextBox();
            this.navegador1 = new CapaDiseno.Navegador();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_EncPolizaDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Century Gothic", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(73, 87);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(609, 49);
            this.lbl_titulo.TabIndex = 33;
            this.lbl_titulo.Text = "Encabezado Polizas Locales";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(169)))), ((int)(((byte)(206)))));
            this.panel1.Controls.Add(this.Btn_Cerrar);
            this.panel1.Controls.Add(this.lbl_nombre);
            this.panel1.Controls.Add(this.Btn_Logo);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1244, 52);
            this.panel1.TabIndex = 32;
            // 
            // Btn_Cerrar
            // 
            this.Btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(192)))), ((int)(((byte)(195)))));
            this.Btn_Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Cerrar.Image")));
            this.Btn_Cerrar.Location = new System.Drawing.Point(1181, 1);
            this.Btn_Cerrar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Size = new System.Drawing.Size(55, 50);
            this.Btn_Cerrar.TabIndex = 12;
            this.Btn_Cerrar.UseVisualStyleBackColor = false;
            this.Btn_Cerrar.Click += new System.EventHandler(this.Btn_Cerrar_Click);
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nombre.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.ForeColor = System.Drawing.Color.Black;
            this.lbl_nombre.Location = new System.Drawing.Point(56, 7);
            this.lbl_nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(584, 40);
            this.lbl_nombre.TabIndex = 11;
            this.lbl_nombre.Text = " 1111_Encabezado Polizas Locales";
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
            this.Btn_Logo.TabIndex = 10;
            this.Btn_Logo.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(192)))), ((int)(((byte)(195)))));
            this.button2.Location = new System.Drawing.Point(1127, 1);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 50);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_NoPoliza
            // 
            this.lbl_NoPoliza.AutoSize = true;
            this.lbl_NoPoliza.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NoPoliza.Location = new System.Drawing.Point(59, 363);
            this.lbl_NoPoliza.Name = "lbl_NoPoliza";
            this.lbl_NoPoliza.Size = new System.Drawing.Size(106, 23);
            this.lbl_NoPoliza.TabIndex = 34;
            this.lbl_NoPoliza.Text = "No. Poliza";
            // 
            // lbl_FechaActual
            // 
            this.lbl_FechaActual.AutoSize = true;
            this.lbl_FechaActual.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FechaActual.Location = new System.Drawing.Point(365, 363);
            this.lbl_FechaActual.Name = "lbl_FechaActual";
            this.lbl_FechaActual.Size = new System.Drawing.Size(141, 23);
            this.lbl_FechaActual.TabIndex = 35;
            this.lbl_FechaActual.Text = "Fecha Actual";
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total.Location = new System.Drawing.Point(999, 370);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(55, 23);
            this.lbl_Total.TabIndex = 36;
            this.lbl_Total.Text = "Total";
            // 
            // txt_Total
            // 
            this.txt_Total.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Total.Location = new System.Drawing.Point(1077, 367);
            this.txt_Total.Name = "txt_Total";
            this.txt_Total.Size = new System.Drawing.Size(127, 32);
            this.txt_Total.TabIndex = 41;
            this.txt_Total.Tag = "3";
            // 
            // dgv_EncPolizaDetalle
            // 
            this.dgv_EncPolizaDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_EncPolizaDetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_EncPolizaDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_EncPolizaDetalle.Location = new System.Drawing.Point(39, 550);
            this.dgv_EncPolizaDetalle.Name = "dgv_EncPolizaDetalle";
            this.dgv_EncPolizaDetalle.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_EncPolizaDetalle.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_EncPolizaDetalle.RowTemplate.Height = 24;
            this.dgv_EncPolizaDetalle.Size = new System.Drawing.Size(1143, 300);
            this.dgv_EncPolizaDetalle.TabIndex = 47;
            this.dgv_EncPolizaDetalle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgv_EncPolizaDetalle.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dgv_EncPolizaDetalle.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            this.dgv_EncPolizaDetalle.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // txt_NoPoliza
            // 
            this.txt_NoPoliza.Enabled = false;
            this.txt_NoPoliza.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NoPoliza.Location = new System.Drawing.Point(188, 360);
            this.txt_NoPoliza.Name = "txt_NoPoliza";
            this.txt_NoPoliza.Size = new System.Drawing.Size(127, 32);
            this.txt_NoPoliza.TabIndex = 39;
            this.txt_NoPoliza.Tag = "1";
            this.txt_NoPoliza.TextChanged += new System.EventHandler(this.txt_NoPoliza_TextChanged);
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.navegador1.DataGr = null;
            this.navegador1.Forma = this;
            this.navegador1.Location = new System.Drawing.Point(39, 185);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.navegador1.Name = "navegador1";
            this.navegador1.Procedimiento = null;
            this.navegador1.pubNombrechm = null;
            this.navegador1.pubNombreHtml = null;
            this.navegador1.Size = new System.Drawing.Size(1143, 74);
            this.navegador1.TabIndex = 48;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(532, 363);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(428, 32);
            this.dateTimePicker1.TabIndex = 49;
            // 
            // Frm_EncabezadoPolizasLocales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 862);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.dgv_EncPolizaDetalle);
            this.Controls.Add(this.txt_Total);
            this.Controls.Add(this.txt_NoPoliza);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.lbl_FechaActual);
            this.Controls.Add(this.lbl_NoPoliza);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_EncabezadoPolizasLocales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_EncabezadoPolizasLocales";
            this.Load += new System.EventHandler(this.Frm_EncabezadoPolizasLocales_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_EncPolizaDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_Cerrar;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Button Btn_Logo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbl_NoPoliza;
        private System.Windows.Forms.Label lbl_FechaActual;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.TextBox txt_Total;
        private System.Windows.Forms.TextBox txt_NoPoliza;
        private System.Windows.Forms.DataGridView dgv_EncPolizaDetalle;
        private System.Windows.Forms.TextBox txt_IdDetaPoliza;
        private System.Windows.Forms.TextBox txt_IdPoliza;
        private System.Windows.Forms.TextBox txt_Abono;
        private System.Windows.Forms.TextBox txt_Cargo;
        private System.Windows.Forms.TextBox txt_NombreCuenta;
        private System.Windows.Forms.TextBox txt_IdCuenta;
        private System.Windows.Forms.Label lbl_Abono;
        private System.Windows.Forms.Label lbl_NombreCuenta;
        private System.Windows.Forms.Label lbl_Cargo;
        private System.Windows.Forms.Label lbl_IdCuenta;
        private CapaDiseno.Navegador navegador1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}