using System.Collections.Generic;
using DebitSecurity.Domain.Entities;
using FluentValidation;

namespace DebitSecurity.Interface
{
    public interface IBaseService<TEntity> where TEntity : BaseEntity
    {
        void Add(TEntity obj);

        void Delete(int id);

        IList<TEntity> Get();

        TEntity Get(int id);

        void Update(TEntity obj);
    }
}