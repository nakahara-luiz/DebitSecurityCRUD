using DebitSecurity.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DebitSecurity.Database.Mapping
{
    public class DocumentMap: IEntityTypeConfiguration<Document>
    {
        public void Configure(EntityTypeBuilder<Document> builder)
        {
            builder.ToTable("Document");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.DocumentNumber)
                .IsRequired()
                .HasColumnName("DocumentNumber")
                .HasColumnType("varchar(15)");
        }
    }
}