using Application.Categories.Commands;
using FluentValidation;

namespace Application.Categories.Validators
{
    public class CreateCategoryCommandValidator : AbstractValidator<CreateCategoryCommand>
    {
        public CreateCategoryCommandValidator()
        {
            RuleFor(v => v.Name).NotNull().MaximumLength(128);
            RuleFor(v => v.DefaultImage).MaximumLength(128);
        }
    }
}