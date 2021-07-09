using ELibrary.Library.Business.Abstract;
using ELibrary.Library.Business.DependencyResolvers.Ninject;
using ELibrary.Library.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BookService
/// </summary>
public class BookService : IBookService
{
    private IBookService _bookService = InstanceFactory.GetInstance<IBookService>();
    public BookService() 
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public Book Add(Book book)
    {
        return _bookService.Add(book);
    }

    public void Delete(Book book)
    {
         _bookService.Delete(book);
    }

    public List<Book> GetAll()
    {
        return _bookService.GetAll();
    }

    public Book GetById(int bookId)
    {
        return _bookService.GetById(bookId);
    }

    public void TransactionalOperation(Book book, Person person)
    {
        _bookService.TransactionalOperation(book, person);
    }

    public Book Update(Book book)
    {
        return _bookService.Update(book);
    }
}