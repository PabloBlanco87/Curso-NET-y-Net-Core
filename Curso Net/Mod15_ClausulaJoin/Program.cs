using Mod15_IntrodConsultasLINQ;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Mod15_ClausulaJoin
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Libro> libros = Libro.GetLibros(); //Linea 1
            List<LibroStats> librosStats = LibroStats.GetLibrosStats();

            var TitulosLibros = from l in libros
                                join s in librosStats on l.ISBN equals s.ISBN
                                select new
                                {
                                    TituloSeleccionado = l.Titulo,
                                    PaginasLibro = s.Paginas
                                };

            foreach (var item in TitulosLibros)
            {
                Console.WriteLine($"Titulo: {item.TituloSeleccionado} Paginas: {item.PaginasLibro}");
            }

            Console.ReadKey();

        }
    }
}
