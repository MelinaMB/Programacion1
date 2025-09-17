using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listas_enlazadas
{
    public partial class Form1 : Form
    {   
        ListaEnlazada lista = new ListaEnlazada();
        public Form1()
        {
            InitializeComponent();
        }

        public void AgregarItemAlista(Nodo unNodo) {

            if (unNodo != null) {

                listListaEnlazada.Items.Add(unNodo.Nombre);
                AgregarItemAlista(unNodo.Siguiente);

            }
        }

        public void MostrarLista() {

            listListaEnlazada.Items.Clear();

            if (lista.Inicio != null) {

                AgregarItemAlista(lista.Inicio);

            }
        }
       

        private void cmdAgregarAlPrincipio_Click(object sender, EventArgs e)
        {
            if (txtNombreNodo.Text.Length > 0)
            {

                Nodo unNuevoNodo = new Nodo();
                unNuevoNodo.Nombre = txtNombreNodo.Text;
                lista.AgregarAlInicio(unNuevoNodo);
                MostrarLista();
            }
            else {

                MessageBox.Show("Debe ingresar un nombre");

            }
            
        }

        private void cmdAgregarAlFinal_Click(object sender, EventArgs e)
        {
            if (txtNombreNodo.Text.Length > 0)
            {

                Nodo unNuevoNodo = new Nodo();
                unNuevoNodo.Nombre = txtNombreNodo.Text;
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
