using ELibrary.Library.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELibrary.Library.Business.Abstract
{
    public interface IPersonService
    {

        List<Person> GetAll();
        Person GetById(int Id);
        Person Add(Person person);
        Person Update(Person person);
        void Delete(Person person);
    }
}
