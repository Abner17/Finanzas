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
            this.pnl_ManBancos = new System.Windows.Forms.Panel();
            this.Lbl_Modulo = new System.Windows.Forms.Label();
            this.Btn_Logo = new System.Windows.Forms.Button();
            this.lbl_CuentaBancaria = new System.Windows.Forms.Label();
            this.navegador1 = new CapaDiseno.Navegador();
            this.gpb_CuentaBancaria = new System.Windows.Forms.GroupBox();
            this.txt_nombreBancos = new System.Windows.Forms.TextBox();
            this.txt_numeroCuenta = new System.Windows.Forms.TextBox();
            this.lbl_nombreBan = new System.Windows.Forms.Label();
            this.lbl_numeroC = new System.Windows.Forms.Label();
            this.pnl_ManBancos.SuspendLayout();
            this.gpb_CuentaBancaria.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_ManBancos
            // 
            this.pnl_ManBancos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.pnl_ManBancos.Controls.Add(this.Lbl_Modulo);
            this.pnl_ManBancos.Controls.Add(this.Btn_Logo);
            this.pnl_ManBancos.Location = new System.Drawing.Point(-1, 0);
            this.pnl_ManBancos.Name = "pnl_ManBancos";
            this.pnl_ManBancos.Size = new System.Drawing.Size(934, 51);
            this.pnl_ManBancos.TabIndex = 0;
            this.pnl_ManBancos.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Lbl_Modulo
            // 
            this.Lbl_Modulo.AutoSize = true;
            this.Lbl_Modulo.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Modulo.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Modulo.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Modulo.Location = new System.Drawing.Point(60, 14);
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
            this.Btn_Logo.Location = new System.Drawing.Point(13, 7);
            this.Btn_Logo.Name = "Btn_Logo";
            this.Btn_Logo.Size = new System.Drawing.Size(41, 41);
            this.Btn_Logo.TabIndex = 9;
            this.Btn_Logo.UseVisualStyleBackColor = false;
            // 
            // lbl_CuentaBancaria
            // 
            this.lbl_CuentaBancaria.AutoSize = true;
            this.lbl_CuentaBancaria.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CuentaBancaria.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CuentaBancaria.ForeColor = System.Drawing.Color.Black;
            this.lbl_CuentaBancaria.Location = new System.Drawing.Point(385, 102);
            this.lbl_CuentaBancaria.Name = "lbl_CuentaBancaria";
            this.lbl_CuentaBancaria.Size = new System.Drawing.Size(167, 23);
            this.lbl_CuentaBancaria.TabIndex = 10;
            this.lbl_CuentaBancaria.Text = "Cuenta Bancaria";
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.navegador1.Forma = this;
            this.navegador1.GridEditar = null;
            this.navegador1.Location = new System.Drawing.Point(39, 202);
            this.navegador1.Name = "navegador1";
            this.navegador1.Procedimiento = null;
            this.navegador1.Size = new System.Drawing.Size(856, 60);
            this.navegador1.TabIndex = 11;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // gpb_CuentaBancaria
            // 
            this.gpb_CuentaBancaria.Controls.Add(this.txt_nombreBancos);
            this.gpb_CuentaBancaria.Controls.Add(this.txt_numeroCuenta);
            this.gpb_CuentaBancaria.Controls.Add(this.lbl_nombreBan);
            this.gpb_CuentaBancaria.Controls.Add(this.lbl_numeroC);
            this.gpb_CuentaBancaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_CuentaBancaria.Location = new System.Drawing.Point(333, 412);
            this.gpb_CuentaBancaria.Name = "gpb_CuentaBancaria";
            this.gpb_CuentaBancaria.Size = new System.Drawing.Size(250, 100);
            this.gpb_CuentaBancaria.TabIndex = 13;
            this.gpb_CuentaBancaria.TabStop = false;
            this.gpb_CuentaBancaria.Text = "Datos";
            // 
            // txt_nombreBancos
            // 
            this.txt_nombreBancos.Location = new System.Drawing.Point(143, 62);
            this.txt_nombreBancos.Name = "txt_nombreBancos";
            this.txt_nombreBancos.Size = new System.Drawing.Size(89, 20);
            this.txt_nombreBancos.TabIndex = 3;
            // 
            // txt_numeroCuenta
            // 
            this.txt_numeroCuenta.Location = new System.Drawing.Point(143, 36);
            this.txt_numeroCuenta.Name = "txt_numeroCuenta";
            this.txt_numeroCuenta.Size = new System.Drawing.Size(89, 20);
            this.txt_numeroCuenta.TabIndex = 2;
            // 
            // lbl_nombreBan
            // 
            this.lbl_nombreBan.AutoSize = true;
            this.lbl_nombreBan.Location = new System.Drawing.Point(26, 72);
            this.lbl_nombreBan.Name = "lbl_nombreBan";
            this.lbl_nombreBan.Size = new System.Drawing.Size(90, 13);
            this.lbl_nombreBan.TabIndex = 1;
            this.lbl_nombreBan.Text = "Nombre Banco";
            // 
            // lbl_numeroC
            // 
            this.lbl_numeroC.AutoSize = true;
            this.lbl_numeroC.Location = new System.Drawing.Point(26, 36);
            this.lbl_numeroC.Name = "lbl_numeroC";
            this.lbl_numeroC.Size = new System.Drawing.Size(94, 13);
            this.lbl_numeroC.TabIndex = 0;
            this.lbl_numeroC.Text = "Numero Cuenta";
            // 
            // Frm_M_cuentaBancaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 700);
            this.Controls.Add(this.gpb_CuentaBancaria);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.lbl_CuentaBancaria);
            this.Controls.Add(this.pnl_ManBancos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_M_cuentaBancaria";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Frm_M_cuentaBancaria_Load);
            this.pnl_ManBancos.ResumeLayout(false);
            this.pnl_ManBancos.PerformLayout();
            this.gpb_CuentaBancaria.ResumeLayout(false);
            this.gpb_CuentaBancaria.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_ManBancos;
        private System.Windows.Forms.Button Btn_Logo;
        private System.Windows.Forms.Label Lbl_Modulo;
        private System.Windows.Forms.Label lbl_CuentaBancaria;
        private CapaDiseno.Navegador navegador1;
        private System.Windows.Forms.GroupBox gpb_CuentaBancaria;
        private System.Windows.Forms.TextBox txt_nombreBancos;
        private System.Windows.Forms.TextBox txt_numeroCuenta;
        private System.Windows.Forms.Label lbl_nombreBan;
        private System.Windows.Forms.Label lbl_numeroC;
    }
}