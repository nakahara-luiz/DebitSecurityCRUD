using DebitSecurity.Domain.Entities;
using DebitSecurity.DTO;

namespace DebitSecurity.Crosscutting.Builders
{
    public class PersonBuilder
    {
        public Person Build(PersonDTO dto) {
            return new Person {
                CPF = dto.CPF,
                Id = dto.PersonId,
                Name = dto.Name
            };
        }
    }
}