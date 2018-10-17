namespace Contabilidad
{
    partial class Frm_Data_Impuestos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Data_Impuestos));
            this.pnl_Mantenimientos = new System.Windows.Forms.Panel();
            this.Btn_Logo = new System.Windows.Forms.Button();
            this.Lbl_Contabilidad = new System.Windows.Forms.Label();
            this.Btn_Cerrar = new System.Windows.Forms.Button();
            this.dgv_Impuestos = new System.Windows.Forms.DataGridView();
            this.btn_seleccionar = new System.Windows.Forms.Button();
            this.lbl_Impuestos = new System.Windows.Forms.Label();
            this.pnl_Mantenimientos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Impuestos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Mantenimientos
            // 
            this.pnl_Mantenimientos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.pnl_Mantenimientos.Controls.Add(this.Btn_Cerrar);
            this.pnl_Mantenimientos.Controls.Add(this.Lbl_Contabilidad);
            this.pnl_Mantenimientos.Controls.Add(this.Btn_Logo);
            this.pnl_Mantenimientos.Location = new System.Drawing.Point(0, 0);
            this.pnl_Mantenimientos.Name = "pnl_Mantenimientos";
            this.pnl_Mantenimientos.Size = new System.Drawing.Size(918, 46);
            this.pnl_Mantenimientos.TabIndex = 0;
            // 
            // Btn_Logo
            // 
            this.Btn_Logo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Logo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.Btn_Logo.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Logo.Image")));
            this.Btn_Logo.Location = new System.Drawing.Point(12, 3);
            this.Btn_Logo.Name = "Btn_Logo";
            this.Btn_Logo.Size = new System.Drawing.Size(48, 41);
            this.Btn_Logo.TabIndex = 13;
            this.Btn_Logo.UseVisualStyleBackColor = false;
            // 
            // Lbl_Contabilidad
            // 
            this.Lbl_Contabilidad.AutoSize = true;
            this.Lbl_Contabilidad.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Contabilidad.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Contabilidad.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Contabilidad.Location = new System.Drawing.Point(56, 9);
            this.Lbl_Contabilidad.Name = "Lbl_Contabilidad";
            this.Lbl_Contabilidad.Size = new System.Drawing.Size(295, 32);
            this.Lbl_Contabilidad.TabIndex = 15;
            this.Lbl_Contabilidad.Text = "1600_Mantenimientos";
            // 
            // Btn_Cerrar
            // 
            this.Btn_Cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.Btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.Btn_Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Cerrar.Image")));
            this.Btn_Cerrar.Location = new System.Drawing.Point(864, 5);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Size = new System.Drawing.Size(41, 41);
            this.Btn_Cerrar.TabIndex = 4;
            this.Btn_Cerrar.UseVisualStyleBackColor = false;
            this.Btn_Cerrar.Click += new System.EventHandler(this.Btn_Cerrar_Click);
            // 
            // dgv_Impuestos
            // 
            this.dgv_Impuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Impuestos.Location = new System.Drawing.Point(227, 143);
            this.dgv_Impuestos.Name = "dgv_Impuestos";
            this.dgv_Impuestos.Size = new System.Drawing.Size(485, 298);
            this.dgv_Impuestos.TabIndex = 1;
            // 
            // btn_seleccionar
            // 
            this.btn_seleccionar.Location = new System.Drawing.Point(444, 547);
            this.btn_seleccionar.Name = "btn_seleccionar";
            this.btn_seleccionar.Size = new System.Drawing.Size(75, 23);
            this.btn_seleccionar.TabIndex = 2;
            this.btn_seleccionar.Text = "Seleccionar";
            this.btn_seleccionar.UseVisualStyleBackColor = true;
            this.btn_seleccionar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_Impuestos
            // 
            this.lbl_Impuestos.AutoSize = true;
            this.lbl_Impuestos.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Impuestos.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Impuestos.ForeColor = System.Drawing.Color.Black;
            this.lbl_Impuestos.Location = new System.Drawing.Point(384, 79);
            this.lbl_Impuestos.Name = "lbl_Impuestos";
            this.lbl_Impuestos.Size = new System.Drawing.Size(148, 32);
            this.lbl_Impuestos.TabIndex = 15;
            this.lbl_Impuestos.Text = "Impuestos";
            // 
            // Frm_Data_Impuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 661);
            this.Controls.Add(this.lbl_Impuestos);
            this.Controls.Add(this.btn_seleccionar);
            this.Controls.Add(this.dgv_Impuestos);
            this.Controls.Add(this.pnl_Mantenimientos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Data_Impuestos";
            this.Text = "Form2";
            this.pnl_Mantenimientos.ResumeLayout(false);
            this.pnl_Mantenimientos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Impuestos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Mantenimientos;
        private System.Windows.Forms.Button Btn_Logo;
        private System.Windows.Forms.Label Lbl_Contabilidad;
        private System.Windows.Forms.Button Btn_Cerrar;
        private System.Windows.Forms.DataGridView dgv_Impuestos;
        private System.Windows.Forms.Button btn_seleccionar;
        private System.Windows.Forms.Label lbl_Impuestos;
    }
}