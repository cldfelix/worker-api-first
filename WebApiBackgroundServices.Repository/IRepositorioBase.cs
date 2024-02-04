using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace WebApiBackgroundServices.Repository;

public interface IRepositorioBase {
    DbSet<T> Set<T>() where T : class;
    int SaveChanges();
    Task<int> SaveChangesAsync();
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    EntityEntry<T> Entry<T>(T entity) where T : class;
    void Dispose();
}