using System.Collections.Generic;
using System.Threading.Tasks;
using DebitSecurity.Domain.Entities;

namespace DebitSecurity.Interface
{
    public interface IBaseService<TEntity> where TEntity : BaseEntity
    {
        TEntity Add(TEntity obj);

        void Delete(int id);

        Task<IList<TEntity>> Get();

        Task<TEntity> Get(int id);

        TEntity Update(TEntity obj);
    }
}