using System.Collections.Generic;

namespace DebitSecurity.Domain.Entities
{
    public class Debit: BaseEntity
    {
        private long _penalty;
        public long Penalty
        {
            get { return _penalty; }
            set { _penalty = value; }
        }
        
        private long _interest;
        public long Interest
        {
            get { return _interest; }
            set { _interest = value; }
        }
        
        private IList<Installment> _installments;
        public IList<Installment> Installments
        {
            get { return _installments; }
            set { _installments = value; }
        }
    }
}