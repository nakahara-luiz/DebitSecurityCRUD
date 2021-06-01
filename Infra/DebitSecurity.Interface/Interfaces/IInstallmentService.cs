using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DebitSecurity.Domain.Entities;

namespace DebitSecurity.Interface.Interfaces
{
    public interface IInstallmentService: IBaseService<Installment>
    {
         Task<IList<Installment>> GetComplete();

        Task<Installment> GetComplete(Guid id);
    }
}