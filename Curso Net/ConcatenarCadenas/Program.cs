using System;

namespace ConcatenarCadenas
{
    class Program
    {
        static void Main(string[] args)
        {
            string superheroe = "Superman";
            string procedencia = "Kripton";
            string superpoder = "super fuerza";

            //Concatenado más básico
            string todosDatos = superheroe + " procede de " + procedencia + " y tiene " + superpoder;
            Console.WriteLine(todosDatos);

            //Otro concatenado
            string todosDatosConcat = string.Concat(superheroe, " procede de ", procedencia, " y tiene ", superpoder);
            Console.WriteLine(todosDatosConcat);

            //Concatenado interpolación
            string todosDatosInterpolacion = $"{ superheroe} procede de { procedencia} y tiene {superpoder}";
            Console.WriteLine(todosDatosInterpolacion);

            //la interpolación nos hace operaciones
            string ejemploInterpolacion = $"¿{3 + 5} es igual a 8?";
            Console.WriteLine(ejemploInterpolacion);
            Console.ReadLine();
        }
    }
}
