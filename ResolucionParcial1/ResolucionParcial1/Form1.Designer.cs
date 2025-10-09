namespace ResolucionParcial1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstClientes = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textNombreCliente = new System.Windows.Forms.TextBox();
            this.btnPagarCajaRapidaONormal = new System.Windows.Forms.Button();
            this.lstColaRapida = new System.Windows.Forms.ListBox();
            this.lstColaNormal = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAgregar_Cliente = new System.Windows.Forms.Button();
            this.textCantidadProductos = new System.Windows.Forms.TextBox();
            this.textImporte = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstClientes
            // 
            this.lstClientes.FormattingEnabled = true;
            this.lstClientes.Location = new System.Drawing.Point(24, 23);
            this.lstClientes.Name = "lstClientes";
            this.lstClientes.Size = new System.Drawing.Size(157, 95);
            this.lstClientes.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingresar nombre del Cliente";
            // 
            // textNombreCliente
            // 
            this.textNombreCliente.Location = new System.Drawing.Point(219, 52);
            this.textNombreCliente.Name = "textNombreCliente";
            this.textNombreCliente.Size = new System.Drawing.Size(100, 20);
            this.textNombreCliente.TabIndex = 2;
            // 
            // btnPagarCajaRapidaONormal
            // 
            this.btnPagarCajaRapidaONormal.Location = new System.Drawing.Point(61, 150);
            this.btnPagarCajaRapidaONormal.Name = "btnPagarCajaRapidaONormal";
            this.btnPagarCajaRapidaONormal.Size = new System.Drawing.Size(207, 23);
            this.btnPagarCajaRapidaONormal.TabIndex = 4;
            this.btnPagarCajaRapidaONormal.Text = "Pagar por Caja Rápida o Normal";
            this.btnPagarCajaRapidaONormal.UseVisualStyleBackColor = true;
            this.btnPagarCajaRapidaONormal.Click += new System.EventHandler(this.btnPagarCajaRapidaONormal_Click_1);
            // 
            // lstColaRapida
            // 
            this.lstColaRapida.FormattingEnabled = true;
            this.lstColaRapida.Location = new System.Drawing.Point(61, 179);
            this.lstColaRapida.Name = "lstColaRapida";
            this.lstColaRapida.Size = new System.Drawing.Size(187, 95);
            this.lstColaRapida.TabIndex = 7;
            // 
            // lstColaNormal
            // 
            this.lstColaNormal.FormattingEnabled = true;
            this.lstColaNormal.Location = new System.Drawing.Point(272, 179);
            this.lstColaNormal.Name = "lstColaNormal";
            this.lstColaNormal.Size = new System.Drawing.Size(192, 95);
            this.lstColaNormal.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Total Caja Rapida:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Total Caja Normal:";
            // 
            // btnAgregar_Cliente
            // 
            this.btnAgregar_Cliente.Location = new System.Drawing.Point(420, 95);
            this.btnAgregar_Cliente.Name = "btnAgregar_Cliente";
            this.btnAgregar_Cliente.Size = new System.Drawing.Size(108, 23);
            this.btnAgregar_Cliente.TabIndex = 11;
            this.btnAgregar_Cliente.Text = "Agregar el cliente";
            this.btnAgregar_Cliente.UseVisualStyleBackColor = true;
            this.btnAgregar_Cliente.Click += new System.EventHandler(this.btnAgregar_Cliente_Click);
            // 
            // textCantidadProductos
            // 
            this.textCantidadProductos.Location = new System.Drawing.Point(428, 52);
            this.textCantidadProductos.Name = "textCantidadProductos";
            this.textCantidadProductos.Size = new System.Drawing.Size(100, 20);
            this.textCantidadProductos.TabIndex = 12;
            // 
            // textImporte
            // 
            this.textImporte.Location = new System.Drawing.Point(610, 51);
            this.textImporte.Name = "textImporte";
            this.textImporte.Size = new System.Drawing.Size(100, 20);
            this.textImporte.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(425, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Ingresar cantidad de productos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(607, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Ingresar Importe";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textImporte);
            this.Controls.Add(this.textCantidadProductos);
            this.Controls.Add(this.btnAgregar_Cliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstColaNormal);
            this.Controls.Add(this.lstColaRapida);
            this.Controls.Add(this.btnPagarCajaRapidaONormal);
            this.Controls.Add(this.textNombreCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstClientes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNombreCliente;
        private System.Windows.Forms.Button btnPagarCajaRapidaONormal;
        private System.Windows.Forms.ListBox lstColaRapida;
        private System.Windows.Forms.ListBox lstColaNormal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAgregar_Cliente;
        private System.Windows.Forms.TextBox textCantidadProductos;
        private System.Windows.Forms.TextBox textImporte;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

