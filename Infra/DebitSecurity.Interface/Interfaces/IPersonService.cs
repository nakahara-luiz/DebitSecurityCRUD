using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DebitSecurity.Domain.Entities;

namespace DebitSecurity.Interface.Interfaces
{
    public interface IPersonService: IBaseService<Person>
    {
         Task<IList<Person>> GetComplete();

        Task<Person> GetComplete(Guid id);
    }
}