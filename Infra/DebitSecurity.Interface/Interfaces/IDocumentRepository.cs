using System.Collections.Generic;
using System.Threading.Tasks;
using DebitSecurity.Domain.Entities;

namespace DebitSecurity.Interface.Interfaces
{
    public interface IDocumentRepository: IBaseRepository<Document>
    {
         Task<IList<Document>> GetComplete(int idDoc = 0);

         IList<Document> GetMock();
    }
}