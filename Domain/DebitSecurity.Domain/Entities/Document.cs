namespace DebitSecurity.Domain.Entities
{
    public class Document: BaseEntity
    {
        public string DocumentNumber { get; set; }
        public virtual Person Customer { get; set; }
        public virtual Debit Debit { get; set; }
    }
}