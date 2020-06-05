using Microsoft.EntityFrameworkCore;
using Mod17_Ejercicio.EntityConfig;
using Mod17_Ejercicio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mod17_Ejercicio.Contexto
{
    public class ContextoDB : DbContext, IContextoDB
    {
        public ContextoDB(DbContextOptions<ContextoDB> options) : base(options)
        {

        }

        public DbSet<Alumno> Alumnos { get; set; }  //Estos serán el nombre de las tablas
        public DbSet<Clase> Clases { get; set; }  
        public DbSet<Colegio> Colegios { get; set; }  
        public DbSet<Profesor> Profesores { get; set; }  

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            AlumnoEntityConfig.SetAlumnoEntityConfig(modelBuilder.Entity<Alumno>());
        }
    }
}
