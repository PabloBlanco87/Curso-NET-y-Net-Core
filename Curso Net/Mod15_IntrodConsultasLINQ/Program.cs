using System;
using System.Collections.Generic;
using System.Linq;

namespace Mod15_IntrodConsultasLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Libro> libros = Libro.GetLibros();

            //Consulta de LINQ
            var titulosLibros =
                from l in libros
                select l.Titulo;

            foreach (var titulo in titulosLibros)
            {
                Console.WriteLine(titulo);
            }

            Console.ReadKey();
        }
    }
}
