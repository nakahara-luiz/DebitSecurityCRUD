using System;

namespace DebitSecurity.Domain.Entities
{
    public class Installment: BaseEntity
    {
        public int InstallmentNumber { get; set; }
        public long Value { get; set; }
        public DateTime DueDate { get; set; }
        public Debit Debit { get; set; }
        public int DebitID { get; set; }
        
    }
}