using DebitSecurity.Database.Context;
using DebitSecurity.Domain.Entities;
using DebitSecurity.Interface.Interfaces;

namespace DebitSecurity.Database.Repository
{
    public class PersonRepository : BaseRepository<Person>, IPersonRepository
    {
        public PersonRepository(DebitSecurityDbContext sqlContext) : base(sqlContext)
        {
        }
    }
}