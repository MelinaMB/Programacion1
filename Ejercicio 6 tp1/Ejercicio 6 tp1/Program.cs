using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6_tp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String numero;

            Console.WriteLine("Ingresa un numero :");
            numero = Console.ReadLine();
            int numeroParaMulticplicar = int.Parse(numero);

            for (int i = 0; i <=10; i++) {

                Console.WriteLine("La tabla de multiplicar de este numero es : {0} ", numeroParaMulticplicar * i);

            }
        }
    }
}
