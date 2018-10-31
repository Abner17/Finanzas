namespace BancosFinalProt
{
    partial class Frm_M_ConceptoBancario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_M_ConceptoBancario));
            this.pnl_ManBancos = new System.Windows.Forms.Panel();
            this.Lbl_Modulo = new System.Windows.Forms.Label();
            this.Btn_Logo = new System.Windows.Forms.Button();
            this.lbl_ConceptoB = new System.Windows.Forms.Label();
            this.gpb_Concepto = new System.Windows.Forms.GroupBox();
            this.cbo_tipo = new System.Windows.Forms.ComboBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.lbl_tipo = new System.Windows.Forms.Label();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.navegador1 = new CapaDiseno.Navegador();
            this.pnl_ManBancos.SuspendLayout();
            this.gpb_Concepto.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_ManBancos
            // 
            this.pnl_ManBancos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.pnl_ManBancos.Controls.Add(this.Lbl_Modulo);
            this.pnl_ManBancos.Controls.Add(this.Btn_Logo);
            this.pnl_ManBancos.Location = new System.Drawing.Point(-1, -1);
            this.pnl_ManBancos.Name = "pnl_ManBancos";
            this.pnl_ManBancos.Size = new System.Drawing.Size(935, 47);
            this.pnl_ManBancos.TabIndex = 0;
            // 
            // Lbl_Modulo
            // 
            this.Lbl_Modulo.AutoSize = true;
            this.Lbl_Modulo.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Modulo.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Modulo.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Modulo.Location = new System.Drawing.Point(60, 10);
            this.Lbl_Modulo.Name = "Lbl_Modulo";
            this.Lbl_Modulo.Size = new System.Drawing.Size(157, 23);
            this.Lbl_Modulo.TabIndex = 9;
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
            this.Btn_Logo.TabIndex = 8;
            this.Btn_Logo.UseVisualStyleBackColor = false;
            // 
            // lbl_ConceptoB
            // 
            this.lbl_ConceptoB.AutoSize = true;
            this.lbl_ConceptoB.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ConceptoB.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ConceptoB.ForeColor = System.Drawing.Color.Black;
            this.lbl_ConceptoB.Location = new System.Drawing.Point(335, 76);
            this.lbl_ConceptoB.Name = "lbl_ConceptoB";
            this.lbl_ConceptoB.Size = new System.Drawing.Size(191, 23);
            this.lbl_ConceptoB.TabIndex = 9;
            this.lbl_ConceptoB.Text = "Concepto Bancario";
            // 
            // gpb_Concepto
            // 
            this.gpb_Concepto.Controls.Add(this.cbo_tipo);
            this.gpb_Concepto.Controls.Add(this.txt_codigo);
            this.gpb_Concepto.Controls.Add(this.lbl_tipo);
            this.gpb_Concepto.Controls.Add(this.lbl_codigo);
            this.gpb_Concepto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_Concepto.Location = new System.Drawing.Point(339, 365);
            this.gpb_Concepto.Name = "gpb_Concepto";
            this.gpb_Concepto.Size = new System.Drawing.Size(271, 114);
            this.gpb_Concepto.TabIndex = 12;
            this.gpb_Concepto.TabStop = false;
            this.gpb_Concepto.Text = "Datos";
            // 
            // cbo_tipo
            // 
            this.cbo_tipo.FormattingEnabled = true;
            this.cbo_tipo.Location = new System.Drawing.Point(140, 73);
            this.cbo_tipo.Name = "cbo_tipo";
            this.cbo_tipo.Size = new System.Drawing.Size(100, 21);
            this.cbo_tipo.TabIndex = 3;
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(140, 37);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(100, 20);
            this.txt_codigo.TabIndex = 2;
            // 
            // lbl_tipo
            // 
            this.lbl_tipo.AutoSize = true;
            this.lbl_tipo.Location = new System.Drawing.Point(29, 81);
            this.lbl_tipo.Name = "lbl_tipo";
            this.lbl_tipo.Size = new System.Drawing.Size(90, 13);
            this.lbl_tipo.TabIndex = 1;
            this.lbl_tipo.Text = "Tipo Concepto";
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Location = new System.Drawing.Point(66, 40);
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
            this.navegador1.Location = new System.Drawing.Point(31, 161);
            this.navegador1.Name = "navegador1";
            this.navegador1.Procedimiento = null;
            this.navegador1.Size = new System.Drawing.Size(857, 60);
            this.navegador1.TabIndex = 13;
            // 
            // Frm_M_ConceptoBancario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 700);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.gpb_Concepto);
            this.Controls.Add(this.lbl_ConceptoB);
            this.Controls.Add(this.pnl_ManBancos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_M_ConceptoBancario";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Frm_M_ConceptoBancario_Load);
            this.pnl_ManBancos.ResumeLayout(false);
            this.pnl_ManBancos.PerformLayout();
            this.gpb_Concepto.ResumeLayout(false);
            this.gpb_Concepto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_ManBancos;
        private System.Windows.Forms.Button Btn_Logo;
        private System.Windows.Forms.Label Lbl_Modulo;
        private System.Windows.Forms.Label lbl_ConceptoB;
        private System.Windows.Forms.GroupBox gpb_Concepto;
        private System.Windows.Forms.ComboBox cbo_tipo;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label lbl_tipo;
        private System.Windows.Forms.Label lbl_codigo;
        private CapaDiseno.Navegador navegador1;
    }
}