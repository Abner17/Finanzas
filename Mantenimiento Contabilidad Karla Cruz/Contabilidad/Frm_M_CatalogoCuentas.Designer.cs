namespace Contabilidad
{
    partial class Frm_M_CatalogoCuentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_M_CatalogoCuentas));
            this.Pnl_Mantenimientos = new System.Windows.Forms.FlowLayoutPanel();
            this.Btn_Logo = new System.Windows.Forms.Button();
            this.Lbl_Contabilidad = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.navegador1 = new CapaDiseno.Navegador();
            this.gpb_Cuentas = new System.Windows.Forms.GroupBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Codigo = new System.Windows.Forms.TextBox();
            this.cbo_Tipo = new System.Windows.Forms.ComboBox();
            this.lbl_Codigo = new System.Windows.Forms.Label();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_Tipo = new System.Windows.Forms.Label();
            this.Pnl_Mantenimientos.SuspendLayout();
            this.gpb_Cuentas.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_Mantenimientos
            // 
            this.Pnl_Mantenimientos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.Pnl_Mantenimientos.Controls.Add(this.Btn_Logo);
            this.Pnl_Mantenimientos.Controls.Add(this.Lbl_Contabilidad);
            this.Pnl_Mantenimientos.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Mantenimientos.Name = "Pnl_Mantenimientos";
            this.Pnl_Mantenimientos.Size = new System.Drawing.Size(935, 48);
            this.Pnl_Mantenimientos.TabIndex = 0;
            // 
            // Btn_Logo
            // 
            this.Btn_Logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.Btn_Logo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Logo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.Btn_Logo.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Logo.Image")));
            this.Btn_Logo.Location = new System.Drawing.Point(3, 3);
            this.Btn_Logo.Name = "Btn_Logo";
            this.Btn_Logo.Size = new System.Drawing.Size(41, 41);
            this.Btn_Logo.TabIndex = 9;
            this.Btn_Logo.UseVisualStyleBackColor = false;
            // 
            // Lbl_Contabilidad
            // 
            this.Lbl_Contabilidad.AutoSize = true;
            this.Lbl_Contabilidad.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Contabilidad.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Contabilidad.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Contabilidad.Location = new System.Drawing.Point(50, 0);
            this.Lbl_Contabilidad.Name = "Lbl_Contabilidad";
            this.Lbl_Contabilidad.Size = new System.Drawing.Size(295, 32);
            this.Lbl_Contabilidad.TabIndex = 12;
            this.Lbl_Contabilidad.Text = "1600_Mantenimientos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(332, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 32);
            this.label1.TabIndex = 13;
            this.label1.Text = "Catalogo de cuentas";
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.navegador1.DataGr = null;
            this.navegador1.Forma = this;
            this.navegador1.Location = new System.Drawing.Point(26, 170);
            this.navegador1.Name = "navegador1";
            this.navegador1.Procedimiento = null;
            this.navegador1.Size = new System.Drawing.Size(857, 60);
            this.navegador1.TabIndex = 14;
            // 
            // gpb_Cuentas
            // 
            this.gpb_Cuentas.Controls.Add(this.txt_Nombre);
            this.gpb_Cuentas.Controls.Add(this.txt_Codigo);
            this.gpb_Cuentas.Controls.Add(this.cbo_Tipo);
            this.gpb_Cuentas.Controls.Add(this.lbl_Codigo);
            this.gpb_Cuentas.Controls.Add(this.lbl_Nombre);
            this.gpb_Cuentas.Controls.Add(this.lbl_Tipo);
            this.gpb_Cuentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_Cuentas.Location = new System.Drawing.Point(316, 365);
            this.gpb_Cuentas.Name = "gpb_Cuentas";
            this.gpb_Cuentas.Size = new System.Drawing.Size(265, 135);
            this.gpb_Cuentas.TabIndex = 16;
            this.gpb_Cuentas.TabStop = false;
            this.gpb_Cuentas.Text = "Datos de cuentas";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(119, 62);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(121, 20);
            this.txt_Nombre.TabIndex = 22;
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.Location = new System.Drawing.Point(119, 31);
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.Size = new System.Drawing.Size(121, 20);
            this.txt_Codigo.TabIndex = 21;
            // 
            // cbo_Tipo
            // 
            this.cbo_Tipo.FormattingEnabled = true;
            this.cbo_Tipo.Location = new System.Drawing.Point(119, 93);
            this.cbo_Tipo.Name = "cbo_Tipo";
            this.cbo_Tipo.Size = new System.Drawing.Size(121, 21);
            this.cbo_Tipo.TabIndex = 20;
            // 
            // lbl_Codigo
            // 
            this.lbl_Codigo.AutoSize = true;
            this.lbl_Codigo.Location = new System.Drawing.Point(26, 38);
            this.lbl_Codigo.Name = "lbl_Codigo";
            this.lbl_Codigo.Size = new System.Drawing.Size(46, 13);
            this.lbl_Codigo.TabIndex = 19;
            this.lbl_Codigo.Text = "Codigo";
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Location = new System.Drawing.Point(22, 65);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(50, 13);
            this.lbl_Nombre.TabIndex = 18;
            this.lbl_Nombre.Text = "Nombre";
            // 
            // lbl_Tipo
            // 
            this.lbl_Tipo.AutoSize = true;
            this.lbl_Tipo.Location = new System.Drawing.Point(26, 96);
            this.lbl_Tipo.Name = "lbl_Tipo";
            this.lbl_Tipo.Size = new System.Drawing.Size(32, 13);
            this.lbl_Tipo.TabIndex = 17;
            this.lbl_Tipo.Text = "Tipo";
            // 
            // Frm_M_CatalogoCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 700);
            this.Controls.Add(this.gpb_Cuentas);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.Pnl_Mantenimientos);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_M_CatalogoCuentas";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Frm_CatalogoCuentas_Load);
            this.Pnl_Mantenimientos.ResumeLayout(false);
            this.Pnl_Mantenimientos.PerformLayout();
            this.gpb_Cuentas.ResumeLayout(false);
            this.gpb_Cuentas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel Pnl_Mantenimientos;
        private System.Windows.Forms.Button Btn_Logo;
        private System.Windows.Forms.Label label1;
        private CapaDiseno.Navegador navegador1;
        private System.Windows.Forms.GroupBox gpb_Cuentas;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_Codigo;
        private System.Windows.Forms.ComboBox cbo_Tipo;
        private System.Windows.Forms.Label lbl_Codigo;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label lbl_Tipo;
        private System.Windows.Forms.Label Lbl_Contabilidad;
    }
}