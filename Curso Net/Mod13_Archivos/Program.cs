using System;
using System.IO;
using System.Text;

namespace Mod13_Archivos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Modos
            //FileMode.Append   Si existe se abre, y se coloca al final del archivo
            //FileMode.Create   Crear un nuevo archivo, si ya existe se sobreescribe
            //FileMode.CreateNew    Crear un nuevo archivo, si ya existe se produce una excepcion
            //FileMode.Open     Abrir un archivo que ya existe, si no existe se produce una excepcion
            //FileMode.OpenOrCreate     Si existe se abre, si no existe, se crea
            //FileMode.Truncate     cuidado con este! 

            /*2 parametros, el nombre del archivo con extension, y el segundo el modo del archivo que indica 
             * como funcionara y se manipulará el archivo*/
            FileStream fsEscribir = new FileStream("miArchivo.txt", FileMode.Create);

            string cadena = "Esto es una cadena de ejemplo";

            fsEscribir.Write(ASCIIEncoding.ASCII.GetBytes(cadena), 0, cadena.Length);
            fsEscribir.Close();

            byte[] buffer = new byte[100];

            FileStream fsLeer = new FileStream("miArchivo.txt", FileMode.Open);
            fsLeer.Read(buffer, 0, (int)fsLeer.Length);

            Console.WriteLine(ASCIIEncoding.ASCII.GetString(buffer));
            Console.ReadKey();

            fsLeer.Close();
        }
    }
}
