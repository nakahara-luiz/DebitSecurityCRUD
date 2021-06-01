using System;

namespace DebitSecurity.Domain.Entities
{
    public class Installment: BaseEntity
    {
        public int Number { get; set; }
        public double Value { get; set; }
        public DateTime DueDate { get; set; }
        public Guid DebitSecurityId { get; set; }
        public Debit DebitSecurity { get; set; }
    }
}