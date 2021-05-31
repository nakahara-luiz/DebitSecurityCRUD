using System.Collections.Generic;
using System.Threading.Tasks;
using DebitSecurity.Domain.Entities;

namespace DebitSecurity.Interface
{
    public interface IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        TEntity Add(TEntity obj);
        TEntity Update(TEntity obj);
        void Delete(int id);
        IList<TEntity> Get();
        TEntity Get(int id);
    }
}