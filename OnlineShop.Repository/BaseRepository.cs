using OnlineShop.IRepository;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class, new()
    {
        private readonly SqlSugarScope dbBase;

        public BaseRepository(SqlSugarScope dbBase)
        {
            this.dbBase = dbBase;
        }
        private ISqlSugarClient DbbaseClient => dbBase;

        protected ISqlSugarClient DbClient => DbbaseClient;

        public Task<TEntity> CreateAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> DeleteAsync(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<TEntity>> FindAllAsync()
        {
            throw new NotImplementedException();
        }

        public  Task<TEntity> FindAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        Task<TEntity> IBaseRepository<TEntity>.UpdateAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
