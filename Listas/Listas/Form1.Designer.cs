namespace Listas
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
            this.textNombreNodo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdAgregarPrincipio = new System.Windows.Forms.Button();
            this.cmdAgregarFinal = new System.Windows.Forms.Button();
            this.listListaEnlazada = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textNombreNodo
            // 
            this.textNombreNodo.Location = new System.Drawing.Point(172, 145);
            this.textNombreNodo.Name = "textNombreNodo";
            this.textNombreNodo.Size = new System.Drawing.Size(130, 20);
            this.textNombreNodo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre del Nodo";
            // 
            // cmdAgregarPrincipio
            // 
            this.cmdAgregarPrincipio.Location = new System.Drawing.Point(172, 181);
            this.cmdAgregarPrincipio.Name = "cmdAgregarPrincipio";
            this.cmdAgregarPrincipio.Size = new System.Drawing.Size(130, 23);
            this.cmdAgregarPrincipio.TabIndex = 2;
            this.cmdAgregarPrincipio.Text = "Agregar al Principio";
            this.cmdAgregarPrincipio.UseVisualStyleBackColor = true;
            this.cmdAgregarPrincipio.Click += new System.EventHandler(this.cmdAgregarPrincipio_Click);
            // 
            // cmdAgregarFinal
            // 
            this.cmdAgregarFinal.Location = new System.Drawing.Point(175, 223);
            this.cmdAgregarFinal.Name = "cmdAgregarFinal";
            this.cmdAgregarFinal.Size = new System.Drawing.Size(127, 23);
            this.cmdAgregarFinal.TabIndex = 3;
            this.cmdAgregarFinal.Text = "Agregar al Final";
            this.cmdAgregarFinal.UseVisualStyleBackColor = true;
            this.cmdAgregarFinal.Click += new System.EventHandler(this.cmdAgregarFinal_Click);
            // 
            // listListaEnlazada
            // 
            this.listListaEnlazada.FormattingEnabled = true;
            this.listListaEnlazada.Location = new System.Drawing.Point(26, 31);
            this.listListaEnlazada.Name = "listListaEnlazada";
            this.listListaEnlazada.Size = new System.Drawing.Size(125, 212);
            this.listListaEnlazada.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listListaEnlazada);
            this.Controls.Add(this.cmdAgregarFinal);
            this.Controls.Add(this.cmdAgregarPrincipio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textNombreNodo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textNombreNodo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdAgregarPrincipio;
        private System.Windows.Forms.Button cmdAgregarFinal;
        private System.Windows.Forms.ListBox listListaEnlazada;
    }
}

