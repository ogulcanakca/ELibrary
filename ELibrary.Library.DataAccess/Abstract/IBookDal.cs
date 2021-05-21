using ELibrary.Library.Core.DataAccess;
using ELibrary.Library.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELibrary.Library.DataAccess.Abstract
{
    public interface IBookDal:IEntityRepository<Book>
    {

    }
}
