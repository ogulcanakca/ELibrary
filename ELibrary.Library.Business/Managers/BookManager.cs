using ELibrary.Library.Business.Abstract;
using ELibrary.Library.Business.ValidationRules.FluentValidation;
using ELibrary.Library.DataAccess.Abstract;
using ELibrary.Library.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELibrary.Library.Business.Managers
{
    public class BookManager : IBookService
    {
        private IBookDal _bookDal;
        public BookManager(IBookDal bookDal)
        {
            _bookDal = bookDal;
        }
        [FluentValidationAspect(typeof(BookValidator))]
        public Book Add(Book book)
        {
            return _bookDal.Add(book);
        }

        public void Delete(Book book)
        {
            _bookDal.Delete(book);
        }

        public List<Book> GetAll()
        {
            return _bookDal.GetList();
        }

        public Book GetById(int bookId)
        {
            return _bookDal.Get(p=>p.BookId==bookId);
        }
        [FluentValidationAspect(typeof(BookValidator))]
        public Book Update(Book book)
        {
            return _bookDal.Update(book);
        }
    }
}
