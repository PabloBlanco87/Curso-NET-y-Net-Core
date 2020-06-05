using Mod17_Ejercicio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mod17_Ejercicio.Services
{
    public interface IProfesorService
    {
        void AddProfesor(Profesor profesor);

        void DeleteProfesor(int profesorId);

        void DeleteProfesor(Profesor profesor);

        List<Profesor> GetProfesores();

        Profesor GetProfesor(int profesorId);

        Profesor UpdateProfesor(Profesor profesor);
    }
}
