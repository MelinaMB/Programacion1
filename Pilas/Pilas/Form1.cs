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
        MiPila miPila = new MiPila();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregarNuevoNodo_Click(object sender, EventArgs e)
        {
            MiNodo unNuevoNodo = new MiNodo();
            unNuevoNodo.Nombre = textNombreNodo.Text;

            miPila.Apilar(unNuevoNodo);
            MostrarPila();
        }

        void MostrarPila() { 

            listMiPila.Items.Clear();

            if (miPila.Tope() != null) {

                MostrarNodoEnLista(miPila.Tope());
            }
            

        }

        void MostrarNodoEnLista(MiNodo unNodo) {
            
            listMiPila.Items.Add(unNodo.Nombre);

            if (unNodo.Siguiente != null) {
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
