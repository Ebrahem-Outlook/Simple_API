using API.Core;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public interface IDbContext
{
    DbSet<TEntity> Set<TEntity>() where TEntity : Entity;

    Task<TEntity> GetByIdAsync<TEntity>(Guid id) where TEntity : Entity;

    void Inster<TEntity>(TEntity entity) where TEntity : Entity;

    void InsterRange<TEntity>(IReadOnlyCollection<TEntity> entities) where TEntity : Entity;

    void Remove<TEntity>(TEntity entity) where TEntity : Entity;
}
