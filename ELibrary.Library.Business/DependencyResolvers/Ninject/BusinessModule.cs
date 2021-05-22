using ELibrary.Library.Business.Abstract;
using ELibrary.Library.Business.Managers;
using ELibrary.Library.Core.DataAccess;
using ELibrary.Library.Core.DataAccess.EntityFramework;
using ELibrary.Library.DataAccess.Abstract;
using ELibrary.Library.DataAccess.Concrete.EntityFramework;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELibrary.Library.Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IPersonService>().To<PersonManager>().InSingletonScope();
            Bind<IPersonDal>().To<EfPersonDal>().InSingletonScope();

            Bind<IBookService>().To<BookManager>().InSingletonScope();
            Bind<IBookDal>().To<EfBookDal>().InSingletonScope();

            Bind(typeof(IQueryableRepository<>)).To(typeof(EfQueryableRepositoryBase<>));

            Bind<DbContext>().To<LibraryContext>().InSingletonScope();

            


        }
    }
}
