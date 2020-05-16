using System;
using static System.Convert;
using static System.Console;

namespace Mod11_Ejercicio3
{
    /*Crear un enumerado llamado "animales" con los siguientes valores, perro = 5, gato = 8, canario = 2, caballo = 12.  
     * Se creara una clase Animal, con una propiedad que sea el tipo de animal.  Se pedirá por consola, un numero, 
     * si coincide con el valor del animal se pintara en pantalla "ese valor pertenece al <nombre animal>" realizar 
     * el ejercicio con todos los elementos vistos hasta la fecha (clases, funciones, enumerados, diccionarios, tuplas 
     * o lo que veamos conveniente para su resolución).*/

    class Program
    {
        static void Main(string[] args)
        {
            int numeroElegido = PideNumero();
            WriteLine($"Ese animal es: {DimeTipoAnimal(numeroElegido)} ");
            ReadKey();
        }

        public static int PideNumero()
        {
            Write("Por favor introduzca un número: ");
            int numero = ToInt32(ReadLine());
            return numero;
        }

        public static string DimeTipoAnimal(int numero)
        {
            switch (numero)
            {
                case 5:
                    return Animales.Perro.ToString();
                    break;
                case 8:
                    return Animales.Gato.ToString();
                    break;
                case 2:
                    return Animales.Canario.ToString();
                    break;
                case 12:
                    return Animales.Caballo.ToString();
                    break;
                default:
                    return "Desconocido";
                    break;
            }
            return string.Empty;
        }
    }
}
