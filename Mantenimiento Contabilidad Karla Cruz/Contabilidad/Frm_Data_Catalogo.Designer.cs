namespace Contabilidad
{
    partial class Frm_Data_Catalogo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Data_Catalogo));
            this.pnl_Mantenimientos = new System.Windows.Forms.Panel();
            this.Btn_Cerrar = new System.Windows.Forms.Button();
            this.Lbl_Contabilidad = new System.Windows.Forms.Label();
            this.Btn_Logo = new System.Windows.Forms.Button();
            this.dgv_Cuentas = new System.Windows.Forms.DataGridView();
            this.btn_Seleccionar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_Mantenimientos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cuentas)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Mantenimientos
            // 
            this.pnl_Mantenimientos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.pnl_Mantenimientos.Controls.Add(this.Btn_Cerrar);
            this.pnl_Mantenimientos.Controls.Add(this.Lbl_Contabilidad);
            this.pnl_Mantenimientos.Controls.Add(this.Btn_Logo);
            this.pnl_Mantenimientos.Location = new System.Drawing.Point(-1, 0);
            this.pnl_Mantenimientos.Name = "pnl_Mantenimientos";
            this.pnl_Mantenimientos.Size = new System.Drawing.Size(935, 46);
            this.pnl_Mantenimientos.TabIndex = 0;
            // 
            // Btn_Cerrar
            // 
            this.Btn_Cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.Btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.Btn_Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Cerrar.Image")));
            this.Btn_Cerrar.Location = new System.Drawing.Point(859, 2);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Size = new System.Drawing.Size(41, 41);
            this.Btn_Cerrar.TabIndex = 3;
            this.Btn_Cerrar.UseVisualStyleBackColor = false;
            this.Btn_Cerrar.Click += new System.EventHandler(this.Btn_Cerrar_Click);
            // 
            // Lbl_Contabilidad
            // 
            this.Lbl_Contabilidad.AutoSize = true;
            this.Lbl_Contabilidad.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Contabilidad.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Contabilidad.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Contabilidad.Location = new System.Drawing.Point(58, 9);
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
            this.Btn_Logo.Location = new System.Drawing.Point(13, 2);
            this.Btn_Logo.Name = "Btn_Logo";
            this.Btn_Logo.Size = new System.Drawing.Size(48, 41);
            this.Btn_Logo.TabIndex = 12;
            this.Btn_Logo.UseVisualStyleBackColor = false;
            // 
            // dgv_Cuentas
            // 
            this.dgv_Cuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Cuentas.Location = new System.Drawing.Point(146, 197);
            this.dgv_Cuentas.Name = "dgv_Cuentas";
            this.dgv_Cuentas.Size = new System.Drawing.Size(632, 289);
            this.dgv_Cuentas.TabIndex = 1;
            // 
            // btn_Seleccionar
            // 
            this.btn_Seleccionar.Location = new System.Drawing.Point(434, 562);
            this.btn_Seleccionar.Name = "btn_Seleccionar";
            this.btn_Seleccionar.Size = new System.Drawing.Size(75, 23);
            this.btn_Seleccionar.TabIndex = 2;
            this.btn_Seleccionar.Text = "Seleccionar";
            this.btn_Seleccionar.UseVisualStyleBackColor = true;
            this.btn_Seleccionar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(324, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 32);
            this.label1.TabIndex = 14;
            this.label1.Text = "Catalogo de cuentas";
            // 
            // Frm_Data_Catalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 700);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Seleccionar);
            this.Controls.Add(this.dgv_Cuentas);
            this.Controls.Add(this.pnl_Mantenimientos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Data_Catalogo";
            this.Text = "Form2";
            this.pnl_Mantenimientos.ResumeLayout(false);
            this.pnl_Mantenimientos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cuentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Mantenimientos;
        private System.Windows.Forms.Button Btn_Logo;
        private System.Windows.Forms.Label Lbl_Contabilidad;
        private System.Windows.Forms.DataGridView dgv_Cuentas;
        private System.Windows.Forms.Button btn_Seleccionar;
        private System.Windows.Forms.Button Btn_Cerrar;
        private System.Windows.Forms.Label label1;
    }
}