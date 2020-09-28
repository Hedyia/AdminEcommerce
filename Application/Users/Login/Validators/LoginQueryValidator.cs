using Application.Users.Login.Queries;
using FluentValidation;

namespace Application.Users.Login.Validators
{
    public class LoginQueryValidator : AbstractValidator<LoginQuery>
    {
        public LoginQueryValidator()
        {
            RuleFor(v => v.Email).NotEmpty().EmailAddress();
            RuleFor(v => v.Password).NotEmpty();
        }        
    }
}