using System.Collections.Generic;
using Avatar.Domain.Interfaces.Repository;

namespace Avatar.Data.Repository.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        public TEntity Create(TEntity obj)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public TEntity GetById(TEntity obj)
        {
            throw new System.NotImplementedException();
        }

        public TEntity Update(TEntity obj)
        {
            throw new System.NotImplementedException();
        }
    }
}
