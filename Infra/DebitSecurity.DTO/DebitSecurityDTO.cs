namespace DebitSecurity.DTO
{
    public class DebitSecurityDTO
    {
        public int DocumentId { get; set; }
        public string DocumentNumber { get; set; }
        public virtual PersonDTO Customer { get; set; }
        public virtual DebitDTO Debit { get; set; }
    }
}