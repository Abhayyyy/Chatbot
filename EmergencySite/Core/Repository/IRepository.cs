using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EmergencySite.Core.Repository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        /// <summary>
        /// Fetches one object according to the given id and the selected entity.
        /// </summary>
        /// <returns>
        /// Returns the fetched object.
        /// </returns>
        Task<TEntity> Get(int id);

        /// <summary>
        /// Fetches all objects of selected entity.
        /// </summary>
        /// <returns>
        /// Returns the list of fetched objects.
        /// </returns>
        Task<IEnumerable<TEntity>> GetAll();
        Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate);

        /// <summary>
        /// Adds the entity to DB context
        /// </summary>
        /// <param name="entity"></param>
        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);

        /// <summary>
        /// Remove objects from context.
        /// </summary>
        /// <param name="entity"></param>
        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities);
    }
}
