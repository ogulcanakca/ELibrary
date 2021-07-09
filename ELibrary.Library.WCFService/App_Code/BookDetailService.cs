using ELibrary.Library.Business.Abstract;
using ELibrary.Library.Business.DependencyResolvers.Ninject;
using ELibrary.Library.Business.ServiceContracts.Wcf;
using ELibrary.Library.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BookDetailService
/// </summary>
public class BookDetailService :IBookDetailService
{
    public BookDetailService()
    {
        
    }
    IBookService _bookService = InstanceFactory.GetInstance<IBookService>();
    public List<Book> GetAll()
    {
        return _bookService.GetAll();
    }
}