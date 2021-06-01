using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DebitSecurity.Domain.Entities;

namespace DebitSecurity.Interface.Interfaces
{
    public interface IDebitRepository: IBaseRepository<Debit>
    {
         Task<IList<Debit>> GetComplete();
         Task<Debit> GetComplete(Guid id);
    }
}