namespace BancosFinalProt
{
    partial class Frm_M_cuentaBancaria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_M_cuentaBancaria));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.navegador1 = new CapaDiseno.Navegador();
            this.txt_nombreBancos = new System.Windows.Forms.TextBox();
            this.txt_numeroCuenta = new System.Windows.Forms.TextBox();
            this.lbl_nombreBan = new System.Windows.Forms.Label();
            this.lbl_numeroC = new System.Windows.Forms.Label();
            this.lbl_CuentaBancaria = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(919, 48);
            this.panel1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(62, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Mantenimientos";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(15, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 41);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.navegador1.DataGr = null;
            this.navegador1.Forma = this;
            this.navegador1.Location = new System.Drawing.Point(48, 219);
            this.navegador1.Name = "navegador1";
            this.navegador1.Procedimiento = null;
            this.navegador1.pubNombrechm = null;
            this.navegador1.pubNombreHtml = null;
            this.navegador1.Size = new System.Drawing.Size(857, 60);
            this.navegador1.TabIndex = 14;
            // 
            // txt_nombreBancos
            // 
            this.txt_nombreBancos.Location = new System.Drawing.Point(478, 442);
            this.txt_nombreBancos.Name = "txt_nombreBancos";
            this.txt_nombreBancos.Size = new System.Drawing.Size(89, 20);
            this.txt_nombreBancos.TabIndex = 18;
            this.txt_nombreBancos.Tag = "2";
            // 
            // txt_numeroCuenta
            // 
            this.txt_numeroCuenta.Location = new System.Drawing.Point(478, 416);
            this.txt_numeroCuenta.Name = "txt_numeroCuenta";
            this.txt_numeroCuenta.Size = new System.Drawing.Size(89, 20);
            this.txt_numeroCuenta.TabIndex = 17;
            this.txt_numeroCuenta.Tag = "1";
            // 
            // lbl_nombreBan
            // 
            this.lbl_nombreBan.AutoSize = true;
            this.lbl_nombreBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombreBan.Location = new System.Drawing.Point(361, 452);
            this.lbl_nombreBan.Name = "lbl_nombreBan";
            this.lbl_nombreBan.Size = new System.Drawing.Size(90, 13);
            this.lbl_nombreBan.TabIndex = 16;
            this.lbl_nombreBan.Text = "Nombre Banco";
            // 
            // lbl_numeroC
            // 
            this.lbl_numeroC.AutoSize = true;
            this.lbl_numeroC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numeroC.Location = new System.Drawing.Point(361, 416);
            this.lbl_numeroC.Name = "lbl_numeroC";
            this.lbl_numeroC.Size = new System.Drawing.Size(94, 13);
            this.lbl_numeroC.TabIndex = 15;
            this.lbl_numeroC.Text = "Numero Cuenta";
            // 
            // lbl_CuentaBancaria
            // 
            this.lbl_CuentaBancaria.AutoSize = true;
            this.lbl_CuentaBancaria.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CuentaBancaria.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CuentaBancaria.ForeColor = System.Drawing.Color.Black;
            this.lbl_CuentaBancaria.Location = new System.Drawing.Point(400, 106);
            this.lbl_CuentaBancaria.Name = "lbl_CuentaBancaria";
            this.lbl_CuentaBancaria.Size = new System.Drawing.Size(167, 23);
            this.lbl_CuentaBancaria.TabIndex = 19;
            this.lbl_CuentaBancaria.Text = "Cuenta Bancaria";
            // 
            // Frm_M_cuentaBancaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 661);
            this.Controls.Add(this.lbl_CuentaBancaria);
            this.Controls.Add(this.txt_nombreBancos);
            this.Controls.Add(this.txt_numeroCuenta);
            this.Controls.Add(this.lbl_nombreBan);
            this.Controls.Add(this.lbl_numeroC);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_M_cuentaBancaria";
            this.Text = "Frm_M_cuentaBancaria";
            this.Load += new System.EventHandler(this.Frm_M_cuentaBancaria_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private CapaDiseno.Navegador navegador1;
        private System.Windows.Forms.Label lbl_CuentaBancaria;
        private System.Windows.Forms.TextBox txt_nombreBancos;
        private System.Windows.Forms.TextBox txt_numeroCuenta;
        private System.Windows.Forms.Label lbl_nombreBan;
        private System.Windows.Forms.Label lbl_numeroC;
    }
}