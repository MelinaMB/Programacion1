using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    internal class Alumnos
    {
        public long DNI { get; private set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public Alumnos(long dni) { 

            this.DNI = dni;
        }

        public Alumnos(string linea) {
            //constructor
            string[] datos = linea.Split(',');
            this.DNI = long.Parse(datos[0]);
            this.Apellido = datos[1];
            this.Nombre = datos[2];

        }
        public String GenerarRegistro() {
            return $"{DNI}, {Apellido}, {Nombre}";
        }
    }
}
