using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5_tp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String base1;
            String altura;

            Console.WriteLine("Ingresa el base del rectangulo :");
            base1 = Console.ReadLine();
            int base1Rectangulo = int.Parse(base1);
            Console.WriteLine("Ingresa el altura del rectangulo :");
            altura = Console.ReadLine();
            int alturaRectangulo = int.Parse(altura);
            Console.WriteLine("La superficie del rectangulo es : {0} ",( 2* (base1Rectangulo + alturaRectangulo)));
            Console.ReadKey();
        }
    }
}
