using Microsoft.EntityFrameworkCore;
using Mod17_Ejercicio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Mod17_Ejercicio.Contexto
{
    public interface IContextoDB
    {
        DbSet<Alumno> Alumnos { get; set; }
        DbSet<Clase> Clases { get; set; }
        DbSet<Colegio> Colegios { get; set; }
        DbSet<Profesor> Profesores { get; set; }

        int SaveChanges();

        Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default(CancellationToken));
    }
}
