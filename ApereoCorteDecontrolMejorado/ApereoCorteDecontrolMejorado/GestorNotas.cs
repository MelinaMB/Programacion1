using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApereoCorteDecontrolMejorado
{
    internal class GestorNotas
    {
        string archivo = "notas.txt";
        public void GuardarNota(Nota unaNota)
        {
            FileStream abroArchivoEnModoEscritor = new FileStream(archivo, FileMode.Append, FileAccess.Write);
            using (StreamWriter escritor = new StreamWriter(abroArchivoEnModoEscritor))
            {
                escritor.WriteLine(unaNota.ObtenerRegistro());
            }
            abroArchivoEnModoEscritor.Close();
        }

        public List<Nota> LeerNota()
        {
            //creo una nueva lista de tipo list
            List<Nota> lista = new List<Nota>();
            //abro el archivo en modo lectura
            FileStream abroElArchivoEnModoLectura = new FileStream(archivo, FileMode.OpenOrCreate, FileAccess.Read);
            //using es una funcion que cuando se terminen de utilizar todos los recursoso se van a cerrar
            using (StreamReader reader = new StreamReader(abroElArchivoEnModoLectura))
            {
                string linea = reader.ReadLine();
                //mientras que la linea sea diferente a null 
                while (linea != null)
                {
                    //creo un alumno, le paso la linea como parametro
                    Nota unaNota = new Nota(linea);

                    //agrego a la lista el nuevo alumno
                    lista.Add(unaNota);
                    linea = reader.ReadLine();
                }

            }
            abroElArchivoEnModoLectura.Close();

            return lista;

        }

        public List<Nota> Ordenar()
        {
            // Lee la lista de alumnos 
            List<Nota> lista = LeerNota();

            // Ordena la lista por Legajo (ascendente)
            lista.Sort((a, b) => a.Legajo.CompareTo(b.Legajo));//Ordena la lista usando un comparador. Compara a.Legajo y b.Legajo; CompareTo devuelve -1, 0 o 1 para orden ascendente.

            return lista;  // Devuelve la lista ordenada
        }

        public void EliminarNota(long Legajo)
        {
            //dar de baja una nota
            // se va a crear un nuevo archivo sin el alumno que quiero dar de baja

            string output = string.Empty;//variable autput que va a ser el resultado del nuevo archivo,sin el alumno que quiero borrar
            FileStream fs = new FileStream(archivo, FileMode.OpenOrCreate, FileAccess.Read);//sbro el archivo en modo lectura
            using (StreamReader reader = new StreamReader(fs))
            {
                string linea = reader.ReadLine();//leo linea por linea

                while (linea != null)
                {//por cada linea
                    
                    Nota unaNota = new Nota(linea);

                    
                    if (unaNota.Legajo != Legajo)
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

        public bool ModificarNota(int legajo, int nuevaNota)
        {
            //leo la lista de notas
            List<Nota> notas = LeerNota();
            Nota nota = null;
            for (int i = 0; i < notas.Count; i++)// Busca por legajo, encuentra la primera nota con ese legajo
            {
                if (notas[i].Legajo == legajo)
                {
                    nota = notas[i];
                    break;//sale del bucle al encontrar el primer elemento que cumple la condicion
                }
            }
            if (nota != null)
            {
                nota.ValorNota = nuevaNota;
                using (StreamWriter writer = new StreamWriter(archivo, false))
                {
                    for (int i = 0; i < notas.Count; i++)
                    {
                        Nota n = notas[i];
                        writer.WriteLine(n.ObtenerRegistro());
                    }
                }
                return true;
            }
            return false;
        }
    }
}
