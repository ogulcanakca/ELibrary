using ELibrary.Library.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELibrary.Library.Business.ValidationRules.FluentValidation
{
    public class BookValidator:AbstractValidator<Book>
    {
        public BookValidator()
        {
            RuleFor(p => p.BookName).NotEmpty().WithMessage("It has place that was left blank");
            RuleFor(p => p.Author).NotEmpty().WithMessage("It has place that was left blank");
            RuleFor(p => p.PageNumber).NotEmpty().WithMessage("It has place that was left blank");
            RuleFor(p => p.BookType).NotEmpty().WithMessage("It has place that was left blank");
            
       
        }
    }
}
