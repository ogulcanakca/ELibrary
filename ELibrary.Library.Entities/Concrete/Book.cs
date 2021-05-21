using ELibrary.Library.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELibrary.Library.Entities.Concrete
{
    public class Book :IEntity
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string Author { get; set; }
        public string Translator { get; set; }
        public DateTime DateOfGetting { get; set; }
        public DateTime DateOfFinishing { get; set; }
        public int PageNumber { get; set; }
        public string BookType { get; set; }

      


    }
}
