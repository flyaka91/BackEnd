using BackEnd.Models.Requests.UserRequests;
using FluentValidation;

namespace BackEnd.Models.REQUESTS.Validators;

public class RegisterUserRequestValidator : AbstractValidator<RegisterUserRequest>
{
    public RegisterUserRequestValidator()
    {
        RuleFor(model => model.Email).EmailAddress();
        RuleFor(model => model.Password).MinimumLength(8);
    }   
}
