using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio6
{
    public class Animal
    {
        public string Tipo { get; set; }
        public string ColorPelo { get; set; }
        public bool Domestico { get; set; }
        public int NumeroPatas { get; set; }

        public Animal() { }

        public Animal(string tipo, string colorPelo, bool domestico, int numeroPatas) =>
            (Tipo, ColorPelo, Domestico, NumeroPatas) = (tipo, colorPelo, domestico, numeroPatas);
    }
}
