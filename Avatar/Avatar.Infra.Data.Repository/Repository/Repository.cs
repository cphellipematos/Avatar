using Avatar.Domain.Interfaces.Repository;
using Avatar.Infra.Data.Repository.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Avatar.Infra.Data.Repository.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected AvatarContext Db;
        protected DbSet<TEntity> DbSet;

        public Repository(AvatarContext context)
        {
            Db = context;
            DbSet = Db.Set<TEntity>();
        }

        public virtual void Create(TEntity obj)
        {
            DbSet.Add(obj);
        }

        public virtual void Delete(int id)
        {
            DbSet.Remove(DbSet.Find(id));
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return DbSet.ToList();
        }

        public virtual TEntity GetById(int id)
        {
            return DbSet.Find(id);
        }

        public virtual TEntity Update(TEntity obj)
        {
            var entry = Db.Entry(obj);
            DbSet.Attach(obj);
            entry.State = EntityState.Modified;

            return obj;
        }
    }
}
