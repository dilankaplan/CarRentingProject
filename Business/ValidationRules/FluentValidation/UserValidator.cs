using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator :AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.UserId).NotEmpty();
            RuleFor(u => u.FirstName).NotEmpty();
            RuleFor(u => u.LastName).NotEmpty();
            RuleFor(u => u.Email).NotEmpty();
            RuleFor(u => u.Password).NotEmpty();
            RuleFor(u => u.Password).MinimumLength(8);
            RuleFor(u => u.Email).EmailAddress();
            RuleFor(u => u.Password).Must(ContainUppercase).WithMessage("En az bir büyük harf içermelidir.");
          
        }

        private bool ContainUppercase(string arg)
        {
            throw  arg.Contain("Uppercase");
        }
    }
}
