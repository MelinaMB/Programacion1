namespace TP_Corte
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
            this.grillaEmpleados = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textNombreEmpleado = new System.Windows.Forms.TextBox();
            this.btnAgregarEmpleado = new System.Windows.Forms.Button();
            this.grillaTotalPorEmpleados = new System.Windows.Forms.DataGridView();
            this.btnTotalPorEmpleado = new System.Windows.Forms.Button();
            this.labelTotal = new System.Windows.Forms.Label();
            this.numCodigoEmpleado = new System.Windows.Forms.NumericUpDown();
            this.numProduccion = new System.Windows.Forms.NumericUpDown();
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grillaEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaTotalPorEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCodigoEmpleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numProduccion)).BeginInit();
            this.SuspendLayout();
            // 
            // grillaEmpleados
            // 
            this.grillaEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaEmpleados.Location = new System.Drawing.Point(409, 12);
            this.grillaEmpleados.Name = "grillaEmpleados";
            this.grillaEmpleados.Size = new System.Drawing.Size(318, 187);
            this.grillaEmpleados.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo Empleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Produccion";
            // 
            // textNombreEmpleado
            // 
            this.textNombreEmpleado.Location = new System.Drawing.Point(175, 64);
            this.textNombreEmpleado.Name = "textNombreEmpleado";
            this.textNombreEmpleado.Size = new System.Drawing.Size(120, 20);
            this.textNombreEmpleado.TabIndex = 6;
            // 
            // btnAgregarEmpleado
            // 
            this.btnAgregarEmpleado.Location = new System.Drawing.Point(175, 150);
            this.btnAgregarEmpleado.Name = "btnAgregarEmpleado";
            this.btnAgregarEmpleado.Size = new System.Drawing.Size(120, 23);
            this.btnAgregarEmpleado.TabIndex = 7;
            this.btnAgregarEmpleado.Text = "Agregar Empleado";
            this.btnAgregarEmpleado.UseVisualStyleBackColor = true;
            this.btnAgregarEmpleado.Click += new System.EventHandler(this.btnAgregarEmpleado_Click);
            // 
            // grillaTotalPorEmpleados
            // 
            this.grillaTotalPorEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaTotalPorEmpleados.Location = new System.Drawing.Point(409, 205);
            this.grillaTotalPorEmpleados.Name = "grillaTotalPorEmpleados";
            this.grillaTotalPorEmpleados.Size = new System.Drawing.Size(318, 140);
            this.grillaTotalPorEmpleados.TabIndex = 8;
            // 
            // btnTotalPorEmpleado
            // 
            this.btnTotalPorEmpleado.Location = new System.Drawing.Point(175, 227);
            this.btnTotalPorEmpleado.Name = "btnTotalPorEmpleado";
            this.btnTotalPorEmpleado.Size = new System.Drawing.Size(207, 23);
            this.btnTotalPorEmpleado.TabIndex = 9;
            this.btnTotalPorEmpleado.Text = "Total de produccion por empleado";
            this.btnTotalPorEmpleado.UseVisualStyleBackColor = true;
            this.btnTotalPorEmpleado.Click += new System.EventHandler(this.btnTotalPorEmpleado_Click);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(406, 348);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(43, 13);
            this.labelTotal.TabIndex = 11;
            this.labelTotal.Text = "Total: $";
            // 
            // numCodigoEmpleado
            // 
            this.numCodigoEmpleado.Location = new System.Drawing.Point(175, 29);
            this.numCodigoEmpleado.Name = "numCodigoEmpleado";
            this.numCodigoEmpleado.Size = new System.Drawing.Size(120, 20);
            this.numCodigoEmpleado.TabIndex = 12;
            // 
            // numProduccion
            // 
            this.numProduccion.Location = new System.Drawing.Point(175, 108);
            this.numProduccion.Name = "numProduccion";
            this.numProduccion.Size = new System.Drawing.Size(120, 20);
            this.numProduccion.TabIndex = 13;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(52, 149);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 14;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.numProduccion);
            this.Controls.Add(this.numCodigoEmpleado);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.btnTotalPorEmpleado);
            this.Controls.Add(this.grillaTotalPorEmpleados);
            this.Controls.Add(this.btnAgregarEmpleado);
            this.Controls.Add(this.textNombreEmpleado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grillaEmpleados);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.grillaEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaTotalPorEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCodigoEmpleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numProduccion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grillaEmpleados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textNombreEmpleado;
        private System.Windows.Forms.Button btnAgregarEmpleado;
        private System.Windows.Forms.DataGridView grillaTotalPorEmpleados;
        private System.Windows.Forms.Button btnTotalPorEmpleado;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.NumericUpDown numCodigoEmpleado;
        private System.Windows.Forms.NumericUpDown numProduccion;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

