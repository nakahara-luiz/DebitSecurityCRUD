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
    public class InstallmentRepository : BaseRepository<Installment>, IInstallmentRepository
    {
        public InstallmentRepository(DebitSecurityDbContext sqlContext) : base(sqlContext)
        {
        }

        public override async Task<IList<Installment>> GetComplete() {
            IQueryable<Installment> query = _sqlContext.Installments
                .Include(i => i.DebitSecurity);

            query = query.OrderByDescending(d => d.DueDate);

            return await query.ToArrayAsync();
        }

        public override async Task<Installment> GetComplete(Guid id)
        {
            IQueryable<Installment> query = _sqlContext.Installments
                .Include(i => i.DebitSecurity)
                .ThenInclude(ds => ds.Person);

            query = query.OrderByDescending(i => i.DueDate)
                .Where(i => i.Id == id);

            return await query.FirstOrDefaultAsync();
        }
    }
}