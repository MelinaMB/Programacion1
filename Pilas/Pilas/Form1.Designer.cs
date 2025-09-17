namespace Pilas
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
            this.label1 = new System.Windows.Forms.Label();
            this.textNombreNodo = new System.Windows.Forms.TextBox();
            this.btnAgregarNuevoNodo = new System.Windows.Forms.Button();
            this.listMiPila = new System.Windows.Forms.ListBox();
            this.btnDesapilar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(306, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresa Numero";
            // 
            // textNombreNodo
            // 
            this.textNombreNodo.Location = new System.Drawing.Point(386, 59);
            this.textNombreNodo.Name = "textNombreNodo";
            this.textNombreNodo.Size = new System.Drawing.Size(100, 20);
            this.textNombreNodo.TabIndex = 1;
            // 
            // btnAgregarNuevoNodo
            // 
            this.btnAgregarNuevoNodo.Location = new System.Drawing.Point(386, 101);
            this.btnAgregarNuevoNodo.Name = "btnAgregarNuevoNodo";
            this.btnAgregarNuevoNodo.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarNuevoNodo.TabIndex = 2;
            this.btnAgregarNuevoNodo.Text = "Apilar";
            this.btnAgregarNuevoNodo.UseVisualStyleBackColor = true;
            this.btnAgregarNuevoNodo.Click += new System.EventHandler(this.btnAgregarNuevoNodo_Click);
            // 
            // listMiPila
            // 
            this.listMiPila.FormattingEnabled = true;
            this.listMiPila.Location = new System.Drawing.Point(503, 59);
            this.listMiPila.Name = "listMiPila";
            this.listMiPila.Size = new System.Drawing.Size(120, 251);
            this.listMiPila.TabIndex = 3;
            // 
            // btnDesapilar
            // 
            this.btnDesapilar.Location = new System.Drawing.Point(386, 141);
            this.btnDesapilar.Name = "btnDesapilar";
            this.btnDesapilar.Size = new System.Drawing.Size(75, 23);
            this.btnDesapilar.TabIndex = 4;
            this.btnDesapilar.Text = "Desapilar";
            this.btnDesapilar.UseVisualStyleBackColor = true;
            this.btnDesapilar.Click += new System.EventHandler(this.btnDesapilar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDesapilar);
            this.Controls.Add(this.listMiPila);
            this.Controls.Add(this.btnAgregarNuevoNodo);
            this.Controls.Add(this.textNombreNodo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNombreNodo;
        private System.Windows.Forms.Button btnAgregarNuevoNodo;
        private System.Windows.Forms.ListBox listMiPila;
        private System.Windows.Forms.Button btnDesapilar;
    }
}

