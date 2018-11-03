namespace BancosFinalProt
{
    partial class Frm_Data_Moneda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Data_Moneda));
            this.pnl_ManBancos = new System.Windows.Forms.Panel();
            this.Btn_cerrar = new System.Windows.Forms.Button();
            this.Lbl_Modulo = new System.Windows.Forms.Label();
            this.Btn_Logo = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dgr3 = new System.Windows.Forms.DataGridView();
            this.lbl_Moneda = new System.Windows.Forms.Label();
            this.pnl_ManBancos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgr3)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_ManBancos
            // 
            this.pnl_ManBancos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.pnl_ManBancos.Controls.Add(this.Btn_cerrar);
            this.pnl_ManBancos.Controls.Add(this.Lbl_Modulo);
            this.pnl_ManBancos.Controls.Add(this.Btn_Logo);
            this.pnl_ManBancos.Controls.Add(this.flowLayoutPanel1);
            this.pnl_ManBancos.Location = new System.Drawing.Point(-1, -4);
            this.pnl_ManBancos.Name = "pnl_ManBancos";
            this.pnl_ManBancos.Size = new System.Drawing.Size(981, 47);
            this.pnl_ManBancos.TabIndex = 1;
            // 
            // Btn_cerrar
            // 
            this.Btn_cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.Btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.Btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_cerrar.Image")));
            this.Btn_cerrar.Location = new System.Drawing.Point(890, 3);
            this.Btn_cerrar.Name = "Btn_cerrar";
            this.Btn_cerrar.Size = new System.Drawing.Size(41, 41);
            this.Btn_cerrar.TabIndex = 12;
            this.Btn_cerrar.UseVisualStyleBackColor = false;
            this.Btn_cerrar.Click += new System.EventHandler(this.Btn_cerrar_Click);
            // 
            // Lbl_Modulo
            // 
            this.Lbl_Modulo.AutoSize = true;
            this.Lbl_Modulo.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Modulo.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Modulo.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Modulo.Location = new System.Drawing.Point(61, 9);
            this.Lbl_Modulo.Name = "Lbl_Modulo";
            this.Lbl_Modulo.Size = new System.Drawing.Size(211, 23);
            this.Lbl_Modulo.TabIndex = 11;
            this.Lbl_Modulo.Text = "6700_Mantenimientos";
            // 
            // Btn_Logo
            // 
            this.Btn_Logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.Btn_Logo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Logo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.Btn_Logo.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Logo.Image")));
            this.Btn_Logo.Location = new System.Drawing.Point(14, 3);
            this.Btn_Logo.Name = "Btn_Logo";
            this.Btn_Logo.Size = new System.Drawing.Size(41, 41);
            this.Btn_Logo.TabIndex = 10;
            this.Btn_Logo.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(857, 91);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // dgr3
            // 
            this.dgr3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgr3.Location = new System.Drawing.Point(202, 290);
            this.dgr3.Name = "dgr3";
            this.dgr3.Size = new System.Drawing.Size(622, 268);
            this.dgr3.TabIndex = 2;
            this.dgr3.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgr3_CellDoubleClick);
            // 
            // lbl_Moneda
            // 
            this.lbl_Moneda.AutoSize = true;
            this.lbl_Moneda.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Moneda.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Moneda.ForeColor = System.Drawing.Color.Black;
            this.lbl_Moneda.Location = new System.Drawing.Point(448, 210);
            this.lbl_Moneda.Name = "lbl_Moneda";
            this.lbl_Moneda.Size = new System.Drawing.Size(134, 36);
            this.lbl_Moneda.TabIndex = 12;
            this.lbl_Moneda.Text = "Moneda";
            // 
            // Frm_Data_Moneda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 700);
            this.Controls.Add(this.lbl_Moneda);
            this.Controls.Add(this.dgr3);
            this.Controls.Add(this.pnl_ManBancos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Data_Moneda";
            this.Text = "Frm_Data_Moneda";
            this.Load += new System.EventHandler(this.Frm_Data_Moneda_Load);
            this.pnl_ManBancos.ResumeLayout(false);
            this.pnl_ManBancos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgr3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_ManBancos;
        private System.Windows.Forms.Button Btn_cerrar;
        private System.Windows.Forms.Label Lbl_Modulo;
        private System.Windows.Forms.Button Btn_Logo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView dgr3;
        private System.Windows.Forms.Label lbl_Moneda;
    }
}