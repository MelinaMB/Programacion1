using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApereoCorteDecontrolMejorado
{
    public partial class Form1 : Form
    {
        GestorAlumnos gestorAlumnos = new GestorAlumnos();
        GestorNotas gestorNotas = new GestorNotas();
        public Form1()
        {
            InitializeComponent();
            MostrarNota();
            MostrarAlumno();
            
        }

        void MostrarAlumno() {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = gestorAlumnos.LeerAlumno();
        }

        void MostrarNota() { 
            this.dataGridView2.DataSource = null;
            this.dataGridView2.DataSource = gestorNotas.LeerNota();
        }
        private void btnGuardarAlumno_Click(object sender, EventArgs e)
        {
            if ((int)numericLegajo.Value <= 0)
            {
                MessageBox.Show("Ingresa un legajo válido (mayor a 0).");
                return;
            }
            Alumno unAlumno = new Alumno((int)numericLegajo.Value, textBoxName.Text);
            List<Alumno> alumnos = gestorAlumnos.LeerAlumno();
            //verifica si el legajo es un numero positivo
            
            // Verifica si el legajo ya existe
            bool legajoRepetido = alumnos.Any(a => a.Legajo == (int)numericLegajo.Value);
            if (legajoRepetido)
            {
                MessageBox.Show("El legajo ya existe. Ingresa un legajo único.");
                return;
            }
            else {
                gestorAlumnos.GuardarAlumno(unAlumno);
                MostrarAlumno();
                MessageBox.Show("Alumno guardado exitosamente.");
            }
            //limpia los campos
            numericLegajo.Value = 0;
            textBoxName.Clear();
        }

        private void GuardarPromedios(List<Promedio> promedios, string archivo)
        {
            using (StreamWriter writer = new StreamWriter(archivo))  // Crea o sobrescribe el archivo
            {
                // Escribe una cabecera 
                writer.WriteLine("Apellido,Legajo,ValorPromedio");

                // Recorre la lista y escribe cada promedio
                foreach (Promedio p in promedios)
                {
                    // Formatea la línea: ej. "Perez,123,8.5"
                    string linea = $"{p.Apellido},{p.Legajo},{p.ValorPromedio}";
                    writer.WriteLine(linea);
                }
            }
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            Nota unaNota = new Nota((int)numLegajoNota.Value, (int)numericNota.Value);
            gestorNotas.GuardarNota(unaNota);
            MostrarNota();
        }

        private void btnSacarAlumno_Click(object sender, EventArgs e)
        {
            gestorAlumnos.SacarAlumno((int)numericLegajo.Value);
            MessageBox.Show("Alumno eliminado.");
            MostrarAlumno();
        }

        private void btnEliminarNota_Click(object sender, EventArgs e)
        {
            gestorNotas.EliminarNota((int)numLegajoNota.Value);
            MessageBox.Show("Nota eliminada.");
            MostrarNota();
        }

        private void btnObtenerPromedio_Click_1(object sender, EventArgs e)
        {
            //primero ordeno la lista de alumnos
            List<Alumno> alumnos = gestorAlumnos.Ordenar();
            //segundo ordeno la lista de notas
            List<Nota> notas = gestorNotas.Ordenar();
            //me fijo si en la lista de alumnos hay alumnos
            if (alumnos.Count == 0)
            {

                MessageBox.Show("No hay alumnos para calcular promedios.");

            }
            //creo una lista para los promedios
            List<Promedio> promedios = new List<Promedio>();


            //voy a recorrer la lista alumnos por su largo
            for (int i = 0; i < alumnos.Count; i++)
            {
                //creo el objeto promedio
                Promedio p = new Promedio();
                //a ese objeto le asigno apellido y legajo
                p.Apellido = alumnos[i].Apellido;
                p.Legajo = alumnos[i].Legajo;

                int contador = 0;
                int acumulador = 0;
                //voy a recorrer la lista notas por su largo
                for (int x = 0; x < notas.Count; x++)
                {
                    //si el legajo de notas coincide con el legajo de alumnos entonces
                    if (notas[x].Legajo == alumnos[i].Legajo)
                    {//cuando esta condicion no se cumpla se realiza el corte de control
                        //aumento el contador en 1
                        contador++;
                        //voy sumando las noras de ese alumno
                        acumulador += notas[x].ValorNota;

                    }
                }
                //una vez que termine de sumar todas las notas de ese alumno saco el promedio y le asigno al objeto p el valor del promedio
                p.ValorPromedio = contador == 0 ? 0 : (double)acumulador / contador;
                //agrego el objeto p a la lista promedios
                promedios.Add(p);

            }
            GuardarPromedios(promedios, "promedios.txt");
            dataGridView3.DataSource = null;
            dataGridView3.DataSource = promedios;
            dataGridView3.Refresh();//actualiza la vista
        }

        private void btnModificarAlumno_Click(object sender, EventArgs e)
        {
            int legajo = (int)numericLegajo.Value;
            string nuevoApellido = textBoxName.Text.Trim();

            // Validaciones
            if (legajo <= 0)
            {
                MessageBox.Show("Ingresa un legajo válido.");
                return;
            }
            if (string.IsNullOrWhiteSpace(nuevoApellido))
            {
                MessageBox.Show("Ingresa un apellido válido.");
                return;
            }

            // Llama al gestor para modificar
            bool modificado = gestorAlumnos.ModificarAlumno(legajo, nuevoApellido);
            if (modificado)
            {
                MostrarAlumno();
                MessageBox.Show("Alumno modificado.");
                numericLegajo.Value = 0;
                textBoxName.Clear();
            }
            else
            {
                MessageBox.Show("Alumno no encontrado.");
            }
        }

        private void btnModificarNota_Click(object sender, EventArgs e)
        {
            int nuevaNota = (int)numericNota.Value;

            // Validar nueva nota
            if (nuevaNota < 0 || nuevaNota > 10)
            {
                MessageBox.Show("Ingresa una nota válida (0-10).");
                return;
            }

            // Verificar selección
            if (dataGridView2.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona al menos una nota.");
                return;
            }

            // Usar for en lugar de foreach
            for (int i = 0; i < dataGridView2.SelectedRows.Count; i++)
            {
                DataGridViewRow row = dataGridView2.SelectedRows[i];
                int legajo = (int)row.Cells["Legajo"].Value;  // Asume columna "Legajo"

                // Guardar de a una: llama a ModificarNota, que guarda el archivo
                bool modificada = gestorNotas.ModificarNota(legajo, nuevaNota);
                if (!modificada)
                {
                    MessageBox.Show($"Nota para legajo {legajo} no encontrada.");
                }
            }

            MostrarNota();  // Refresca el grid
            MessageBox.Show("Notas modificadas.");
        }
    }
}
