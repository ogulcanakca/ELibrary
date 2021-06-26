using ELibrary.Library.Business.Abstract;
using ELibrary.Library.Business.ValidationRules.FluentValidation;
using ELibrary.Library.DataAccess.Abstract;
using ELibrary.Library.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ELibrary.Library.Core.Aspects.Postsharp.ValidationAspects;
using ELibrary.Library.Core.DataAccess;
using ELibrary.Library.Core.Aspects.Postsharp.TransactionAspects;
using ELibrary.Library.Core.CrossCuttingConcerns.Logging.Log4Net.Loggers;
using ELibrary.Library.Core.Aspects.Postsharp.LogAspects;
using ELibrary.Library.Core.Aspects.Postsharp.PerformanceAspects;

namespace ELibrary.Library.Business.Managers
{
    [LogAspect(typeof(DatabaseLogger))]
    public class BookManager : IBookService
    {
       
        private  IBookDal _bookDal;
        private  IPersonDal _personDal;
        
        /* private readonly IQueryableRepository<Book> _queryable; */
        public BookManager(IBookDal bookDal, IPersonDal personDal/*IQueryableRepository<Book> queryable */)
        {
            _personDal = personDal;
            /*_queryable = queryable; */
            _bookDal = bookDal;
        }
       //[FluentValidationAspect(typeof(BookValidator))]
       //[LogAspect(typeof(DatabaseLogger))]
        
        public Book Add(Book book)
        {
            return _bookDal.Add(book);
        }

        public void Delete(Book book)
        {
            _bookDal.Delete(book);
        }
        
        [PerformanceCounterAspect(2)]
        public List<Book> GetAll()
        {
            return _bookDal.GetList();
        }
        [TransactionScopeAspect]
        [FluentValidationAspect(typeof(PersonValidator))]
        [FluentValidationAspect(typeof(BookValidator))]

        public void TransactionalOperation(Book book, Person person)
        {
            _bookDal.Add(book);
            _personDal.Delete(person);
            // Business Codes
            
        }

        public Book GetById(int bookId)
        {
            return _bookDal.Get(p=>p.BookId==bookId);
        }
       //[FluentValidationAspect(typeof(BookValidator))]
        public Book Update(Book book)
        {
            return _bookDal.Update(book);
        }
    }
}
