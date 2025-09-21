namespace Colas2020
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
            this.lstColaF = new System.Windows.Forms.ListView();
            this.txtNombreNodo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEncolar = new System.Windows.Forms.Button();
            this.lstColaM = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDesencolarF = new System.Windows.Forms.Button();
            this.btnDesencolarM = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstColaF
            // 
            this.lstColaF.HideSelection = false;
            this.lstColaF.Location = new System.Drawing.Point(17, 51);
            this.lstColaF.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstColaF.Name = "lstColaF";
            this.lstColaF.Size = new System.Drawing.Size(174, 127);
            this.lstColaF.TabIndex = 0;
            this.lstColaF.UseCompatibleStateImageBehavior = false;
            // 
            // txtNombreNodo
            // 
            this.txtNombreNodo.Location = new System.Drawing.Point(253, 171);
            this.txtNombreNodo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombreNodo.Name = "txtNombreNodo";
            this.txtNombreNodo.Size = new System.Drawing.Size(60, 20);
            this.txtNombreNodo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 137);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nadadores";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnEncolar
            // 
            this.btnEncolar.Location = new System.Drawing.Point(253, 206);
            this.btnEncolar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEncolar.Name = "btnEncolar";
            this.btnEncolar.Size = new System.Drawing.Size(56, 19);
            this.btnEncolar.TabIndex = 3;
            this.btnEncolar.Text = "Encolar";
            this.btnEncolar.UseVisualStyleBackColor = true;
            this.btnEncolar.Click += new System.EventHandler(this.btnEncolar_Click);
            // 
            // lstColaM
            // 
            this.lstColaM.HideSelection = false;
            this.lstColaM.Location = new System.Drawing.Point(17, 236);
            this.lstColaM.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstColaM.Name = "lstColaM";
            this.lstColaM.Size = new System.Drawing.Size(174, 121);
            this.lstColaM.TabIndex = 5;
            this.lstColaM.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cola Femenina";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 206);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cola Masculina";
            // 
            // btnDesencolarF
            // 
            this.btnDesencolarF.Location = new System.Drawing.Point(238, 236);
            this.btnDesencolarF.Name = "btnDesencolarF";
            this.btnDesencolarF.Size = new System.Drawing.Size(91, 32);
            this.btnDesencolarF.TabIndex = 8;
            this.btnDesencolarF.Text = "DesencolarF";
            this.btnDesencolarF.UseVisualStyleBackColor = true;
            this.btnDesencolarF.Click += new System.EventHandler(this.btnDesencolarF_Click);
            // 
            // btnDesencolarM
            // 
            this.btnDesencolarM.Location = new System.Drawing.Point(238, 274);
            this.btnDesencolarM.Name = "btnDesencolarM";
            this.btnDesencolarM.Size = new System.Drawing.Size(90, 27);
            this.btnDesencolarM.TabIndex = 9;
            this.btnDesencolarM.Text = "DesencolarM";
            this.btnDesencolarM.UseVisualStyleBackColor = true;
            this.btnDesencolarM.Click += new System.EventHandler(this.btnDesencolarM_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 366);
            this.Controls.Add(this.btnDesencolarM);
            this.Controls.Add(this.btnDesencolarF);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstColaM);
            this.Controls.Add(this.btnEncolar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombreNodo);
            this.Controls.Add(this.lstColaF);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstColaF;
        private System.Windows.Forms.TextBox txtNombreNodo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEncolar;
        private System.Windows.Forms.ListView lstColaM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDesencolarF;
        private System.Windows.Forms.Button btnDesencolarM;
    }
}

