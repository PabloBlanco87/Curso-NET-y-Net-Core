using System;
using System.Collections.Generic;
using System.Text;

namespace Mod18_O.Correcto
{
    //Se hace la clase abstracta para hacer el el metodo abstracto
    public abstract class Libro2
    {
        public string Tipo;
        string Autor;
        string Titulo;
        int NumeroPaginas;

        public Libro2(string tipo, string autor, string titulo, int numeroPaginas)
        {
            Tipo = tipo;
            Autor = autor;
            Titulo = titulo;
            NumeroPaginas = numeroPaginas;
        }

        public string GetTipoLibro()
        {
            return Tipo;
        }

        public string GetAutor()
        {
            return Autor;
        }

        public int GetNumeroPaginas()
        {
            return NumeroPaginas;
        }

        //Declaramos la clase abstracta
        public abstract void imprimirTipoDeLibro();
    }

    public class IT : Libro2
    {
        public IT(string tipo, string autor, string titulo, int numeroPaginas) : base(tipo, autor, titulo, numeroPaginas) { }

        public override void imprimirTipoDeLibro()
        {
            Console.WriteLine("Es IT");
        }
    }

    public class Fantastica : Libro2
    {
        public Fantastica(string tipo, string autor, string titulo, int numeroPaginas) : base(tipo, autor, titulo, numeroPaginas) { }

        public override void imprimirTipoDeLibro()
        {
            Console.WriteLine("Es Fantastica");
        }
    }

    public class Comedia : Libro2
    {
        public Comedia(string tipo, string autor, string titulo, int numeroPaginas) : base(tipo, autor, titulo, numeroPaginas) { }

        public override void imprimirTipoDeLibro()
        {
            Console.WriteLine("Es Comedia");
        }
    }
}

