using System;
using System.Collections.Generic;
using System.IO; //esto es para usar StreamWriter
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_streams
{
    class Program
    {
        static void Main(string[] args)
        {/*
           
            // Ingreso de datos por consola ------------------------------------------------------------------
          
            Console.WriteLine("Escribe tu nombre: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("hola " + nombre);

            Console.WriteLine("Ahora escribe tu edad: ");
            int edad = int.Parse(Console.ReadLine());     // Aca estoy cambiando de tipo int a tipo string
                                                          // para que readline lo pueda leer

            Console.WriteLine("Bienvenido {0}. Tu edad es: {1}", nombre, edad);
            */

            // Escritura en un archivo   ---------------------------------------------------------------------

            String archivo = "archivo.txt";
            
            /*StreamWriter file = new StreamWriter(@archivo);
            file.WriteLine("Esto es una prueba");
            file.WriteLine("Segunda linea");
            
            
            FileStream fs = new FileStream(archivo, FileMode.Append);  //FileMode.Append es para abrir el archivo
            byte[] data = Encoding.Default.GetBytes("Este es el renglon 3");
           //arreglo de caracteres en la variable data
            fs.Write(data, 0, data.Length);
            //funcion que agrega el contenido de la variable data, desde su posicion cero hasta 
            //la posicion final de caracteres que tiene el data (que se resume en Length)

            fs.Close();
            */

            // Lectura en un archivo   ---------------------------------------------------------------------

            //String archivo = "archivo.txt";
            String contenido;
            FileStream fsSource = new FileStream(archivo, FileMode.Open, FileAccess.Read);
            using (StreamReader sr = new StreamReader(fsSource))
            {
                contenido = sr.ReadToEnd();
            }

            Console.WriteLine(contenido);

            Console.ReadLine();
        }
    }
}
