namespace EjercicioSegundoParcial
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
            this.grillaVentas = new System.Windows.Forms.DataGridView();
            this.textCodigoMarca = new System.Windows.Forms.TextBox();
            this.textModelo = new System.Windows.Forms.TextBox();
            this.numericVentaAuto = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAlta = new System.Windows.Forms.Button();
            this.grillaTotalVentasPorMarca = new System.Windows.Forms.DataGridView();
            this.labelTotalConsecionaria = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnTotalDeVentasXMarca = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grillaVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericVentaAuto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaTotalVentasPorMarca)).BeginInit();
            this.SuspendLayout();
            // 
            // grillaVentas
            // 
            this.grillaVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaVentas.Location = new System.Drawing.Point(232, 32);
            this.grillaVentas.Name = "grillaVentas";
            this.grillaVentas.Size = new System.Drawing.Size(389, 150);
            this.grillaVentas.TabIndex = 0;
            // 
            // textCodigoMarca
            // 
            this.textCodigoMarca.Location = new System.Drawing.Point(126, 35);
            this.textCodigoMarca.Name = "textCodigoMarca";
            this.textCodigoMarca.Size = new System.Drawing.Size(100, 20);
            this.textCodigoMarca.TabIndex = 1;
            // 
            // textModelo
            // 
            this.textModelo.Location = new System.Drawing.Point(126, 80);
            this.textModelo.Name = "textModelo";
            this.textModelo.Size = new System.Drawing.Size(100, 20);
            this.textModelo.TabIndex = 2;
            // 
            // numericVentaAuto
            // 
            this.numericVentaAuto.Location = new System.Drawing.Point(106, 124);
            this.numericVentaAuto.Name = "numericVentaAuto";
            this.numericVentaAuto.Size = new System.Drawing.Size(120, 20);
            this.numericVentaAuto.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Codigo Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Modelo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Venta x Auto";
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(142, 159);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(75, 23);
            this.btnAlta.TabIndex = 7;
            this.btnAlta.Text = "Alta";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // grillaTotalVentasPorMarca
            // 
            this.grillaTotalVentasPorMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaTotalVentasPorMarca.Location = new System.Drawing.Point(232, 188);
            this.grillaTotalVentasPorMarca.Name = "grillaTotalVentasPorMarca";
            this.grillaTotalVentasPorMarca.Size = new System.Drawing.Size(389, 150);
            this.grillaTotalVentasPorMarca.TabIndex = 8;
            // 
            // labelTotalConsecionaria
            // 
            this.labelTotalConsecionaria.AutoSize = true;
            this.labelTotalConsecionaria.Location = new System.Drawing.Point(229, 364);
            this.labelTotalConsecionaria.Name = "labelTotalConsecionaria";
            this.labelTotalConsecionaria.Size = new System.Drawing.Size(113, 13);
            this.labelTotalConsecionaria.TabIndex = 9;
            this.labelTotalConsecionaria.Text = "Total Consecionaria: $";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTotalDeVentasXMarca
            // 
            this.btnTotalDeVentasXMarca.Location = new System.Drawing.Point(67, 208);
            this.btnTotalDeVentasXMarca.Name = "btnTotalDeVentasXMarca";
            this.btnTotalDeVentasXMarca.Size = new System.Drawing.Size(134, 23);
            this.btnTotalDeVentasXMarca.TabIndex = 12;
            this.btnTotalDeVentasXMarca.Text = "Total de Ventas x Marca";
            this.btnTotalDeVentasXMarca.UseVisualStyleBackColor = true;
            this.btnTotalDeVentasXMarca.Click += new System.EventHandler(this.btnTotalDeVentasXMarca_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTotalDeVentasXMarca);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelTotalConsecionaria);
            this.Controls.Add(this.grillaTotalVentasPorMarca);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericVentaAuto);
            this.Controls.Add(this.textModelo);
            this.Controls.Add(this.textCodigoMarca);
            this.Controls.Add(this.grillaVentas);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.grillaVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericVentaAuto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaTotalVentasPorMarca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grillaVentas;
        private System.Windows.Forms.TextBox textCodigoMarca;
        private System.Windows.Forms.TextBox textModelo;
        private System.Windows.Forms.NumericUpDown numericVentaAuto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.DataGridView grillaTotalVentasPorMarca;
        private System.Windows.Forms.Label labelTotalConsecionaria;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnTotalDeVentasXMarca;
    }
}

