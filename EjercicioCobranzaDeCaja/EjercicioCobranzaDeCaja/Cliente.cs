using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCobranzaDeCaja
{
    internal class Cliente
    {
        public string Nombre { get; set; }
        public int Cantidad { get; set; }

        public decimal Importe { get; set; }

        public Cliente Siguiente { get; set; }


        public override string ToString()
        {
            return $"{Nombre} - {Cantidad} productos - ${Importe}";
        }
    }
}
