using System;
using System.Collections.Generic;
using System.Text;

namespace Mod18_O
{
    public class Libro
    {
        public string Tipo;
        string Autor;
        string Titulo;
        int NumeroPaginas;

        public Libro(string tipo, string autor, string titulo, int numeroPaginas)
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
    }
}