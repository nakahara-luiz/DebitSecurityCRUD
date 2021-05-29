namespace DebitSecurity.Domain.Entities
{
    public class Document: BaseEntity
    {
        private string _documentNumber;
        public string DocumentNumber
        {
            get { return _documentNumber; }
            set { _documentNumber = value; }
        }
        
        private Person _customer;
        public Person Customer
        {
            get { return _customer; }
            set { _customer = value; }
        }
        
        private Debit _debit;
        public Debit Debit
        {
            get { return _debit; }
            set { _debit = value; }
        }
    }
}