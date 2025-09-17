using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilasNumeros
{
    internal class MiPila
    {
        MiNodo tope;

        public MiNodo Tope()
        {
            return tope;
        }
        public void Apilar(MiNodo unNodo)
        {

            if (tope == null)
            {

                tope = unNodo;
            }
            else
            {
                MiNodo aux = tope;
                tope = unNodo;
                tope.Siguiente = aux;
            }

        }

        public void Desapilar()
        {
            if (tope != null)
            {

                tope = tope.Siguiente;
            }

        }
    }
}
