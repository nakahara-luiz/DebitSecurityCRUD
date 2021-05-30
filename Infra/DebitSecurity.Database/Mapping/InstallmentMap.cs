using DebitSecurity.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DebitSecurity.Database.Mapping
{
    public class InstallmentMap: IEntityTypeConfiguration<Installment>
    {
        public void Configure(EntityTypeBuilder<Installment> builder)
        {
            builder.ToTable("Installment");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.DueDate)
                .IsRequired()
                .HasColumnName("DueDate")
                .HasColumnType("datetime");

            builder.Property(prop => prop.InstallmentNumber)
                .IsRequired()
                .HasColumnName("InstallmentNumber")
                .HasColumnType("int");

            builder.Property(prop => prop.Value)
                .IsRequired()
                .HasColumnName("Value")
                .HasColumnType("bigint");
        }
    }
}