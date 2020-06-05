using Mod17_Ejercicio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mod17_Ejercicio.Services
{
    public interface IClaseService
    {
        void AddClase(Clase clase);

        void DeleteClase(int claseId);

        void DeleteClase(Clase clase);

        List<Clase> GetClases();

        Clase GetClase(int claseId);

        Clase UpdateClase(Clase clase);
    }
}
