using ELibrary.Library.Business.Abstract;
using ELibrary.Library.Business.ValidationRules.FluentValidation;
using ELibrary.Library.Core.Aspects.Postsharp.ValidationAspects;
using ELibrary.Library.DataAccess.Abstract;
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
        private IPersonDal _personDal;
        public PersonManager(IPersonDal personDal)
        {
            _personDal = personDal;
        }
        [FluentValidationAspect(typeof(PersonValidator))]
        public Person Add(Person person)
        {
            return _personDal.Add(person);
        }

        public void Delete(Person person)
        {
            _personDal.Delete(person);

        }

        public List<Person> GetAll()
        {
            return _personDal.GetList();

        }

        public Person GetById(int Id)
        {
            return _personDal.Get(p=>p.Id ==Id);

        }
        [FluentValidationAspect(typeof(PersonValidator))]
        public Person Update(Person person)
        {
            return _personDal.Update(person);

        }
    }
}
