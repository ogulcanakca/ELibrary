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
        
    }
}
