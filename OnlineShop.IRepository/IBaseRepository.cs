using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.IRepository
{
    /// <summary>
    ///  where TEntity : class : have to be a  class
    ///  new(): classes come with a constructor
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public interface IBaseRepository<TEntity> where TEntity : class, new()
    {

        Task<TEntity> CreateAsync(TEntity entity);

        Task<TEntity> UpdateAsync(TEntity entity);

        Task<TEntity> DeleteAsync(string id);

        Task<TEntity> FindAsync(TEntity entity);

        /// <summary>
        /// Find all entities
        /// </summary>
        /// <returns>List</returns>
        Task<List<TEntity>> FindAllAsync();
    }
}
