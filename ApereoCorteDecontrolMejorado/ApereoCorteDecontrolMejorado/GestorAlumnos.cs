using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApereoCorteDecontrolMejorado
{
    internal class GestorAlumnos
    {
        string archivo = "alumnos.txt";

        
        public List<Alumno> LeerAlumno()
        {
            //creo una nueva lista de tipo list
            List<Alumno> lista = new List<Alumno>();
            //abro el archivo en modo lectura
            FileStream fs = new FileStream(archivo, FileMode.OpenOrCreate, FileAccess.Read);

            using (StreamReader reader = new StreamReader(fs))
            {
                string linea = reader.ReadLine();
                //mientras que la linea sea diferente a null 
                while (linea != null)
                {
                    //creo un alumno, le paso la linea como parametro
                    Alumno unAlumno = new Alumno(linea);

                    //agrego a la lista el nuevo alumno
                    lista.Add(unAlumno);
                    linea = reader.ReadLine();
                }

            }
            fs.Close();

            return lista;

        }

        public List<Alumno> Ordenar() 
        {
            // Lee la lista de alumnos 
            List<Alumno> lista = LeerAlumno();  

            // Ordena la lista por Legajo (ascendente)
            lista.Sort((a, b) => a.Legajo.CompareTo(b.Legajo));//Ordena la lista usando un comparador. Compara a.Legajo y b.Legajo; CompareTo devuelve -1, 0 o 1 para orden ascendente.

            return lista;  // Devuelve la lista ordenada
        }

        public void GuardarAlumno(Alumno unAlumno)
        {
            FileStream fs = new FileStream(archivo, FileMode.Append, FileAccess.Write);
            using (StreamWriter sw = new StreamWriter(fs)) {
                sw.WriteLine(unAlumno.GenerarRegistro());
            }
            fs.Close();
        }

        public void SacarAlumno(long Legajo)
        {
            //dar de baja un alumno
            // se va a crear un nuevo archivo sin el alumno que quiero dar de baja

            string output = string.Empty;//variable autput que va a ser el resultado del nuevo archivo,sin el alumno que quiero borrar
            FileStream fs = new FileStream(archivo, FileMode.OpenOrCreate, FileAccess.Read);//sbro el archivo en modo lectura
            using (StreamReader reader = new StreamReader(fs))
            {
                string linea = reader.ReadLine();//leo linea por linea

                while (linea != null)
                {//por cada linea
                    //creo el objeto alumnos y uso el constructor Alumnos(linea) y resibe una linea
                    Alumno unAlumno = new Alumno(linea);

                    //si el alumno no es igual al que quiero borrar
                    if (unAlumno.Legajo != Legajo)
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

        public bool ModificarAlumno(int legajo, string nuevoApellido)
        {
            List<Alumno> alumnos = LeerAlumno();  // Lee la lista
            Alumno alumno = null;//si no s encuentra ningun alumno con ese legajo alumno queda en null
            for (int i = 0; i < alumnos.Count; i++)// Busca por legajo, encuentra el primer alumno con ese legajo
            {
                if (alumnos[i].Legajo == legajo)
                {
                    alumno = alumnos[i];
                    break;//sale del bucle al encontrar el primer elemento que cumple la condicion
                }
            }
            
            if (alumno != null)
            {
                alumno.Apellido = nuevoApellido;  // Actualiza
                                                  // Reescribe el archivo
                using (StreamWriter writer = new StreamWriter(archivo, false))
                {  // false = sobrescribe
                    for (int i = 0; i < alumnos.Count; i++)
                    {
                        Alumno a = alumnos[i];
                        writer.WriteLine(a.GenerarRegistro());
                    }
                }
                return true;
            }
            return false;  // No encontrado
        }
    }
}
