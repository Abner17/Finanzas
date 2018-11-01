namespace BancosFinalProt
{
    partial class Frm_VisorConciliacionBancaria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_VisorConciliacionBancaria));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Cerrar = new System.Windows.Forms.Button();
            this.Lbl_VisorConciliacionBancaria = new System.Windows.Forms.Label();
            this.Pic_Logo = new System.Windows.Forms.Button();
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.Lbl_NumeroMovimientos = new System.Windows.Forms.Label();
            this.Lbl_Movimientos = new System.Windows.Forms.Label();
            this.Lbl_EstadodeCuenta = new System.Windows.Forms.Label();
            this.Lbl_MovimientosBancarios = new System.Windows.Forms.Label();
            this.Dgv_CierreContable = new System.Windows.Forms.DataGridView();
            this.Btn_Minimizar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_CierreContable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(147)))), ((int)(((byte)(125)))));
            this.panel1.Controls.Add(this.Btn_Cerrar);
            this.panel1.Controls.Add(this.Lbl_VisorConciliacionBancaria);
            this.panel1.Controls.Add(this.Pic_Logo);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 42);
            this.panel1.TabIndex = 0;
            // 
            // Btn_Cerrar
            // 
            this.Btn_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(147)))), ((int)(((byte)(125)))));
            this.Btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(147)))), ((int)(((byte)(125)))));
            this.Btn_Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Cerrar.Image")));
            this.Btn_Cerrar.Location = new System.Drawing.Point(885, 1);
            this.Btn_Cerrar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Size = new System.Drawing.Size(45, 39);
            this.Btn_Cerrar.TabIndex = 16;
            this.Btn_Cerrar.UseVisualStyleBackColor = false;
            this.Btn_Cerrar.Click += new System.EventHandler(this.Btn_Cerrar_Click);
            // 
            // Lbl_VisorConciliacionBancaria
            // 
            this.Lbl_VisorConciliacionBancaria.AutoSize = true;
            this.Lbl_VisorConciliacionBancaria.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_VisorConciliacionBancaria.Location = new System.Drawing.Point(51, 5);
            this.Lbl_VisorConciliacionBancaria.Name = "Lbl_VisorConciliacionBancaria";
            this.Lbl_VisorConciliacionBancaria.Size = new System.Drawing.Size(492, 32);
            this.Lbl_VisorConciliacionBancaria.TabIndex = 15;
            this.Lbl_VisorConciliacionBancaria.Text = "6210_Visor de Conciliacion Bancaria";
            // 
            // Pic_Logo
            // 
            this.Pic_Logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(147)))), ((int)(((byte)(125)))));
            this.Pic_Logo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pic_Logo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(147)))), ((int)(((byte)(125)))));
            this.Pic_Logo.Image = ((System.Drawing.Image)(resources.GetObject("Pic_Logo.Image")));
            this.Pic_Logo.Location = new System.Drawing.Point(2, 4);
            this.Pic_Logo.Margin = new System.Windows.Forms.Padding(2);
            this.Pic_Logo.Name = "Pic_Logo";
            this.Pic_Logo.Size = new System.Drawing.Size(38, 33);
            this.Pic_Logo.TabIndex = 14;
            this.Pic_Logo.UseVisualStyleBackColor = false;
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(561, 108);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(365, 562);
            this.axAcroPDF1.TabIndex = 25;
            this.axAcroPDF1.Enter += new System.EventHandler(this.axAcroPDF1_Enter);
            // 
            // Lbl_NumeroMovimientos
            // 
            this.Lbl_NumeroMovimientos.AutoSize = true;
            this.Lbl_NumeroMovimientos.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NumeroMovimientos.Location = new System.Drawing.Point(100, 675);
            this.Lbl_NumeroMovimientos.Name = "Lbl_NumeroMovimientos";
            this.Lbl_NumeroMovimientos.Size = new System.Drawing.Size(15, 16);
            this.Lbl_NumeroMovimientos.TabIndex = 24;
            this.Lbl_NumeroMovimientos.Text = "0";
            // 
            // Lbl_Movimientos
            // 
            this.Lbl_Movimientos.AutoSize = true;
            this.Lbl_Movimientos.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Movimientos.Location = new System.Drawing.Point(12, 675);
            this.Lbl_Movimientos.Name = "Lbl_Movimientos";
            this.Lbl_Movimientos.Size = new System.Drawing.Size(82, 16);
            this.Lbl_Movimientos.TabIndex = 23;
            this.Lbl_Movimientos.Text = "Movimientos";
            // 
            // Lbl_EstadodeCuenta
            // 
            this.Lbl_EstadodeCuenta.AutoSize = true;
            this.Lbl_EstadodeCuenta.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_EstadodeCuenta.Location = new System.Drawing.Point(561, 73);
            this.Lbl_EstadodeCuenta.Name = "Lbl_EstadodeCuenta";
            this.Lbl_EstadodeCuenta.Size = new System.Drawing.Size(374, 32);
            this.Lbl_EstadodeCuenta.TabIndex = 22;
            this.Lbl_EstadodeCuenta.Text = "Estado de Cuenta Bancario";
            // 
            // Lbl_MovimientosBancarios
            // 
            this.Lbl_MovimientosBancarios.AutoSize = true;
            this.Lbl_MovimientosBancarios.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_MovimientosBancarios.Location = new System.Drawing.Point(124, 73);
            this.Lbl_MovimientosBancarios.Name = "Lbl_MovimientosBancarios";
            this.Lbl_MovimientosBancarios.Size = new System.Drawing.Size(323, 32);
            this.Lbl_MovimientosBancarios.TabIndex = 21;
            this.Lbl_MovimientosBancarios.Text = "Movimientos Bancarios ";
            this.Lbl_MovimientosBancarios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Dgv_CierreContable
            // 
            this.Dgv_CierreContable.AllowUserToDeleteRows = false;
            this.Dgv_CierreContable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_CierreContable.Location = new System.Drawing.Point(9, 108);
            this.Dgv_CierreContable.Name = "Dgv_CierreContable";
            this.Dgv_CierreContable.ReadOnly = true;
            this.Dgv_CierreContable.Size = new System.Drawing.Size(540, 564);
            this.Dgv_CierreContable.TabIndex = 20;
            this.Dgv_CierreContable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_CierreContable_CellContentClick);
            // 
            // Btn_Minimizar
            // 
            this.Btn_Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Minimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(147)))), ((int)(((byte)(125)))));
            this.Btn_Minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Minimizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(147)))), ((int)(((byte)(125)))));
            this.Btn_Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Minimizar.Image")));
            this.Btn_Minimizar.Location = new System.Drawing.Point(848, 0);
            this.Btn_Minimizar.Name = "Btn_Minimizar";
            this.Btn_Minimizar.Size = new System.Drawing.Size(41, 41);
            this.Btn_Minimizar.TabIndex = 17;
            this.Btn_Minimizar.UseVisualStyleBackColor = false;
            this.Btn_Minimizar.Click += new System.EventHandler(this.Btn_Minimizar_Click);
            // 
            // Frm_VisorConciliacionBancaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 700);
            this.Controls.Add(this.Btn_Minimizar);
            this.Controls.Add(this.axAcroPDF1);
            this.Controls.Add(this.Lbl_NumeroMovimientos);
            this.Controls.Add(this.Lbl_Movimientos);
            this.Controls.Add(this.Lbl_EstadodeCuenta);
            this.Controls.Add(this.Lbl_MovimientosBancarios);
            this.Controls.Add(this.Dgv_CierreContable);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_VisorConciliacionBancaria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_VisorConciliacionBancaria";
            this.Load += new System.EventHandler(this.Frm_VisorConciliacionBancaria_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_CierreContable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_Cerrar;
        private System.Windows.Forms.Label Lbl_VisorConciliacionBancaria;
        private System.Windows.Forms.Button Pic_Logo;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
        private System.Windows.Forms.Label Lbl_NumeroMovimientos;
        private System.Windows.Forms.Label Lbl_Movimientos;
        private System.Windows.Forms.Label Lbl_EstadodeCuenta;
        private System.Windows.Forms.Label Lbl_MovimientosBancarios;
        private System.Windows.Forms.DataGridView Dgv_CierreContable;
        private System.Windows.Forms.Button Btn_Minimizar;
    }
}