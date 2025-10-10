using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResolucionParcial1
{
    public partial class Form1 : Form
  
    {

        Cola colaCliente = new Cola();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Cliente_Click(object sender, EventArgs e)
        {
            String nombre = textNombreCliente.Text;
            string cantidadProd = textCantidadProductos.Text;
            String importeCliente = textImporte.Text;

            if (textNombreCliente.Text.Length == 0 || textCantidadProductos.Text.Length == 0 || textImporte.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar un valor");
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(nombre, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("El nombre debe contener solo letras");

            }
            else if (!int.TryParse(cantidadProd, out int cantidad))
            {

                MessageBox.Show("La cantidad debe ser un numero entero");

            }
            else if (!decimal.TryParse(importeCliente, out decimal importe))
            {

                MessageBox.Show("El importe debe ser un numero valido decimal o entero");

            }
            else
            {
                Cliente unNuevoCliente = new Cliente
                {
                    Nombre = nombre,
                    Cantidad = cantidad,
                    Importe = importe
                };


                colaCliente.Encolar(unNuevoCliente);
                MostrarCola();
                textNombreCliente.Clear();
                textCantidadProductos.Clear();
                textImporte.Clear();
            }
        }

        private void MostrarCola() { 
            lstClientes.Items.Clear();
            MostrarClienteEnPantalla(colaCliente.InicioCliente);
        }

        private void MostrarClienteEnPantalla(Cliente unCliente) {
             

            if (unCliente != null ) { 
                lstClientes.Items.Add(unCliente);
               

                if (unCliente.Siguiente != null) {
                    MostrarClienteEnPantalla(unCliente.Siguiente);
                }

            }

        }

        public decimal totalNormal = 0;
        public decimal totalRapida = 0;

        private void btnPagarCajaRapidaONormal_Click_1(object sender, EventArgs e)
        {
            if (colaCliente.Vacia())
            {

                MessageBox.Show("En la cola no hay clientes");
            }
            else
            {

                Cliente cliente = colaCliente.Desencolar();
                if (cliente.Cantidad <= 10)
                {
                    totalRapida += cliente.Importe;
                    label2.Text = $"Total Caja Rapido: ${totalRapida}";


                }
                else if (cliente.Cantidad > 10)
                {

                    totalNormal += cliente.Importe;
                    label3.Text = $"Total Caja Normal: ${totalNormal}";


                }

            }

            MostrarCola();
        }

        
    }
}
