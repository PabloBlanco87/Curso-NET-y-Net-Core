using System;
using static System.Console;

namespace Cadenas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Iniciar cadena
            string miCadena = "";
            string miCadena1 = string.Empty;
            string miCadena2="Hola Mundo!";

            //Convertir a cadena
            int numero = 7;
            string numeroString = numero.ToString();

            //DateTime ya tiene sus metodos de extension que nos ayudan a formatear de forma muy facil a formato cadena.
            DateTime fecha = new DateTime();
            fecha = DateTime.Now;
            WriteLine("ToLocalTime: " + fecha.ToLocalTime());
            WriteLine("ToLongDateString: " + fecha.ToLongDateString());
            WriteLine("ToLongTimeString: " + fecha.ToLongTimeString());
            WriteLine("ToOADate: " + fecha.ToOADate());
            WriteLine("ToShortDateString: " + fecha.ToShortDateString());
            WriteLine("ToShortTimeString: " + fecha.ToShortTimeString());
            WriteLine("ToString: " + fecha.ToString());
            WriteLine("ToUniversalTime: " + fecha.ToUniversalTime());
            ReadLine();

            //Si esto no nos resulta útil y queremos hacerlo con el formato que nosotros queramos (mirar en el recurso formato-cadenas):
            string fechaString = String.Format("La fecha de hoy es: {0:dddd mm yyyy}", DateTime.Now);
            WriteLine(fechaString);
            ReadLine();
        }
    }
}
