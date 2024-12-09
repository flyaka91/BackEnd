using FluentValidation;

namespace BackEnd.Models.Requests.Validators;

public class AddBookRequestValidator : AbstractValidator<AddBookRequest>
{
    public AddBookRequestValidator()
    {
        RuleFor(model => model.BookName).MaximumLength(32).NotEmpty();
        RuleFor(model => model.Author).MaximumLength(32).NotEmpty();
        RuleFor(model => model.Description).MaximumLength(232).NotEmpty();
        RuleFor(model => model.Price).NotEmpty();
        RuleFor(model => model.PublicationDate).NotEmpty();
        //на каждый куэри валидаторы!!!!!!!!!!!!!!
    }
}
