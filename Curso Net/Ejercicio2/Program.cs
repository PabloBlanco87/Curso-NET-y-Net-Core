using System;
using System.Collections;
using System.Collections.Generic;
using static System.Console;
using static System.Convert;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Desarrollar el ejercicio anterior, pero ahora al introducir el nombre, se especificara si es Alumno o Profesor, 
             * con lo que se crearan 2 clases nuevas que Heredaran ambas de "Persona". Si es Alumno, se pedirá el numero 
             * de alumno, si es profesor, se pedirá la materia que imparte.*/
            CreaArrayConjunto();
            ReadKey();
        }

        public static void CreaArrayConjunto()
        {
            List<Object> lista = new List<Object>();
            string nombre, eleccion;

            Write($"Por favor, introduza el nombre de la persona: ");
            nombre = ReadLine();

            WriteLine($"¿{nombre} es alumno o profesor? Introduzca 'a' si es alumno o 'p' si es profesor: ");
            eleccion = ReadLine();

            while (eleccion != "a" && eleccion != "p")
            {
                WriteLine($"Por favor, introduzca 'a' si es alumno o 'p' si es profesor: ");
                eleccion = ReadLine();
            }

            if (eleccion == "a")
                CreaAlumno(nombre);
            else
                CreaProfesor(nombre);
        }

        public static void CreaAlumno(string name)
        {
            int numeroAlumno;
            Write($"Introduzca el número de alumno: ");
            numeroAlumno = ToInt32(ReadLine());
            Alumno alumno = new Alumno(name, numeroAlumno);
            WriteLine($"Alumno con nombre {name} y número de alumno {numeroAlumno}.");
        }

        public static void CreaProfesor(string name)
        {
            string materiaImpartida;
            Write($"Introduzca la materia que imparte este profesor: ");
            materiaImpartida = ReadLine();
            Profesor profesor = new Profesor(name, materiaImpartida);
            WriteLine($"Profesor con nombre {name} e imparte {materiaImpartida}.");
        }
    }
}
