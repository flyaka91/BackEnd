using FluentValidation;

namespace BackEnd.Models.Requests.Validators;

public class UpdateUserRequestValidator : AbstractValidator<UpdateUserRequest>
{
    public UpdateUserRequestValidator()
    {
        RuleFor(model => model.Password).MinimumLength(6);
        RuleFor(model => model.UserName).MaximumLength(32).MinimumLength(2);
        RuleFor(model => model.LastName).MaximumLength(32).MinimumLength(2);
        RuleFor(model => model.PhoneNumber).MaximumLength(11).MinimumLength(11);
    }
}
