using Mod17_Ejercicio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mod17_Ejercicio.Services
{
    public interface IColegioService
    {
        void AddColegio(Colegio colegio);

        void DeleteColegio(int colegioId);

        void DeleteColegio(Colegio colegio);

        List<Colegio> GetColegios();

        Colegio GetColegio(int colegioId);

        Colegio UpdateColegio(Colegio colegio);
    }
}
