using FluentValidation;
using DebitSecurity.Domain.Entities;
using DebitSecurity.Crosscutting.Utils;

namespace DebitSecurity.Crosscutting.validatiors
{
    public class DocumentValidator: AbstractValidator<Debit>
    {
        public DocumentValidator()
        {
            
            RuleFor(p => p.SecurityNumber)
                .NotEmpty().WithMessage(ValidationMessages.RequiredField)
                .NotNull().WithMessage(ValidationMessages.RequiredField);
        }
    }
}