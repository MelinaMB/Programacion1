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



            if (_inicioCliente == null)
            {
                return null;
            }

            Cliente clienteAEliminar = _inicioCliente;
            _inicioCliente = _inicioCliente.Siguiente;
            return clienteAEliminar;

        }



        public Cliente InicioCliente { 

            get { return _inicioCliente; }
        }

        

        public bool Vacia()
        {
            return (_inicioCliente == null);
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
