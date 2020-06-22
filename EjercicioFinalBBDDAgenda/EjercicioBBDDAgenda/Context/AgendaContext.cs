using EjercicioBBDDAgenda.Clases;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioBBDDAgenda.Context
{
    public class AgendaContext : DbContext
    {

        public DbSet<Cita> Citas { get; set; }
        public DbSet<Contacto> Contactos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Debes introducir tu stringConnection
            optionsBuilder.UseSqlServer(@"Server = tcp:agendapablo.database.windows.net, 1433; " +
                "Initial Catalog=Agenda;Persist Security Info=False;" +
                "User ID=Pablitroke;Password={tucontraseña};MultipleActiveResultSets=False;" +
                "Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }

        
    }
}
