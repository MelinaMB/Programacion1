using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioSegundoParcial
{
    public partial class Form1 : Form
    {
        GestorDeVentas gestorDeVentas;
        public Form1()
        {
            InitializeComponent();
            gestorDeVentas = new GestorDeVentas();
        }

        void MostrarVenta()
        {
            this.grillaVentas.DataSource = null;
            this.grillaVentas.DataSource = gestorDeVentas.LeerVenta();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            if (textCodigoMarca.Text.Length == 0 || textModelo.Text.Length == 0 || numericVentaAuto.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar un valor");
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(textCodigoMarca.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("La Marca debe contener solo letras");

            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(textModelo.Text, @"^[a-zA-Z\s]+$"))
            {

                MessageBox.Show("El Modelo debe contener solo letras");

            }
            else if (numericVentaAuto.Value <= 0 )
            {

                MessageBox.Show("La cantidad de ventas debe ser un numero entero positivo");

            }
            else
            {
                Ventas unaVenta = new Ventas(textCodigoMarca.Text, textModelo.Text, (int)this.numericVentaAuto.Value);
                gestorDeVentas.GuardarVenta(unaVenta);
                MostrarVenta();
            }
        }

        private void btnTotalDeVentasXMarca_Click(object sender, EventArgs e)
        {
            Ventas[] ventas = gestorDeVentas.LeerVenta();
            List<VentasRealizadasPorMarca> totalPorMarca = new List<VentasRealizadasPorMarca>();

            int total = 0;
            int i = 0;

            while (i < ventas.Length)
            {
                int acumulador = 0;
                VentasRealizadasPorMarca v = new VentasRealizadasPorMarca();

                string CodigoActual = ventas[i].CodigoDeMarca;
                


                while (i < ventas.Length && ventas[i].CodigoDeMarca == CodigoActual)
                {

                    acumulador = acumulador + ventas[i].VentasXAuto;
                    i++;

                }

                v.CodigoMarca = CodigoActual;
                v.TotalVentasXMarca = acumulador;
                totalPorMarca.Add(v);
                total = total + acumulador;

            }

            grillaTotalVentasPorMarca.DataSource = null;
            grillaTotalVentasPorMarca.DataSource = totalPorMarca;
            labelTotalConsecionaria.Text = $"Total general de producción: {total}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gestorDeVentas.LimpiarArchivo();
            MostrarVenta(); 
        }
    }
}
