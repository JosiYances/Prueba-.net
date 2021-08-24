
namespace AppControl
{
    partial class Usarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usarios));
            this.label1 = new System.Windows.Forms.Label();
            this.ENVIAR = new System.Windows.Forms.Button();
            this.IMPRIMIR = new System.Windows.Forms.Button();
            this.Cuenta = new System.Windows.Forms.ListBox();
            this.Contrato = new System.Windows.Forms.ListBox();
            this.FechaF = new System.Windows.Forms.ListBox();
            this.FechaV = new System.Windows.Forms.ListBox();
            this.Valor = new System.Windows.Forms.ListBox();
            this.Razon = new System.Windows.Forms.ListBox();
            this.Nombre = new System.Windows.Forms.ListBox();
            this.ID = new System.Windows.Forms.ListBox();
            this.Direccion = new System.Windows.Forms.ListBox();
            this.Ciudad = new System.Windows.Forms.ListBox();
            this.TCuenta = new System.Windows.Forms.TextBox();
            this.TContrato = new System.Windows.Forms.TextBox();
            this.TFechaF = new System.Windows.Forms.TextBox();
            this.TFechaV = new System.Windows.Forms.TextBox();
            this.TValor = new System.Windows.Forms.TextBox();
            this.TRazon = new System.Windows.Forms.TextBox();
            this.TNombre = new System.Windows.Forms.TextBox();
            this.TID = new System.Windows.Forms.TextBox();
            this.TDireccion = new System.Windows.Forms.TextBox();
            this.TCiudad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(533, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "USUARIOS";
            // 
            // ENVIAR
            // 
            this.ENVIAR.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ENVIAR.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ENVIAR.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ENVIAR.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ENVIAR.Location = new System.Drawing.Point(196, 594);
            this.ENVIAR.Name = "ENVIAR";
            this.ENVIAR.Size = new System.Drawing.Size(268, 51);
            this.ENVIAR.TabIndex = 1;
            this.ENVIAR.Text = "ENVIAR FACTURAS";
            this.ENVIAR.UseMnemonic = false;
            this.ENVIAR.UseVisualStyleBackColor = false;
            this.ENVIAR.Click += new System.EventHandler(this.ENVIAR_Click);
            // 
            // IMPRIMIR
            // 
            this.IMPRIMIR.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.IMPRIMIR.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.IMPRIMIR.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IMPRIMIR.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.IMPRIMIR.Location = new System.Drawing.Point(766, 591);
            this.IMPRIMIR.Name = "IMPRIMIR";
            this.IMPRIMIR.Size = new System.Drawing.Size(268, 51);
            this.IMPRIMIR.TabIndex = 3;
            this.IMPRIMIR.Text = "IMPRIMIR FACTURAS";
            this.IMPRIMIR.UseMnemonic = false;
            this.IMPRIMIR.UseVisualStyleBackColor = false;
            this.IMPRIMIR.Click += new System.EventHandler(this.IMPRIMIR_Click);
            // 
            // Cuenta
            // 
            this.Cuenta.FormattingEnabled = true;
            this.Cuenta.ItemHeight = 20;
            this.Cuenta.Location = new System.Drawing.Point(24, 67);
            this.Cuenta.Name = "Cuenta";
            this.Cuenta.Size = new System.Drawing.Size(117, 504);
            this.Cuenta.TabIndex = 4;
            // 
            // Contrato
            // 
            this.Contrato.FormattingEnabled = true;
            this.Contrato.ItemHeight = 20;
            this.Contrato.Location = new System.Drawing.Point(140, 67);
            this.Contrato.Name = "Contrato";
            this.Contrato.Size = new System.Drawing.Size(117, 504);
            this.Contrato.TabIndex = 5;
            // 
            // FechaF
            // 
            this.FechaF.FormattingEnabled = true;
            this.FechaF.ItemHeight = 20;
            this.FechaF.Location = new System.Drawing.Point(256, 67);
            this.FechaF.Name = "FechaF";
            this.FechaF.Size = new System.Drawing.Size(117, 504);
            this.FechaF.TabIndex = 6;
            // 
            // FechaV
            // 
            this.FechaV.FormattingEnabled = true;
            this.FechaV.ItemHeight = 20;
            this.FechaV.Location = new System.Drawing.Point(372, 67);
            this.FechaV.Name = "FechaV";
            this.FechaV.Size = new System.Drawing.Size(117, 504);
            this.FechaV.TabIndex = 7;
            // 
            // Valor
            // 
            this.Valor.FormattingEnabled = true;
            this.Valor.ItemHeight = 20;
            this.Valor.Location = new System.Drawing.Point(487, 67);
            this.Valor.Name = "Valor";
            this.Valor.Size = new System.Drawing.Size(117, 504);
            this.Valor.TabIndex = 8;
            // 
            // Razon
            // 
            this.Razon.FormattingEnabled = true;
            this.Razon.ItemHeight = 20;
            this.Razon.Location = new System.Drawing.Point(603, 67);
            this.Razon.Name = "Razon";
            this.Razon.Size = new System.Drawing.Size(26, 504);
            this.Razon.TabIndex = 9;
            // 
            // Nombre
            // 
            this.Nombre.FormattingEnabled = true;
            this.Nombre.ItemHeight = 20;
            this.Nombre.Location = new System.Drawing.Point(628, 67);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(213, 504);
            this.Nombre.TabIndex = 10;
            // 
            // ID
            // 
            this.ID.FormattingEnabled = true;
            this.ID.ItemHeight = 20;
            this.ID.Location = new System.Drawing.Point(840, 67);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(117, 504);
            this.ID.TabIndex = 11;
            // 
            // Direccion
            // 
            this.Direccion.FormattingEnabled = true;
            this.Direccion.ItemHeight = 20;
            this.Direccion.Location = new System.Drawing.Point(956, 67);
            this.Direccion.Name = "Direccion";
            this.Direccion.Size = new System.Drawing.Size(224, 504);
            this.Direccion.TabIndex = 12;
            // 
            // Ciudad
            // 
            this.Ciudad.FormattingEnabled = true;
            this.Ciudad.ItemHeight = 20;
            this.Ciudad.Location = new System.Drawing.Point(1178, 67);
            this.Ciudad.Name = "Ciudad";
            this.Ciudad.Size = new System.Drawing.Size(117, 504);
            this.Ciudad.TabIndex = 13;
            // 
            // TCuenta
            // 
            this.TCuenta.Location = new System.Drawing.Point(24, 40);
            this.TCuenta.Name = "TCuenta";
            this.TCuenta.Size = new System.Drawing.Size(118, 27);
            this.TCuenta.TabIndex = 14;
            // 
            // TContrato
            // 
            this.TContrato.Location = new System.Drawing.Point(140, 40);
            this.TContrato.Name = "TContrato";
            this.TContrato.Size = new System.Drawing.Size(118, 27);
            this.TContrato.TabIndex = 15;
            // 
            // TFechaF
            // 
            this.TFechaF.Location = new System.Drawing.Point(256, 40);
            this.TFechaF.Name = "TFechaF";
            this.TFechaF.Size = new System.Drawing.Size(118, 27);
            this.TFechaF.TabIndex = 16;
            // 
            // TFechaV
            // 
            this.TFechaV.Location = new System.Drawing.Point(372, 40);
            this.TFechaV.Name = "TFechaV";
            this.TFechaV.Size = new System.Drawing.Size(116, 27);
            this.TFechaV.TabIndex = 17;
            // 
            // TValor
            // 
            this.TValor.Location = new System.Drawing.Point(488, 40);
            this.TValor.Name = "TValor";
            this.TValor.Size = new System.Drawing.Size(116, 27);
            this.TValor.TabIndex = 18;
            // 
            // TRazon
            // 
            this.TRazon.Location = new System.Drawing.Point(603, 40);
            this.TRazon.Name = "TRazon";
            this.TRazon.Size = new System.Drawing.Size(26, 27);
            this.TRazon.TabIndex = 19;
            // 
            // TNombre
            // 
            this.TNombre.Location = new System.Drawing.Point(628, 40);
            this.TNombre.Name = "TNombre";
            this.TNombre.Size = new System.Drawing.Size(213, 27);
            this.TNombre.TabIndex = 20;
            // 
            // TID
            // 
            this.TID.Location = new System.Drawing.Point(841, 40);
            this.TID.Name = "TID";
            this.TID.Size = new System.Drawing.Size(116, 27);
            this.TID.TabIndex = 21;
            // 
            // TDireccion
            // 
            this.TDireccion.Location = new System.Drawing.Point(956, 40);
            this.TDireccion.Name = "TDireccion";
            this.TDireccion.Size = new System.Drawing.Size(224, 27);
            this.TDireccion.TabIndex = 22;
            // 
            // TCiudad
            // 
            this.TCiudad.Location = new System.Drawing.Point(1178, 40);
            this.TCiudad.Name = "TCiudad";
            this.TCiudad.Size = new System.Drawing.Size(116, 27);
            this.TCiudad.TabIndex = 23;
            // 
            // Usarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1315, 671);
            this.Controls.Add(this.TCiudad);
            this.Controls.Add(this.TDireccion);
            this.Controls.Add(this.TID);
            this.Controls.Add(this.TNombre);
            this.Controls.Add(this.TRazon);
            this.Controls.Add(this.TValor);
            this.Controls.Add(this.TFechaV);
            this.Controls.Add(this.TFechaF);
            this.Controls.Add(this.TContrato);
            this.Controls.Add(this.TCuenta);
            this.Controls.Add(this.Ciudad);
            this.Controls.Add(this.Direccion);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.Razon);
            this.Controls.Add(this.Valor);
            this.Controls.Add(this.FechaV);
            this.Controls.Add(this.FechaF);
            this.Controls.Add(this.Contrato);
            this.Controls.Add(this.Cuenta);
            this.Controls.Add(this.IMPRIMIR);
            this.Controls.Add(this.ENVIAR);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Usarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ENVIAR;
        private System.Windows.Forms.Button IMPRIMIR;
        private System.Windows.Forms.ListBox Cuenta;
        private System.Windows.Forms.ListBox Contrato;
        private System.Windows.Forms.ListBox FechaF;
        private System.Windows.Forms.ListBox FechaV;
        private System.Windows.Forms.ListBox Valor;
        private System.Windows.Forms.ListBox Razon;
        private System.Windows.Forms.ListBox Nombre;
        private System.Windows.Forms.ListBox ID;
        private System.Windows.Forms.ListBox Direccion;
        private System.Windows.Forms.ListBox Ciudad;
        private System.Windows.Forms.TextBox TCuenta;
        private System.Windows.Forms.TextBox TContrato;
        private System.Windows.Forms.TextBox TFechaF;
        private System.Windows.Forms.TextBox TFechaV;
        private System.Windows.Forms.TextBox TValor;
        private System.Windows.Forms.TextBox TRazon;
        private System.Windows.Forms.TextBox TNombre;
        private System.Windows.Forms.TextBox TID;
        private System.Windows.Forms.TextBox TDireccion;
        private System.Windows.Forms.TextBox TCiudad;
    }
}