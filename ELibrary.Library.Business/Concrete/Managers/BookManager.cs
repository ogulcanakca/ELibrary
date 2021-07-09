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
using ELibrary.Library.Core.Aspects.Postsharp.AuthorizationAspects;
using AutoMapper;
using ELibrary.Library.Core.Utilities.Mappings;

namespace ELibrary.Library.Business.Managers
{
    
    [LogAspect(typeof(DatabaseLogger))]
    public class BookManager : IBookService
    {
        
        private  IBookDal _bookDal;
        private  IPersonDal _personDal;
        private IMapper _mapper;
        
        /* private readonly IQueryableRepository<Book> _queryable; */
        public BookManager(IBookDal bookDal, IPersonDal personDal/*IQueryableRepository<Book> queryable */, IMapper mapper)
        {
            _mapper = mapper;
            _personDal = personDal;
            /*_queryable = queryable; */
            _bookDal = bookDal;
        }
       [FluentValidationAspect(typeof(BookValidator))]
       [LogAspect(typeof(DatabaseLogger))]
        
        public Book Add(Book book)
        {
            return _bookDal.Add(book);
        }

        public void Delete(Book book)
        {
            _bookDal.Delete(book);
        }
        
        [PerformanceCounterAspect(2)]
        [SecuredOperation(Roles = "Admin, Editor, Student")]
        public List<Book> GetAll()
        {
            //return _bookDal.GetList().Select(b => new Book
            //{
            //    BookId = b.BookId,
            //    Author = b.Author,
            //    BookName = b.BookName,
            //    BookType = b.BookType,
            //    DateOfFinishing = b.DateOfFinishing,
            //    DateOfGetting = b.DateOfGetting,
            //    PageNumber = b.PageNumber,
            //    Translator = b.Translator

            //    /* Yukarıdaki kodu mapping yaparak da oluşturabiliriz, her metodda uzun uzun yazmak yerine mapping yaparız. Business'a AutoMapper'ı ekle.*/
            /*        //}).ToList();                            ↓
                                                                ↓
                                                                ↓                                                                                                    */
            var books = _mapper.Map<List<Book>>(_bookDal.GetList());
            return books;

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
        [FluentValidationAspect(typeof(BookValidator))]
        public Book Update(Book book)
        {
            return _bookDal.Update(book);
        }
    }
}
