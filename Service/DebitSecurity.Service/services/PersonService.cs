using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DebitSecurity.Domain.Entities;
using DebitSecurity.Interface.Interfaces;

namespace DebitSecurity.Service.services
{
    public class PersonService : BaseService<IPersonRepository, Person>, IPersonService
    {
        public PersonService(IPersonRepository repository): base(repository) {}

        public async Task<IList<Person>> GetComplete()
        {
            return await _repository.GetComplete();
        }

        public async Task<Person> GetComplete(Guid id)
        {
            return await _repository.GetComplete(id);
        }
    }
}