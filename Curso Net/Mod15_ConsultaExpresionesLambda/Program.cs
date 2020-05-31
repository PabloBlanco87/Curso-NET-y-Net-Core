using System;
using System.Collections.Generic;
using System.Linq;

namespace Mod15_ConsultaExpresionesLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Libro> libros = Libro.GetLibros();

            //ASÍ SE HARÍA UTILIZANDO CONSULTAS LINQ
            var linq = from h in libros
                       select h.Titulo;

            //ASÍ SE HARÍA UTILIZANDO CONSULTAS LAMBDA
            /*var titulos, cojo el origen de datos (libros), le doy a .select y la expresion lambda 
             * (nombre de variable, flecha y accedo al titulo*/
            var titulos = libros.Select(x => x.Titulo);
            var titulos2 = libros.Select(y => y.Titulo);

            var ISBNs = libros.Select(x => x.ISBN);

            //Muestrame del origen de datos todos los libros que la fecha de salida sea esta
            var fechaSalida = libros.Where(x => x.FechaSalida > DateTime.Now.AddYears(-2))
                .Select(x => x.Titulo);

            //Muestrame del origen de datos todos los libros que el titulo sea menor que 10 letras
            var tituloCorto = libros.Where(x => x.Titulo.Length < 10)
                .Select(x => x.Titulo);

            //Crear clases anonimas
            var claseAnonima = libros.Select(x => new
            {
                Titulo2 = x.Titulo,
                FechaAuxiliar = x.FechaSalida
            });

            foreach (var item in claseAnonima)
            {
                Console.WriteLine($"valor titulo2: {item.Titulo2}, valor fecha: {item.FechaAuxiliar}");
            }

            Console.Read();
        }
    }
}
