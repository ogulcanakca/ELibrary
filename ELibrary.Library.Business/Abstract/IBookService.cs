using ELibrary.Library.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ELibrary.Library.Business.Abstract
{
    [ServiceContract]
    public interface IBookService
    {
        [OperationContract]
        void TransactionalOperation(Book book, Person person);
        [OperationContract]
        List<Book> GetAll();
        [OperationContract]
        Book GetById(int bookId);
        [OperationContract]
        Book Add(Book book);
        [OperationContract]
        Book Update(Book book);
        [OperationContract]
        void Delete(Book book);
        
    }
}
