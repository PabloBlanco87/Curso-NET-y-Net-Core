using System;
using System.Collections.Generic;
using System.Text;

namespace Mod18_S
{
    public class Libro1
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

        //Este metodo rompe el principio de reponsabilidad unica, ya que accede a la bbdd

        public void GuardarLibroBBDD(Libro libro)
        {
            //Lógica de acceso a la bbdd para guardar el libro
        }
    }
}
