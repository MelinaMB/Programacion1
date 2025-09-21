using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colas2020
{
    class Cola
    {
        Nodo _inicioF;
        Nodo _inicioM;

        public void Encolar(Nodo unNodo)
        {

            if (unNodo.Nombre.Substring(0, 1) == "F" || unNodo.Nombre.Substring(0, 1) == "f")
            {

                if (_inicioF == null)
                {
                    _inicioF = unNodo;
                }
                else
                {
                    Nodo aux = BuscarUltimo(_inicioF);
                    aux.Siguiente = unNodo;
                }
            }
            else if (unNodo.Nombre.Substring(0, 1) == "M" || unNodo.Nombre.Substring(0, 1) == "m")
            {

                if (_inicioM == null)
                {
                    _inicioM = unNodo;
                }
                else
                {
                    Nodo aux = BuscarUltimo(_inicioM);
                    aux.Siguiente = unNodo;
                }

            } else {
                MessageBox.Show("Debe ingresar un nombre de nodo válido");
            }
        }

        public void DesencolarF() { 

            _inicioF = _inicioF.Siguiente;
            

        }

        public void DesencolarM() { 
            
            _inicioM = _inicioM.Siguiente;
        }

        private Nodo BuscarUltimo(Nodo unNodo)
        {
            if (unNodo.Siguiente == null)
            {
                return unNodo;
            }
            else
            {
                return BuscarUltimo(unNodo.Siguiente);
            }
        }
       

        public Nodo InicioF
        {
            get
            {
                return _inicioF;
            }
        }

        public Nodo InicioM
        {
            get
            {
                return _inicioM;
            }
        }


        public bool VaciaF()
        {
            return (_inicioF == null);
        }
        public bool VaciaM()
        {
            return (_inicioM == null);
        }


    }
}
