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

        //funcion alta recibe por parametro el objeto alumno
        public void Alta(Alumnos unAlumno) {

            // creo un stream que va a conectar nuestro sistema con un archivo, modo append agrega los registros al final
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

            string output = string.Empty;//variable autput que va a ser el resultado del nuevo archivo,sin el alumno que quiero borrar
            FileStream fs = new FileStream(archivo, FileMode.OpenOrCreate, FileAccess.Read);//sbro el archivo en modo lectura
            using (StreamReader reader = new StreamReader(fs))
            { 
                string linea = reader.ReadLine();//leo linea por linea

                while (linea != null) {//por cada linea
                    //creo el objeto alumnos y uso el constructor Alumnos(linea) y resibe una linea
                    Alumnos unAlumno = new Alumnos(linea);

                    //si el alumno no es igual al que quiero borrar
                    if (unAlumno.DNI != DNI)
                    {
                        //lo guardo en la variable output
                        output += linea + Environment.NewLine;
                    }

                    linea = reader.ReadLine();
                }
            }//cierro el modo lectura
            fs.Close();
            //abro el archivo en modo truncate que va a pisar lo que habia en el archivo, con acceso de escritura
            fs = new FileStream(archivo, FileMode.Truncate, FileAccess.Write);
            using (StreamWriter write = new StreamWriter(fs))
            {
                //escribo todo lo que esta en el output 
                write.Write(output);
            }
            fs.Close();
        }

        // funcion lista va a recorrer el archivo y va a devolver una lista de objetos alumno
        //cada objeto va a representar un registro del archivo de alumnos
        public List<Alumnos> Lista()
        {
            //creo una nueva lista de tipo list
            List<Alumnos> lista = new List<Alumnos>();
            //abro el archivo en modo lectura
            FileStream fs = new FileStream(archivo, FileMode.OpenOrCreate, FileAccess.Read);

            using (StreamReader reader = new StreamReader(fs)) 
            {
                string linea = reader.ReadLine();
                //mientras que la linea sea diferente a null 
                while (linea != null) 
                {
                    //creo un alumno, le paso la linea como parametro
                    Alumnos unAlumno = new Alumnos(linea);

                    //agrego a la lista el nuevo alumno
                    lista.Add(unAlumno);
                    linea = reader.ReadLine();
                }
                
            }
            fs.Close();

            return lista;

        }

        
    }
}
