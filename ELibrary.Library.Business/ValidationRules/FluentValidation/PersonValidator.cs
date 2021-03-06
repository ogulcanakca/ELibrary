using ELibrary.Library.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELibrary.Library.Business.ValidationRules.FluentValidation
{
    public class PersonValidator:AbstractValidator<Person>
    {
        public PersonValidator()
        {
            RuleFor(p => p.FirstName).NotEmpty().WithMessage("It has place that was left blank");
            RuleFor(p => p.LastName).NotEmpty().WithMessage("It has place that was left blank");
            RuleFor(p => p.UserName).NotEmpty().WithMessage("It has place that was left blank");
            RuleFor(p => p.Password)/*.Must(Condition)*/.NotEmpty().WithMessage("It must contain letter and number");
            RuleFor(p => p.Email).Must(Contain).WithMessage("It must contain '@'");
        }

        private bool Contain(string arg)
        {
            return arg.Contains("@");
        }

        /*private bool Condition(string arg)
        {
            
            return arg.Contains(Convert.ToString(arg.GetType() != typeof(char)));
        }
        */
    }
}
