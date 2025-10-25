using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_Apareo_Corte_Control
{
    public partial class Form1 : Form
    {
        GestorAlumnos gestorAlumnos;
        GestorNotas gestorNotas;
        public Form1()
        {
            InitializeComponent();
        }

        void MostrarAlumno() {

            this.grillaAlumnos.DataSource = null;
            this.grillaAlumnos.DataSource = gestorAlumnos.LeerAlumnos();
        }

        void MostrarNota()
        {

            this.grillaAlumnos.DataSource = null;
            this.grillaAlumnos.DataSource = gestorNotas.LeerNotas();
        }

        private void btnGuardarAlumno_Click(object sender, EventArgs e)
        {
            Alumno unAlumno = new Alumno((int)this.numLegajo.Value, this.textApellido.Text);
            gestorAlumnos.GuardarAlumno(unAlumno);
            MostrarAlumno();
        }

        private void btnGuardarNota_Click(object sender, EventArgs e)
        {
            Nota unaNota = new Nota((int)numLegajo2.Value, (int)numNota.Value);
            gestorNotas.GuardarNota(unaNota);
            MostrarNota();
        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            Alumno[] alumnos = gestorAlumnos.Ordenar();
            Nota[] notas = gestorNotas.Ordenar();
            List<Promedio> promedios = new List<Promedio>();

            for (int i = 0; i < alumnos.Length; i++) {

                Promedio p = new Promedio();
                p.Apellido = alumnos[i].Apellido;
                p.Legajo = alumnos[i].Legajo;

                int contador = 0;
                int acumulador = 0;
                for (int x = 0; x < notas.Length; x++) {

                    if (notas[x].Legajo == alumnos[i].Legajo) {

                        contador++;
                        acumulador += notas[x].ValorNota;
                        
                    }
                }

                p.ValorPromedio = contador ==0?0 :acumulador/contador;
                promedios.Add(p);
            }

            grillaPromedio.DataSource = null;
            grillaPromedio.DataSource = promedios;
        }
    }
}
