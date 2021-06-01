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
    public class DebitRepository : BaseRepository<Debit>, IDebitRepository
    {
        public DebitRepository(DebitSecurityDbContext sqlContext) :base(sqlContext)
        {
        }

        public override async Task<IList<Debit>> GetComplete() {
            IQueryable<Debit> query = _sqlContext.Debits
                .Include(ds => ds.Person)
                .Include(d => d.Installments);

            query = query.OrderByDescending(d => d.SecurityNumber);

            return await query.ToArrayAsync();
        }

        public override async Task<Debit> GetComplete(Guid id)
        {
            IQueryable<Debit> query = _sqlContext.Debits
                .Include(ds => ds.Person)
                .Include(d => d.Installments);

            query = query.OrderByDescending(d => d.SecurityNumber)
                .Where(d => d.Id == id);

            return await query.FirstOrDefaultAsync();
        }
    }
}