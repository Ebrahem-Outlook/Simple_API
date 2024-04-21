using API.Core;
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

    public new DbSet<TEntity> Set<TEntity>() where TEntity : Entity
    {
        return base.Set<TEntity>();
    }

    public async Task<TEntity> GetByIdAsync<TEntity>(Guid id) where TEntity : Entity
    {
        var entity = await Set<TEntity>().FirstOrDefaultAsync(e => e.Id == id);
        if(entity is null)
        {
            throw new NullReferenceException();
        }
        return entity;
    }

    public void Inster<TEntity>(TEntity entity) where TEntity : Entity
    {
        Set<TEntity>().Add(entity);
    }

    public void InsterRange<TEntity>(IReadOnlyCollection<TEntity> entities) where TEntity : Entity
    {
        Set<TEntity>().AddRange(entities);
    }

    public new void Remove<TEntity>(TEntity entity) where TEntity : Entity
    {
        Set<TEntity>().Remove(entity);
    }

    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return await base.SaveChangesAsync(cancellationToken);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        base.OnModelCreating(modelBuilder);
    }
}
