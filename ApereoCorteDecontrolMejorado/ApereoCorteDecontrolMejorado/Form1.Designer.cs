namespace ApereoCorteDecontrolMejorado
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
            this.btnGuardarAlumno = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnObtenerPromedio = new System.Windows.Forms.Button();
            this.numericLegajo = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.numLegajoNota = new System.Windows.Forms.NumericUpDown();
            this.numericNota = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.btnSacarAlumno = new System.Windows.Forms.Button();
            this.btnEliminarNota = new System.Windows.Forms.Button();
            this.btnModificarAlumno = new System.Windows.Forms.Button();
            this.btnModificarNota = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericLegajo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLegajoNota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardarAlumno
            // 
            this.btnGuardarAlumno.Location = new System.Drawing.Point(116, 105);
            this.btnGuardarAlumno.Name = "btnGuardarAlumno";
            this.btnGuardarAlumno.Size = new System.Drawing.Size(111, 23);
            this.btnGuardarAlumno.TabIndex = 0;
            this.btnGuardarAlumno.Text = "Guardar Alumno";
            this.btnGuardarAlumno.UseVisualStyleBackColor = true;
            this.btnGuardarAlumno.Click += new System.EventHandler(this.btnGuardarAlumno_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(127, 270);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Guardar Nota";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnObtenerPromedio
            // 
            this.btnObtenerPromedio.Location = new System.Drawing.Point(127, 380);
            this.btnObtenerPromedio.Name = "btnObtenerPromedio";
            this.btnObtenerPromedio.Size = new System.Drawing.Size(100, 23);
            this.btnObtenerPromedio.TabIndex = 2;
            this.btnObtenerPromedio.Text = "Obtener Promedio";
            this.btnObtenerPromedio.UseVisualStyleBackColor = true;
            this.btnObtenerPromedio.Click += new System.EventHandler(this.btnObtenerPromedio_Click_1);
            // 
            // numericLegajo
            // 
            this.numericLegajo.Location = new System.Drawing.Point(127, 43);
            this.numericLegajo.Name = "numericLegajo";
            this.numericLegajo.Size = new System.Drawing.Size(120, 20);
            this.numericLegajo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Legajo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Apellido";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(127, 69);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 6;
            // 
            // numLegajoNota
            // 
            this.numLegajoNota.Location = new System.Drawing.Point(127, 199);
            this.numLegajoNota.Name = "numLegajoNota";
            this.numLegajoNota.Size = new System.Drawing.Size(120, 20);
            this.numLegajoNota.TabIndex = 7;
            // 
            // numericNota
            // 
            this.numericNota.Location = new System.Drawing.Point(127, 238);
            this.numericNota.Name = "numericNota";
            this.numericNota.Size = new System.Drawing.Size(120, 20);
            this.numericNota.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Legajo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nota";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(313, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(322, 150);
            this.dataGridView1.TabIndex = 11;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(313, 178);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(322, 150);
            this.dataGridView2.TabIndex = 12;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(313, 358);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(322, 150);
            this.dataGridView3.TabIndex = 13;
            // 
            // btnSacarAlumno
            // 
            this.btnSacarAlumno.Location = new System.Drawing.Point(116, 136);
            this.btnSacarAlumno.Name = "btnSacarAlumno";
            this.btnSacarAlumno.Size = new System.Drawing.Size(111, 23);
            this.btnSacarAlumno.TabIndex = 14;
            this.btnSacarAlumno.Text = "Sacar Alumno";
            this.btnSacarAlumno.UseVisualStyleBackColor = true;
            this.btnSacarAlumno.Click += new System.EventHandler(this.btnSacarAlumno_Click);
            // 
            // btnEliminarNota
            // 
            this.btnEliminarNota.Location = new System.Drawing.Point(127, 299);
            this.btnEliminarNota.Name = "btnEliminarNota";
            this.btnEliminarNota.Size = new System.Drawing.Size(100, 23);
            this.btnEliminarNota.TabIndex = 15;
            this.btnEliminarNota.Text = "Eliminar Nota";
            this.btnEliminarNota.UseVisualStyleBackColor = true;
            this.btnEliminarNota.Click += new System.EventHandler(this.btnEliminarNota_Click);
            // 
            // btnModificarAlumno
            // 
            this.btnModificarAlumno.Location = new System.Drawing.Point(116, 166);
            this.btnModificarAlumno.Name = "btnModificarAlumno";
            this.btnModificarAlumno.Size = new System.Drawing.Size(111, 23);
            this.btnModificarAlumno.TabIndex = 16;
            this.btnModificarAlumno.Text = "Modificar Alumno";
            this.btnModificarAlumno.UseVisualStyleBackColor = true;
            this.btnModificarAlumno.Click += new System.EventHandler(this.btnModificarAlumno_Click);
            // 
            // btnModificarNota
            // 
            this.btnModificarNota.Location = new System.Drawing.Point(127, 329);
            this.btnModificarNota.Name = "btnModificarNota";
            this.btnModificarNota.Size = new System.Drawing.Size(100, 23);
            this.btnModificarNota.TabIndex = 17;
            this.btnModificarNota.Text = "Modificar Nota";
            this.btnModificarNota.UseVisualStyleBackColor = true;
            this.btnModificarNota.Click += new System.EventHandler(this.btnModificarNota_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 532);
            this.Controls.Add(this.btnModificarNota);
            this.Controls.Add(this.btnModificarAlumno);
            this.Controls.Add(this.btnEliminarNota);
            this.Controls.Add(this.btnSacarAlumno);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericNota);
            this.Controls.Add(this.numLegajoNota);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericLegajo);
            this.Controls.Add(this.btnObtenerPromedio);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnGuardarAlumno);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericLegajo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLegajoNota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardarAlumno;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnObtenerPromedio;
        private System.Windows.Forms.NumericUpDown numericLegajo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.NumericUpDown numLegajoNota;
        private System.Windows.Forms.NumericUpDown numericNota;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button btnSacarAlumno;
        private System.Windows.Forms.Button btnEliminarNota;
        private System.Windows.Forms.Button btnModificarAlumno;
        private System.Windows.Forms.Button btnModificarNota;
    }
}

