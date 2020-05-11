using System;
using static System.Convert;

namespace CastingConversiones
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena = "Hola";
            int numero = 12;

            cadena = numero.ToString();

            //Casting Implicitos
            int numeroEntero = 34543;
            long numeroLong = numeroEntero;

            //Casting Explicitos
            double numeroDouble = 12.56;
            int numeroEnteroDouble = (int)numeroDouble;

            //Clases de Convert
            double doubleValor = 8.45;
            int enteroValor = ToInt32(doubleValor);
            Convert.ToInt32(doubleValor);

            //Casting definidos por el usuario
            //Casting con clases de asistentes
        }
    }
}
