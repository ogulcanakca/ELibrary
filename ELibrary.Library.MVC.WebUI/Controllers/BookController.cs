using ELibrary.Library.Business.Abstract;
using ELibrary.Library.Core.CrossCuttingConcerns.Logging.Log4Net.Loggers;
using ELibrary.Library.DataAccess.Abstract;
using ELibrary.Library.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

// target frameworkü 4.7.2 ye düşür yani eski haline, şuan 4.8. şu an 2 hata çıkıyo

namespace ELibrary.Library.MVC.WebUI.Controllers
{

    public class BookController : Controller
    {
        private IBookService _bookService;
        //private IPersonService _personService;
        public BookController(IBookService bookService /* ,IPersonService personService */ )
        {
            // _personService = personService;    
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
        public string Add()
        {
            _bookService.Add(new Book
            {
                Author = "Dostoyevski",
                BookName = "Suç ve Ceza",
                BookType = "Roman",
                DateOfFinishing = DateTime.Now,
                Translator = "Hasan Ali Yücel",
                PageNumber = 687,
                DateOfGetting = DateTime.Now

            });
            return "Başarıyla eklenmiştir.";
        }
        /* public string DeleteAdd()
        {
            _bookService.TransactionalOperation(new Book
            {
                
                BookName = "Nutuk",
                BookType = "Tarih",
                Author = "Atatürk",
                DateOfFinishing = DateTime.Now,
                DateOfGetting = DateTime.Now,
                PageNumber = 505,
                Translator = "Atatürk"
            }, new Person
            {
               
                Email = "abcdf"
            });

                return "Done";
        }
        */
    }
}