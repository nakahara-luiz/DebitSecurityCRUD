namespace DebitSecurity.Domain.Entities
{
    public class Document: BaseEntity
    {
        public string DocumentNumber { get; set; }
        public Person Customer { get; set; }
        public Debit Debit { get; set; }
    }
}