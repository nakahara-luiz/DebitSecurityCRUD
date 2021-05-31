using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DebitSecurity.Domain.Entities;
using DebitSecurity.Interface;
using DebitSecurity.Interface.Interfaces;

namespace DebitSecurity.Service.services
{
    public class DebitSecurityService : IBaseService<Document>
    {
        public DebitSecurityService(IDocumentRepository docRepository)
        {
            _docRepository = docRepository;
        }

        public IDocumentRepository _docRepository { get; }

        public Document Add(Document obj)
        {
            _docRepository.Add(obj);
            return obj;
        }

        public void Delete(int id)
        {
            _docRepository.Delete(id);
        }

        public async Task<IList<Document>> Get()
        {
            return await _docRepository.GetComplete();
        }

        public async Task<Document> Get(int id)
        {
            return await _docRepository.GetComplete(id);
        }

        public Document Update(Document obj)
        {
            var existentDoc = _docRepository.Get(obj.Id);
            if (existentDoc == null || existentDoc.Id == 0)
                throw new NotImplementedException("Documento não identificado!");

            _docRepository.Update(obj);
            return obj;
        }
    }
}