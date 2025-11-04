using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Archivos
{
    public partial class Form1 : Form
    {
        GestorAlumnos alumnos = new GestorAlumnos();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            Alumnos alumno = new Alumnos((long)this.numDNI.Value)
            {
                Apellido = this.textApellido.Text,
                Nombre = this.textNombre.Text

            };

            alumnos.Alta(alumno);
            LlenarGrilla();
        }

        private void LlenarGrilla()
        {
            this.dataGridView1.DataSource = null; // borra todos los datos que hay en la grilla 
            this.dataGridView1.DataSource = alumnos.Lista(); // devuelve una lista con los alumnos
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count == 1) 
            {
                Alumnos seleccionado = (Alumnos)this.dataGridView1.SelectedRows[0].DataBoundItem;
                alumnos.Baja(seleccionado.DNI);
                LlenarGrilla();
            }
        }
    }

    


}
