using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploColas
{
    internal class Cola
    {
        Nodo _inicio;
        public void Encolar(Nodo unNodo) { // agraga una persona al final

        }

        public void Desencolar() { // quita la primera persona

            _inicio = _inicio.Siguiente;
        }

        public Nodo Inicio { // persona al inicio de la cola

            get { return _inicio; }

        }
    }
}
