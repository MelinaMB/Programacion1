
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CajaCobranzaColas
{
    public partial class Form1 : Form
    {
        Queue<Cliente> colaGeneral = new Queue<Cliente>();
        Queue<Cliente> colaRapida = new Queue<Cliente>();
        Queue<Cliente> colaNormal = new Queue<Cliente>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtCantidad.Text == "" || txtImporte.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos.");
                return;
            }

            Cliente nuevo = new Cliente
            {
                Nombre = txtNombre.Text,
                Cantidad = int.Parse(txtCantidad.Text),
                Importe = decimal.Parse(txtImporte.Text)
            };

            colaGeneral.Enqueue(nuevo);
            listBoxGeneral.Items.Add(nuevo.ToString());

            txtNombre.Clear();
            txtCantidad.Clear();
            txtImporte.Clear();
        }

        private void btnCajaRapida_Click(object sender, EventArgs e)
        {
            colaRapida.Clear();
            listBoxRapida.Items.Clear();

            Queue<Cliente> nuevaColaGeneral = new Queue<Cliente>();

            while (colaGeneral.Count > 0)
            {
                Cliente c = colaGeneral.Dequeue();
                if (c.Cantidad <= 10)
                {
                    colaRapida.Enqueue(c);
                    listBoxRapida.Items.Add(c.ToString());
                }
                else
                {
                    nuevaColaGeneral.Enqueue(c);
                }
            }

            colaGeneral = nuevaColaGeneral;
            listBoxGeneral.Items.Clear();
            foreach (Cliente c in colaGeneral)
            {
                listBoxGeneral.Items.Add(c.ToString());
            }
        }

        private void btnCajaNormal_Click(object sender, EventArgs e)
        {
            colaNormal.Clear();
            listBoxNormal.Items.Clear();

            Queue<Cliente> nuevaColaGeneral = new Queue<Cliente>();

            while (colaGeneral.Count > 0)
            {
                Cliente c = colaGeneral.Dequeue();
                if (c.Cantidad > 10)
                {
                    colaNormal.Enqueue(c);
                    listBoxNormal.Items.Add(c.ToString());
                }
                else
                {
                    nuevaColaGeneral.Enqueue(c);
                }
            }

            colaGeneral = nuevaColaGeneral;
            listBoxGeneral.Items.Clear();
            foreach (Cliente c in colaGeneral)
            {
                listBoxGeneral.Items.Add(c.ToString());
            }
        }
    }
}
