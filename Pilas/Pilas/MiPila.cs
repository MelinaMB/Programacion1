using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilas
{
    internal class MiPila
    {
        //variable interna de la pila que va a indicar el tope
        MiNodo tope;

        //funcion que nos devuelve el tope
        public MiNodo Tope() { 
            return tope;
        }
          // tipo de dato por referencia unNddo
         public void Apilar(MiNodo unNodo) {

            //si el tope es null quiere decir que la pila esta vacia
            if (tope == null)
            {
                //entonces a ese tope le asigno el nodo pasado por parametro
                tope = unNodo;
            }
            else { 
                //guardo lo que hay al principio en tope en la variable aux
                MiNodo aux = tope;
                //ahora a tope le agrego el nodo pasado por parametro
                tope = unNodo;
                //al siguiente de tope le agrego lo que tenia antes en el principio
                tope.Siguiente = aux;
            }
        
        }

        //quita el elemento que hay arriba, como simepre quito el primero que este en la pila no hace falta pasarle parametro unNodo
        public void Desapilar() {
            //si tope es diferente a null, quiere decir que la pila no esta vacia
            if (tope != null) { 
                //entonces asigno a tope el siguiente elemento
                tope = tope.Siguiente;
            }
            
        }
    }
}
