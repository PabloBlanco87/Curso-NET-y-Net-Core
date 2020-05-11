using System;

namespace OperacionesCadenas
{
    class Program
    {
        static void Main(string[] args)
        {
            string villano = "Gru";
            string esbirros = "Minions";
            string frase = "Los Minions ayudan a Gru a conquistar el mundo";

            //Concatenar cadenas
            string concatenar = String.Concat(villano, " tiene ", esbirros);
            Console.WriteLine(concatenar);

            //Encontrar cadena
            if (villano.Contains("Gru"))
            {
                //código
            }
            if (esbirros.Contains("Mini"))
            {
                //código
            }

            //Obtener subcadena
            string subcadena = frase.Substring(4, 7);   //Dice donde empieza a cortar, y después cuántos caracteres tiene.
            Console.WriteLine($"subcadena: {subcadena}");
            Console.ReadLine();

            //Una cadena acaba en...
            if (frase.EndsWith("mundo"))
            {
                //código
            }

            //Insertar una cadena en otra
            frase = frase.Insert(3, " adorables");
            Console.WriteLine(frase);

            //Encontrar posición de una cadena
            var posicion = frase.LastIndexOf("mundo");
            frase= frase.Insert(posicion, "enorme ");
            Console.WriteLine(frase);

            //Borrar cadena
            var posicion2 = frase.LastIndexOf("enorme");
            frase = frase.Remove(posicion2, 7);
            Console.WriteLine(frase);

            //Reemplazar cadena
            frase= frase.Replace("mundo", "luna");

            //Dividir cadena
            var palabras = frase.Split(' ');
            foreach (var palabra in palabras)
            {
                Console.WriteLine(palabra);
            }

            //Pasar mayúsculas y minúsculas
            string gru = villano.ToUpper();
            string esbirros2 = esbirros.ToLower();

            Console.WriteLine(gru);
            Console.WriteLine(esbirros2);

            //Podar cadenas
            string espaciosDelanteros = "      palabra";
            string espaciosTraseros = "palabra      ";
            string espacios = "      palabra        ";

            Console.WriteLine(espaciosDelanteros.TrimStart());
            Console.WriteLine(espaciosTraseros.TrimEnd());
            Console.WriteLine(espacios.Trim());
      
            Console.ReadLine();
        }
    }
}
