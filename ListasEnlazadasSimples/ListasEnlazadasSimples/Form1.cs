using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListasEnlazadasSimples
{
    public partial class Form1 : Form
    {
        ListasEnlazadaSimple lista = new ListasEnlazadaSimple();
        public Form1()
        {
            InitializeComponent();
        }

        public void AgregarItemLista(NodoSimple unNodo)
        {
            NodoSimple actual = unNodo;  // Empezar desde el nodo recibido, Asigna el nodo de entrada
                                   // a una variable temporal para no modificar el original.

            while (actual != null)
            {  // Mientras haya un nodo
                listBox1.Items.Add(actual.Nombre);  // Agregar el nombre del nodo actual
                actual = actual.Siguiente;  // Avanzar al siguiente nodo
            }
        }

        public void MostrarLista()
        {
            //primero tengo que borrar todo lo esta en pantall en la lista 
            listBox1.Items.Clear();
            //lo unico que sabemos de la lista enlazada es que tiene un inicio
            //debemos preguntar si la lista.inicio no es null porque si es null no puedo mostrar nada
            //porque no hay nada en la lista
            if (lista.NodoInicial != null)
            {

                AgregarItemLista(lista.NodoInicial);
            }

        }
        private void btnAgregarAlPrincipio_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {

                lista.AgregarAlPrincipio(textBox1.Text);
                textBox1.Clear();
                textBox2.Clear();
                MostrarLista();

            }
            else
            {

                MessageBox.Show("Debe ingresar un nombbre");
            }


        }

        private void btnAgregarAlFinal_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0) {

                lista.AgregarAlFinal(textBox1.Text);
                textBox1.Clear();
                textBox2.Clear();
                MostrarLista();
               
            }
            else
            {

                MessageBox.Show("Debe ingresar un nombbre");
            }
        }

        private void btnQuitarPrimero_Click(object sender, EventArgs e)
        {
            // Verificar si la lista no está vacía 
            if (lista.NodoInicial != null)
            {
                lista.QuitarPrimero();  // Quitar el primer nodo
                MostrarLista();  // Actualizar la lista en la vista
            }
            else
            {
                MessageBox.Show("La lista está vacía. No hay nada que quitar.", "Advertencia");
            }
        }

        private void btnQuitarUltimo_Click(object sender, EventArgs e)
        {
            // Verificar si la lista no está vacía
            if (lista.NodoInicial != null)
            {
                lista.QuitarUltimo();  // Quitar el último nodo
                MostrarLista();  // Actualizar la lista visual
            }
            else
            {
                MessageBox.Show("La lista está vacía. No hay nada que quitar.", "Advertencia");
            }
        }



        private void btnQuitarSeleccionado_Click(object sender, EventArgs e)
        {
            // Validar que el TextBox no esté vacío
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Ingresa un número válido para quitar.", "Error");
                return;
            }

            try
            {
                int numero = int.Parse(textBox2.Text);  // Convertir a int
                // Verificar si el número existe 
                if (!lista.NumeroExiste(numero))
                { 
                    MessageBox.Show("El número no existe en la lista.", "Error");
                    return;
                }

                lista.QuitarPosicion(numero);  // Quitar el nodo con ese número
                textBox2.Clear();  // Limpiar el TextBox
                MostrarLista();  // Actualizar la lista
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingresa un número entero válido.", "Error");
            }
        }
    }
}
