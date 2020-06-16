using api.net.core.ejemplo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace api.net.core.ejemplo.DataAccess
{
    public interface IBBDDContext
    {
        DbSet<ModelItem> ModelItem { get; set; }

        DbSet<TEntity> Set<TEntity>() where TEntity : class;
        DatabaseFacade Database { get; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
        Task<int> SaveChanges(CancellationToken cancellationToken = default(CancellationToken));
        void RemoveRange(IEnumerable<object> entifies);
        EntityEntry Update(object entity);
    }
}
