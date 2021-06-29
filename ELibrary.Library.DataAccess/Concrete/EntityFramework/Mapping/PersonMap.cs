using ELibrary.Library.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELibrary.Library.DataAccess.Concrete.EntityFramework.Mapping
{
    public class PersonMap:EntityTypeConfiguration<Person>
    {
        public PersonMap()
        {
            ToTable(@"People", @"dbo");
            HasKey(x => x.Id);
            
            Property(x => x.BookId).HasColumnName("BookId");
            Property(x => x.FirstName).HasColumnName("FirstName");
            Property(x => x.LastName).HasColumnName("LastName");
            Property(x => x.UserName).HasColumnName("UserName");
            Property(x => x.Password).HasColumnName("Password");
            Property(x => x.Email).HasColumnName("Email");
            Property(x => x.DateOfFinishing).HasColumnName("DateOfFinishing");
            Property(x => x.DateOfGetting).HasColumnName("DateOfGetting");
            Property(x => x.IsRead).HasColumnName("IsRead");

             
        }
    }
}
