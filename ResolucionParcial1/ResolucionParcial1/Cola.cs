using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResolucionParcial1
{
     class Cola
    {
        Cliente _inicioCliente;

        public void Encolar(Cliente unCliente)
        {
            if (_inicioCliente == null) {
                
                _inicioCliente = unCliente;
            } else {

                Cliente aux = BuscarUltimo(_inicioCliente);
                if (aux != null)
                {

                    aux.Siguiente = unCliente;
                }
            }

        }

        public Cliente Desencolar() {

            
            
            return _inicioCliente = _inicioCliente.Siguiente;
        }


        public Cliente inicioCliente { 

            get { return _inicioCliente; }
        }

        public int Contar() {
            int contador = 0;
            Cliente actual = _inicioCliente;

            while (actual != null) { 
                contador ++;
                actual = actual.Siguiente;
            }
            return contador;
        }

        private Cliente BuscarUltimo(Cliente unCliente)
        {
            if (unCliente.Siguiente == null)
            {
                return unCliente;

            } else  
            {
                return BuscarUltimo(unCliente.Siguiente);
            }
            
           
        }


    }

    
}
