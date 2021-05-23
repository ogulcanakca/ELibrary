using System;
using ELibrary.Library.Business.Managers;
using ELibrary.Library.DataAccess.Abstract;
using ELibrary.Library.Entities.Concrete;
using FluentValidation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace ELibrary.Library.Business.Tests
{
    [TestClass]
    public class PersonManagerTests
    {
        [ExpectedException(typeof(ValidationException))]
        [TestMethod]
        public void Person_Validation_Check()
        {
            Mock<IPersonDal> mock = new Mock<IPersonDal>();
            PersonManager pm = new PersonManager(mock.Object);
            pm.Add(new Person(
            /* {
                Id = 1,
                FirstName = "Oğulcan",
                LastName = "Akca",
                UserName = "ogulcanakca",
                Password = "Asdasdasd1113",
                Email = "ogulcanakca54@gmail.com",
                BookId = 1,
                DateOfFinishing = DateTime.Now,
                DateOfGetting = DateTime.Now,
                IsRead = true
            }*/));

        }
    }
}
