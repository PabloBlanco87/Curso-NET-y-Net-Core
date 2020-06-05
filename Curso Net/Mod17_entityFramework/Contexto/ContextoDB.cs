using Microsoft.EntityFrameworkCore;
using Mod17_entityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mod17_entityFramework.Contexto
{
    public class ContextoDB : DbContext
    {
        public ContextoDB(DbContextOptions<ContextoDB> options) : base(options) { }

        public DbSet<Cancion> Canciones { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) { }
    }
}
