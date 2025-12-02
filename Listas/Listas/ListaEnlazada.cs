using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    class ListaEnlazada
    {   //debo conocer el inicio por eso creo una variable de tipo Nodo que se
        //llame Inicio aca es donde vamos a guara el puntero al primer nodo
        public Nodo Inicio;

        //funcion recursiva para buscar el ultimo nodo 
        /*  public Nodo BuscarUltomo(Nodo unNodo) {

              if (unNodo.Siguiente == null)
              {

                  return unNodo;

              }
              else {

                  return BuscarUltomo(unNodo.Siguiente);

              }


          } */

        public Nodo BuscarUltimo(Nodo unNodo)
        {
            // Verificar si la lista está vacía (opcional, para evitar errores)
            if (unNodo == null)
            {
                return null;  // O lanza una excepción
            }

            Nodo actual = unNodo;  // Empezar desde el nodo recibido

            // Bucle: avanzar hasta el último nodo
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }

            return actual;  // Devolver el último nodo
        }



        //unNodo es el parametro que yo le paso a la funcion, es el nodo que quiero agregar
        public void AgregarAlFinal(Nodo unNodo)
        {
            if (Inicio == null)
            {// si es null quiere decir que no hay nada en la lista asi que
             //lo agrego

                Inicio = unNodo;
            }
            else {

                //debo encontrar el ultimo elemento
                // para esto debo recorrer toda la lista hasta el ultimo elemento
                //recorro desde el inicio si llego aca es que el inicio no es null 
                Nodo aux = BuscarUltimo(Inicio);
                aux.Siguiente = unNodo;
            }

        }
        
        
        public void AgregarAlInicio(Nodo unNodo)
        {

            if (Inicio == null)
            {
                //si entra aca, es que la lista esta vacia.
                //entonces digo que el Inicio = unNodo que es el nodo que le pago
                Inicio = unNodo;
            }
            else
            {//si Inicio no es null 
            //hay que guardar lo que hay actualmente en el inicio en una variable en este caso de 
            //tipo Nodo llamada aux
                Nodo aux = Inicio;
                //ahora en la variable inicio guardo el nuevo nodo que quiero agregar en inicio
                //que es el parametro unNodo
                Inicio = unNodo;
                //entonces al nodo que yo agregue nuevo le digo que su siguiente es lo que esta
                //en la variable aux
                Inicio.Siguiente = aux;
            }
        }
    }
}
