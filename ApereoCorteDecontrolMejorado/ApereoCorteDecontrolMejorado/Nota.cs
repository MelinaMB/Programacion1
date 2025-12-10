using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApereoCorteDecontrolMejorado
{
    internal class Nota
    {
        public int Legajo { get; set; }
        public int ValorNota { get; set; }

        //CONSTRUCTOR recibe como parametro la linea
        public Nota(string linea)
        {

            var datos = linea.Split(',');

            Legajo = int.Parse(datos[0]);
            ValorNota = int.Parse(datos[1]);
        }

        //CONSTRUCTOR para crear una instancia de un objeto recibe como parametro el legajo y valorNota
        public Nota(int legajo, int valorNota)
        {

            Legajo = legajo;
            ValorNota = valorNota;

        }

        public string ObtenerRegistro()
        {

            return String.Format("{0},{1}", Legajo, ValorNota);

        }
    }
}
