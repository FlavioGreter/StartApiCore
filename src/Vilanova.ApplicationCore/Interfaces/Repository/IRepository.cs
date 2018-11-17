using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Vilanova.ApplicationCore.Interfaces.Repository
{
    public interface IRepository<TEntity> where TEntity: class
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id);
        IEnumerable<TEntity> GetByExpression(Expression<Func<TEntity, bool>> predicate);
        void DeleteById(int id);
    }
}
