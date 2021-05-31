using System.Collections.Generic;
using DebitSecurity.Domain.Entities;
using DebitSecurity.DTO;

namespace DebitSecurity.Interface.Interfaces
{
    public interface IDebitSecurityCalculatorService
    {
         DebitSecurityResumeDTO Calculate(Document debitSecurity);
         IList<DebitSecurityResumeDTO> Calculate(IList<Document> debitSecurity);
    }
}