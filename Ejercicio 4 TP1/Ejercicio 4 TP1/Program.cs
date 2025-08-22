using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4_TP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String lado;

            Console.WriteLine("Ingresa el lado del cuadrado :");
            lado = Console.ReadLine();
            int ladoDelCuadrado = int.Parse(lado);
            Console.WriteLine("El perimetro del cuadrado es : {0}", ladoDelCuadrado*ladoDelCuadrado);
            Console.ReadKey();
        }
    }
}
