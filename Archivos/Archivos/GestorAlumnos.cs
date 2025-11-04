using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    internal class GestorAlumnos
    {// manipulo el archivo

        string archivo = "alumnos.txt";

        public void Alta(Alumnos unAlumno) {

            // creo un stream que va a conectar nuestro sistema con un archivo
            FileStream fs = new FileStream(archivo, FileMode.Append, FileAccess.Write);

            //using es una funcion que cuando se terminen de utilizar todos los recursoso se van a cerrar
            using (StreamWriter writer = new StreamWriter(fs))// creo un escritor y le digo en que archivo se va a ejecutar
            {
                //escribe una linea en base al dato recibido por el parametro unAlumno luego Genera el registro y lo guarda en el archivo
                writer.WriteLine(unAlumno.GenerarRegistro());

            }
            fs.Close();
        }

        public void Baja(long DNI) {
            //dar de baja un alumno
            // se va a crear un nuevo archivo sin el alumno que quiero dar de baja

            string output = string.Empty;
            FileStream fs = new FileStream(archivo, FileMode.OpenOrCreate, FileAccess.Read);
            using (StreamReader reader = new StreamReader(fs))
            { 
                string linea = reader.ReadLine();

                while (linea != null) {

                    Alumnos unAlumno = new Alumnos(linea);

                    if (unAlumno.DNI != DNI)
                    {
                        output += linea + Environment.NewLine;
                    }

                    linea = reader.ReadLine();
                }
            }
            fs.Close();

            fs = new FileStream(archivo, FileMode.Truncate, FileAccess.Write);
            using (StreamWriter write = new StreamWriter(fs))
            {
                write.Write(output);
            }
            fs.Close();
        }

        // funcion lista va a recorrer el archivo y va a devolver una lista de objetos alumno
        //cada objeto va a representar un registro del archivo de alumnos
        public List<Alumnos> Lista()
        {
            List<Alumnos> lista = new List<Alumnos>();

            FileStream fs = new FileStream(archivo, FileMode.OpenOrCreate, FileAccess.Read);

            using (StreamReader reader = new StreamReader(fs)) 
            {
                string linea = reader.ReadLine();
                while (linea != null) 
                {
                    Alumnos unAlumno = new Alumnos(linea);

                    lista.Add(unAlumno);
                    linea = reader.ReadLine();
                }
            }
            fs.Close();

            return lista;

        }

        
    }
}
