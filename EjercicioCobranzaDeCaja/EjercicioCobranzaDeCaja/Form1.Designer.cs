namespace EjercicioCobranzaDeCaja
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
            this.btnPagarCajaRapida = new System.Windows.Forms.Button();
            this.btnPagarCajaNormal = new System.Windows.Forms.Button();
            this.listCajaRapida = new System.Windows.Forms.ListBox();
            this.listCajaNormal = new System.Windows.Forms.ListBox();
            this.textNombreCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTotalCajaRapida = new System.Windows.Forms.Label();
            this.labelTotalCajaNormal = new System.Windows.Forms.Label();
            this.btnIngresarAlCliente = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textCantidadProductos = new System.Windows.Forms.TextBox();
            this.textImporte = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPagarCajaRapida
            // 
            this.btnPagarCajaRapida.Location = new System.Drawing.Point(330, 312);
            this.btnPagarCajaRapida.Name = "btnPagarCajaRapida";
            this.btnPagarCajaRapida.Size = new System.Drawing.Size(123, 23);
            this.btnPagarCajaRapida.TabIndex = 0;
            this.btnPagarCajaRapida.Text = "Pagar Caja Rapida";
            this.btnPagarCajaRapida.UseVisualStyleBackColor = true;
            this.btnPagarCajaRapida.Click += new System.EventHandler(this.btnPagarCajaRapida_Click);
            // 
            // btnPagarCajaNormal
            // 
            this.btnPagarCajaNormal.Location = new System.Drawing.Point(83, 312);
            this.btnPagarCajaNormal.Name = "btnPagarCajaNormal";
            this.btnPagarCajaNormal.Size = new System.Drawing.Size(123, 23);
            this.btnPagarCajaNormal.TabIndex = 1;
            this.btnPagarCajaNormal.Text = "Pagar Caja Normal";
            this.btnPagarCajaNormal.UseVisualStyleBackColor = true;
            this.btnPagarCajaNormal.Click += new System.EventHandler(this.btnPagarCajaNormal_Click);
            // 
            // listCajaRapida
            // 
            this.listCajaRapida.FormattingEnabled = true;
            this.listCajaRapida.Location = new System.Drawing.Point(289, 211);
            this.listCajaRapida.Name = "listCajaRapida";
            this.listCajaRapida.Size = new System.Drawing.Size(190, 95);
            this.listCajaRapida.TabIndex = 2;
            // 
            // listCajaNormal
            // 
            this.listCajaNormal.FormattingEnabled = true;
            this.listCajaNormal.Location = new System.Drawing.Point(46, 211);
            this.listCajaNormal.Name = "listCajaNormal";
            this.listCajaNormal.Size = new System.Drawing.Size(188, 95);
            this.listCajaNormal.TabIndex = 3;
            // 
            // textNombreCliente
            // 
            this.textNombreCliente.Location = new System.Drawing.Point(63, 42);
            this.textNombreCliente.Name = "textNombreCliente";
            this.textNombreCliente.Size = new System.Drawing.Size(86, 20);
            this.textNombreCliente.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ingresar Nombre";
            // 
            // labelTotalCajaRapida
            // 
            this.labelTotalCajaRapida.AutoSize = true;
            this.labelTotalCajaRapida.Location = new System.Drawing.Point(327, 355);
            this.labelTotalCajaRapida.Name = "labelTotalCajaRapida";
            this.labelTotalCajaRapida.Size = new System.Drawing.Size(119, 13);
            this.labelTotalCajaRapida.TabIndex = 6;
            this.labelTotalCajaRapida.Text = "Total de Caja Rapida :$";
            // 
            // labelTotalCajaNormal
            // 
            this.labelTotalCajaNormal.AutoSize = true;
            this.labelTotalCajaNormal.Location = new System.Drawing.Point(84, 355);
            this.labelTotalCajaNormal.Name = "labelTotalCajaNormal";
            this.labelTotalCajaNormal.Size = new System.Drawing.Size(118, 13);
            this.labelTotalCajaNormal.TabIndex = 7;
            this.labelTotalCajaNormal.Text = "Total de Caja Normal: $";
            // 
            // btnIngresarAlCliente
            // 
            this.btnIngresarAlCliente.Location = new System.Drawing.Point(238, 97);
            this.btnIngresarAlCliente.Name = "btnIngresarAlCliente";
            this.btnIngresarAlCliente.Size = new System.Drawing.Size(148, 23);
            this.btnIngresarAlCliente.TabIndex = 8;
            this.btnIngresarAlCliente.Text = "Ingresar el cliente";
            this.btnIngresarAlCliente.UseVisualStyleBackColor = true;
            this.btnIngresarAlCliente.Click += new System.EventHandler(this.btnIngresarAlCliente_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ingresar Cantidad";
            // 
            // textCantidadProductos
            // 
            this.textCantidadProductos.Location = new System.Drawing.Point(244, 41);
            this.textCantidadProductos.Name = "textCantidadProductos";
            this.textCantidadProductos.Size = new System.Drawing.Size(100, 20);
            this.textCantidadProductos.TabIndex = 10;
            // 
            // textImporte
            // 
            this.textImporte.Location = new System.Drawing.Point(468, 42);
            this.textImporte.Name = "textImporte";
            this.textImporte.Size = new System.Drawing.Size(100, 20);
            this.textImporte.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(476, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ingresar Importe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(343, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Lista Clientes Caja Rapida";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Lista Clientes Caja Normal";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textImporte);
            this.Controls.Add(this.textCantidadProductos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnIngresarAlCliente);
            this.Controls.Add(this.labelTotalCajaNormal);
            this.Controls.Add(this.labelTotalCajaRapida);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textNombreCliente);
            this.Controls.Add(this.listCajaNormal);
            this.Controls.Add(this.listCajaRapida);
            this.Controls.Add(this.btnPagarCajaNormal);
            this.Controls.Add(this.btnPagarCajaRapida);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPagarCajaRapida;
        private System.Windows.Forms.Button btnPagarCajaNormal;
        private System.Windows.Forms.ListBox listCajaRapida;
        private System.Windows.Forms.ListBox listCajaNormal;
        private System.Windows.Forms.TextBox textNombreCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTotalCajaRapida;
        private System.Windows.Forms.Label labelTotalCajaNormal;
        private System.Windows.Forms.Button btnIngresarAlCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textCantidadProductos;
        private System.Windows.Forms.TextBox textImporte;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

