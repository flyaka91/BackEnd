using FluentValidation;

namespace BackEnd.Models.Requests.Validators;

public class RegisterUserRequestValidator : AbstractValidator<RegisterUserRequest>
{
    public RegisterUserRequestValidator()
    {
        RuleFor(model => model.Email).EmailAddress().NotEmpty();
        RuleFor(model => model.Password).MinimumLength(6).NotEmpty();
        RuleFor(model => model.UserName).MaximumLength(32).MinimumLength(2).NotEmpty();
        RuleFor(model => model.LastName).MaximumLength(32).MinimumLength(2).NotEmpty();
    }
}
