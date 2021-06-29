using ELibrary.Library.Core.DataAccess.EntityFramework;
using ELibrary.Library.DataAccess.Abstract;
using ELibrary.Library.Entities.ComplexTypes;
using ELibrary.Library.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELibrary.Library.DataAccess.Concrete.EntityFramework
{
    public class EfPersonDal : EfEntityRepositoryBase<Person, LibraryContext>, IPersonDal
    {
        public List<UserRoleItem> GetUserRoleItems(Person person)
        {
            using (LibraryContext context = new LibraryContext())
            {
                var result = from ur in context.UserRoles
                             join r in context.Roles
                             on ur.UserId equals person.Id
                             where ur.UserId == person.Id
                             select new UserRoleItem { RoleName = r.Name };
                return result.ToList();
            }
        }
        

        

    }
}
