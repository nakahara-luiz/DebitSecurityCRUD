using DebitSecurity.Domain.Entities;
using DebitSecurity.DTO;

namespace DebitSecurity.Crosscutting.Builders
{
    public class InstallmentBuilder
    {
        public Installment Build(InstallmentDTO dto) {
            return new Installment {
                Id = dto.InstallmentId,
                DebitSecurityId = dto.DebitSecurityId,
                DueDate = dto.DueDate,
                Number = dto.Number,
                Value = dto.Value
            };
        }
    }
}