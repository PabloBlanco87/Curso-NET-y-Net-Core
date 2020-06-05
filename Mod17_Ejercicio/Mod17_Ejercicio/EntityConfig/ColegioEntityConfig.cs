using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mod17_Ejercicio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mod17_Ejercicio.EntityConfig
{
    public class ColegioEntityConfig
    {
        public static void SetColegioEntityConfig(EntityTypeBuilder<Colegio> entityBuilder)
        {
            entityBuilder.HasKey(x => x.ColegioId);
            entityBuilder.Property(x => x.Nombre).IsRequired();
        }
    }
}
