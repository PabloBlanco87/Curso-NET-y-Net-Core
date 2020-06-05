using Mod17_Ejercicio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mod17_Ejercicio.Services
{
    public interface IAlumnoService
    {
        void AddAlumno(Alumno alumno);

        void DeleteAlumno(int alumnoId);

        void DeleteAlumno(Alumno alumno);

        List<Alumno> GetAlumnos();

        Alumno GetAlumno(int alumnoId);

        Alumno UpdateAlumno(Alumno alumno);
    }
}
