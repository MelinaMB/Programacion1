using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Corte
{
    public partial class Form1 : Form
    {
        GestorEmpleado gestorEmpleado;
        public Form1()
        {
            InitializeComponent();
            gestorEmpleado = new GestorEmpleado();
        }

        void MostrarEmpleado() {
            this.grillaEmpleados.DataSource = null;// vacia la grilla
            this.grillaEmpleados.DataSource = gestorEmpleado.LeerEmpleado();
        }
        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            Empleado unEmpleado = new Empleado((int)this.numCodigoEmpleado.Value, textNombreEmpleado.Text, (int)this.numProduccion.Value );
            gestorEmpleado.GuardarEmpleado(unEmpleado);
            MostrarEmpleado();
        }

        private void btnTotalPorEmpleado_Click(object sender, EventArgs e)
        {
            Empleado[] empleados = gestorEmpleado.LeerEmpleado();
            List<Produccion> totalPorEmpleado = new List<Produccion>();
           
            int total = 0;
            int i = 0;

            while (i < empleados.Length) {
                int acumulador = 0;
                Produccion p = new Produccion();
                
                 int CodigoActual = empleados[i].CodigoEmpleado;
                 p.NombreEmpleado = empleados[i].NombreEmpleado;

                
                while (i < empleados.Length && empleados[i].CodigoEmpleado == CodigoActual) {
                    
                    acumulador = acumulador + empleados[i].ProduccionEmpleado;
                    i++;
                    
                }

                p.CodigoEmpleado = CodigoActual;
                p.totalDeProduccionPorEmpleado = acumulador;
                totalPorEmpleado.Add(p);
                total = total + acumulador;

            }

            grillaTotalPorEmpleados.DataSource = null;
            grillaTotalPorEmpleados.DataSource = totalPorEmpleado;
            labelTotal.Text = $"Total general de producción: {total}";

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            gestorEmpleado.LimpiarArchivo();
            MostrarEmpleado(); // Actualiza la grilla
            
        }
    }
}
