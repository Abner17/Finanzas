namespace Contabilidad
{
    partial class Frm_M_Impuestos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_M_Impuestos));
            this.pnl_Mantenimientos = new System.Windows.Forms.Panel();
            this.Lbl_Contabilidad = new System.Windows.Forms.Label();
            this.Btn_Logo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.navegador1 = new CapaDiseno.Navegador();
            this.gpd_datos = new System.Windows.Forms.GroupBox();
            this.txt_Porcentaje = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Codigo = new System.Windows.Forms.TextBox();
            this.lbl_porcentaje = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_Codigo = new System.Windows.Forms.Label();
            this.pnl_Mantenimientos.SuspendLayout();
            this.gpd_datos.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Mantenimientos
            // 
            this.pnl_Mantenimientos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.pnl_Mantenimientos.Controls.Add(this.Lbl_Contabilidad);
            this.pnl_Mantenimientos.Controls.Add(this.Btn_Logo);
            this.pnl_Mantenimientos.Location = new System.Drawing.Point(-4, -1);
            this.pnl_Mantenimientos.Name = "pnl_Mantenimientos";
            this.pnl_Mantenimientos.Size = new System.Drawing.Size(939, 58);
            this.pnl_Mantenimientos.TabIndex = 0;
            // 
            // Lbl_Contabilidad
            // 
            this.Lbl_Contabilidad.AutoSize = true;
            this.Lbl_Contabilidad.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Contabilidad.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Contabilidad.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Contabilidad.Location = new System.Drawing.Point(76, 12);
            this.Lbl_Contabilidad.Name = "Lbl_Contabilidad";
            this.Lbl_Contabilidad.Size = new System.Drawing.Size(295, 32);
            this.Lbl_Contabilidad.TabIndex = 14;
            this.Lbl_Contabilidad.Text = "1600_Mantenimientos";
            // 
            // Btn_Logo
            // 
            this.Btn_Logo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Logo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.Btn_Logo.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Logo.Image")));
            this.Btn_Logo.Location = new System.Drawing.Point(29, 3);
            this.Btn_Logo.Name = "Btn_Logo";
            this.Btn_Logo.Size = new System.Drawing.Size(41, 41);
            this.Btn_Logo.TabIndex = 12;
            this.Btn_Logo.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(388, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 32);
            this.label1.TabIndex = 14;
            this.label1.Text = "Impuestos";
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.navegador1.Forma = this;
            this.navegador1.Location = new System.Drawing.Point(34, 157);
            this.navegador1.Name = "navegador1";
            this.navegador1.Procedimiento = null;
            this.navegador1.Size = new System.Drawing.Size(858, 55);
            this.navegador1.TabIndex = 15;
            // 
            // gpd_datos
            // 
            this.gpd_datos.Controls.Add(this.txt_Porcentaje);
            this.gpd_datos.Controls.Add(this.txt_Nombre);
            this.gpd_datos.Controls.Add(this.txt_Codigo);
            this.gpd_datos.Controls.Add(this.lbl_porcentaje);
            this.gpd_datos.Controls.Add(this.lbl_nombre);
            this.gpd_datos.Controls.Add(this.lbl_Codigo);
            this.gpd_datos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpd_datos.Location = new System.Drawing.Point(321, 345);
            this.gpd_datos.Name = "gpd_datos";
            this.gpd_datos.Size = new System.Drawing.Size(263, 203);
            this.gpd_datos.TabIndex = 17;
            this.gpd_datos.TabStop = false;
            this.gpd_datos.Text = "Datos";
            // 
            // txt_Porcentaje
            // 
            this.txt_Porcentaje.Location = new System.Drawing.Point(106, 142);
            this.txt_Porcentaje.Name = "txt_Porcentaje";
            this.txt_Porcentaje.Size = new System.Drawing.Size(141, 20);
            this.txt_Porcentaje.TabIndex = 5;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(106, 88);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(141, 20);
            this.txt_Nombre.TabIndex = 4;
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.Location = new System.Drawing.Point(106, 41);
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.Size = new System.Drawing.Size(141, 20);
            this.txt_Codigo.TabIndex = 3;
            // 
            // lbl_porcentaje
            // 
            this.lbl_porcentaje.AutoSize = true;
            this.lbl_porcentaje.Location = new System.Drawing.Point(13, 145);
            this.lbl_porcentaje.Name = "lbl_porcentaje";
            this.lbl_porcentaje.Size = new System.Drawing.Size(68, 13);
            this.lbl_porcentaje.TabIndex = 2;
            this.lbl_porcentaje.Text = "Porcentaje";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(27, 95);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(50, 13);
            this.lbl_nombre.TabIndex = 1;
            this.lbl_nombre.Text = "Nombre";
            // 
            // lbl_Codigo
            // 
            this.lbl_Codigo.AutoSize = true;
            this.lbl_Codigo.Location = new System.Drawing.Point(27, 44);
            this.lbl_Codigo.Name = "lbl_Codigo";
            this.lbl_Codigo.Size = new System.Drawing.Size(46, 13);
            this.lbl_Codigo.TabIndex = 0;
            this.lbl_Codigo.Text = "Codigo";
            // 
            // Frm_M_Impuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 700);
            this.Controls.Add(this.gpd_datos);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnl_Mantenimientos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_M_Impuestos";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Frm_M_Impuestos_Load);
            this.pnl_Mantenimientos.ResumeLayout(false);
            this.pnl_Mantenimientos.PerformLayout();
            this.gpd_datos.ResumeLayout(false);
            this.gpd_datos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Mantenimientos;
        private System.Windows.Forms.Button Btn_Logo;
        private System.Windows.Forms.Label Lbl_Contabilidad;
        private System.Windows.Forms.Label label1;
        private CapaDiseno.Navegador navegador1;
        private System.Windows.Forms.GroupBox gpd_datos;
        private System.Windows.Forms.TextBox txt_Porcentaje;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_Codigo;
        private System.Windows.Forms.Label lbl_porcentaje;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_Codigo;
    }
}