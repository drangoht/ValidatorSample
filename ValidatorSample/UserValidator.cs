using FluentValidation;
using LanguageExt;
using LanguageExt.Common;
using System.ComponentModel.DataAnnotations;
public class UserValidator : AbstractValidator<User>
{
    public UserValidator()
    {
        RuleFor(x => x.FirstName).NotEmpty().WithMessage("Please specify a first name");
        RuleFor(x => x.LastName).NotEmpty().WithMessage("Please specify a last name");
        RuleFor(x => x.Age).GreaterThan(21).WithMessage("Age must be greater than 21"); ;
        
    }
}
