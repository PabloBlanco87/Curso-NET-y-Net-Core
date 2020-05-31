using Mod15_IntrodConsultasLINQ;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Mod15_ClausulaSelect
{
    public class Categoria
    {
        public string Titulo { get; set; }
        public string IdLibro { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Libro> libros = Libro.GetLibros();

            //Devuelve todos los titulos
            var tituloLibros = from l in libros
                               select l.Titulo;

            //Devuelve una coleccion de objetos Categoria
            var ejemplo2 = from l in libros
                           select new Categoria { IdLibro = l.ISBN, Titulo = l.Titulo };

            //Devuelve los libros con el filtro del where
            var ejemplo3 = from l in libros
                           where l.FechaSalida > DateTime.Now.AddMonths(-6)
                           select l;

            //Asingnando tipos anonimos
            var ejemplo4 = from l in libros
                           select new { ISBN = l.ISBN, ISBNAux = "wqr-" + l.ISBN };

            //Selección condicional; si cumple (en venta), si no cumple (en breve)
            var ejemplo5 = from l in libros
                           select new { ISBN = l.ISBN, Lanzado = (l.FechaSalida < DateTime.Now ? "En venta" : "En breve") };

        }
    }
}
