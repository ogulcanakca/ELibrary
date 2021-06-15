using ELibrary.Library.Business.Abstract;
using ELibrary.Library.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ELibrary.Library.MVC.WebUI.Controllers
{
    public class BookController : Controller
    {
        private IBookService _bookService;
        
        public BookController(IBookService bookService)
        {
            
            _bookService = bookService;
        }
        public ActionResult Index()
        {
            var model = new BookListViewModel
            {
                Books = _bookService.GetAll()
            };
            return View(model);
        }
    }
}