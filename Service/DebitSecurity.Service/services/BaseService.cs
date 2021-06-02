using System;
using System.Collections.Generic;
using DebitSecurity.Domain.Entities;
using DebitSecurity.Interface;

namespace DebitSecurity.Service.services
{
    public class BaseService<TRepository, TEntity> : IBaseService<TEntity> 
        where TEntity : BaseEntity 
        where TRepository : IBaseRepository<TEntity>
    {
        protected TRepository _repository;
        public BaseService(TRepository repository)
        {
            _repository = repository;
        }

        public TEntity Add(TEntity obj)
        {
            _repository.Add(obj);
            return obj;
        }

        public void Delete(Guid id)
        {
            _repository.Delete(id);
        }

        public IList<TEntity> Get()
        {
            return _repository.Get();
        }

        public TEntity Get(Guid id)
        {
            return _repository.Get(id);
        }

        public TEntity Update(TEntity obj)
        {
            var existentDoc = _repository.Get(obj.Id);
            if (existentDoc == null || existentDoc.Id.Equals(Guid.Empty) || string.IsNullOrWhiteSpace(existentDoc.Id.ToString()))
                throw new NotImplementedException("Registro Não identificado!");

            existentDoc = obj;

            _repository.Update(obj);
            return obj;
        }
    }
}