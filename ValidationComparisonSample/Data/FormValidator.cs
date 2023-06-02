using FluentValidation;

namespace ValidationComparisonSample.Data;

public class FormValidator : AbstractValidator<Form2>
{
    public FormValidator()
    {
        RuleFor(x => x.Email)
            .NotEmpty().WithMessage("Email is required.")
            .EmailAddress().WithMessage("Please enter a valid email address.");
    }
}