using System;
using System.Collections.Generic;
using System.Linq;
using DebitSecurity.Domain.Entities;
using DebitSecurity.DTO;
using DebitSecurity.Interface.Interfaces;

namespace DebitSecurity.Service.services
{
    public class DebitSecurityCalculatorService: IDebitSecurityCalculatorService
    {
        public IList<DebitSecurityResumeDTO> Calculate(IList<Debit> debitSecurity) {
            var resumes = new List<DebitSecurityResumeDTO>();

            foreach (var item in debitSecurity)
                resumes.Add(Calculate(item));
            
            return resumes;
        }
        public DebitSecurityResumeDTO Calculate(Debit debitSecurity) {
            if (debitSecurity == null) 
                throw new Exception("Título de dívida não informado!");
            if (debitSecurity.Person == null || string.IsNullOrWhiteSpace(debitSecurity.Person.Name)) 
                throw new Exception("Cliente não informado no Título de dívida!");
            if (debitSecurity.Installments == null || !debitSecurity.Installments.Any()) 
                throw new Exception("Parcela(s) não informada(s) no Título de dívida!");
            
            var firstInstallment = debitSecurity.Installments.First();
            var penaltyFee = debitSecurity.Penalty;
            var interestFee = debitSecurity.Interest;

            var penaltyValue = CalculateFee(penaltyFee, firstInstallment);
            var interestValue = CalculateFee(interestFee, debitSecurity.Installments);
            var originalValue = debitSecurity.Installments.Sum(i => i.Value);
            var daysOverDue = (firstInstallment.DueDate - DateTime.Now).TotalDays;

            return new DebitSecurityResumeDTO {
                ActualValue = originalValue + penaltyValue + interestValue,
                CustomerName = debitSecurity.Person.Name,
                DaysOverDue = Convert.ToInt32(daysOverDue),
                DocumentNumber = debitSecurity.SecurityNumber,
                NumberInstallments = debitSecurity.Installments.Count(),
                OriginalValue = originalValue
            };
        }

        private int CalculateFee(double fee, IList<Installment> installments) {
            return installments.Sum(i => CalculateFee(fee, i));
        }

        private int CalculateFee(double fee, Installment installment) {
            //calcular juros compostos
            var daysOverDue = 1;
            var m = installment.Value * Math.Pow(1 + (fee / 100), daysOverDue);

            return 0;//installment.Value * (fee / 100);
        }
    }
}