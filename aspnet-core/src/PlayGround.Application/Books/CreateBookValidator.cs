using FluentValidation;

namespace PlayGround.Books;

public class CreateBookValidator : AbstractValidator<CreateBookDto>
{
    public CreateBookValidator()
    {
        RuleFor(o => o.Name).NotNull().WithMessage("TEst");
        RuleFor(o => o.Price).NotEmpty();
        RuleFor(o => o.AuthorId).NotEmpty();
    }
}