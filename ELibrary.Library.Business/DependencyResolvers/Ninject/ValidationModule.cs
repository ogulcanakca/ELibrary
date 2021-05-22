using ELibrary.Library.Business.ValidationRules.FluentValidation;
using ELibrary.Library.Entities.Concrete;
using FluentValidation;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELibrary.Library.Business.DependencyResolvers.Ninject
{
    public class ValidationModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IValidator<Person>>().To<PersonValidator>().InSingletonScope();
            Bind<IValidator<Book>>().To<BookValidator>().InSingletonScope();

        }
    }
}
