using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace API.Data;

public class ApplicationDbContext : DbContext, IDbContext , IUnitOfWork
{
    private readonly IMediator _mediator;

    public ApplicationDbContext(DbContextOptions options, IMediator mediator) : base(options)  
    {
        _mediator = mediator;
    }

    public new DbSet<TEntity> Set<TEntity>() where TEntity : class
    {
        return base.Set<TEntity>();
    }

    public async Task<TEntity> GetByIdAsync<TEntity>(Guid id) where TEntity : class
    {
        var entity = await Set<TEntity>().FindAsync(id);
        if(entity is null)
        {
            throw new NullReferenceException();
        }
        return entity;
    }

    public void Inster<TEntity>(TEntity entity) where TEntity : class
    {
        Set<TEntity>().Add(entity);
    }

    public void InsterRange<TEntity>(IReadOnlyCollection<TEntity> entities) where TEntity : class
    {
        Set<TEntity>().AddRange(entities);
    }

    void IDbContext.Remove<TEntity>(TEntity entity)
    {
        Set<TEntity>().Remove(entity);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        base.OnModelCreating(modelBuilder);
    }
}
