﻿namespace BancosFinalProt
{
    partial class Mdi_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mdi_Principal));
            this.pnl_Top = new System.Windows.Forms.Panel();
            this.Lbl_Modulo = new System.Windows.Forms.Label();
            this.Btn_Logo = new System.Windows.Forms.Button();
            this.Btn_cerrar = new System.Windows.Forms.Button();
            this.Btn_Minimizar = new System.Windows.Forms.Button();
            this.Pnl_Menu = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cuentasBancariasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimientosBancariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadosCuentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depositosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retirosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transferenciasBancariasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formasDePagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_Hora = new System.Windows.Forms.Label();
            this.Lbl_Fecha = new System.Windows.Forms.Label();
            this.Lbl_Moneda = new System.Windows.Forms.Label();
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.pnl_Top.SuspendLayout();
            this.Pnl_Menu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Top
            // 
            this.pnl_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(147)))), ((int)(((byte)(125)))));
            this.pnl_Top.Controls.Add(this.Lbl_Modulo);
            this.pnl_Top.Controls.Add(this.Btn_Logo);
            this.pnl_Top.Controls.Add(this.Btn_cerrar);
            this.pnl_Top.Controls.Add(this.Btn_Minimizar);
            this.pnl_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Top.Location = new System.Drawing.Point(0, 0);
            this.pnl_Top.Name = "pnl_Top";
            this.pnl_Top.Size = new System.Drawing.Size(1371, 42);
            this.pnl_Top.TabIndex = 1;
            this.pnl_Top.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_Top_Paint);
            // 
            // Lbl_Modulo
            // 
            this.Lbl_Modulo.AutoSize = true;
            this.Lbl_Modulo.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Modulo.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Modulo.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Modulo.Location = new System.Drawing.Point(50, 14);
            this.Lbl_Modulo.Name = "Lbl_Modulo";
            this.Lbl_Modulo.Size = new System.Drawing.Size(161, 28);
            this.Lbl_Modulo.TabIndex = 8;
            this.Lbl_Modulo.Text = "1000_Bancos";
            // 
            // Btn_Logo
            // 
            this.Btn_Logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(147)))), ((int)(((byte)(125)))));
            this.Btn_Logo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Logo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(147)))), ((int)(((byte)(125)))));
            this.Btn_Logo.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Logo.Image")));
            this.Btn_Logo.Location = new System.Drawing.Point(3, 0);
            this.Btn_Logo.Name = "Btn_Logo";
            this.Btn_Logo.Size = new System.Drawing.Size(41, 41);
            this.Btn_Logo.TabIndex = 7;
            this.Btn_Logo.UseVisualStyleBackColor = false;
            // 
            // Btn_cerrar
            // 
            this.Btn_cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(147)))), ((int)(((byte)(125)))));
            this.Btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(147)))), ((int)(((byte)(125)))));
            this.Btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_cerrar.Image")));
            this.Btn_cerrar.Location = new System.Drawing.Point(1327, 0);
            this.Btn_cerrar.Name = "Btn_cerrar";
            this.Btn_cerrar.Size = new System.Drawing.Size(41, 41);
            this.Btn_cerrar.TabIndex = 6;
            this.Btn_cerrar.UseVisualStyleBackColor = false;
            this.Btn_cerrar.Click += new System.EventHandler(this.button2_Click);
            // 
            // Btn_Minimizar
            // 
            this.Btn_Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Minimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(147)))), ((int)(((byte)(125)))));
            this.Btn_Minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Minimizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(147)))), ((int)(((byte)(125)))));
            this.Btn_Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Minimizar.Image")));
            this.Btn_Minimizar.Location = new System.Drawing.Point(1290, 0);
            this.Btn_Minimizar.Name = "Btn_Minimizar";
            this.Btn_Minimizar.Size = new System.Drawing.Size(41, 41);
            this.Btn_Minimizar.TabIndex = 5;
            this.Btn_Minimizar.UseVisualStyleBackColor = false;
            this.Btn_Minimizar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Pnl_Menu
            // 
            this.Pnl_Menu.Controls.Add(this.menuStrip1);
            this.Pnl_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_Menu.Location = new System.Drawing.Point(0, 42);
            this.Pnl_Menu.Name = "Pnl_Menu";
            this.Pnl_Menu.Size = new System.Drawing.Size(1371, 37);
            this.Pnl_Menu.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(182)))), ((int)(((byte)(160)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cuentasBancariasToolStripMenuItem,
            this.movimientosBancariosToolStripMenuItem,
            this.estadosCuentasToolStripMenuItem,
            this.depositosToolStripMenuItem,
            this.retirosToolStripMenuItem,
            this.transferenciasBancariasToolStripMenuItem,
            this.formasDePagoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1371, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // cuentasBancariasToolStripMenuItem
            // 
            this.cuentasBancariasToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuentasBancariasToolStripMenuItem.Name = "cuentasBancariasToolStripMenuItem";
            this.cuentasBancariasToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.cuentasBancariasToolStripMenuItem.Text = "Movimientos Bancarios";
            this.cuentasBancariasToolStripMenuItem.Click += new System.EventHandler(this.cuentasBancariasToolStripMenuItem_Click_1);
            // 
            // movimientosBancariosToolStripMenuItem
            // 
            this.movimientosBancariosToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movimientosBancariosToolStripMenuItem.Name = "movimientosBancariosToolStripMenuItem";
            this.movimientosBancariosToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.movimientosBancariosToolStripMenuItem.Text = "Concilacion Bancaria";
            this.movimientosBancariosToolStripMenuItem.Click += new System.EventHandler(this.movimientosBancariosToolStripMenuItem_Click);
            // 
            // estadosCuentasToolStripMenuItem
            // 
            this.estadosCuentasToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estadosCuentasToolStripMenuItem.Name = "estadosCuentasToolStripMenuItem";
            this.estadosCuentasToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.estadosCuentasToolStripMenuItem.Text = "Disponibilidad Diaria";
            this.estadosCuentasToolStripMenuItem.Click += new System.EventHandler(this.estadosCuentasToolStripMenuItem_Click);
            // 
            // depositosToolStripMenuItem
            // 
            this.depositosToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositosToolStripMenuItem.Name = "depositosToolStripMenuItem";
            this.depositosToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.depositosToolStripMenuItem.Text = "Tipo De Cambio";
            this.depositosToolStripMenuItem.Click += new System.EventHandler(this.depositosToolStripMenuItem_Click);
            // 
            // retirosToolStripMenuItem
            // 
            this.retirosToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retirosToolStripMenuItem.Name = "retirosToolStripMenuItem";
            this.retirosToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
            this.retirosToolStripMenuItem.Text = "Proceso y Autorizacion De Compra";
            this.retirosToolStripMenuItem.Click += new System.EventHandler(this.retirosToolStripMenuItem_Click);
            // 
            // transferenciasBancariasToolStripMenuItem
            // 
            this.transferenciasBancariasToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transferenciasBancariasToolStripMenuItem.Name = "transferenciasBancariasToolStripMenuItem";
            this.transferenciasBancariasToolStripMenuItem.Size = new System.Drawing.Size(388, 22);
            this.transferenciasBancariasToolStripMenuItem.Text = "Proceso De Generacion de Cheques para Planilla";
            this.transferenciasBancariasToolStripMenuItem.Click += new System.EventHandler(this.transferenciasBancariasToolStripMenuItem_Click);
            // 
            // formasDePagoToolStripMenuItem
            // 
            
            // 
            // lbl_Hora
            // 
            this.lbl_Hora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_Hora.AutoSize = true;
            this.lbl_Hora.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hora.ForeColor = System.Drawing.Color.Black;
            this.lbl_Hora.Location = new System.Drawing.Point(-4, 612);
            this.lbl_Hora.Name = "lbl_Hora";
            this.lbl_Hora.Size = new System.Drawing.Size(93, 39);
            this.lbl_Hora.TabIndex = 4;
            this.lbl_Hora.Text = "Hora";
            this.lbl_Hora.Click += new System.EventHandler(this.lbl_HoraFecha_Click);
            // 
            // Lbl_Fecha
            // 
            this.Lbl_Fecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Lbl_Fecha.AutoSize = true;
            this.Lbl_Fecha.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Fecha.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Fecha.Location = new System.Drawing.Point(-4, 572);
            this.Lbl_Fecha.Name = "Lbl_Fecha";
            this.Lbl_Fecha.Size = new System.Drawing.Size(117, 39);
            this.Lbl_Fecha.TabIndex = 7;
            this.Lbl_Fecha.Text = "Fecha";
            this.Lbl_Fecha.Click += new System.EventHandler(this.label1_Click);
            // 
            // Lbl_Moneda
            // 
            this.Lbl_Moneda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Lbl_Moneda.AutoSize = true;
            this.Lbl_Moneda.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Moneda.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Moneda.Location = new System.Drawing.Point(-4, 655);
            this.Lbl_Moneda.Name = "Lbl_Moneda";
            this.Lbl_Moneda.Size = new System.Drawing.Size(153, 39);
            this.Lbl_Moneda.TabIndex = 8;
            this.Lbl_Moneda.Text = "Moneda";
            this.Lbl_Moneda.Click += new System.EventHandler(this.Lbl_Moneda_Click);
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Usuario.ForeColor = System.Drawing.Color.Black;
            this.lbl_Usuario.Location = new System.Drawing.Point(1065, 655);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(135, 39);
            this.lbl_Usuario.TabIndex = 9;
            this.lbl_Usuario.Text = "Usuario";
            this.lbl_Usuario.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Mdi_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(182)))), ((int)(((byte)(160)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1371, 700);
            this.Controls.Add(this.lbl_Usuario);
            this.Controls.Add(this.Lbl_Moneda);
            this.Controls.Add(this.Lbl_Fecha);
            this.Controls.Add(this.lbl_Hora);
            this.Controls.Add(this.Pnl_Menu);
            this.Controls.Add(this.pnl_Top);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(182)))), ((int)(((byte)(160)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Mdi_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl_Top.ResumeLayout(false);
            this.pnl_Top.PerformLayout();
            this.Pnl_Menu.ResumeLayout(false);
            this.Pnl_Menu.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Top;
        private System.Windows.Forms.Button Btn_cerrar;
        private System.Windows.Forms.Button Btn_Minimizar;
        private System.Windows.Forms.Button Btn_Logo;
        private System.Windows.Forms.Label Lbl_Modulo;
        private System.Windows.Forms.Panel Pnl_Menu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cuentasBancariasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimientosBancariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadosCuentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depositosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retirosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transferenciasBancariasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formasDePagoToolStripMenuItem;
        private System.Windows.Forms.Label lbl_Hora;
        private System.Windows.Forms.Label Lbl_Fecha;
        private System.Windows.Forms.Label Lbl_Moneda;
        private System.Windows.Forms.Label lbl_Usuario;
    }
}

