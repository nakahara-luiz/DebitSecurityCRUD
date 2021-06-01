using System.Collections.Generic;

namespace DebitSecurity.Domain.Entities
{
    public class Person: BaseEntity
    {
        public string Name { get; set; }   
        public string CPF { get; set; }
        public IList<Debit> Debits { get; set; }
    }
}