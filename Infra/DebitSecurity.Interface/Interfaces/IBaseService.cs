using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DebitSecurity.Domain.Entities;

namespace DebitSecurity.Interface
{
    public interface IBaseService<TEntity> where TEntity : BaseEntity
    {
        TEntity Add(TEntity obj);

        void Delete(Guid id);

        IList<TEntity> Get();

        TEntity Get(Guid id);

        TEntity Update(TEntity obj);
    }
}