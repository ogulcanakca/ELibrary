using ELibrary.Library.Business.Abstract;
using ELibrary.Library.Core.Aspects.Postsharp.Security.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ELibrary.Library.MVC.WebUI.Controllers
{
    public class PersonController : Controller
    {
        private IPersonService _personService;
        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }
        // GET: Person
        public string Login(string userName, string password)
        {
            var user = _personService.GetByUserNameAndPassword("ogulcanakca", "12345");
            if (user!=null)
            {
                AuthenticationHelper.CreateAuthCookie(new Guid(), user.UserName, user.Email,
                DateTime.Now.AddDays(15),
                _personService.GetUserRoleItems(user).Select(u => u.RoleName).ToArray(),
                false, user.FirstName, user.LastName);
                return "User is authenticated!";
            }
            else
            {
                return "UserName is not authenticated";
            }
        }
    }
}