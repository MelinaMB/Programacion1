using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioCobranzaDeCaja
{
    internal class Cola
    {
        Cliente _inicioClienteCajaRapida;
        Cliente _inicioClienteCajaNormal;

        public void Encolar(Cliente unCliente)
        {
            if (unCliente.Cantidad <= 10)
            {

                if (_inicioClienteCajaRapida == null)
                {
                    _inicioClienteCajaRapida = unCliente;
                }
                else
                {
                    Cliente aux = BuscarUltimo(_inicioClienteCajaRapida);
                    aux.Siguiente = unCliente;
                }
            }
            else if (unCliente.Cantidad > 10)
            {

                if (_inicioClienteCajaNormal == null)
                {
                    _inicioClienteCajaNormal = unCliente;
                }
                else
                {
                    Cliente aux = BuscarUltimo(_inicioClienteCajaNormal);
                    aux.Siguiente = unCliente;
                }

            }
            

        }

        public Cliente DesencolarCajaRapida()
        {

            if (_inicioClienteCajaRapida == null) {
                return null;
            }

            Cliente clienteAEliminar = _inicioClienteCajaRapida;
            _inicioClienteCajaRapida = _inicioClienteCajaRapida.Siguiente;
            return clienteAEliminar;
        }


        public Cliente DesencolarCajaNormal()
        {
            if (_inicioClienteCajaNormal == null) {
                return null;
            }
                

            Cliente clienteAEliminar = _inicioClienteCajaNormal;
            _inicioClienteCajaNormal = _inicioClienteCajaNormal.Siguiente;
            return clienteAEliminar;
        }



        public Cliente InicioClienteCajaNormal
        {

            get { return _inicioClienteCajaNormal; }
        }

        public Cliente InicioClienteCajaRapida
        {

            get { return _inicioClienteCajaRapida; }
        }

        public bool VaciaCajaRapida()
        {
            return (_inicioClienteCajaRapida == null);
        }

        public bool VaciaCajaNormal()
        {
            return (_inicioClienteCajaNormal == null);
        }

        private Cliente BuscarUltimo(Cliente unCliente)
        {
            if (unCliente.Siguiente == null)
            {
                return unCliente;

            }
            else
            {
                return BuscarUltimo(unCliente.Siguiente);
            }


        }
    }
}
