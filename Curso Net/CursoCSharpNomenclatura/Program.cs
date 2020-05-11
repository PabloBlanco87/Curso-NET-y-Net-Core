using System;

namespace CursoCSharpNomenclatura
{
    class Program
    {
        //Variable privada (se suele poner _ antes del nombre de la variable para identificarla)
        private readonly string _estaEsMiCadena;

        static void Main(string[] args)
        {
            //Camel case (se usa en variables locales y en miembros privados)
            var estoEsUnaVariable = "Camel";

            //Pascal (se usa en tipos, métodos y clases)
            var EstoEsUnaVariable = "Pascal";
        }

        //Ejemplo de método
        public int SumaDosNumeros(int numeroUno, int numeroDos)
        {
            var resultado = numeroUno + numeroDos;
            return resultado;
        }
    }
}
