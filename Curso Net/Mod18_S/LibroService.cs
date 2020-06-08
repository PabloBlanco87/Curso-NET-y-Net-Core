using System;
using System.Collections.Generic;
using System.Text;

namespace Mod18_S
{
    //ASÍ ES COMO DEBERÍA SER, NO COMO EN LA CLASE LIBRO CREADA ANTERIORMENTE

    public class Libro
    {
        string Tipo;
        string Autor;
        int NumeroPaginas;

        Libro(string tipo, string autor, int numeroPaginas)
        {
            Tipo = tipo;
            Autor = autor;
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

    //Encapsulamos la lógica de guardar libro en otra clase (o servicio)
    public class LibroService
    {
        public void GuardarLibroBBDD(Libro libro)
        {
            //Lógica de acceso a la bbdd para guardar el libro
        }

        public void EliminarLibroBBDD(Libro libro)
        {
            //Lógica de acceso a la bbdd para eliminar el libro
        }
    }
}
