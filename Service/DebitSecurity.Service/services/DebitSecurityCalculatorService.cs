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
        public IList<DebitSecurityResumeDTO> Calculate(IList<Document> debitSecurity) {
            var resumes = new List<DebitSecurityResumeDTO>();

            foreach (var item in debitSecurity)
                resumes.Add(Calculate(item));
            
            return resumes;
        }
        public DebitSecurityResumeDTO Calculate(Document debitSecurity) {
            if (debitSecurity == null) 
                throw new Exception("Título de dívida não informado!");
            if (debitSecurity.Customer == null || string.IsNullOrWhiteSpace(debitSecurity.Customer.Name)) 
                throw new Exception("Cliente não informado no Título de dívida!");
            if (debitSecurity.Debit == null || debitSecurity.Debit.Installments == null || !debitSecurity.Debit.Installments.Any()) 
                throw new Exception("Parcela(s) não informada(s) no Título de dívida!");
            
            var firstInstallment = debitSecurity.Debit.Installments.First();
            var penaltyFee = debitSecurity.Debit.Penalty;
            var interestFee = debitSecurity.Debit.Interest;

            var penaltyValue = CalculateFee(penaltyFee, firstInstallment);
            var interestValue = CalculateFee(interestFee, debitSecurity.Debit.Installments);
            var originalValue = debitSecurity.Debit.Installments.Sum(i => i.Value);
            var daysOverDue = (firstInstallment.DueDate - DateTime.Now).TotalDays;

            return new DebitSecurityResumeDTO {
                ActualValue = originalValue + penaltyValue + interestValue,
                CustomerName = debitSecurity.Customer.Name,
                DaysOverDue = Convert.ToInt32(daysOverDue),
                DocumentNumber = debitSecurity.DocumentNumber,
                NumberInstallments = debitSecurity.Debit.Installments.Count(),
                OriginalValue = originalValue
            };
        }

        private int CalculateFee(int fee, IList<Installment> installments) {
            return installments.Sum(i => CalculateFee(fee, i));
        }

        private int CalculateFee(int fee, Installment installment) {
            return installment.Value * (fee / 100);
        }
    }
}