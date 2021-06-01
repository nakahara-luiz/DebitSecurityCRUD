using DebitSecurity.Database.Context;
using DebitSecurity.Domain.Entities;
using DebitSecurity.Interface.Interfaces;

namespace DebitSecurity.Database.Repository
{
    public class InstallmentRepository : BaseRepository<Installment>, IInstallmentRepository
    {
        public InstallmentRepository(DebitSecurityDbContext sqlContext) : base(sqlContext)
        {
        }
    }
}