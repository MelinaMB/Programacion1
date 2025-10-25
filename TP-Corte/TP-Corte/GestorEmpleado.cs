using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Corte
{
    public class GestorEmpleado
    {
        string archivo = "empleados.txt";

        public Empleado[] LeerEmpleado()
        {

            Empleado[] lista = new Empleado[1];
            FileStream fs = new FileStream(archivo, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader br = new StreamReader(fs);

            string linea = br.ReadLine();
            int i = 0;
            while (linea != null)
            {
                lista[i] = new Empleado(linea);
                linea = br.ReadLine();
                if (linea != null)
                {
                    Array.Resize(ref lista, lista.Length + 1);
                }
                i++;

            }
            br.Close();
            return lista;
        }

       

        public void GuardarEmpleado(Empleado unEmpleado)
        {
            FileStream fs = new FileStream(archivo, FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(unEmpleado.ObtenerRegistro());
            sw.Close();
        }

        public void LimpiarArchivo()
        {
            File.WriteAllText(archivo, string.Empty);
            
        }


    }
}

