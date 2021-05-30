using FluentValidation;
using DebitSecurity.Domain.Entities;
using DebitSecurity.Crosscutting.Utils;

namespace DebitSecurity.Crosscutting.validatiors
{
    public class PersonValidator: AbstractValidator<Person>
    {
        public PersonValidator()
        {
            
            RuleFor(p => p.Name)
                .NotEmpty().WithMessage(ValidationMessages.RequiredField)
                .NotNull().WithMessage(ValidationMessages.RequiredField);
            
            RuleFor(p => p.CPF)
                .NotEmpty().WithMessage(ValidationMessages.RequiredField)
                .NotNull().WithMessage(ValidationMessages.RequiredField);
        }
    }
}