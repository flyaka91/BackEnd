﻿using FluentValidation;

namespace BackEnd.Models.Requests.Validators;

public class RegisterUserRequestValidator : AbstractValidator<RegisterUserRequest>
{
    public RegisterUserRequestValidator()
    {
        RuleFor(model => model.Email).EmailAddress();
        RuleFor(model => model.Password).MinimumLength(6);
        RuleFor(model => model.UserName).MaximumLength(32).MinimumLength(2);
        RuleFor(model => model.LastName).MaximumLength(32).MinimumLength(2);
    }
}
