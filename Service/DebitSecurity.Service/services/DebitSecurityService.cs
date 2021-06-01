using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DebitSecurity.Domain.Entities;
using DebitSecurity.Interface;
using DebitSecurity.Interface.Interfaces;

namespace DebitSecurity.Service.services
{
    public class DebitSecurityService : IDebitService
    {
        public DebitSecurityService(IDebitRepository docRepository)
        {
            _docRepository = docRepository;
        }

        public IDebitRepository _docRepository { get; }

        public Debit Add(Debit obj)
        {
            _docRepository.Add(obj);
            return obj;
        }

        public void Delete(Guid id)
        {
            _docRepository.Delete(id);
        }

        public async Task<IList<Debit>> Get()
        {
            return await _docRepository.GetComplete();
        }

        public async Task<Debit> Get(Guid id)
        {
            return await _docRepository.GetComplete(id);
        }

        public Debit Update(Debit obj)
        {
            var existentDoc = _docRepository.Get(obj.Id);
            if (existentDoc == null || existentDoc.Id.Equals(Guid.Empty) || string.IsNullOrWhiteSpace(existentDoc.Id.ToString()))
                throw new NotImplementedException("Debito não identificado!");

            _docRepository.Update(obj);
            return obj;
        }
    }
}