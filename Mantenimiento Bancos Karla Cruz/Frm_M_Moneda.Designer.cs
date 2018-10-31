namespace BancosFinalProt
{
    partial class Frm_M_Moneda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_M_Moneda));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lbl_Modulo = new System.Windows.Forms.Label();
            this.Btn_Logo = new System.Windows.Forms.Button();
            this.lbl_Moneda = new System.Windows.Forms.Label();
            this.gpb_moneda = new System.Windows.Forms.GroupBox();
            this.txt_abreviatura = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.lbl_tipoCambio = new System.Windows.Forms.Label();
            this.lbl_abreviatura = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.navegador1 = new CapaDiseno.Navegador();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.gpb_moneda.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.panel1.Controls.Add(this.Lbl_Modulo);
            this.panel1.Controls.Add(this.Btn_Logo);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(939, 47);
            this.panel1.TabIndex = 0;
            // 
            // Lbl_Modulo
            // 
            this.Lbl_Modulo.AutoSize = true;
            this.Lbl_Modulo.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Modulo.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Modulo.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Modulo.Location = new System.Drawing.Point(60, 11);
            this.Lbl_Modulo.Name = "Lbl_Modulo";
            this.Lbl_Modulo.Size = new System.Drawing.Size(157, 23);
            this.Lbl_Modulo.TabIndex = 10;
            this.Lbl_Modulo.Text = "Mantenimientos";
            // 
            // Btn_Logo
            // 
            this.Btn_Logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.Btn_Logo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Logo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.Btn_Logo.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Logo.Image")));
            this.Btn_Logo.Location = new System.Drawing.Point(13, 3);
            this.Btn_Logo.Name = "Btn_Logo";
            this.Btn_Logo.Size = new System.Drawing.Size(41, 41);
            this.Btn_Logo.TabIndex = 9;
            this.Btn_Logo.UseVisualStyleBackColor = false;
            // 
            // lbl_Moneda
            // 
            this.lbl_Moneda.AutoSize = true;
            this.lbl_Moneda.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Moneda.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Moneda.ForeColor = System.Drawing.Color.Black;
            this.lbl_Moneda.Location = new System.Drawing.Point(422, 116);
            this.lbl_Moneda.Name = "lbl_Moneda";
            this.lbl_Moneda.Size = new System.Drawing.Size(88, 23);
            this.lbl_Moneda.TabIndex = 10;
            this.lbl_Moneda.Text = "Moneda";
            // 
            // gpb_moneda
            // 
            this.gpb_moneda.Controls.Add(this.textBox1);
            this.gpb_moneda.Controls.Add(this.txt_abreviatura);
            this.gpb_moneda.Controls.Add(this.txt_nombre);
            this.gpb_moneda.Controls.Add(this.txt_codigo);
            this.gpb_moneda.Controls.Add(this.lbl_tipoCambio);
            this.gpb_moneda.Controls.Add(this.lbl_abreviatura);
            this.gpb_moneda.Controls.Add(this.lbl_nombre);
            this.gpb_moneda.Controls.Add(this.lbl_codigo);
            this.gpb_moneda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_moneda.Location = new System.Drawing.Point(357, 404);
            this.gpb_moneda.Name = "gpb_moneda";
            this.gpb_moneda.Size = new System.Drawing.Size(235, 163);
            this.gpb_moneda.TabIndex = 13;
            this.gpb_moneda.TabStop = false;
            this.gpb_moneda.Text = "Datos";
            // 
            // txt_abreviatura
            // 
            this.txt_abreviatura.Location = new System.Drawing.Point(119, 90);
            this.txt_abreviatura.Name = "txt_abreviatura";
            this.txt_abreviatura.Size = new System.Drawing.Size(95, 20);
            this.txt_abreviatura.TabIndex = 6;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(119, 58);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(95, 20);
            this.txt_nombre.TabIndex = 5;
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(119, 18);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(95, 20);
            this.txt_codigo.TabIndex = 4;
            // 
            // lbl_tipoCambio
            // 
            this.lbl_tipoCambio.AutoSize = true;
            this.lbl_tipoCambio.Location = new System.Drawing.Point(13, 124);
            this.lbl_tipoCambio.Name = "lbl_tipoCambio";
            this.lbl_tipoCambio.Size = new System.Drawing.Size(77, 13);
            this.lbl_tipoCambio.TabIndex = 3;
            this.lbl_tipoCambio.Text = "Tipo Cambio";
            // 
            // lbl_abreviatura
            // 
            this.lbl_abreviatura.AutoSize = true;
            this.lbl_abreviatura.Location = new System.Drawing.Point(13, 97);
            this.lbl_abreviatura.Name = "lbl_abreviatura";
            this.lbl_abreviatura.Size = new System.Drawing.Size(72, 13);
            this.lbl_abreviatura.TabIndex = 2;
            this.lbl_abreviatura.Text = "Abreviatura";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(30, 61);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(50, 13);
            this.lbl_nombre.TabIndex = 1;
            this.lbl_nombre.Text = "Nombre";
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Location = new System.Drawing.Point(30, 25);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(46, 13);
            this.lbl_codigo.TabIndex = 0;
            this.lbl_codigo.Text = "Codigo";
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.navegador1.Forma = this;
            this.navegador1.GridEditar = null;
            this.navegador1.Location = new System.Drawing.Point(30, 203);
            this.navegador1.Name = "navegador1";
            this.navegador1.Procedimiento = null;
            this.navegador1.Size = new System.Drawing.Size(857, 60);
            this.navegador1.TabIndex = 14;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(119, 121);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(95, 20);
            this.textBox1.TabIndex = 7;
            // 
            // Frm_M_Moneda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 700);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.gpb_moneda);
            this.Controls.Add(this.lbl_Moneda);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_M_Moneda";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Frm_M_Moneda_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gpb_moneda.ResumeLayout(false);
            this.gpb_moneda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_Logo;
        private System.Windows.Forms.Label Lbl_Modulo;
        private System.Windows.Forms.Label lbl_Moneda;
        private System.Windows.Forms.GroupBox gpb_moneda;
        private System.Windows.Forms.TextBox txt_abreviatura;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label lbl_tipoCambio;
        private System.Windows.Forms.Label lbl_abreviatura;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_codigo;
        private CapaDiseno.Navegador navegador1;
        private System.Windows.Forms.TextBox textBox1;
    }
}