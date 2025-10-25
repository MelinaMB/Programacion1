namespace Ejemplo_Apareo_Corte_Control
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
            this.grillaAlumnos = new System.Windows.Forms.DataGridView();
            this.grillaNotas = new System.Windows.Forms.DataGridView();
            this.grillaPromedio = new System.Windows.Forms.DataGridView();
            this.numLegajo = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.btnGuardarAlumno = new System.Windows.Forms.Button();
            this.numLegajo2 = new System.Windows.Forms.NumericUpDown();
            this.numNota = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGuardarNota = new System.Windows.Forms.Button();
            this.btnPromedio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grillaAlumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaNotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaPromedio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLegajo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLegajo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNota)).BeginInit();
            this.SuspendLayout();
            // 
            // grillaAlumnos
            // 
            this.grillaAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaAlumnos.Location = new System.Drawing.Point(324, 12);
            this.grillaAlumnos.Name = "grillaAlumnos";
            this.grillaAlumnos.Size = new System.Drawing.Size(295, 150);
            this.grillaAlumnos.TabIndex = 0;
            // 
            // grillaNotas
            // 
            this.grillaNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaNotas.Location = new System.Drawing.Point(324, 168);
            this.grillaNotas.Name = "grillaNotas";
            this.grillaNotas.Size = new System.Drawing.Size(295, 150);
            this.grillaNotas.TabIndex = 1;
            // 
            // grillaPromedio
            // 
            this.grillaPromedio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaPromedio.Location = new System.Drawing.Point(324, 325);
            this.grillaPromedio.Name = "grillaPromedio";
            this.grillaPromedio.Size = new System.Drawing.Size(295, 150);
            this.grillaPromedio.TabIndex = 2;
            // 
            // numLegajo
            // 
            this.numLegajo.Location = new System.Drawing.Point(128, 28);
            this.numLegajo.Name = "numLegajo";
            this.numLegajo.Size = new System.Drawing.Size(120, 20);
            this.numLegajo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Legajo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Apellido";
            // 
            // textApellido
            // 
            this.textApellido.Location = new System.Drawing.Point(128, 66);
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(100, 20);
            this.textApellido.TabIndex = 6;
            // 
            // btnGuardarAlumno
            // 
            this.btnGuardarAlumno.Location = new System.Drawing.Point(124, 112);
            this.btnGuardarAlumno.Name = "btnGuardarAlumno";
            this.btnGuardarAlumno.Size = new System.Drawing.Size(124, 23);
            this.btnGuardarAlumno.TabIndex = 7;
            this.btnGuardarAlumno.Text = "Guardar Alumno";
            this.btnGuardarAlumno.UseVisualStyleBackColor = true;
            this.btnGuardarAlumno.Click += new System.EventHandler(this.btnGuardarAlumno_Click);
            // 
            // numLegajo2
            // 
            this.numLegajo2.Location = new System.Drawing.Point(128, 221);
            this.numLegajo2.Name = "numLegajo2";
            this.numLegajo2.Size = new System.Drawing.Size(120, 20);
            this.numLegajo2.TabIndex = 8;
            // 
            // numNota
            // 
            this.numNota.Location = new System.Drawing.Point(128, 275);
            this.numNota.Name = "numNota";
            this.numNota.Size = new System.Drawing.Size(120, 20);
            this.numNota.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Legajo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nota";
            // 
            // btnGuardarNota
            // 
            this.btnGuardarNota.Location = new System.Drawing.Point(128, 325);
            this.btnGuardarNota.Name = "btnGuardarNota";
            this.btnGuardarNota.Size = new System.Drawing.Size(131, 23);
            this.btnGuardarNota.TabIndex = 12;
            this.btnGuardarNota.Text = "Guardar Nota";
            this.btnGuardarNota.UseVisualStyleBackColor = true;
            this.btnGuardarNota.Click += new System.EventHandler(this.btnGuardarNota_Click);
            // 
            // btnPromedio
            // 
            this.btnPromedio.Location = new System.Drawing.Point(124, 400);
            this.btnPromedio.Name = "btnPromedio";
            this.btnPromedio.Size = new System.Drawing.Size(134, 23);
            this.btnPromedio.TabIndex = 13;
            this.btnPromedio.Text = "Obtener Promedio";
            this.btnPromedio.UseVisualStyleBackColor = true;
            this.btnPromedio.Click += new System.EventHandler(this.btnPromedio_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 482);
            this.Controls.Add(this.btnPromedio);
            this.Controls.Add(this.btnGuardarNota);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numNota);
            this.Controls.Add(this.numLegajo2);
            this.Controls.Add(this.btnGuardarAlumno);
            this.Controls.Add(this.textApellido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numLegajo);
            this.Controls.Add(this.grillaPromedio);
            this.Controls.Add(this.grillaNotas);
            this.Controls.Add(this.grillaAlumnos);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.grillaAlumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaNotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaPromedio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLegajo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLegajo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grillaAlumnos;
        private System.Windows.Forms.DataGridView grillaNotas;
        private System.Windows.Forms.DataGridView grillaPromedio;
        private System.Windows.Forms.NumericUpDown numLegajo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textApellido;
        private System.Windows.Forms.Button btnGuardarAlumno;
        private System.Windows.Forms.NumericUpDown numLegajo2;
        private System.Windows.Forms.NumericUpDown numNota;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGuardarNota;
        private System.Windows.Forms.Button btnPromedio;
    }
}

