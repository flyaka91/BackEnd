using FluentValidation;

namespace BackEnd.Models.Requests.Validators;

public class AddBookRequestValidator : AbstractValidator<AddBookRequest>
{
    public AddBookRequestValidator()
    {
        RuleFor(model => model.BookName).NotEmpty();
        RuleFor(model => model.Author).NotEmpty();
        RuleFor(model => model.Description).NotEmpty();
        RuleFor(model => model.Price).NotEmpty();
        RuleFor(model => model.PublicationDate).NotEmpty();
    }
}
