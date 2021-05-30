using DebitSecurity.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DebitSecurity.Database.Mapping
{
    public class DebitMap: IEntityTypeConfiguration<Debit>
    {
        public void Configure(EntityTypeBuilder<Debit> builder)
        {
            builder.ToTable("Debit");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Interest)
                .IsRequired()
                .HasColumnName("Interest")
                .HasColumnType("int");

            builder.Property(prop => prop.Penalty)
                .IsRequired()
                .HasColumnName("Penalty")
                .HasColumnType("int");
        }
    }
}