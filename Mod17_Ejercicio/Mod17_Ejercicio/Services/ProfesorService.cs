using Microsoft.EntityFrameworkCore;
using Mod17_Ejercicio.Contexto;
using Mod17_Ejercicio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mod17_Ejercicio.Services
{
    public class ProfesorService : IProfesorService
    {
        private readonly IContextoDB _contextoDB;

        public ProfesorService(IContextoDB contextoDB)
        {
            _contextoDB = contextoDB;
        }

        //CRUD

        public void AddProfesor(Profesor profesor)
        {
            _contextoDB.Profesores.Add(profesor);
            _contextoDB.SaveChanges();
        }

        public void DeleteProfesor(int profesorId)
        {
            var profesor = GetProfesor(profesorId);
            DeleteProfesor(profesor);
        }

        public void DeleteProfesor(Profesor profesor)
        {
            _contextoDB.Profesores.Remove(profesor);
            _contextoDB.SaveChanges();
        }

        public List<Profesor> GetProfesores()
        {
            return _contextoDB.Profesores.Select(x => x).ToList();
        }

        public Profesor GetProfesor(int profesorId)
        {
            return _contextoDB.Profesores.Include(x=>x.Clase).Where(x => x.ProfesorId == profesorId).FirstOrDefault();
        }

        public Profesor UpdateProfesor(Profesor profesor)
        {
            var profesorUpdated = _contextoDB.Profesores.Update(profesor).Entity;
            _contextoDB.SaveChanges();

            return profesorUpdated;
        }
    }
}