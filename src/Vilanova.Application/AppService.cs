using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Vilanova.Application.Interfaces;
using Vilanova.Domain.Interfaces.Services;

namespace Vilanova.Application
{
    public class AppService<TEntity> : IAppService<TEntity> where TEntity : class
    {

        private readonly IService<TEntity> _serviceBase;

        public AppService(IService<TEntity> iService)
        {
            _serviceBase = iService;
        }


        public void Add(TEntity entity)
        {
            _serviceBase.Add(entity);
        }

        public void DeleteById(int id)
        {
            _serviceBase.DeleteById(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return  _serviceBase.GetAll();
        }

        public IEnumerable<TEntity> GetByExpression(Expression<Func<TEntity, bool>> predicate)
        {
            return _serviceBase.GetByExpression(predicate);
        }

        public TEntity GetById(int id)
        {
            return GetById(id);
        }

        public void Update(TEntity entity)
        {
            _serviceBase.Update(entity);
        }
    }
}
