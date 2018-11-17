using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Vilanova.ApplicationCore.Interfaces.Repository;
using Vilanova.Infrastructure.Data;

namespace Vilanova.Infrastructure.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {

        protected readonly VilanovaContext _db;

        public Repository(VilanovaContext db)
        {
            _db = db;
        }

        public void Add(TEntity entity)
        {
            _db.Set<TEntity>().Add(entity);
            _db.SaveChanges();
        }

        public void DeleteById(int id)
        {
            var entity = GetById(id);
            _db.Set<TEntity>().Remove(entity);
            _db.SaveChanges();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return  _db.Set<TEntity>().AsEnumerable();
        }

        public IEnumerable<TEntity> GetByExpression(Expression<Func<TEntity, bool>> predicate)
        {
            return _db.Set<TEntity>().Where(predicate).AsEnumerable();
        }

        public TEntity GetById(int id)
        {
            return _db.Set<TEntity>().Find(id);
        }

        public void Update(TEntity entity)
        {
            _db.Entry(entity).State = EntityState.Modified;
            _db.SaveChanges();
        }
    }
}
