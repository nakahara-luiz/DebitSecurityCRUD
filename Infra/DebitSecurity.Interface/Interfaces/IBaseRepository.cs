using System;
using System.Collections.Generic;
using DebitSecurity.Domain.Entities;

namespace DebitSecurity.Interface
{
    public interface IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        TEntity Add(TEntity obj);
        TEntity Update(TEntity obj);
        void Delete(Guid id);
        IList<TEntity> Get();
        TEntity Get(Guid id);
    }
}