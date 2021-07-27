﻿using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CustomerValidator :AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(ct => ct.CompanyName).NotEmpty();
            RuleFor(ct => ct.CompanyName).MinimumLength(2);

        }
    }
}
