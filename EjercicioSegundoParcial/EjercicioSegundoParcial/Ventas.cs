using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioSegundoParcial
{
    internal class Ventas
    {
       public string CodigoDeMarca { get; set; }
       public string Modelo { get; set; }

       public int VentasXAuto { get; set; }

        public Ventas(string linea) {

            var datos = linea.Split(',');
            CodigoDeMarca = datos[0];
            Modelo = datos[1];
            VentasXAuto = int.Parse(datos[2]);

        }

        public Ventas(string codigo, string modelo, int ventasXAuto) {
            CodigoDeMarca = codigo;
            Modelo = modelo;
            VentasXAuto = ventasXAuto;


        }

        public string ObtenerRegistro()
        {
            return String.Format("{0},{1},{2}", CodigoDeMarca, Modelo, VentasXAuto);
        }
    }
}
