using ELibrary.Library.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELibrary.Library.DataAccess.Concrete.EntityFramework.Mapping
{
    public class BookMap:EntityTypeConfiguration<Book>
    {
        public BookMap()
        {
            

            ToTable(@"Books", @"dbo");
            HasKey(x => x.BookId);
            Property(x => x.BookId).HasColumnName("BookId");
            Property(x => x.BookName).HasColumnName("BookName");
            Property(x => x.Author).HasColumnName("Author");
            Property(x => x.Translator).HasColumnName("Translator");
            Property(x => x.DateOfSale).HasColumnName("DateOfSale");
            Property(x => x.PageNumber).HasColumnName("PageNumber");
            Property(x => x.BookType).HasColumnName("BookType");
            Property(x => x.IsRead).HasColumnName("IsRead");

        }
      
    }  
    
}
