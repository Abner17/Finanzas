﻿namespace Prototipo_Abner_Portillo
{
    partial class Frm_ListadoPolizasLocales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ListadoPolizasLocales));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Cerrar = new System.Windows.Forms.Button();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.Btn_Logo = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.dgv_ListadoPolizasLocales = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListadoPolizasLocales)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(169)))), ((int)(((byte)(206)))));
            this.panel1.Controls.Add(this.Btn_Cerrar);
            this.panel1.Controls.Add(this.lbl_nombre);
            this.panel1.Controls.Add(this.Btn_Logo);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1244, 52);
            this.panel1.TabIndex = 4;
            // 
            // Btn_Cerrar
            // 
            this.Btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(192)))), ((int)(((byte)(195)))));
            this.Btn_Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Cerrar.Image")));
            this.Btn_Cerrar.Location = new System.Drawing.Point(1181, 1);
            this.Btn_Cerrar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Size = new System.Drawing.Size(55, 50);
            this.Btn_Cerrar.TabIndex = 12;
            this.Btn_Cerrar.UseVisualStyleBackColor = false;
            this.Btn_Cerrar.Click += new System.EventHandler(this.Btn_Cerrar_Click);
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nombre.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.ForeColor = System.Drawing.Color.Black;
            this.lbl_nombre.Location = new System.Drawing.Point(56, 7);
            this.lbl_nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(490, 40);
            this.lbl_nombre.TabIndex = 11;
            this.lbl_nombre.Text = " 1110_Listado Polizas Locales";
            // 
            // Btn_Logo
            // 
            this.Btn_Logo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Logo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(192)))), ((int)(((byte)(195)))));
            this.Btn_Logo.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Logo.Image")));
            this.Btn_Logo.Location = new System.Drawing.Point(4, 1);
            this.Btn_Logo.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Logo.Name = "Btn_Logo";
            this.Btn_Logo.Size = new System.Drawing.Size(55, 50);
            this.Btn_Logo.TabIndex = 10;
            this.Btn_Logo.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(192)))), ((int)(((byte)(195)))));
            this.button2.Location = new System.Drawing.Point(1127, 1);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 50);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Century Gothic", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(73, 87);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(490, 49);
            this.lbl_titulo.TabIndex = 30;
            this.lbl_titulo.Text = "Listado Polizas Locales";
            // 
            // dgv_ListadoPolizasLocales
            // 
            this.dgv_ListadoPolizasLocales.AllowUserToAddRows = false;
            this.dgv_ListadoPolizasLocales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ListadoPolizasLocales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_ListadoPolizasLocales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListadoPolizasLocales.Location = new System.Drawing.Point(63, 205);
            this.dgv_ListadoPolizasLocales.Name = "dgv_ListadoPolizasLocales";
            this.dgv_ListadoPolizasLocales.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_ListadoPolizasLocales.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_ListadoPolizasLocales.RowTemplate.Height = 24;
            this.dgv_ListadoPolizasLocales.Size = new System.Drawing.Size(1119, 591);
            this.dgv_ListadoPolizasLocales.TabIndex = 31;
            this.dgv_ListadoPolizasLocales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ListadoPolizasLocales_CellContentClick);
            this.dgv_ListadoPolizasLocales.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ListadoPolizasLocales_CellDoubleClick);
            // 
            // Frm_ListadoPolizasLocales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 862);
            this.Controls.Add(this.dgv_ListadoPolizasLocales);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_ListadoPolizasLocales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_ListadoPolizasLocales";
            this.Load += new System.EventHandler(this.Frm_ListadoPolizasLocales_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListadoPolizasLocales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_Cerrar;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Button Btn_Logo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.DataGridView dgv_ListadoPolizasLocales;
    }
}