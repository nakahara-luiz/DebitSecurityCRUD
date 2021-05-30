namespace DebitSecurity.Domain.Entities
{
    public class Person: BaseEntity
    {
        public string Name { get; set; }   
        public string CPF { get; set; }
        public int DocumentId { get; set; }
        public Document Document { get; set; }
    }
}