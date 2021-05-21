using ELibrary.Library.DataAccess.Concrete.EntityFramework.Mapping;
using ELibrary.Library.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELibrary.Library.DataAccess.Concrete.EntityFramework
{
    public class LibraryContext :DbContext
    {
        public LibraryContext()
        {
            Database.SetInitializer<LibraryContext>(null);
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Person> People { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new BookMap());
            modelBuilder.Configurations.Add(new PersonMap());

        }
    }
}
