using Mod18_O.Correcto;
using System;
using System.Collections.Generic;

namespace Mod18_O
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Libro> listLibros = new List<Libro>()
            {
                new Libro("IT", "Autor anónimo","Manual principios SOLID",543),
                new Libro("Fantastica", "JR Martin","Juego de tronos",893),
            };

            imprimirTipoDeLibro(listLibros);

            //Si añadimos un nuevo tipo de libro, por ejemplo:
            listLibros.Add(new Libro("Comedia", "Autor 2", "Algo pasa con Mary", 195));
            /*Tendriamos que modificar imprimirTipoDeLibro, porque no estamos contemplando la comedia,
             * con lo que no cumpliriamos el Principio de abierto/cerrado*/

            //De esta forma sería la forma correcta de hacerlo, usando principios SOLID
            List<Libro2> listLibro2 = new List<Libro2>();

            listLibro2.Add(new IT("IT", "Autor anónimo", "Manual principios SOLID", 543));
            listLibro2.Add(new Fantastica("Fantastica", "JR Martin", "Juego de tronos", 893));
            listLibro2.Add(new Comedia("Comedia", "Autor 2", "Algo pasa con Mary", 195));

            imprimirTipoDeLibro2(listLibro2);
            
        }

        public static void imprimirTipoDeLibro(List<Libro> listaLibros)
        {
            foreach (var item in listaLibros)
            {
                if (item.Tipo.Contains("IT")) Console.WriteLine("Es IT");
                if (item.Tipo.Contains("Fantastica")) Console.WriteLine("Es Fantastica");

                //if (item.Tipo.Contains("Comedia")) Console.WriteLine("Es Comedia");
            }
        }


        //Des esta forma este método nunca cambiará por más tipos de libros que introduzcamos nuevos
        public static void imprimirTipoDeLibro2(List<Libro2> listaLibros)
        {
            foreach (var item in listaLibros)
            {
                item.imprimirTipoDeLibro();
            }
        }
    }
}
