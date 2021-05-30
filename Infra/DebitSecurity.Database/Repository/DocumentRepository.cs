using DebitSecurity.Database.Context;
using DebitSecurity.Domain.Entities;
using DebitSecurity.Interface.Interfaces;

namespace DebitSecurity.Database.Repository
{
    public class DocumentRepository : BaseRepository<Document>, IDocumentRepository
    {
        public DocumentRepository(DebitSecurityDbContext sqlContext) :base(sqlContext)
        {
        }
    }
}