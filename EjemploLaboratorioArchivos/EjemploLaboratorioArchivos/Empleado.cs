using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploLaboratorioArchivos
{
    internal class Empleado
    {
        public Empleado(int legajo)
        {
            this.legajo = legajo;
        }

        public Empleado(string lines) {

            string[] datos = lines.Split(',');
            this.legajo = int.Parse(datos[0]);
            this.nombreYApellido = datos[1];
            this.categoria = datos[2];
        }

        public int legajo { get; set; }
        public string nombreYApellido { get; set; }

        public string categoria {  get; set; }



        public string GenerarRegistro() {
            return $"{legajo}, {nombreYApellido}, {categoria}";
        }
        
    }
}
