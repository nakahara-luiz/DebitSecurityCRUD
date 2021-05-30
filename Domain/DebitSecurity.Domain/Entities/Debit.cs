using System.Collections.Generic;

namespace DebitSecurity.Domain.Entities
{
    public class Debit: BaseEntity
    {
        public long Penalty { get; set; }
        public long Interest { get; set; }
        public IList<Installment> Installments { get; set; }
        public Document Document { get; set; }
        public int DocumentId { get; set; }
    }
}