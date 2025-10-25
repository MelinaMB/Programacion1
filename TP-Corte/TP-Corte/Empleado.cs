using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Corte
{
    public class Empleado
    {
        public int CodigoEmpleado { get; set; }
        public string NombreEmpleado { get; set; }
        public int ProduccionEmpleado { get; set; }

        public Empleado(string linea)
        {

            var datos = linea.Split(',');
            CodigoEmpleado = int.Parse(datos[0]);
            NombreEmpleado = datos[1];
            ProduccionEmpleado = int.Parse(datos[2]);
        }

        public Empleado(int codigo, string nombre, int produccion)
        {

            CodigoEmpleado = codigo;
            NombreEmpleado = nombre;
            ProduccionEmpleado = produccion;
        }

        public string ObtenerRegistro()
        {
            return String.Format("{0},{1},{2}", CodigoEmpleado, NombreEmpleado, ProduccionEmpleado);
        }
    }
}
