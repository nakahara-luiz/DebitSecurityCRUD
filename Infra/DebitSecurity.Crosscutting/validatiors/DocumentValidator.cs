using FluentValidation;
using DebitSecurity.Domain.Entities;
using DebitSecurity.Crosscutting.Utils;

namespace DebitSecurity.Crosscutting.validatiors
{
    public class DocumentValidator: AbstractValidator<Document>
    {
        public DocumentValidator()
        {
            
            RuleFor(p => p.DocumentNumber)
                .NotEmpty().WithMessage(ValidationMessages.RequiredField)
                .NotNull().WithMessage(ValidationMessages.RequiredField);
        }
    }
}