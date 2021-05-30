namespace DebitSecurity.Domain.Entities
{
    public class Person: BaseEntity
    {
        public string Name { get; set; }   
        public string CPF { get; set; }
    }
}