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

        Cola miCola = new Cola();
        Cola miColaRapida = new Cola();
        Cola miColaNormal = new Cola();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Cliente_Click(object sender, EventArgs e)
        {
            if (textNombreCliente.Text.Length == 0 || textCantidadProductos.Text.Length == 0 || textImporte.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar un valor");
            }
            else { 
                Cliente unNuevoCliente = new Cliente();
                unNuevoCliente.Nombre = textNombreCliente.Text;
                unNuevoCliente.Cantidad = int.Parse(textCantidadProductos.Text);
                
                unNuevoCliente.Importe = decimal.Parse(textImporte.Text);

                miCola.Encolar(unNuevoCliente);
                
                MostrarCola();

                textNombreCliente.Clear();
                textCantidadProductos.Clear();
                textImporte.Clear();
            }
        }

        private void MostrarCola() { 
            lstClientes.Items.Clear();
            MostrarClienteEnPantalla(miCola.inicioCliente);
        }

        private void MostrarClienteEnPantalla(Cliente unCliente) {
             

            if (unCliente != null ) { 
                lstClientes.Items.Add(unCliente);
               

                if (unCliente.Siguiente != null) {
                    MostrarClienteEnPantalla(unCliente.Siguiente);
                }

            }

        }

        private void MostrarColaRapida(Cliente unCliente) {

            if (unCliente != null)
            {
                lstColaRapida.Items.Add(unCliente);

                if (unCliente.Siguiente != null) {

                    MostrarColaRapida(unCliente.Siguiente);
                    
                }
            }
            
        }

        private void MostrarColaNormal(Cliente unCliente)
        {

            if (unCliente != null)
            {
                lstColaNormal.Items.Add(unCliente);

                if (unCliente.Siguiente != null)
                {

                    MostrarColaNormal(unCliente.Siguiente);

                }
            }

        }



        private void btnPagarCajaRapidaONormal_Click_1(object sender, EventArgs e)
        {
            decimal totalNormal = 0;
            decimal totalRapida = 0;

                Cliente cliente = miCola.Desencolar();
                if (miCola.Contar() > 0 && cliente.Cantidad <= 10)
                {
                    

                    miColaRapida.Encolar(cliente);
                    MostrarColaRapida(cliente);
                    totalRapida += cliente.Importe;
                    label2.Text = $"Total Caja Rapido: ${totalRapida}";
                    

                }
                else if (miCola.Contar() > 0 && cliente.Cantidad > 10)
                {
                    

                    miColaNormal.Encolar(cliente);
                    MostrarColaNormal(cliente);
                    totalNormal += cliente.Importe;
                    label3.Text = $"Total Caja Normal: ${totalNormal}";
                    

                }


        }
    }
}
