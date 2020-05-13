using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio2
{
    public class Profesor: Persona
    {
        public string MateriaImpartida;

        public Profesor() { }

        public Profesor(string nombre, string materiaImpartida)
        {
            Nombre = nombre;
            MateriaImpartida = materiaImpartida;
        }
    }
}
