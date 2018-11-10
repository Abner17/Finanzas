namespace prueba444
{
    partial class principal2
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.textEstatus = new System.Windows.Forms.TextBox();
            this.txtNick = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.dgr1 = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.navegador1 = new CapaDiseno.Navegador();
            ((System.ComponentModel.ISupportInitialize)(this.dgr1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(131, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "ESTATUS:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "CONTRASEÑA:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "NICKNAME:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(203, 151);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 29;
            this.txtCodigo.Tag = "1";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(139, 154);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(52, 13);
            this.lbl.TabIndex = 28;
            this.lbl.Text = "CODIGO:";
            // 
            // textEstatus
            // 
            this.textEstatus.Location = new System.Drawing.Point(203, 280);
            this.textEstatus.Name = "textEstatus";
            this.textEstatus.Size = new System.Drawing.Size(100, 20);
            this.textEstatus.TabIndex = 35;
            this.textEstatus.Tag = "4";
            // 
            // txtNick
            // 
            this.txtNick.Location = new System.Drawing.Point(203, 199);
            this.txtNick.Name = "txtNick";
            this.txtNick.Size = new System.Drawing.Size(100, 20);
            this.txtNick.TabIndex = 33;
            this.txtNick.Tag = "2";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(203, 241);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(100, 20);
            this.txtContraseña.TabIndex = 36;
            this.txtContraseña.Tag = "3";
            // 
            // dgr1
            // 
            this.dgr1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgr1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.descripcion,
            this.Nombre,
            this.Estatus});
            this.dgr1.Location = new System.Drawing.Point(383, 132);
            this.dgr1.Name = "dgr1";
            this.dgr1.Size = new System.Drawing.Size(449, 266);
            this.dgr1.TabIndex = 37;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "cod";
            this.Codigo.Name = "Codigo";
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "descrip";
            this.descripcion.Name = "descripcion";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "nombreModulo";
            this.Nombre.Name = "Nombre";
            // 
            // Estatus
            // 
            this.Estatus.HeaderText = "status";
            this.Estatus.Name = "Estatus";
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.navegador1.DataGr = null;
            this.navegador1.Location = new System.Drawing.Point(12, 12);
            this.navegador1.Name = "navegador1";
            this.navegador1.Procedimiento = null;
            this.navegador1.pubNombrechm = null;
            this.navegador1.pubNombreHtml = null;
            this.navegador1.Size = new System.Drawing.Size(857, 60);
            this.navegador1.TabIndex = 0;
            // 
            // principal2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 450);
            this.Controls.Add(this.dgr1);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.textEstatus);
            this.Controls.Add(this.txtNick);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.navegador1);
            this.Name = "principal2";
            this.Text = "principal2";
            this.Load += new System.EventHandler(this.principal2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgr1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CapaDiseno.Navegador navegador1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox textEstatus;
        private System.Windows.Forms.TextBox txtNick;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.DataGridView dgr1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estatus;
    }
}