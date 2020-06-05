using Microsoft.EntityFrameworkCore;
using Mod17_Ejercicio.Contexto;
using Mod17_Ejercicio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mod17_Ejercicio.Services
{
    public class ClaseService : IClaseService
    {
        private readonly IContextoDB _contextoDB;

        public ClaseService(IContextoDB contextoDB)
        {
            _contextoDB = contextoDB;
        }

        //CRUD

        public void AddClase(Clase clase)
        {
            _contextoDB.Clases.Add(clase);
            _contextoDB.SaveChanges();
        }

        public void DeleteClase(int claseId)
        {
            var clase = GetClase(claseId);
            DeleteClase(clase);
        }

        public void DeleteClase(Clase clase)
        {
            _contextoDB.Clases.Remove(clase);
            _contextoDB.SaveChanges();
        }

        public List<Clase> GetClases()
        {
            return _contextoDB.Clases.Select(x => x).ToList();
        }

        public Clase GetClase(int claseId)
        {
            return _contextoDB.Clases.Include(x=>x.Colegio).Where(x => x.ClaseId == claseId).FirstOrDefault();
        }

        public Clase UpdateClase(Clase clase)
        {
            var claseUpdated = _contextoDB.Clases.Update(clase).Entity;
            _contextoDB.SaveChanges();

            return claseUpdated;
        }
    }
}

