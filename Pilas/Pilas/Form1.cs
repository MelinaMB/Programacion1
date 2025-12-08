using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pilas
{
    public partial class Form1 : Form
    {
        //creo una instancia de miPila 
        MiPila miPila = new MiPila();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregarNuevoNodo_Click(object sender, EventArgs e)
        {
            //creo un nodo
            MiNodo unNuevoNodo = new MiNodo();
            //al nuevo nodo le asigno el atributo Nombre cuyo valor proviene de lo que se escriba en el textbox
            unNuevoNodo.Nombre = textNombreNodo.Text;

            //una vez que tenga el nodo con el valor de Nombre lo agrego a la pila
            miPila.Apilar(unNuevoNodo);
            MostrarPila();
        }

        void MostrarPila() { 
            //borrar lo que se encuentra en el listbox
            listMiPila.Items.Clear();
            //si el tope de la pila es diferente de null, quiere decir que no esta vacia
            if (miPila.Tope() != null) {
                //como no esta vacia la pila voy a mostrar el nuevo elemento que hay 
                MostrarNodoEnLista(miPila.Tope());
            }
            
        }

        //funcion recursiva, va a recibir un nodo en la lista
        void MostrarNodoEnLista(MiNodo unNodo) {
            
            //agreggo el nodo a la pila
            listMiPila.Items.Add(unNodo.Nombre);

            //si el nodo.siguiente es diferente de null, qiere decir que no es el ultimo
            if (unNodo.Siguiente != null) {
                //entonces va a seguir con el siguiente nodo
                MostrarNodoEnLista(unNodo.Siguiente);
            }
            
        
        }

        private void btnDesapilar_Click(object sender, EventArgs e)
        {
            miPila.Desapilar();
            MostrarPila();
        }

        
    }
}
