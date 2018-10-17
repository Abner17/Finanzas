namespace Contabilidad
{
    partial class Frm_Polizas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Polizas));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lbl_Contabilidad = new System.Windows.Forms.Label();
            this.Btn_Cerrar = new System.Windows.Forms.Button();
            this.Btn_Logo = new System.Windows.Forms.Button();
            this.dgv_polizas = new System.Windows.Forms.DataGridView();
            this.txt_noPoliza = new System.Windows.Forms.TextBox();
            this.txt_noEmpleado = new System.Windows.Forms.TextBox();
            this.txt_nombreEmpleado = new System.Windows.Forms.TextBox();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.lbl_numeroPoliza = new System.Windows.Forms.Label();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.lbl_noEmpleado = new System.Windows.Forms.Label();
            this.lbl_nombreEmpleado = new System.Windows.Forms.Label();
            this.lbl_tipoPoliza = new System.Windows.Forms.Label();
            this.lbl_departamento = new System.Windows.Forms.Label();
            this.lbl_totalPoliza = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.navegador2 = new CapaDiseno.Navegador();
            this.dgv_estadoResultados = new System.Windows.Forms.DataGridView();
            this.dgv_estadoResultados = new System.Windows.Forms.DataGridView();
            this.Polizas = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_polizas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_estadoResultados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_estadoResultados)).BeginInit();
            this.Polizas.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(192)))), ((int)(((byte)(195)))));
            this.panel1.Controls.Add(this.Lbl_Contabilidad);
            this.panel1.Controls.Add(this.Btn_Cerrar);
            this.panel1.Controls.Add(this.Btn_Logo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1245, 52);
            this.panel1.TabIndex = 1;
            // 
            // Lbl_Contabilidad
            // 
            this.Lbl_Contabilidad.AutoSize = true;
            this.Lbl_Contabilidad.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Contabilidad.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Contabilidad.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Contabilidad.Location = new System.Drawing.Point(56, 6);
            this.Lbl_Contabilidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Contabilidad.Name = "Lbl_Contabilidad";
            this.Lbl_Contabilidad.Size = new System.Drawing.Size(220, 40);
            this.Lbl_Contabilidad.TabIndex = 5;
            this.Lbl_Contabilidad.Text = "1110_Polizas";
            // 
            // Btn_Cerrar
            // 
            this.Btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(192)))), ((int)(((byte)(195)))));
            this.Btn_Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Cerrar.Image")));
            this.Btn_Cerrar.Location = new System.Drawing.Point(1181, 0);
            this.Btn_Cerrar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Size = new System.Drawing.Size(55, 50);
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
            this.Btn_Logo.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Logo.Name = "Btn_Logo";
            this.Btn_Logo.Size = new System.Drawing.Size(55, 50);
            this.Btn_Logo.TabIndex = 9;
            this.Btn_Logo.UseVisualStyleBackColor = false;
            // 
            // dgv_polizas
            // 
            this.dgv_polizas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_polizas.Location = new System.Drawing.Point(51, 407);
            this.dgv_polizas.Name = "dgv_polizas";
            this.dgv_polizas.RowTemplate.Height = 24;
            this.dgv_polizas.Size = new System.Drawing.Size(1159, 281);
            this.dgv_polizas.TabIndex = 3;
            // 
            // txt_noPoliza
            // 
            this.txt_noPoliza.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_noPoliza.Location = new System.Drawing.Point(234, 34);
            this.txt_noPoliza.Name = "txt_noPoliza";
            this.txt_noPoliza.Size = new System.Drawing.Size(100, 26);
            this.txt_noPoliza.TabIndex = 4;
            // 
            // txt_noEmpleado
            // 
            this.txt_noEmpleado.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_noEmpleado.Location = new System.Drawing.Point(234, 97);
            this.txt_noEmpleado.Name = "txt_noEmpleado";
            this.txt_noEmpleado.Size = new System.Drawing.Size(100, 26);
            this.txt_noEmpleado.TabIndex = 6;
            // 
            // txt_nombreEmpleado
            // 
            this.txt_nombreEmpleado.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombreEmpleado.Location = new System.Drawing.Point(547, 97);
            this.txt_nombreEmpleado.Name = "txt_nombreEmpleado";
            this.txt_nombreEmpleado.Size = new System.Drawing.Size(393, 26);
            this.txt_nombreEmpleado.TabIndex = 9;
            // 
            // txt_total
            // 
            this.txt_total.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total.Location = new System.Drawing.Point(454, 209);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(127, 26);
            this.txt_total.TabIndex = 10;
            // 
            // lbl_numeroPoliza
            // 
            this.lbl_numeroPoliza.AutoSize = true;
            this.lbl_numeroPoliza.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numeroPoliza.Location = new System.Drawing.Point(31, 42);
            this.lbl_numeroPoliza.Name = "lbl_numeroPoliza";
            this.lbl_numeroPoliza.Size = new System.Drawing.Size(138, 18);
            this.lbl_numeroPoliza.TabIndex = 11;
            this.lbl_numeroPoliza.Text = "Numero de Poliza";
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha.Location = new System.Drawing.Point(365, 42);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(54, 18);
            this.lbl_fecha.TabIndex = 12;
            this.lbl_fecha.Text = "Fecha";
            // 
            // lbl_noEmpleado
            // 
            this.lbl_noEmpleado.AutoSize = true;
            this.lbl_noEmpleado.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_noEmpleado.Location = new System.Drawing.Point(30, 105);
            this.lbl_noEmpleado.Name = "lbl_noEmpleado";
            this.lbl_noEmpleado.Size = new System.Drawing.Size(171, 18);
            this.lbl_noEmpleado.TabIndex = 13;
            this.lbl_noEmpleado.Text = "Numero de Empleado";
            // 
            // lbl_nombreEmpleado
            // 
            this.lbl_nombreEmpleado.AutoSize = true;
            this.lbl_nombreEmpleado.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombreEmpleado.Location = new System.Drawing.Point(365, 105);
            this.lbl_nombreEmpleado.Name = "lbl_nombreEmpleado";
            this.lbl_nombreEmpleado.Size = new System.Drawing.Size(176, 18);
            this.lbl_nombreEmpleado.TabIndex = 16;
            this.lbl_nombreEmpleado.Text = "Nombre del Empleado";
            // 
            // lbl_tipoPoliza
            // 
            this.lbl_tipoPoliza.AutoSize = true;
            this.lbl_tipoPoliza.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipoPoliza.Location = new System.Drawing.Point(92, 160);
            this.lbl_tipoPoliza.Name = "lbl_tipoPoliza";
            this.lbl_tipoPoliza.Size = new System.Drawing.Size(109, 18);
            this.lbl_tipoPoliza.TabIndex = 15;
            this.lbl_tipoPoliza.Text = "Tipo de Poliza";
            // 
            // lbl_departamento
            // 
            this.lbl_departamento.AutoSize = true;
            this.lbl_departamento.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_departamento.Location = new System.Drawing.Point(438, 160);
            this.lbl_departamento.Name = "lbl_departamento";
            this.lbl_departamento.Size = new System.Drawing.Size(115, 18);
            this.lbl_departamento.TabIndex = 14;
            this.lbl_departamento.Text = "Departamento";
            // 
            // lbl_totalPoliza
            // 
            this.lbl_totalPoliza.AutoSize = true;
            this.lbl_totalPoliza.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalPoliza.Location = new System.Drawing.Point(318, 217);
            this.lbl_totalPoliza.Name = "lbl_totalPoliza";
            this.lbl_totalPoliza.Size = new System.Drawing.Size(113, 18);
            this.lbl_totalPoliza.TabIndex = 17;
            this.lbl_totalPoliza.Text = "Total de Poliza";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(441, 36);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(315, 26);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(234, 152);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(179, 26);
            this.comboBox1.TabIndex = 19;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(559, 152);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(179, 26);
            this.comboBox2.TabIndex = 20;
            // 
            // navegador2
            // 
            this.navegador2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            // 
            // dgv_estadoResultados
            // 
            this.dgv_estadoResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_estadoResultados.Location = new System.Drawing.Point(45, 179);
            this.dgv_estadoResultados.Name = "dgv_estadoResultados";
            this.dgv_estadoResultados.RowTemplate.Height = 24;
            this.dgv_estadoResultados.Size = new System.Drawing.Size(642, 490);
            this.dgv_estadoResultados.TabIndex = 2;
            this.navegador2.DataGr = this.dgv_estadoResultados;
            this.navegador2.Forma = this;
            this.navegador2.Location = new System.Drawing.Point(33, 69);
            this.navegador2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.navegador2.Name = "navegador2";
            this.navegador2.Procedimiento = null;
            this.navegador2.pubNombrechm = null;
            this.navegador2.pubNombreHtml = null;
            this.navegador2.Size = new System.Drawing.Size(1143, 74);
            this.navegador2.TabIndex = 21;
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
            // Polizas
            // 
            this.Polizas.Controls.Add(this.comboBox2);
            this.Polizas.Controls.Add(this.comboBox1);
            this.Polizas.Controls.Add(this.dateTimePicker1);
            this.Polizas.Controls.Add(this.lbl_totalPoliza);
            this.Polizas.Controls.Add(this.lbl_nombreEmpleado);
            this.Polizas.Controls.Add(this.lbl_tipoPoliza);
            this.Polizas.Controls.Add(this.lbl_departamento);
            this.Polizas.Controls.Add(this.lbl_noEmpleado);
            this.Polizas.Controls.Add(this.lbl_fecha);
            this.Polizas.Controls.Add(this.lbl_numeroPoliza);
            this.Polizas.Controls.Add(this.txt_total);
            this.Polizas.Controls.Add(this.txt_nombreEmpleado);
            this.Polizas.Controls.Add(this.txt_noEmpleado);
            this.Polizas.Controls.Add(this.txt_noPoliza);
            this.Polizas.Location = new System.Drawing.Point(136, 150);
            this.Polizas.Name = "Polizas";
            this.Polizas.Size = new System.Drawing.Size(958, 251);
            this.Polizas.TabIndex = 22;
            this.Polizas.TabStop = false;
            this.Polizas.Text = "Polizas";
            // 
            // Frm_Polizas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 700);
            this.Controls.Add(this.Polizas);
            this.Controls.Add(this.navegador2);
            this.Controls.Add(this.dgv_polizas);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_Polizas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Polizas";
            this.Load += new System.EventHandler(this.Frm_Polizas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_polizas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_estadoResultados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_estadoResultados)).EndInit();
            this.Polizas.ResumeLayout(false);
            this.Polizas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lbl_Contabilidad;
        private System.Windows.Forms.Button Btn_Cerrar;
        private System.Windows.Forms.Button Btn_Logo;
        private System.Windows.Forms.DataGridView dgv_polizas;
        private System.Windows.Forms.Label lbl_totalPoliza;
        private System.Windows.Forms.Label lbl_nombreEmpleado;
        private System.Windows.Forms.Label lbl_tipoPoliza;
        private System.Windows.Forms.Label lbl_departamento;
        private System.Windows.Forms.Label lbl_noEmpleado;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.Label lbl_numeroPoliza;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.TextBox txt_nombreEmpleado;
        private System.Windows.Forms.TextBox txt_noEmpleado;
        private System.Windows.Forms.TextBox txt_noPoliza;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private CapaDiseno.Navegador navegador2;
        private System.Windows.Forms.DataGridView dgv_estadoResultados;
        private System.Windows.Forms.GroupBox Polizas;
    }
}