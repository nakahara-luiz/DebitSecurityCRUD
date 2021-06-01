using System;
using System.Collections.Generic;

namespace DebitSecurity.Domain.Entities
{
    public class Debit: BaseEntity
    {
        public string SecurityNumber { get; set; }
        public double Interest { get; set; }
        public double Penalty { get; set; }
        public Guid PersonId { get; set; }
        public Person Person { get; set; }
        public IList<Installment> Installments { get; set; }
    }
}