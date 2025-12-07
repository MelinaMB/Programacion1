namespace ListasEnlazadasSimples
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarAlPrincipio = new System.Windows.Forms.Button();
            this.btnAgregarAlFinal = new System.Windows.Forms.Button();
            this.btnQuitarSeleccionado = new System.Windows.Forms.Button();
            this.btnQuitarPrimero = new System.Windows.Forms.Button();
            this.btnQuitarUltimo = new System.Windows.Forms.Button();
            this.btnIntercambiarDerecha = new System.Windows.Forms.Button();
            this.btnIntercambiarIzquierda = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(182, 277);
            this.listBox1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(200, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // btnAgregarAlPrincipio
            // 
            this.btnAgregarAlPrincipio.Location = new System.Drawing.Point(203, 89);
            this.btnAgregarAlPrincipio.Name = "btnAgregarAlPrincipio";
            this.btnAgregarAlPrincipio.Size = new System.Drawing.Size(116, 23);
            this.btnAgregarAlPrincipio.TabIndex = 3;
            this.btnAgregarAlPrincipio.Text = "Agregar al Principio";
            this.btnAgregarAlPrincipio.UseVisualStyleBackColor = true;
            this.btnAgregarAlPrincipio.Click += new System.EventHandler(this.btnAgregarAlPrincipio_Click);
            // 
            // btnAgregarAlFinal
            // 
            this.btnAgregarAlFinal.Location = new System.Drawing.Point(203, 119);
            this.btnAgregarAlFinal.Name = "btnAgregarAlFinal";
            this.btnAgregarAlFinal.Size = new System.Drawing.Size(116, 23);
            this.btnAgregarAlFinal.TabIndex = 4;
            this.btnAgregarAlFinal.Text = "Agregar al final";
            this.btnAgregarAlFinal.UseVisualStyleBackColor = true;
            this.btnAgregarAlFinal.Click += new System.EventHandler(this.btnAgregarAlFinal_Click);
            // 
            // btnQuitarSeleccionado
            // 
            this.btnQuitarSeleccionado.Location = new System.Drawing.Point(203, 149);
            this.btnQuitarSeleccionado.Name = "btnQuitarSeleccionado";
            this.btnQuitarSeleccionado.Size = new System.Drawing.Size(116, 23);
            this.btnQuitarSeleccionado.TabIndex = 5;
            this.btnQuitarSeleccionado.Text = "Quitar Seleccionado";
            this.btnQuitarSeleccionado.UseVisualStyleBackColor = true;
            this.btnQuitarSeleccionado.Click += new System.EventHandler(this.btnQuitarSeleccionado_Click);
            // 
            // btnQuitarPrimero
            // 
            this.btnQuitarPrimero.Location = new System.Drawing.Point(203, 179);
            this.btnQuitarPrimero.Name = "btnQuitarPrimero";
            this.btnQuitarPrimero.Size = new System.Drawing.Size(116, 23);
            this.btnQuitarPrimero.TabIndex = 6;
            this.btnQuitarPrimero.Text = "Quitar Primero";
            this.btnQuitarPrimero.UseVisualStyleBackColor = true;
            this.btnQuitarPrimero.Click += new System.EventHandler(this.btnQuitarPrimero_Click);
            // 
            // btnQuitarUltimo
            // 
            this.btnQuitarUltimo.Location = new System.Drawing.Point(203, 209);
            this.btnQuitarUltimo.Name = "btnQuitarUltimo";
            this.btnQuitarUltimo.Size = new System.Drawing.Size(116, 23);
            this.btnQuitarUltimo.TabIndex = 7;
            this.btnQuitarUltimo.Text = "Quitar ultimo";
            this.btnQuitarUltimo.UseVisualStyleBackColor = true;
            this.btnQuitarUltimo.Click += new System.EventHandler(this.btnQuitarUltimo_Click);
            // 
            // btnIntercambiarDerecha
            // 
            this.btnIntercambiarDerecha.Location = new System.Drawing.Point(203, 238);
            this.btnIntercambiarDerecha.Name = "btnIntercambiarDerecha";
            this.btnIntercambiarDerecha.Size = new System.Drawing.Size(149, 23);
            this.btnIntercambiarDerecha.TabIndex = 8;
            this.btnIntercambiarDerecha.Text = "Intercambiar Derecha";
            this.btnIntercambiarDerecha.UseVisualStyleBackColor = true;
            // 
            // btnIntercambiarIzquierda
            // 
            this.btnIntercambiarIzquierda.Location = new System.Drawing.Point(203, 265);
            this.btnIntercambiarIzquierda.Name = "btnIntercambiarIzquierda";
            this.btnIntercambiarIzquierda.Size = new System.Drawing.Size(149, 23);
            this.btnIntercambiarIzquierda.TabIndex = 9;
            this.btnIntercambiarIzquierda.Text = "Intercambiar Izquierda";
            this.btnIntercambiarIzquierda.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(344, 50);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(350, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Numero";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnIntercambiarIzquierda);
            this.Controls.Add(this.btnIntercambiarDerecha);
            this.Controls.Add(this.btnQuitarUltimo);
            this.Controls.Add(this.btnQuitarPrimero);
            this.Controls.Add(this.btnQuitarSeleccionado);
            this.Controls.Add(this.btnAgregarAlFinal);
            this.Controls.Add(this.btnAgregarAlPrincipio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregarAlPrincipio;
        private System.Windows.Forms.Button btnAgregarAlFinal;
        private System.Windows.Forms.Button btnQuitarSeleccionado;
        private System.Windows.Forms.Button btnQuitarPrimero;
        private System.Windows.Forms.Button btnQuitarUltimo;
        private System.Windows.Forms.Button btnIntercambiarDerecha;
        private System.Windows.Forms.Button btnIntercambiarIzquierda;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
    }
}

