using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio2
{
    public class Alumno : Persona
    {
        public int NumeroAlumno;

        public Alumno() { }

        public Alumno(string nombre, int numeroAlumno)
        {
            Nombre = nombre;
            NumeroAlumno = numeroAlumno;
        }
    }
}
