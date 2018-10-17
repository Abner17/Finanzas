namespace BancosFinalProt
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pnl_ManBancos = new System.Windows.Forms.Panel();
            this.Btn_cerrar = new System.Windows.Forms.Button();
            this.Lbl_Modulo = new System.Windows.Forms.Label();
            this.Btn_Logo = new System.Windows.Forms.Button();
            this.dgv_ConBancario = new System.Windows.Forms.DataGridView();
            this.btn_Seleccionar = new System.Windows.Forms.Button();
            this.lbl_ConceptoBan = new System.Windows.Forms.Label();
            this.pnl_ManBancos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ConBancario)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_ManBancos
            // 
            this.pnl_ManBancos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.pnl_ManBancos.Controls.Add(this.Btn_cerrar);
            this.pnl_ManBancos.Controls.Add(this.Lbl_Modulo);
            this.pnl_ManBancos.Controls.Add(this.Btn_Logo);
            this.pnl_ManBancos.Location = new System.Drawing.Point(0, 0);
            this.pnl_ManBancos.Name = "pnl_ManBancos";
            this.pnl_ManBancos.Size = new System.Drawing.Size(918, 50);
            this.pnl_ManBancos.TabIndex = 0;
            // 
            // Btn_cerrar
            // 
            this.Btn_cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.Btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.Btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_cerrar.Image")));
            this.Btn_cerrar.Location = new System.Drawing.Point(864, 6);
            this.Btn_cerrar.Name = "Btn_cerrar";
            this.Btn_cerrar.Size = new System.Drawing.Size(41, 41);
            this.Btn_cerrar.TabIndex = 10;
            this.Btn_cerrar.UseVisualStyleBackColor = false;
            this.Btn_cerrar.Click += new System.EventHandler(this.Btn_cerrar_Click);
            // 
            // Lbl_Modulo
            // 
            this.Lbl_Modulo.AutoSize = true;
            this.Lbl_Modulo.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Modulo.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Modulo.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Modulo.Location = new System.Drawing.Point(59, 13);
            this.Lbl_Modulo.Name = "Lbl_Modulo";
            this.Lbl_Modulo.Size = new System.Drawing.Size(211, 23);
            this.Lbl_Modulo.TabIndex = 9;
            this.Lbl_Modulo.Text = "6700_Mantenimientos";
            // 
            // Btn_Logo
            // 
            this.Btn_Logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.Btn_Logo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Logo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.Btn_Logo.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Logo.Image")));
            this.Btn_Logo.Location = new System.Drawing.Point(12, 6);
            this.Btn_Logo.Name = "Btn_Logo";
            this.Btn_Logo.Size = new System.Drawing.Size(41, 41);
            this.Btn_Logo.TabIndex = 8;
            this.Btn_Logo.UseVisualStyleBackColor = false;
            // 
            // dgv_ConBancario
            // 
            this.dgv_ConBancario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ConBancario.Location = new System.Drawing.Point(238, 123);
            this.dgv_ConBancario.Name = "dgv_ConBancario";
            this.dgv_ConBancario.Size = new System.Drawing.Size(441, 294);
            this.dgv_ConBancario.TabIndex = 1;
            // 
            // btn_Seleccionar
            // 
            this.btn_Seleccionar.Location = new System.Drawing.Point(414, 500);
            this.btn_Seleccionar.Name = "btn_Seleccionar";
            this.btn_Seleccionar.Size = new System.Drawing.Size(75, 23);
            this.btn_Seleccionar.TabIndex = 2;
            this.btn_Seleccionar.Text = "Seleccionar";
            this.btn_Seleccionar.UseVisualStyleBackColor = true;
            this.btn_Seleccionar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_ConceptoBan
            // 
            this.lbl_ConceptoBan.AutoSize = true;
            this.lbl_ConceptoBan.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ConceptoBan.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ConceptoBan.ForeColor = System.Drawing.Color.Black;
            this.lbl_ConceptoBan.Location = new System.Drawing.Point(369, 81);
            this.lbl_ConceptoBan.Name = "lbl_ConceptoBan";
            this.lbl_ConceptoBan.Size = new System.Drawing.Size(191, 23);
            this.lbl_ConceptoBan.TabIndex = 11;
            this.lbl_ConceptoBan.Text = "Concepto Bancario";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 661);
            this.Controls.Add(this.lbl_ConceptoBan);
            this.Controls.Add(this.btn_Seleccionar);
            this.Controls.Add(this.dgv_ConBancario);
            this.Controls.Add(this.pnl_ManBancos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.pnl_ManBancos.ResumeLayout(false);
            this.pnl_ManBancos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ConBancario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_ManBancos;
        private System.Windows.Forms.Button Btn_Logo;
        private System.Windows.Forms.Label Lbl_Modulo;
        private System.Windows.Forms.Button Btn_cerrar;
        private System.Windows.Forms.DataGridView dgv_ConBancario;
        private System.Windows.Forms.Button btn_Seleccionar;
        private System.Windows.Forms.Label lbl_ConceptoBan;
    }
}