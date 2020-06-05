using Microsoft.EntityFrameworkCore;
using Mod17_Ejercicio.Contexto;
using Mod17_Ejercicio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mod17_Ejercicio.Services
{
    public class AlumnoService : IAlumnoService
    {
        private readonly IContextoDB _contextoDB;

        public AlumnoService(IContextoDB contextoDB)
        {
            _contextoDB = contextoDB;
        }

        //CRUD

        public void AddAlumno(Alumno alumno)
        {
            _contextoDB.Alumnos.Add(alumno);
            _contextoDB.SaveChanges();
        }

        public void DeleteAlumno(int alumnoId)
        {
            var alumno = GetAlumno(alumnoId);
            DeleteAlumno(alumno);
        }

        public void DeleteAlumno(Alumno alumno)
        {
            _contextoDB.Alumnos.Remove(alumno);
            _contextoDB.SaveChanges();
        }

        public List<Alumno> GetAlumnos()
        {
            return _contextoDB.Alumnos.Select(x => x).ToList();
        }

        public Alumno GetAlumno(int alumnoId)
        {
            return _contextoDB.Alumnos.Include(x=>x.Clase).Where(x => x.AlumnoId == alumnoId).FirstOrDefault();
        }

        public Alumno UpdateAlumno(Alumno alumno)
        {
            var alumnoUpdated= _contextoDB.Alumnos.Update(alumno).Entity;
            _contextoDB.SaveChanges();

            return alumnoUpdated;
        }
    }
}
