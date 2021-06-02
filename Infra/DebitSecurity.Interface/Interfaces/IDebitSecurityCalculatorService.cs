using System.Collections.Generic;
using DebitSecurity.Domain.Entities;
using DebitSecurity.DTO;

namespace DebitSecurity.Interface.Interfaces
{
    public interface IDebitSecurityCalculatorService
    {
        DebitResumeDTO Calculate(Debit debitSecurity);
        IList<DebitResumeDTO> Calculate(IList<Debit> debitSecurity);
    }
}