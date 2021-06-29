using ELibrary.Library.Business.Abstract;
using ELibrary.Library.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ELibrary.Library.WebApi.Controllers
{
    public class BooksController : ApiController
    {
        public IBookService _bookService;
        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }
        public List<Book> Get()
        {
            return _bookService.GetAll();
        }
    }
}
