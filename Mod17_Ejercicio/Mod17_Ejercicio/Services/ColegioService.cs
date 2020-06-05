using Mod17_Ejercicio.Contexto;
using Mod17_Ejercicio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mod17_Ejercicio.Services
{
    public class ColegioService: IColegioService
    {
        private readonly IContextoDB _contextoDB;

        public ColegioService(IContextoDB contextoDB)
        {
            _contextoDB = contextoDB;
        }

        //CRUD

        public void AddColegio(Colegio colegio)
        {
            _contextoDB.Colegios.Add(colegio);
            _contextoDB.SaveChanges();
        }

        public void DeleteColegio(int colegioId)
        {
            var colegio = GetColegio(colegioId);
            DeleteColegio(colegio);
        }

        public void DeleteColegio(Colegio colegio)
        {
            _contextoDB.Colegios.Remove(colegio);
            _contextoDB.SaveChanges();
        }

        public List<Colegio> GetColegios()
        {
            return _contextoDB.Colegios.Select(x => x).ToList();
        }

        public Colegio GetColegio(int colegioId)
        {
            return _contextoDB.Colegios.Where(x => x.ColegioId == colegioId).FirstOrDefault();
        }

        public Colegio UpdateColegio(Colegio colegio)
        {
            var colegioUpdated = _contextoDB.Colegios.Update(colegio).Entity;
            _contextoDB.SaveChanges();

            return colegioUpdated;
        }
    }
}
