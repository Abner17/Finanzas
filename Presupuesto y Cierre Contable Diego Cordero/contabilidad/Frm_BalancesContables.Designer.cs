namespace Contabilidad
{
    partial class Frm_BalancesContables
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_BalancesContables));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lbl_Contabilidad = new System.Windows.Forms.Label();
            this.Btn_Cerrar = new System.Windows.Forms.Button();
            this.Btn_Logo = new System.Windows.Forms.Button();
            this.navegador1 = new CapaDiseno.Navegador();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(192)))), ((int)(((byte)(195)))));
            this.panel1.Controls.Add(this.Lbl_Contabilidad);
            this.panel1.Controls.Add(this.Btn_Cerrar);
            this.panel1.Controls.Add(this.Btn_Logo);
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 42);
            this.panel1.TabIndex = 2;
            // 
            // Lbl_Contabilidad
            // 
            this.Lbl_Contabilidad.AutoSize = true;
            this.Lbl_Contabilidad.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Contabilidad.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Contabilidad.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Contabilidad.Location = new System.Drawing.Point(42, 5);
            this.Lbl_Contabilidad.Name = "Lbl_Contabilidad";
            this.Lbl_Contabilidad.Size = new System.Drawing.Size(276, 32);
            this.Lbl_Contabilidad.TabIndex = 5;
            this.Lbl_Contabilidad.Text = "Balances Contables";
            // 
            // Btn_Cerrar
            // 
            this.Btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(192)))), ((int)(((byte)(195)))));
            this.Btn_Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Cerrar.Image")));
            this.Btn_Cerrar.Location = new System.Drawing.Point(892, 0);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Size = new System.Drawing.Size(41, 41);
            this.Btn_Cerrar.TabIndex = 3;
            this.Btn_Cerrar.UseVisualStyleBackColor = false;
            this.Btn_Cerrar.Click += new System.EventHandler(this.Btn_Cerrar_Click);
            // 
            // Btn_Logo
            // 
            this.Btn_Logo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Logo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(192)))), ((int)(((byte)(195)))));
            this.Btn_Logo.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Logo.Image")));
            this.Btn_Logo.Location = new System.Drawing.Point(0, 0);
            this.Btn_Logo.Name = "Btn_Logo";
            this.Btn_Logo.Size = new System.Drawing.Size(41, 41);
            this.Btn_Logo.TabIndex = 9;
            this.Btn_Logo.UseVisualStyleBackColor = false;
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.navegador1.DataGr = null;
            this.navegador1.Forma = null;
            this.navegador1.Location = new System.Drawing.Point(49, 47);
            this.navegador1.Name = "navegador1";
            this.navegador1.Procedimiento = null;
            this.navegador1.Size = new System.Drawing.Size(857, 60);
            this.navegador1.TabIndex = 3;
            // 
            // Frm_BalancesContables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 700);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_BalancesContables";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_BalancesContables";
            this.Load += new System.EventHandler(this.Frm_BalancesContables_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lbl_Contabilidad;
        private System.Windows.Forms.Button Btn_Cerrar;
        private System.Windows.Forms.Button Btn_Logo;
        private CapaDiseno.Navegador navegador1;
    }
}