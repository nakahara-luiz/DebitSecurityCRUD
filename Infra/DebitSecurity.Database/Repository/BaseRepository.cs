using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DebitSecurity.Database.Context;
using DebitSecurity.Domain.Entities;
using DebitSecurity.Interface;

namespace DebitSecurity.Database.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly DebitSecurityDbContext _sqlContext;

        public BaseRepository(DebitSecurityDbContext sqlContext)
        {
            _sqlContext = sqlContext;
        }

        public TEntity Add(TEntity obj)
        {
            _sqlContext.Set<TEntity>().Add(obj);
            _sqlContext.SaveChanges();

            return obj;
        }

        public TEntity Update(TEntity obj)
        {
            _sqlContext.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _sqlContext.SaveChanges();

            return obj;
        }

        public void Delete(Guid id)
        {
            _sqlContext.Set<TEntity>().Remove(Get(id));
            _sqlContext.SaveChanges();
        }

        public IList<TEntity> Get() =>
            _sqlContext.Set<TEntity>().ToList();

        public TEntity Get(Guid id) =>
            _sqlContext.Set<TEntity>().Find(id);

        public virtual Task<IList<TEntity>> GetComplete()
        {
            throw new NotImplementedException();
        }

        public virtual Task<TEntity> GetComplete(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}