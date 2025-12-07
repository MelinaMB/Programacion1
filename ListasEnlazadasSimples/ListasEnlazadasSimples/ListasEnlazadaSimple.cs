using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ListasEnlazadasSimples
{
    internal class ListasEnlazadaSimple
    {
        public NodoSimple NodoInicial = null;
        public void AgregarAlPrincipio(string nombre)
        {
            //primero creo un nodo, se llama nodo
            NodoSimple nodo = new NodoSimple();
            //al nodo creado le asigno la propiedad numero que va a estar dada por la funcion ProximoNumero()
            nodo.Numero = ProximoNumero();
            //al nodo creado le asigno la propiedad nombre que va a eates dada por el parametro nombre
            nodo.Nombre = nombre;
            //pregunto si el NodoInicial es igual a null quiere decir que no hay ningun nodo en la lista 
            if (NodoInicial == null)
                //como no hay ningun nodo en la lista asigno el nodo creado al inicio
                NodoInicial = nodo;
            else
            {
                //si hay elementos en la lista, tenemos que agregarlo entre el inicial y el siguiente
                //guardo todo los que hay en el inicio de la lista en la variable aux
                NodoSimple aux = NodoInicial;
                //asigno el nodo creado al inicio
                NodoInicial = nodo;
                //todo lo que habia guardado en la variable aux lo pongo siguiente al nodo inicial
                NodoInicial.Siguiente = aux;
            }
        }

        public void AgregarAlFinal(string nombre)
        {
            //creo un nodo
            NodoSimple nodo = new NodoSimple();
            //al nodo creado le asigno la propiedad Numero cuyo valor lo tomo de la funcion ProximoNumero()
            nodo.Numero = ProximoNumero();
            //al nodo creado le asigno la propiedad Nombre, el valor lo paso por parametro
            nodo.Nombre = nombre;
            //pregunto si NodoInicial es igual a null si es verdad quiere decir que la lista esta vacia
            if (NodoInicial == null)
            {
                //si la lista esta vacia asigno el nodo creado al inicio
                NodoInicial = nodo; //quiere decir que la lista esta vacia
            }
            else {

                //si la lista no esta vacia, necesito buscar el último nodo para agregarlo al final
                //creo una variable tipo nodo llamada ultimo y le asigno el valor que me devuelve la funcion BuscarUltimo() y le paso como parametro el NodoInicial para que emiece a buscar desde el inicio
                NodoSimple ultimo = BuscarUltimo(NodoInicial);
                //cuando obtengo el ultimo nodo guardado en la variable ultimo le asigno siguiente al nodo creado
                ultimo.Siguiente = nodo;//agrego al final


            }
               
        }

        private int BuscarMaximo(NodoSimple nodo, int numero)
        {
            //El numero que recibo por parametro lo asigno a una variable max
            int max = numero;
            //el nodo que recibo por parametro lo asigno a la variable actual de tipo NodoSimple
            NodoSimple actual = nodo;
            //mientras que el nodo actual sea distinto de null
            while (actual != null)
            {
                //pregunto si el numero del nodo actual es mayor a max 
                if (actual.Numero > max) 
                    //entonces max va aser igual al numero de nodo actual
                    max = actual.Numero;
                //asigno a actual al siguiente nodo 
                actual = actual.Siguiente;
            }
            //cuando llegue al ultimo nodo obtengo el numero y lo devuelvo
            return max;

        }

        private int ProximoNumero()
        {
            if (NodoInicial == null)
            {
                return 1;

            }
                
            int max = BuscarMaximo(NodoInicial, NodoInicial.Numero);
            //busco el maximo y le sumo uno

            return max + 1;
        }

        private NodoSimple BuscarUltimo(NodoSimple nodo)
        {
            //la lista este vacia
            if (nodo == null) {
                //devuelvo null 
                return null;

            }
            //creo una variable tipo nodo llamada actual y le asigno el nodo recibido por parametro
            NodoSimple actual = nodo;
            //busco el ultimo, mientras que actula.siguiente es distinto de null sigo recorriendo
            while (actual.Siguiente != null)
            {   
                //en actual asigno el siguiente nodo
                actual = actual.Siguiente;
            }
            //cuando actual sea igual a null devuelvo ese nodo, encontre el ultimo
            return actual;
        }

        public void QuitarPrimero()
        {
            //par aquitar el primero, necesito usar una variable temporal
            //la lista este vacia
            if (NodoInicial != null)
            {
                //asigna el nodo inicial cal siguiente elemento
                NodoInicial = NodoInicial.Siguiente;
            }
            
        }

        public void QuitarUltimo()
        {
            //necesitamos buscar el anteultimo
            NodoSimple anteultimo = BuscarAnteultimo(NodoInicial);
            if (anteultimo != null)
                anteultimo.Siguiente = null;
            else
                //la lista esta vacia
                NodoInicial = null;
        }

        private NodoSimple BuscarAnteultimo(NodoSimple nodo)
        {
            if (nodo == null || nodo.Siguiente == null) 
                return null;  // Vacía o un elemento
            NodoSimple actual = nodo;
            // Mientras haya al menos dos adelante
            while (actual.Siguiente.Siguiente != null)
            {  
                //asigna como nodo actual al nodo siguiente, este seria el anteultimo
                actual = actual.Siguiente;
            }
            //devuelve el nodo anteultimo
            return actual;

        }

        private NodoSimple BuscarAnterior(NodoSimple nodo, int numero)
        {
            if (nodo.Siguiente != null && nodo.Siguiente.Numero == numero)
                return nodo;
            if (nodo.Siguiente != null)
                return BuscarAnterior(nodo.Siguiente, numero);
            return null; //es el ultimo...
        }
        /*
         misma funcion que el anterior pero sin la recursividad 
        private NodoSimple BuscarAnterior(NodoSimple nodo, int numero)
        {
            NodoSimple actual = nodo;  // Empezar desde el nodo inicial

            while (actual != null && actual.Siguiente != null) {  // Mientras haya nodos y un siguiente
                if (actual.Siguiente.Numero == numero) {
                    return actual;  // Encontrado: este es el anterior
                }
                actual = actual.Siguiente;  // Avanzar al siguiente
            }

        return null;  // No encontrado o es el último/primer nodo
        }
         */

        public void QuitarPosicion(int numero)
        {   
            //verifico que la lista no este vacia
            if (NodoInicial != null)
            {
                //si el primero es el que se quiere borrar
                if (NodoInicial.Numero == numero)
                {
                    QuitarPrimero();
                }
                else
                {
                    // si el ultimo es el que se quiere borrar
                    NodoSimple ultimo = BuscarUltimo(NodoInicial);
                    if (ultimo != null && ultimo.Numero == numero)
                        QuitarUltimo();
                    else
                    { //si se quiere borrar un nodo intermedio
                        NodoSimple nodoAnteriorAlElegido =
                       BuscarAnterior(NodoInicial, numero);
                        if (nodoAnteriorAlElegido != null)
                            nodoAnteriorAlElegido.Siguiente = nodoAnteriorAlElegido.Siguiente.Siguiente;
                    }
                }
            }


        }
        public bool NumeroExiste(int numero)
        {
            NodoSimple actual = NodoInicial;
            while (actual != null)
            {
                if (actual.Numero == numero) return true;
                actual = actual.Siguiente;
            }
            return false;
        }

        public void IntercambiarDerecha(int numero)
        {
            if (NodoInicial == null || NodoInicial.Siguiente == null) return;  // Lista vacía o un elemento

            NodoSimple anterior = null;
            NodoSimple actual = NodoInicial;

            // Buscar el nodo con 'numero'
            while (actual != null && actual.Numero != numero)
            {
                anterior = actual;
                actual = actual.Siguiente;
            }

            if (actual == null || actual.Siguiente == null) return;  // No encontrado o es el último

            NodoSimple siguiente = actual.Siguiente;

            // Intercambiar: actual con siguiente
            actual.Siguiente = siguiente.Siguiente;
            siguiente.Siguiente = actual;

            // Ajustar el anterior
            if (anterior != null)
            {
                anterior.Siguiente = siguiente;
            }
            else
            {
                NodoInicial = siguiente;  // Si era el primero
            }
        }
        public void IntercambiarIzquierda(int numero)
        {
            if (NodoInicial == null || NodoInicial.Siguiente == null) return;

            if (NodoInicial.Numero == numero) return;  // El primero no tiene anterior

            NodoSimple anteriorAnterior = null;
            NodoSimple anterior = NodoInicial;
            NodoSimple actual = NodoInicial.Siguiente;

            // Buscar el nodo con 'numero' y su anterior
            while (actual != null && actual.Numero != numero)
            {
                anteriorAnterior = anterior;
                anterior = actual;
                actual = actual.Siguiente;
            }

            if (actual == null) return;  // No encontrado

            // Intercambiar: anterior con actual
            anterior.Siguiente = actual.Siguiente;
            actual.Siguiente = anterior;

            // Ajustar el anterior al anterior
            if (anteriorAnterior != null)
            {
                anteriorAnterior.Siguiente = actual;
            }
            else
            {
                NodoInicial = actual;  // Si era el segundo
            }
        }
        public void Intercambiar(int numero1, int numero2)
        {
        }
    }
}
