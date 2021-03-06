using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DebitSecurity.Domain.Entities;
using DebitSecurity.Interface.Interfaces;

namespace DebitSecurity.Service.services
{
    public class DebitSecurityService : BaseService<IDebitRepository, Debit>, IDebitService
    {
        public DebitSecurityService(IDebitRepository docRepository): base(docRepository) {}

        public async Task<IList<Debit>> GetComplete()
        {
            return await _repository.GetComplete();
        }

        public async Task<Debit> GetComplete(Guid id)
        {
            return await _repository.GetComplete(id);
        }
    }
}