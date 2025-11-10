using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioSegundoParcial
{
    internal class GestorDeVentas
    {
        string archivo = "ventas.txt";

        public Ventas[] LeerVenta()
        {
            Ventas[] lista = new Ventas[1];
            FileStream archivoAbiertoComoLectura = new FileStream(archivo, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader reader = new StreamReader(archivoAbiertoComoLectura);

            string linea = reader.ReadLine();
            int i = 0;
            while (linea != null)
            {
                lista[i] = new Ventas(linea);
                linea = reader.ReadLine();
                if (linea != null)
                {
                    Array.Resize(ref lista, lista.Length + 1);
                }
                i++;

            }
            reader.Close();
            return lista;
        }

        public void GuardarVenta(Ventas unaVenta) {
            FileStream archivoAbiertoComoEscritura = new FileStream(archivo, FileMode.Append);
            StreamWriter writer = new StreamWriter(archivoAbiertoComoEscritura);
            writer.WriteLine(unaVenta.ObtenerRegistro());
            writer.Close();
        }

        public void LimpiarArchivo()
        {
            File.WriteAllText(archivo, string.Empty);

        }
    }
}
