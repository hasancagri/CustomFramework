using System.Collections.Generic;
using System.ServiceModel;

namespace NorthwindApp.BLL.Abstract
{
    [ServiceContract]
    public interface IProductService
    {
        [OperationContract]
        List<Entities.DTO.Product> GetAll(int pageSize, int pageNumber);

        [OperationContract]
        Entities.DTO.Product Get(string id);

        [OperationContract]
        List<Entities.DTO.Product> GetByCategory(int categoryId);

        [OperationContract]
        int Add(Entities.DTO.Product product);

        [OperationContract]
        int Update(Entities.DTO.Product product);

        [OperationContract]
        int Delete(string id);

        [OperationContract]
        int GetProductCount();
    }
}
