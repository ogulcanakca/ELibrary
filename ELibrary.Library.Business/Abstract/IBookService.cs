using ELibrary.Library.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELibrary.Library.Business.Abstract
{
    public interface IBookService
    {
        List<Book> GetAll();
        Book GetById(int bookId);
        Book Add(Book book);
        Book Update(Book book);
        void Delete(Book book);
    }
}
