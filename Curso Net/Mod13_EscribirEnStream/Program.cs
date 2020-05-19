using System;
using System.IO;
using System.Text;

namespace Mod13_EscribirEnStream
{
    class Program
    {
        static void Main(string[] args)
        {
            MemoryStream ms = new MemoryStream(150);
            var capacidad = ms.Capacity;
            var longitud = ms.Length;
            var posicion = ms.Position;

            byte[] miBuffer = new byte[50];

            //3 parametros, un array de bytes, desde donde se empieza a escribir. el tercero, el numero de bytes a usar
            ms.Write(miBuffer, 0, 5);
            ms.Close(); //siempre cerrar cuando terminemos de usarlo

            //Ejemplo
            MemoryStream msEjemplo = new MemoryStream(50);

            string miInformacion = string.Empty;
            var capacidad2 = ms.Capacity;
            var longitud2 = ms.Length;
            var posicion2 = ms.Position;

            byte[] miBuffer2 = new byte[50];

            //El usuario da los datos
            Console.WriteLine("Introduce la información");
            miInformacion = Console.ReadLine();

            msEjemplo.Write(ASCIIEncoding.ASCII.GetBytes(miInformacion), 0, miInformacion.Length);
            msEjemplo.Seek(0, SeekOrigin.Begin);
            msEjemplo.Read(miBuffer2, 0, 5);

            Console.WriteLine(ASCIIEncoding.ASCII.GetString(miBuffer2));
            msEjemplo.Close();

        }
    }
}
