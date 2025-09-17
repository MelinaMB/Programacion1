using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PilasNumeros
{
    public partial class Form1 : Form
    {
        MiPila miPila = new MiPila();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnApilar_Click(object sender, EventArgs e)
        {
            int numero;
            if (int.TryParse(textBox1.Text, out numero))
            {
                MiNodo unNuevoNodo = new MiNodo();
                unNuevoNodo.Numero = textBox1.Text;

                miPila.Apilar(unNuevoNodo);
                MostrarPila();
                textBox1.Clear();
            }
            else {
                MessageBox.Show("Por favor, ingrese solo números.");
            }
            
        }
        void MostrarPila()
        {

            listBox1.Items.Clear();

            if (miPila.Tope() != null)
            {

                MostrarNodoEnLista(miPila.Tope());
            }


        }

        void MostrarNodoEnLista(MiNodo unNodo)
        {

            listBox1.Items.Add(unNodo.Numero);

            if (unNodo.Siguiente != null)
            {
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
