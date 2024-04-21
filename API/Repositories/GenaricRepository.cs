using API.Core;
using API.Data;

namespace API.Repositories
{
    public abstract class GenaricRepository<TEntity> where TEntity : Entity
    {
        /// <summary>
        /// Initialies a new instance of <see cref="GenaricRepository{TEntity}"/> Class.
        /// </summary>
        /// <param name="context"></param>
        protected GenaricRepository(IDbContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// Get instance of the connection to database.
        /// </summary>
        protected IDbContext context { get; }

        /// <summary>
        /// Get the entity with the specified identifier.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<TEntity> GetByIdAsync(Guid id) => await context.GetByIdAsync<TEntity>(id);

        /// <summary>
        /// Inserts the specified entity into the database.
        /// </summary>
        /// <param name="entity"></param>
        public void Insert(TEntity entity) => context.Inster(entity);

        /// <summary>
        /// Inserts the specified entities to the database.
        /// </summary>
        /// <param name="entities"></param>
        public void InsertRange(IReadOnlyCollection<TEntity> entities) => context.InsterRange(entities);

        /// <summary>
        /// Remove the spicefied entity from the database.
        /// </summary>
        /// <param name="entity"></param>
        public void Delete(TEntity entity) => context.Remove(entity);

        /// <summary>
        /// Update the specified entity in the database.
        /// </summary>
        /// <param name="entity"></param>
        public void Update(TEntity entity) => context.Set<TEntity>().Update(entity);
    }
}
