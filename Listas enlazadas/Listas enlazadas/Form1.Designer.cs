namespace Listas_enlazadas
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
            this.cmdAgregarAlPrincipio = new System.Windows.Forms.Button();
            this.txtNombreNodo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listListaEnlazada = new System.Windows.Forms.ListBox();
            this.cmdAgregarAlFinal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdAgregarAlPrincipio
            // 
            this.cmdAgregarAlPrincipio.Location = new System.Drawing.Point(471, 240);
            this.cmdAgregarAlPrincipio.Name = "cmdAgregarAlPrincipio";
            this.cmdAgregarAlPrincipio.Size = new System.Drawing.Size(127, 33);
            this.cmdAgregarAlPrincipio.TabIndex = 0;
            this.cmdAgregarAlPrincipio.Text = "Agregar al Principio";
            this.cmdAgregarAlPrincipio.UseVisualStyleBackColor = true;
            this.cmdAgregarAlPrincipio.Click += new System.EventHandler(this.cmdAgregarAlPrincipio_Click);
            // 
            // txtNombreNodo
            // 
            this.txtNombreNodo.Location = new System.Drawing.Point(471, 200);
            this.txtNombreNodo.Name = "txtNombreNodo";
            this.txtNombreNodo.Size = new System.Drawing.Size(174, 20);
            this.txtNombreNodo.TabIndex = 1;
            
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(486, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre del Nodo";
            
            // 
            // listListaEnlazada
            // 
            this.listListaEnlazada.FormattingEnabled = true;
            this.listListaEnlazada.Location = new System.Drawing.Point(238, 12);
            this.listListaEnlazada.Name = "listListaEnlazada";
            this.listListaEnlazada.Size = new System.Drawing.Size(179, 407);
            this.listListaEnlazada.TabIndex = 3;
            // 
            // cmdAgregarAlFinal
            // 
            this.cmdAgregarAlFinal.Location = new System.Drawing.Point(471, 296);
            this.cmdAgregarAlFinal.Name = "cmdAgregarAlFinal";
            this.cmdAgregarAlFinal.Size = new System.Drawing.Size(127, 33);
            this.cmdAgregarAlFinal.TabIndex = 4;
            this.cmdAgregarAlFinal.Text = "Agregar Al Final";
            this.cmdAgregarAlFinal.UseVisualStyleBackColor = true;
            this.cmdAgregarAlFinal.Click += new System.EventHandler(this.cmdAgregarAlFinal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdAgregarAlFinal);
            this.Controls.Add(this.listListaEnlazada);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombreNodo);
            this.Controls.Add(this.cmdAgregarAlPrincipio);
            this.Name = "Form1";
            this.Text = "Form1";
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdAgregarAlPrincipio;
        private System.Windows.Forms.TextBox txtNombreNodo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listListaEnlazada;
        private System.Windows.Forms.Button cmdAgregarAlFinal;
    }
}

