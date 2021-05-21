using ELibrary.Library.Core.DataAccess.EntityFramework;
using ELibrary.Library.DataAccess.Abstract;
using ELibrary.Library.Entities.ComplexTypes;
using ELibrary.Library.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ELibrary.Library.DataAccess.Concrete.EntityFramework
{
    public class EfBookDal : EfEntityRepositoryBase<Book, LibraryContext>, IBookDal
    {
        public List<BookDetail> GetBookDetails()
        {
            using (LibraryContext context = new LibraryContext())
            {
                var result = from p in context.Books
                             join c in context.People on p.BookId equals c.BookId
                             select new BookDetail
                             {
                                 BookId = p.BookId,
                                 DateOfGetting = p.DateOfGetting,
                                 DateOfFinishing = p.DateOfFinishing
                             };
                return result.ToList();
            }
        }
    }
}
