using DebitSecurity.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DebitSecurity.Database.Context
{
    public class DebitSecurityDbContext: DbContext
    {
        public DebitSecurityDbContext(DbContextOptions<DebitSecurityDbContext> options): base(options) {}

        public DbSet<Person> Persons { get; set; }
        public DbSet<Installment> Installments { get; set; }
        public DbSet<Debit> Debits { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);
        }
    }
}