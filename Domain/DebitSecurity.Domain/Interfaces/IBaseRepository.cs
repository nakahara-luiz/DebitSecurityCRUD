using System.Collections.Generic;
using DebitSecurity.Domain.Entities;

namespace DebitSecurity.Domain.Interfaces
{
    public interface IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        void Insert(TEntity obj);
        void Update(TEntity obj);
        void Delete(int id);
        IList<TEntity> Get();
        TEntity Get(int id);
    }
}