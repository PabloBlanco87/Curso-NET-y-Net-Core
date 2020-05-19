using System;
using System.IO;

namespace Mod13_LeerDatosDeStream
{
    class Program
    {
        static void Main(string[] args)
        {
            MemoryStream ms = new MemoryStream(150);
            var capacidad = ms.Capacity;
            var longitud = ms.Length;
            var posicion = ms.Position;

            byte[] buffer = new byte[50];

            //3 parametros, un array de bytes, desde donde se empieza a leer. el tercero, el numero de bytes a leer
            ms.Read(buffer, 0, 5);
        }
    }
}
