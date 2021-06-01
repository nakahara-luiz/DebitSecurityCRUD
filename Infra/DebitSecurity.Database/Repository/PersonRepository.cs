using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DebitSecurity.Database.Context;
using DebitSecurity.Domain.Entities;
using DebitSecurity.Interface.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DebitSecurity.Database.Repository
{
    public class PersonRepository : BaseRepository<Person>, IPersonRepository
    {
        public PersonRepository(DebitSecurityDbContext sqlContext) : base(sqlContext)
        {
        }

        public override async Task<IList<Person>> GetComplete() {
            IQueryable<Person> query = _sqlContext.Persons
                .Include(p => p.Debits)
                .ThenInclude(ds => ds.Installments);

            query = query.OrderByDescending(d => d.Name);

            return await query.ToArrayAsync();
        }

        public override async Task<Person> GetComplete(Guid id)
        {
            IQueryable<Person> query = _sqlContext.Persons
                .Include(p => p.Debits)
                .ThenInclude(ds => ds.Installments);

            query = query.OrderByDescending(d => d.Name)
                .Where(d => d.Id == id);

            return await query.FirstOrDefaultAsync();
        }
    }
}