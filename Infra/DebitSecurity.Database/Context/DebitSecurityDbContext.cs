using DebitSecurity.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DebitSecurity.Database.Context
{
    public class DebitSecurityDbContext: DbContext
    {
        public DebitSecurityDbContext(DbContextOptions<DebitSecurityDbContext> options) {}

        public DbSet<Person> Persons { get; set; }
        public DbSet<Installment> Installments { get; set; }
        public DbSet<Debit> Debits { get; set; }
        public DbSet<Document> DebitSecurities { get; set; }

        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-NAKAHAR;Integrated Security=True;Initial Catalog=DebitSecurity");
        }*/

        /*protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);
        }*/
    }
}