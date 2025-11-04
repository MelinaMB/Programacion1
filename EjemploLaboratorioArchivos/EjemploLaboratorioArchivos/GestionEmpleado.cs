using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploLaboratorioArchivos
{
    internal class GestionEmpleado
    {
        string archivo = "empleados.txt";

        public void Alta(Empleado unEmpleado) { 

            FileStream archivoAbiertoComoEscritura = new FileStream(archivo, FileMode.Open, FileAccess.Write);
            StreamWriter writer = new StreamWriter(archivoAbiertoComoEscritura);

            using (writer) {

                writer.WriteLine(unEmpleado.GenerarRegistro());
            
            }
            archivoAbiertoComoEscritura.Close();
        }

        public void Baja(int legajo) {
            
            string sinElElementoDeBaja = string.Empty;
            FileStream archivoAbiertoComoLectura = new FileStream(archivo, FileMode.OpenOrCreate, FileAccess.Read);
            using (StreamReader reader = new StreamReader(archivoAbiertoComoLectura)) {
                
                string linea = reader.ReadLine();

                while (linea != null){
                    
                    Empleado unEmpleado = new Empleado(linea);

                    if (unEmpleado.legajo != legajo) { 
                        
                        sinElElementoDeBaja += linea + Environment.NewLine;
                    }
                    linea = reader.ReadLine();
                    
                }
                
            
            }
            archivoAbiertoComoLectura.Close();

            FileStream archivoAbiertoComoEscritura = new FileStream(archivo, FileMode.Truncate, FileAccess.Write);
            using (StreamWriter write = new StreamWriter(archivoAbiertoComoEscritura)) {

                write.Write(sinElElementoDeBaja);
            
            }
            archivoAbiertoComoEscritura.Close();
        }

        public void Modificar(int legajo, string nombreYApellido, string categoria) { 

            string modificado = string.Empty;

            FileStream archivoAbiertoComoLectura = new FileStream(archivo, FileMode.OpenOrCreate, FileAccess.Read);
            using (StreamReader reader = new StreamReader(archivoAbiertoComoLectura)) {

                string linea = reader.ReadLine();

                while (linea != null) {

                    Empleado unEmpleado = new Empleado(linea);

                    if (unEmpleado.legajo == legajo) {

                        unEmpleado.nombreYApellido = nombreYApellido;
                        unEmpleado.categoria = categoria;

                    }

                    modificado += unEmpleado.GenerarRegistro() + Environment.NewLine;

                    linea = reader.ReadLine();

                }
                
            }
            archivoAbiertoComoLectura.Close();

            FileStream archivoAbiertoComoEscritura = new FileStream(archivo, FileMode.Open, FileAccess.Write);
            using (StreamWriter writer = new StreamWriter(archivoAbiertoComoEscritura)) {
                writer.Write(modificado);
                
            }
            archivoAbiertoComoEscritura.Close();
        }

        public List<Empleado> Lista() { 
            
            List<Empleado> lista = new List<Empleado>();

            FileStream archivoAbiertoComoLectura = new FileStream (archivo, FileMode.OpenOrCreate, FileAccess.Read);

            using (StreamReader reader = new StreamReader(archivoAbiertoComoLectura)) {

                string linea = reader.ReadLine();
                while (linea != null) {
                    Empleado unEmpleado = new Empleado(linea);
                    lista.Add(unEmpleado);
                    linea = reader.ReadLine();
                }

            }
            archivoAbiertoComoLectura.Close();
            return lista;
        }
    }
}
