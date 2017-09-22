using System;
using System.Collections.Generic;
using System.Text;

namespace Avatar.Domain.Interfaces.Repository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        void Create(TEntity obj);
        void Delete(int id);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        TEntity Update(TEntity obj);
    }
}
