using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioCobranzaDeCaja
{
    public partial class Form1 : Form
    {
        
        Cola colaCliente = new Cola();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresarAlCliente_Click(object sender, EventArgs e)
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

            } else if (!int.TryParse(cantidadProd, out int cantidad)) {

                MessageBox.Show("La cantidad debe ser un numero entero");

            } else if (!decimal.TryParse(importeCliente, out decimal importe)) {

                MessageBox.Show("El importe debe ser un numero valido decimal o entero");
                
            }
            else {
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
            listCajaNormal.Items.Clear();
            listCajaRapida.Items.Clear();
            MostrarClienteCajaNormal(colaCliente.InicioClienteCajaNormal);
            MostrarClienteCajaRapida(colaCliente.InicioClienteCajaRapida);
        }
        

        private void MostrarClienteCajaRapida(Cliente unCliente)
        {


            if (unCliente != null)
            {
                listCajaRapida.Items.Add(unCliente);


                if (unCliente.Siguiente != null)
                {
                    MostrarClienteCajaRapida(unCliente.Siguiente);
                }

            }

        }

        private void MostrarClienteCajaNormal(Cliente unCliente)
        {


            if (unCliente != null)
            {
                listCajaNormal.Items.Add(unCliente);


                if (unCliente.Siguiente != null)
                {
                    MostrarClienteCajaNormal(unCliente.Siguiente);
                }

            }

        }

        public decimal totalNormal = 0;
        private void btnPagarCajaNormal_Click(object sender, EventArgs e)
        {
            
            if (colaCliente.VaciaCajaNormal())
            {

                MessageBox.Show("La cola esta vacia");
            }
            else {
                Cliente clienteColaNormal = colaCliente.DesencolarCajaNormal();
                totalNormal += clienteColaNormal.Importe;
                labelTotalCajaNormal.Text = $"Total Caja Normal: ${totalNormal}";
                MostrarCola();
            }
                


        }
        public decimal totalRapida = 0;
        private void btnPagarCajaRapida_Click(object sender, EventArgs e)
        {
            
            if (colaCliente.VaciaCajaRapida())
            {
                MessageBox.Show("La cola esta vacia");
            }
            else {
                Cliente clienteColaRapida = colaCliente.DesencolarCajaRapida();
                totalRapida += clienteColaRapida.Importe;
                labelTotalCajaRapida.Text = $"Total Caja Rapido: ${totalRapida}";
                MostrarCola();
            }
            


        }
    }
}
