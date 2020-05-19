using System;
using System.IO;

namespace Mod13_MemoryStream
{
    class Program
    {
        static void Main(string[] args)
        {
            MemoryStream ms = new MemoryStream(150);
            var capacidad = ms.Capacity;    //capacidad (numero de bytes que puede almacenar el stream, en este caso 150)
            var longitud = ms.Length;   //longitud (tamaño de la información actual que tiene el stream)
            var posicion = ms.Position; //posicion (indica el lugar donde se encuentra el byte actual)

            /* Seek sirve para colocar la posición actual en un sitio determinado, necesita dos parámetros, 
             * el primero es la distancia desde el punto de referencia donde quedará la nueva posición, 
             * y el segundo indica el punto de referencia que utilizaremos*/
            ms.Seek(0, SeekOrigin.Begin);   //Inicial
            ms.Seek(10, SeekOrigin.Begin);
            ms.Seek(-10, SeekOrigin.Begin); //este es como dar la vuelta

            ms.Seek(5, SeekOrigin.Current); //Actual
            ms.Seek(-10, SeekOrigin.Current);
        }
    }
}
