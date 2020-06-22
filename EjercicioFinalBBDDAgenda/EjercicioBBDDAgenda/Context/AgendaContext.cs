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
            optionsBuilder.UseSqlServer(@"Server = tcp:agendapablo.database.windows.net, 1433; " +
                "Initial Catalog=Agenda;Persist Security Info=False;" +
                "User ID=Pablitroke;Password=Zizou1987;MultipleActiveResultSets=False;" +
                "Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }

        
    }
}
