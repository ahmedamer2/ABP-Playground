using FluentValidation;

namespace PlayGround.Books;

public class CreateBookValidator : AbstractValidator<CreateBookDto>
{
    public CreateBookValidator()
    {
        RuleFor(o => o.Name).NotNull().NotEmpty();
        RuleFor(o => o.Price).NotNull().NotEmpty();
        RuleFor(o => o.AuthorId).NotNull().NotEmpty();
    }
}