using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DebitSecurity.Domain.Entities;
using DebitSecurity.Interface.Interfaces;

namespace DebitSecurity.Service.services
{
    public class InstallmentService : BaseService<IInstallmentRepository, Installment>, IInstallmentService
    {
        public InstallmentService(IInstallmentRepository repository): base(repository) {}

        public async Task<IList<Installment>> GetComplete()
        {
            return await _repository.GetComplete();
        }

        public async Task<Installment> GetComplete(Guid id)
        {
            return await _repository.GetComplete(id);
        }
    }
}