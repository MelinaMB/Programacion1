using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilas
{
    internal class MiPila
    {
        MiNodo tope;

        public MiNodo Tope() { 
            return tope;
        }
        void Apilar(MiNodo unNodo) {

            if (tope == null)
            {

                tope = unNodo;
            }
            else { 
                MiNodo aux = tope;
                tope = unNodo;
                tope.Siguiente = aux;
            }
        
        }

        void Desapilar() {
            if (tope != null) { 

                tope = tope.Siguiente;
            }
            
        }
    }
}
