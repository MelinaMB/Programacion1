using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listas
{
    public partial class Form1 : Form
    {
        //creo una instacia de listaEnlazada que se llama lista para poder administrarla
        //en esta varible lista creo una nueva lista enlazada
        //me va a permitir usar esta lista en cualquier parte del formulario
        ListaEnlazada lista = new ListaEnlazada();
        public Form1()
        {
            InitializeComponent();
        }

        //funcion recursiva va a recibir como parametro UnNodo
        //Ventajas de recursivo: Es elegante y directo para estructuras como listas enlazadas.
        //Desventajas: Usa la pila de llamadas (puede causar stack overflow si la lista es muy larga) y es menos eficiente en memoria.
       // public void AgregarItemLista(Nodo unNodo) {

            //si un nodo es null no puedo mostrar nada
           /* if (unNodo != null) {
                //si unNodo es distinto de null quiere decir que existe por lo que 
                //agrego un item a la lista de lo que hay dentro del inicio que es el nombre 
                //para que se meuestre en la pantalla
                listListaEnlazada.Items.Add(unNodo.Nombre);

                //llamo a la funcion nuevamente para que agregue a la lista el siguiente
               AgregarItemLista(unNodo.Siguiente);
            }
            
        }*/

        //forma mas simple de recorrer una lista sin usar recursividad
        //es utilizar el while
        public void AgregarItemLista(Nodo unNodo)
        {
            Nodo actual = unNodo;  // Empezar desde el nodo recibido, Asigna el nodo de entrada
                                   // a una variable temporal para no modificar el original.

            while (actual != null)
           {  // Mientras haya un nodo
               listListaEnlazada.Items.Add(actual.Nombre);  // Agregar el nombre del nodo actual
               actual = actual.Siguiente;  // Avanzar al siguiente nodo
            }
       }

        public void MostrarLista() { 
            //primero tengo que borrar todo lo esta en pantall en la lista 
            listListaEnlazada.Items.Clear();
            //lo unico que sabemos de la lista enlazada es que tiene un inicio
            //debemos preguntar si la lista.inicio no es null porque si es null no puedo mostrar nada
            //porque no hay nada en la lista
            if (lista.Inicio != null) {

                AgregarItemLista(lista.Inicio);
            }
            
        }

        private void cmdAgregarPrincipio_Click(object sender, EventArgs e)
        {   
            //primero pregunto si en el cuadro de texto hay un valor adentro
            if (textNombreNodo.Text.Length > 0)
            {
                //si es mayor a 0 quiere decir que hay un valor en cuagro de texto
                //entonces puedo agregarlo a la lista el nuevo nodo
                //para esto creo un nodo llamado unNuevoNodo
                Nodo unNuevoNodo = new Nodo();

                //al nuevo nodo le defino una propiedad en este caso Nombre
                //y digo que tome el valor del texto que esta en el cuadro de texto
                unNuevoNodo.Nombre = textNombreNodo.Text;

                //invoco a la lista que cree al principio y llamo a la funcion 
                //que me agrega al principio el nodo y le paso por parametro unNuevoNodo
                lista.AgregarAlInicio(unNuevoNodo);
                MostrarLista();
            }
            else {// si no hay n valor en el cuadro de texto muestro un mensaje
                MessageBox.Show("Debe ingresar un nombre");
            }
        }

        private void cmdAgregarFinal_Click(object sender, EventArgs e)
        {
            //primero pregunto si en el cuadro de texto hay un valor adentro
            if (textNombreNodo.Text.Length > 0)
            {
                //si es mayor a 0 quiere decir que hay un valor en cuagro de texto
                //entonces puedo agregarlo a la lista el nuevo nodo
                //para esto creo un nodo llamado unNuevoNodo
                Nodo unNuevoNodo = new Nodo();

                //al nuevo nodo le defino una propiedad en este caso Nombre
                //y digo que tome el valor del texto que esta en el cuadro de texto
                unNuevoNodo.Nombre = textNombreNodo.Text;

                //invoco a la lista que cree al principio y llamo a la funcion 
                //que me agrega al final el nodo y le paso por parametro unNuevoNodo
                lista.AgregarAlFinal(unNuevoNodo);
                MostrarLista();
            }
            else
            {
                MessageBox.Show("Debe ingresar un nombre");
            }
        }
    }
}
