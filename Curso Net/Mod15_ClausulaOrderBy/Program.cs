using Mod15_ClausulaJoin;
using Mod15_IntrodConsultasLINQ;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Mod15_ClausulaOrderBy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Libro> libros = Libro.GetLibros();
            List<LibroStats> librosStats = LibroStats.GetLibrosStats();

            //Ordenado por fecha de salida y luego por nº de páginas si tienen las mismas páginas
            var TitulosLibros = from l in libros
                                join s in librosStats on l.ISBN equals s.ISBN
                                orderby l.FechaSalida, s.Paginas
                                select new
                                {
                                    Nombre = l.Titulo,
                                    Fecha = l.FechaSalida,
                                    Pag = s.Paginas
                                };

            var TitulosLibros2 = from l in libros
                                 join s in librosStats on l.ISBN equals s.ISBN
                                 orderby l.FechaSalida, s.Paginas descending
                                 select new
                                 {
                                     Nombre = l.Titulo,
                                     Fecha = l.FechaSalida,
                                     Pag = s.Paginas
                                 };

            var TitulosLibros3 = from l in libros
                                 join s in librosStats on l.ISBN equals s.ISBN
                                 orderby l.FechaSalida descending, s.Paginas
                                 select new
                                 {
                                     Nombre = l.Titulo,
                                     Fecha = l.FechaSalida,
                                     Pag = s.Paginas
                                 };

            Console.ReadKey();

        }
    }
}
