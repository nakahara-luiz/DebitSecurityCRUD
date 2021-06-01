using System.Collections.Generic;
using DebitSecurity.Domain.Entities;
using DebitSecurity.DTO;

namespace DebitSecurity.Interface.Interfaces
{
    public interface IDebitSecurityCalculatorService
    {
        DebitSecurityResumeDTO Calculate(Debit debitSecurity);
        IList<DebitSecurityResumeDTO> Calculate(IList<Debit> debitSecurity);
    }
}