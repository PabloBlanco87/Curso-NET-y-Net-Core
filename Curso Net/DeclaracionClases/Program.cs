using System;

namespace DeclaracionClases
{
    class Program
    {
        static void Main(string[] args)
        {
            Clase clase = new Clase();
            clase.Campo = 12;
            clase.Apellidos = "Blanco Hernández";
            //clase.Edad = 12;  //No nos deja, porque es privado el método set

            Console.WriteLine(clase.Edad);
            Console.ReadLine();

            Clase clase2 = new Clase();
            var estado = clase2.Estado;
            clase2.Estado = 5;
            Console.WriteLine(clase2.Edad);

            clase2.Calcular(45);
            var suma = clase2.Sumar(1, 6);
            Console.WriteLine(suma);


        }
    }
}
