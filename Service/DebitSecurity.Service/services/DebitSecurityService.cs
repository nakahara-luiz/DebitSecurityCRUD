using System;
using System.Collections.Generic;
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

        public void Add(Document obj)
        {
            _docRepository.Add(obj);
        }

        public void Delete(int id)
        {
            _docRepository.Delete(id);
        }

        public IList<Document> Get()
        {
            return _docRepository.GetMock();
        }

        public Document Get(int id)
        {
            return _docRepository.Get(id);
        }

        public void Update(Document obj)
        {
            var existentDoc = _docRepository.Get(obj.Id);
            if (existentDoc == null || existentDoc.Id == 0)
                throw new NotImplementedException("Documento não identificado!");

            _docRepository.Update(obj);
        }
    }
}