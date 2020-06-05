using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mod17_Ejercicio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mod17_Ejercicio.EntityConfig
{
    public class ProfesorEntityConfig
    {
        public static void SetProfesorEntityConfig(EntityTypeBuilder<Profesor> entityBuilder)
        {
            entityBuilder.HasKey(x => x.ProfesorId);
            entityBuilder.Property(x => x.Nombre).IsRequired();
            entityBuilder.Property(x => x.Apellidos).IsRequired();
            entityBuilder.Property(x => x.Apellidos).HasMaxLength(100);
        }
    }
}
