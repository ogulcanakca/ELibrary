using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELibrary.Library.Entities.ComplexTypes
{
    public class BookDetail
    {
        public int BookId { get; set; }
        public DateTime DateOfGetting { get; set; }
        public DateTime DateOfFinishing { get; set; }
    }
}
