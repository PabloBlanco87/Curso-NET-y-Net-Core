using System;
using System.Collections.Generic;
using System.Linq;

namespace Mod15_ClausulaGroupBy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Libro> libros = Libro.GetLibros();
            List<LibroStats> librosStats = LibroStats.GetLibrosStats();


            var titulosLibros = from l in libros
                                join s in librosStats on l.ISBN equals s.ISBN
                                let porSalir = (l.FechaSalida > DateTime.Now ? "por salir" : "en venta")
                                orderby s.Rank
                                group new
                                {
                                    Titulo = l.Titulo,
                                    Precio = l.Precio,
                                    Paginas = s.Paginas
                                }
                                by porSalir
                                into librosAgrupados
                                select new
                                {
                                    Status = librosAgrupados.Key,
                                    Valores = librosAgrupados
                                };

        }
    }
}
