using ELibrary.Library.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ELibrary.Library.Business.ServiceContracts.Wcf
{
    [ServiceContract]
    public interface IBookDetailService
    {
        [OperationContract]
        List<Book> GetAll();
    }
}
