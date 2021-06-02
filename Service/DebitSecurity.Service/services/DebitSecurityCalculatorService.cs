using System;
using System.Collections.Generic;
using System.Linq;
using DebitSecurity.Crosscutting.Utils;
using DebitSecurity.Domain.Entities;
using DebitSecurity.DTO;
using DebitSecurity.Interface.Interfaces;

namespace DebitSecurity.Service.services
{
    public class DebitSecurityCalculatorService: IDebitSecurityCalculatorService
    {
        private FeeUtils _feeUtils;
        private DateTime _referenceDate;

        public DebitSecurityCalculatorService(DateTime referenceDate = new DateTime())
        {
            _referenceDate = referenceDate;
            _feeUtils = new FeeUtils();
        }

        public IList<DebitResumeDTO> Calculate(IList<Debit> debitSecurity) {
            var resumes = new List<DebitResumeDTO>();

            foreach (var item in debitSecurity)
                resumes.Add(Calculate(item));
            
            return resumes;
        }

        public DebitResumeDTO Calculate(Debit debitSecurity) {
            if (debitSecurity == null) 
                throw new Exception("Título de dívida não informado!");
            if (debitSecurity.Person == null || string.IsNullOrWhiteSpace(debitSecurity.Person.Name)) 
                throw new Exception("Cliente não informado no Título de dívida!");
            if (debitSecurity.Installments == null || !debitSecurity.Installments.Any()) 
                throw new Exception("Parcela(s) não informada(s) no Título de dívida!");
            
            var firstInstallment = debitSecurity.Installments.First();
            var penaltyFee = debitSecurity.Penalty;
            var interestFee = debitSecurity.Interest;

            var originalValue = debitSecurity.Installments.Sum(i => i.Value);
            var daysOverDue = (firstInstallment.DueDate - DateTime.Now).TotalDays;
            var penaltyValue = _feeUtils.CalculateSingleInterestDiff(firstInstallment.Value, penaltyFee);
            var interestValue = CalculateTotalInterest(debitSecurity.Installments, interestFee);

            return new DebitResumeDTO {
                ActualValue = originalValue + penaltyValue + interestValue,
                CustomerName = debitSecurity.Person.Name,
                DaysOverDue = Convert.ToInt32(daysOverDue),
                SecurityNumber = debitSecurity.SecurityNumber,
                NumberInstallments = debitSecurity.Installments.Count(),
                OriginalValue = originalValue
            };
        }

        private double CalculateTotalInterest(IList<Installment> installments, double monthlyFee) {
            double totalInterest = 0;
            var dailyFee = _feeUtils.ConvertMonthlyToDaily(monthlyFee);

            foreach (var installment in installments)
            {
                var daysOverDue = (installment.DueDate - _referenceDate).TotalDays;

                totalInterest += _feeUtils.CalculateInterestDiff(installment.Value, dailyFee, daysOverDue);
            }

            return totalInterest;
        }
    }
}