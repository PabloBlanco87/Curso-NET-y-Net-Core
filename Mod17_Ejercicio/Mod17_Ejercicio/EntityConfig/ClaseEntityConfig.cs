using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mod17_Ejercicio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mod17_Ejercicio.EntityConfig
{
    public class ClaseEntityConfig
    {
        public static void SetClaseEntityConfig(EntityTypeBuilder<Clase> entityBuilder)
        {
            entityBuilder.HasKey(x => x.ClaseId);
            entityBuilder.Property(x => x.Nombre).IsRequired();
        }
    }
}
