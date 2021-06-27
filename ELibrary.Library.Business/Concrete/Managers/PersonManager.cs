using ELibrary.Library.Business.Abstract;
using ELibrary.Library.Business.ValidationRules.FluentValidation;
using ELibrary.Library.Core.Aspects.Postsharp.AuthorizationAspects;
using ELibrary.Library.Core.Aspects.Postsharp.CacheAspects;
using ELibrary.Library.Core.Aspects.Postsharp.LogAspects;
using ELibrary.Library.Core.Aspects.Postsharp.ValidationAspects;
using ELibrary.Library.Core.CrossCuttingConcerns.Caching.Microsoft;
using ELibrary.Library.Core.CrossCuttingConcerns.Logging.Log4Net.Loggers;
using ELibrary.Library.Core.DataAccess;
using ELibrary.Library.DataAccess.Abstract;
using ELibrary.Library.Entities.ComplexTypes;
using ELibrary.Library.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELibrary.Library.Business.Managers
{
    
    public class PersonManager : IPersonService
    {
        private readonly IPersonDal _personDal;
        /* private readonly IQueryableRepository<Person> _queryable; */
        public PersonManager(IPersonDal personDal /* IQueryableRepository<Person> queryable */)
        {
            /* _queryable = queryable; */
            _personDal = personDal;
        }

        //[FluentValidationAspect(typeof(PersonValidator))]
        //[CacheRemoveAspect(typeof(MemoryCacheManager))]
        public Person Add(Person person)
        {
            return _personDal.Add(person);
        }

        public void Delete(Person person)
        {
            _personDal.Delete(person);

        }

        //[CacheAspect(typeof(MemoryCacheManager))]
        //[LogAspect(typeof(JsonFileLogger))]
        
        public List<Person> GetAll()
        {
            return _personDal.GetList();

        }

        public Person GetById(int Id)
        {
            return _personDal.Get(p=>p.Id ==Id);

        }

        public Person GetByUserNameAndPassword(string userName, string password)
        {
            return _personDal.Get(u => u.UserName == userName & u.Password == password);
        }

        public List<UserRoleItem> GetUserRoleItems(Person person)
        {
            return _personDal.GetUserRoleItems(person);
        }

        //[FluentValidationAspect(typeof(PersonValidator))]
        public Person Update(Person person)
        {
            return _personDal.Update(person);

        }
    }
}
