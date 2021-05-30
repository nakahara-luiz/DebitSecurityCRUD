using System.Collections.Generic;

namespace DebitSecurity.Domain.Entities
{
    public class Debit: BaseEntity
    {
        public int Penalty { get; set; }
        public int Interest { get; set; }
        public IList<Installment> Installments { get; set; }
        public int DocumentId { get; set; }
        public Document Document { get; set; }
    }
}