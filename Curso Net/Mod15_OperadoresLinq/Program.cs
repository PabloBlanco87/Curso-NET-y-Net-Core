using Mod15_ClausulaGroupBy;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Mod15_OperadoresLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Libro> libros = Libro.GetLibros();

            //Operadores matematicos

            var count = libros.Count();

            var suma = libros.Sum(x => x.Precio);

            var maximo = libros.Max(x => x.Precio);

            var minimo = libros.Min(x => x.Precio);

            var media = libros.Average(x => x.Precio);

            //operadores miembros

            var toma = libros.Take(2);  //toma tantos elementos como le digamos

            var salta = libros.Skip(5); //salta tantos elementos como le digamos

            var tomaYSalta = libros.Skip(2).Take(3);    //para paginados

            var vuelta = libros.Reverse<Libro>();   //da la vuelta al listado

            var primero = libros.First();   //devuelve el primero
            primero = libros.Where(x => x.Titulo.Length > 0).OrderBy(x => x.Precio).First();//PODEMOS AÑADIR SELECT, WHERE...

            var primeroONulo = libros.FirstOrDefault();

            var elementoEn = libros.ElementAt(4);   //devuelve el elemento del listado en la posicion 4

            var ultimo = libros.Last();

            var single = libros.Single(x => x.ISBN.Contains("22")); //devuelve el primero que se encuentre

            var alguno = libros.Any();  //si tiene algun elemento, devuelve true, si no tiene, devuelve false

            var condicionTodos = libros.All(x => x.Titulo.Length > 0);  //si todos los elementnos del listado cumplen condicion true, si no, false

            var contiene = libros.Contains(new Libro    //si existe o no existe
            {
                FechaSalida = DateTime.Now.AddYears(-3),
                ISBN = "111111",
                Precio = 12.22M,
                Titulo = "El señor de los anillos"
            });

        }
    }
}
