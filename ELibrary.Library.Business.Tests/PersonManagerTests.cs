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
            pm.Add(new Person
                { 
                Id = 1,
                FirstName = "Oğulcan",
                LastName ="Akca",
                UserName = "ogulcanakca",
                Password = "Asdasdasd1113",
                Email = "ogulcanakca54@gmail.com",
                BookId = 1,
                DateOfFinishing = DateTime.Now,
                DateOfGetting = DateTime.Now,
                IsRead = true
                });
        }
    }
}
/*
public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int BookId { get; set; }
        public DateTime DateOfGetting { get; set; }
        public DateTime DateOfFinishing { get; set; }
        public bool IsRead { get; set; }


 public PersonValidator()
        {
            RuleFor(p => p.FirstName).NotEmpty().WithMessage("It has place that was left blank");
            RuleFor(p => p.LastName).NotEmpty().WithMessage("It has place that was left blank");
            RuleFor(p => p.UserName).NotEmpty().WithMessage("It has place that was left blank");
            RuleFor(p => p.Password).Must(Condition1).Must(Condition2).WithMessage("It must contain letter and number");
            RuleFor(p => p.Email).Must(Contain).WithMessage("It must contain '@'");
        }

        private bool Contain(string arg)
        {
            return arg.Contains("@");
        }

        private bool Condition2(string arg)
        {
            return arg.GetType() == typeof(string);
        }

        private bool Condition1(string arg)
        {
            return arg.GetType() == typeof(int);
        }






 */