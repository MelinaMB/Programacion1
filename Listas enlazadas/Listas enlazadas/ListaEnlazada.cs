using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_enlazadas
{
    public class ListaEnlazada
    {
        public Nodo Inicio;

        public Nodo BuscarUltimo(Nodo unNodo) {

            if (unNodo.Siguiente == null)
            {

                return unNodo;
            }
            else {
                return BuscarUltimo(unNodo.Siguiente);
            }
        }

        public void AgregarAlFinal(Nodo unNodo) {

            if (Inicio == null)
            {

                Inicio = unNodo;

            }
            else {
                //encontrar el ultimo, para poder agregarlo al final.
                Nodo aux = BuscarUltimo(Inicio);
                aux.Siguiente = unNodo;
            }
            
        }

        public void AgregarAlInicio(Nodo unNodo) {

            if (Inicio == null)
            {

                //si entra aca, es que la lista esta vacia
                Inicio = unNodo;

            }
            else { 
                Nodo aux = Inicio;
                Inicio = unNodo;
                Inicio.Siguiente = aux;
            }
        
        }
    }
}
