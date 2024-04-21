using Microsoft.EntityFrameworkCore;

namespace API.Data;

public interface IDbContext
{
    DbSet<TEntity> Set<TEntity>() where TEntity : class;

    Task<TEntity> GetByIdAsync<TEntity>(Guid id) where TEntity : class;

    void Inster<TEntity>(TEntity entity) where TEntity : class;

    void InsterRange<TEntity>(IReadOnlyCollection<TEntity> entities) where TEntity : class;

    void Remove<TEntity>(TEntity entity) where TEntity : class;
}
