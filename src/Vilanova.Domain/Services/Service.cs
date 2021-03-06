﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Vilanova.Domain.Interfaces.Repository;
using Vilanova.Domain.Interfaces.Services;

namespace Vilanova.Domain.Services
{
    public class Service<TEntity> : IService<TEntity> where TEntity : class
    {
        protected readonly IRepository<TEntity> _repository;

        public Service(IRepository<TEntity> repository)
        {
            _repository = repository;
        }

        public void Add(TEntity entity)
        {
            //Regra Geral para Adicionar um Objeto
            try
            {
                _repository.Add(entity);
            }
            catch (Exception ex )
            {
                throw;
            }
            
        }

        public void DeleteById(int id)
        {
            //Regra Geral para Deletar um Objeto
            try
            {
                _repository.DeleteById(id);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public IEnumerable<TEntity> GetAll()
        {
           return  _repository.GetAll();
        }

        public IEnumerable<TEntity> GetByExpression(Expression<Func<TEntity, bool>> predicate)
        {
            return _repository.GetByExpression(predicate);
        }

        public TEntity GetById(int id)
        {
            return _repository.GetById(id);
        }

        public void Update(TEntity entity)
        {
            _repository.Update(entity);
        }
    }
}
