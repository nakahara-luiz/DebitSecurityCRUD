using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DebitSecurity.Database.Context;
using DebitSecurity.Domain.Entities;
using DebitSecurity.Interface;
using FluentValidation;

namespace DebitSecurity.Database.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly DebitSecurityDbContext _sqlContext;

        public BaseRepository(DebitSecurityDbContext sqlContext)
        {
            _sqlContext = sqlContext;
        }

        public void Add(TEntity obj)
        {
            _sqlContext.Set<TEntity>().Add(obj);
            _sqlContext.SaveChanges();
        }

        public void Update(TEntity obj)
        {
            _sqlContext.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _sqlContext.SaveChanges();
        }

        public void Delete(int id)
        {
            _sqlContext.Set<TEntity>().Remove(Get(id));
            _sqlContext.SaveChanges();
        }

        public IList<TEntity> Get() =>
            _sqlContext.Set<TEntity>().ToList();

        public TEntity Get(int id) =>
            _sqlContext.Set<TEntity>().Find(id);

        public Task<IList<Document>> GetComplete(int idDoc = 0)
        {
            throw new System.NotImplementedException();
        }
    }
}